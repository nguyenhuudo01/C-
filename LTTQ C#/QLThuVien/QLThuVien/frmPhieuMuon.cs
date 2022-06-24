using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVien
{
    public partial class frmPhieuMuon : Form
    {
        int slSachToiDa = 10; //số lượng sách tối đa sinh viên có thể mượn
        string sql, the = "",ht="", sTheDG="" ;
        int vtLV = -1,  sl=0, slSachMuon = 0;

        DataGridViewCellMouseEventArgs vt, vtTra;
        ListViewItem itemLV;

        public frmPhieuMuon()
        {
            InitializeComponent();
        }

        private void frmPhieuMuon_Load(object sender, EventArgs e)
        {
            dgSach.AutoGenerateColumns = false;
            dgSachMuonDG.AutoGenerateColumns = false;
            txtSoPhieu.Text = Public.TaoMa("SoPhieu", "Phieu");
            dtpNgayLap.Value = DateTime.Now;
            dtpNgayHenTra.Value = DateTime.Now.AddMonths(1);
            txtNguoiLap.Text = Public.HoDem + " " + Public.Ten;
            dtpNgayTra.Value = DateTime.Now;
            LayNguonSach();
        }

        private void cmdKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdXoaTrang_Click(object sender, EventArgs e)
        {
            if (lvwSachMuon.Items.Count <= 0) return;
            if (MessageBox.Show("Bạn có muốn xóa trắng danh mục sách đang chọn không?", "Thông Báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                lvwSachMuon.Items.Clear(); lblChon.Text = "";
            lblChon.Text = "";
        }

        private void cmdChonSach_Click(object sender, EventArgs e)
        {
            if (dgSach.RowCount <= 0) return;
            if (txtDocGia.Text == "")
            {
                MessageBox.Show("Bạn phải chọn độc giả trước khi thêm sách vào phiếu?", "Thông Báo",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTheDG.Focus();
                return;

            }
            if (vt.RowIndex >= 0)
            {
                DataGridViewRow row = dgSach.Rows[vt.RowIndex];
                string ma = row.Cells[0].Value.ToString();
                string ten = row.Cells[1].Value.ToString();
                //kiem tra trung ma
                for (int i = 0; i < lvwSachMuon.Items.Count; i++)
                    if (lvwSachMuon.Items[i].Text.Equals(ma) == true) return;
                //kiem tra so luong
                if ((slSachMuon + lvwSachMuon.Items.Count) >= slSachToiDa)
                {
                    MessageBox.Show("Độc giả đang mượn sách vượt sự cho phép, hãy kết thúc các phiếu mượn trước rồi tiếp tục?", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //them sach
                if (MessageBox.Show("Bạn có muốn chọn sách đưa vào phiếu mượn không không?", "Thông Báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    itemLV = new ListViewItem(new[] {ma, ten });
                    lvwSachMuon.Items.Add(itemLV);
                }
            }
            lblChon.Text = "Đã chọn :" + lvwSachMuon.Items.Count + ".";
        }

        private void cmdXoaSach_Click(object sender, EventArgs e)
        {
            if (lvwSachMuon.Items.Count <= 0) return;
            if (vtLV < 0) return;
            if (MessageBox.Show("Bạn bỏ mục sách ["+ lvwSachMuon.Items[vtLV].SubItems[1].Text +"] trong phiếu mượn đi không?", "Thông Báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lvwSachMuon.Items.RemoveAt(vtLV);
                vtLV = -1;
                lblChon.Text = "Đã chọn :" + lvwSachMuon.Items.Count + ".";
            }
        }

        private void lvwSachMuon_SelectedIndexChanged(object sender, EventArgs e)
        {
            vtLV = -1;
            if (lvwSachMuon.Items.Count <= 0)
                return;
            if (lvwSachMuon.SelectedItems.Count <= 0)
                return;
            itemLV = lvwSachMuon.SelectedItems[0];
            vtLV = itemLV.Index;
        }

        private void cmdGhiPhieu_Click(object sender, EventArgs e)
        {
            if (txtDocGia.Text == "") return;
            if (lvwSachMuon.Items.Count <= 0) return;
            if (dtpNgayLap.Value < DateTime.Now.AddDays(-1))
            {
                MessageBox.Show("Ngày lập phiếu không hợp lệ?", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgayLap.Focus();
                return;
            }
            if (dtpNgayHenTra.Value <= DateTime.Now)
            {
                MessageBox.Show("Ngày hẹn trả không hợp lệ?", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgayHenTra.Focus();
                return;
            }
            if (dtpNgayLap.Value > dtpNgayHenTra.Value)
            {
                MessageBox.Show("Ngày lập phiếu và ngày hẹn trả không hợp lệ?", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgayHenTra.Focus();
                return;
            }
            if (MessageBox.Show("Bạn có muốn ghi phiếu mượn này không?", "Thông Báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //ghi phieu
                sql = "Insert Into Phieu(sophieu,ngaylap, macb, thedg, ngayhentra,ngayketthuc,daketthuc)" +
                    " values(@sophieu,@ngaylap, @macb, @thedg, @ngayhentra,NULL,0)";
                SqlConnection conn = Public.KetNoi();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@sophieu", SqlDbType.NVarChar).Value = txtSoPhieu.Text;
                cmd.Parameters.Add("@ngaylap", SqlDbType.NVarChar).Value = dtpNgayLap.Value.ToString("MM/dd/yyyy");
                cmd.Parameters.Add("@macb", SqlDbType.NVarChar).Value = Public.MaCB;
                cmd.Parameters.Add("@thedg", SqlDbType.NVarChar).Value = sTheDG;
                cmd.Parameters.Add("@ngayhentra", SqlDbType.NVarChar).Value = dtpNgayHenTra.Value.ToString("MM/dd/yyyy");
                if (conn.State != ConnectionState.Open) conn.Open();
                cmd.ExecuteNonQuery();
                //ghi chi tiet phieu (ghi tinh trang sach)
                for (int i = 0; i < lvwSachMuon.Items.Count; i++)
                {
                    sql = "INSERT INTO CTPhieu(SoPhieu,MaSach,NgayTra,BiHong,GhiChu) VALUES (@SoPhieu,@MaSach,NULL,0,'')";
                    cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.Add("@SoPhieu", SqlDbType.NVarChar).Value = txtSoPhieu.Text;
                    cmd.Parameters.Add("@MaSach", SqlDbType.NVarChar).Value = lvwSachMuon.Items[i].Text;
                    if (conn.State != ConnectionState.Open) conn.Open();
                    cmd.ExecuteNonQuery();
                    //ghi tinh trang sach trong bang sach
                    sql = "Update Sach Set DaChoMuon = 1 Where MaSach = N'" + lvwSachMuon.Items[i].Text + "'";
                    if (conn.State != ConnectionState.Open) conn.Open();
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Ghi phiếu mượn thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //xoa trang va tao phieu moi
                txtDocGia.Text = "";txtHoTenDG.Text = "";txtLop.Text = "";
                lvwSachMuon.Items.Clear();lblChon.Text = "";
                dgSachMuonDG.DataSource = null; dgSach.DataSource = null;
                txtSoPhieu.Text = Public.TaoMa("SoPhieu", "Phieu");
            }
        }

        private void dgSach_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            cmdChonSach_Click(sender, e);
        }

        private void cmdTimDG_Click(object sender, EventArgs e)
        {
            if (txtTheDG.Text == "") return;
            txtSoPhieuTra.Text = ""; txtMaSach.Text = ""; txtTenSach.Text = "";txtGhiChu.Text = "";
            long num = long.Parse(txtTheDG.Text);
            sql = "select TheDG, HoDem + ' ' + Ten as HoTen, Lop, NgayMuaThe, NgayHetHan from docgia where thedg = '" + num.ToString("0000000000") + "'";
            DataTable dg = Public.LayDuLieu(sql);
            if (dg.Rows.Count > 0)
            {
                the = dg.Rows[0]["TheDG"].ToString();
                txtHoTenDG.Text = dg.Rows[0]["HoTen"].ToString();
                ht = txtHoTenDG.Text;
                txtLop.Text = dg.Rows[0]["Lop"].ToString();
                if (dg.Rows[0]["NgayMuaThe"].ToString() == "")
                    dtpNgayMuaThe.Value = DateTime.Now.AddDays(-1);
                else
                    dtpNgayMuaThe.Value = DateTime.Parse(dg.Rows[0]["NgayMuaThe"].ToString());
                if (dg.Rows[0]["NgayHetHan"].ToString() == "")
                    dtpNgayHetHan.Value = DateTime.Now.AddDays(-1);
                else
                    dtpNgayHetHan.Value = DateTime.Parse(dg.Rows[0]["NgayHetHan"].ToString());
                //lay nguon sach muon
                sql = "Select Phieu.SoPhieu, Sach.MaSach, TenSach, NgayLap, NgayHenTra " +
                    " From Phieu inner join CTPhieu on Phieu.SoPhieu=CTPhieu.SoPhieu inner join Sach on Sach.MaSach=CTPhieu.MaSach " +
                    " Where TheDG = '" + dg.Rows[0]["TheDG"].ToString() + "' And DaKetThuc = 0 And (NgayTra IS NULL)";
                Public.GanNguonDataGridView(dgSachMuonDG, sql);
                lblSoSachMuon.Text = "Độc giả hiện mượn " + dgSachMuonDG.RowCount + " cuốn sách.";
                sl = dgSachMuonDG.RowCount;

                //chon doc gia vao phieu muon
                if (dtpNgayHetHan.Value < DateTime.Now) return;
                if (dgSachMuonDG.RowCount >= slSachToiDa) return;
                txtDocGia.Text = ht + " - " + the;
                sTheDG = the;
                slSachMuon = sl;
            }
            else
            {                
                txtHoTenDG.Text = ""; txtLop.Text = ""; txtDocGia.Text = "";
                dgSachMuonDG.DataSource = null;
                lblSoSachMuon.Text = "";
            }
        }

        private void cmdTraSach_Click(object sender, EventArgs e)
        {
            if (txtSoPhieuTra.Text == "" || txtMaSach.Text == "") return;
            if (MessageBox.Show("Bạn muốn trả sách mượn này không?", "Thông Báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "Update CTPhieu Set NgayTra=@NgayTra, BiHong=@BiHong, GhiChu=@GhiChu Where SoPhieu=@SP And MaSach=@MS";
                SqlConnection conn = Public.KetNoi();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@NgayTra", SqlDbType.Date).Value = dtpNgayTra.Value;
                cmd.Parameters.Add("@BiHong", SqlDbType.Bit).Value = chkTinhTrang.Checked==true ? 1 : 0;
                cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = txtGhiChu.Text;
                cmd.Parameters.Add("@SP", SqlDbType.NVarChar).Value = txtSoPhieuTra.Text;
                cmd.Parameters.Add("@MS", SqlDbType.NVarChar).Value = txtMaSach.Text;
                if (conn.State != ConnectionState.Open) conn.Open();
                cmd.ExecuteNonQuery();
                //cap nhat tinh trang sach
                sql = "Update Sach Set DaChoMuon = 0, DaBiHong = "+ (chkTinhTrang.Checked==true?1:0) +" Where MaSach = N'" + txtMaSach.Text + "'";
                if (conn.State != ConnectionState.Open) conn.Open();
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                //kiem tra phieu
                Public.ktKetThucPhieu(txtSoPhieuTra.Text);
                //lay nguon doc gia
                cmdTimDG_Click(sender, e);
            }
        }

        private void cmdTimSach_Click(object sender, EventArgs e)
        {
            LayNguonSach();
        }

        private void cmdInPhieu_Click(object sender, EventArgs e)
        {
            if (dgSachMuonDG.RowCount <= 0) return;
            if (txtSoPhieuTra.Text == "") return;
            if (MessageBox.Show("Bạn có muốn in phiếu [ " + txtSoPhieuTra.Text + " ] không?", "Thông Báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Phieu.InPhieu(txtSoPhieuTra.Text);
        }

        private void dgSachMuonDG_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgSachMuonDG.RowCount <= 0) return;
            if (e.RowIndex >= 0)
            {
                vtTra = e;
                DataGridViewRow row = dgSachMuonDG.Rows[e.RowIndex];
                txtSoPhieuTra.Text = row.Cells[0].Value.ToString();
                txtMaSach.Text = row.Cells[1].Value.ToString();
                txtTenSach.Text = row.Cells[2].Value.ToString();
                chkTinhTrang.Checked = false;txtGhiChu.Text = "";
            }
        }

        private void dgSach_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgSach.RowCount <= 0) return;
            if (e.RowIndex >= 0) vt = e;
        }

        private void txtTheDG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8) || e.KeyChar == (char)Keys.Enter)
            {
                if (e.KeyChar == (char)Keys.Enter) {
                    cmdTimDG_Click(sender,e);
                }
                else
                    e.Handled = true;
            }
        }

        private void cmdChonDG_Click(object sender, EventArgs e)
        {
            if (txtHoTenDG.Text == "") return;
            if (dtpNgayHetHan.Value < DateTime.Now)
            {
                MessageBox.Show("Thẻ độc giả đã hết hạn, không cho phép mượn?", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dgSachMuonDG.RowCount >= slSachToiDa)
            {
                MessageBox.Show("Độc giả đang mượn sách vượt sự cho phép, hãy kết thúc các phiếu mượn trước rồi tiếp tục?", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTheDG.Focus();
                return;
            }
            if (MessageBox.Show("Bạn chọn độc giả mượn sách này không?","Thông Báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtDocGia.Text = ht + " - " + the;
                sTheDG = the;
                slSachMuon = sl;
            }
        }

        void LayNguonSach()
        {
            sql = "select MaSach,TenSach, TenMuc, TenTG, TenNXB, ViTri, NoiDung, DaChoMuon, DaBiHong, Sach.MaMuc, Sach.MaTG, Sach.MaNXB " +
                "from Sach inner join ChuyenMuc on Sach.MaMuc = ChuyenMuc.MaMuc " +
                "inner join TacGia on Sach.MaTG = TacGia.MaTG " +
                "inner join NhaXB on Sach.MaNXB = NhaXB.MaNXB ";
            sql += " Where (DaBiHong = 0) And (DaChoMuon = 0) ";
            if (txtTimSach.Text != "")
            {
                string dk = txtTimSach.Text;
                sql += " And (MaSach like '%" + dk + "%' or TenSach like N'%" + dk + "%' or TenMuc like N'%" + dk +
                    "%' or ViTri like N'%" + dk + "%' or NoiDung like N'%" + dk + "%')";
            }
            Public.GanNguonDataGridView(dgSach, sql);
            if (dgSach.RowCount > 0)
                lblThongBao.Text = "Có " + dgSach.RowCount + " sách.";
            else
                lblThongBao.Text = "";
        }
        private void txtTimSach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                LayNguonSach();
            }

        }
       
    }
}
