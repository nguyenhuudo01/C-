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
    public partial class frmSach : Form
    {
        string sql, macu, dk, dk0, dk1, dk2;
        DataGridViewCellMouseEventArgs vt;
        bool ktThem;
        public frmSach()
        {
            InitializeComponent();
        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                dk = txtTimKiem.Text.Trim();
                LayNguon();
            }
        }

        private void frmSach_Load(object sender, EventArgs e)
        {
            cboFTinhTrang.SelectedIndex = 0;
            cboFMuonTra.SelectedIndex = 0;
            KhoaMo(true);
            dk = "";
            LayNguon();
            LayNguonComBo();
        }
        void LayNguon()
        {
            sql = "select MaSach,TenSach, TenMuc, TenTG, TenNXB, ViTri, NoiDung, DaChoMuon, DaBiHong, Sach.MaMuc, Sach.MaTG, Sach.MaNXB " +
                    "from Sach inner join ChuyenMuc on Sach.MaMuc = ChuyenMuc.MaMuc " +
                    "inner join TacGia on Sach.MaTG = TacGia.MaTG " +
                    "inner join NhaXB on Sach.MaNXB = NhaXB.MaNXB";
            dk0 = "";
            if (dk != "")
                dk0 = " (MaSach like '%" + dk + "%' or TenSach like N'%" + dk + "%' or TenMuc like N'%" + dk + 
                    "%' or ViTri like N'%" + dk + "%' or NoiDung like N'%" + dk + "%')";
            dk1 = "";
            if (cboFMuonTra.SelectedIndex > 0)
            {
                dk1 = " (DaChoMuon = " + (cboFMuonTra.SelectedIndex == 1 ? "0" : "1") + ")";
            }
            dk2 = "";
            if (cboFTinhTrang.SelectedIndex > 0)
            {
                dk2= " (DaBiHong = " + (cboFTinhTrang.SelectedIndex==1? "0" : "1") + ")";
            }
            if (dk0 != "" || dk1 != "" || dk2 != "")
            {
                sql = sql + " where ";
                if (dk0 != "")
                    sql = sql + dk0;
                if (dk1 != "")
                    sql = sql +  (dk==""?"":" and ") + dk1;
                if (dk2 != "")
                    sql = sql + (dk == "" && dk1 == "" ? "" : " and ") + dk2;
            }
            sql = sql + " order by TenSach";
            Public.GanNguonDataGridView(dgDanhSach, sql);
            if (dgDanhSach.RowCount > 0)
                lblThongBao.Text = "Danh sách có " + dgDanhSach.RowCount + " dòng.";
            else
                lblThongBao.Text = "";
        }
        void LayNguonComBo()
        {
            Public.GanNguonComboBox(cboChuyenMuc, "TenMuc", "MaMuc", "Select MaMuc,TenMuc From ChuyenMuc Order By TenMuc");
            Public.GanNguonComboBox(cboTacGia, "TenTG", "MaTG", "Select MaTG,TenTG From TacGia Order By TenTG");
            Public.GanNguonComboBox(cboNhaXB, "TenNXB", "MaNXB", "Select MaNXB,TenNXB From NhaXB Order By TenNXB");
        }

        void KhoaMo(bool b)
        {
            dgDanhSach.Enabled = b;
            txtTenSach.ReadOnly = b; txtViTri.ReadOnly = b; txtNoiDung.ReadOnly = b;
            cboChuyenMuc.Enabled = !b; cboTacGia.Enabled = !b; cboNhaXB.Enabled = !b;
            cboMuonTra.Enabled = !b; cboTinhTrang.Enabled = !b;
            cmdInDS.Enabled = b;
            cmdThem.Enabled = b; cmdSua.Enabled = b;
            cmdXoa.Enabled = b; cmdKetThuc.Enabled = b;
            cmdGhi.Enabled = !b; cmdKhong.Enabled = !b;
        }

        void XoaTrang()
        {
            txtMaSach.Text = ""; txtTenSach.Text = ""; txtViTri.Text = ""; txtNoiDung.Text = "";
        }
        private void dgDanhSach_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgDanhSach.RowCount <= 0) return;
            if (e.RowIndex >= 0)
            {
                vt = e;
                DataGridViewRow row = dgDanhSach.Rows[e.RowIndex];
                txtMaSach.Text = row.Cells[0].Value.ToString();
                txtTenSach.Text = row.Cells[1].Value.ToString();
                cboChuyenMuc.SelectedValue = row.Cells[9].Value.ToString();
                cboTacGia.SelectedValue = row.Cells[10].Value.ToString();
                cboNhaXB.SelectedValue = row.Cells[11].Value.ToString();
                txtViTri.Text = row.Cells[5].Value.ToString();
                txtNoiDung.Text = row.Cells[6].Value.ToString();
                cboMuonTra.SelectedIndex = Boolean.Parse(row.Cells[7].Value.ToString()) == true ? 1 : 0;
                cboTinhTrang.SelectedIndex = Boolean.Parse(row.Cells[8].Value.ToString()) == true ? 1 : 0;
            }
        }
        private void cmdThem_Click(object sender, EventArgs e)
        {
            ktThem = true;
            KhoaMo(false);
            XoaTrang();
            txtMaSach.Text = Public.TaoMa("MaSach", "Sach");
            txtTenSach.Focus();
        }

        private void cmdSua_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text == "") return;
            if (cboMuonTra.SelectedIndex == 1)
            {
                MessageBox.Show("Sách đang cho mượn, không được cập nhật.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ktThem = false;
            macu = txtMaSach.Text;
            KhoaMo(false);
            txtTenSach.Focus();
        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text == "") return;
            if (cboMuonTra.SelectedIndex == 1)
            {
                MessageBox.Show("Sách đang cho mượn, không được cập nhật.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            macu = txtMaSach.Text;
            if (MessageBox.Show("Bạn có muốn xóa cuốn sách đang chọn không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "Delete From Sach Where MaSach='" + macu + "'";
                if (Public.ThucHienSQL(sql) == true)
                {
                    MessageBox.Show("Bạn thực hiện xóa thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    XoaTrang();
                    LayNguon();
                }
            }
        }

        private void cmdInDS_Click(object sender, EventArgs e)
        {
            if (dgDanhSach.RowCount <= 0) return;
            if (MessageBox.Show("Bạn có muốn xuất danh sách ra excel không?", "Thông Báo",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            Public.XuatFileExcel(dgDanhSach, "Sach.xls");
        }

        private void cmdGhi_Click(object sender, EventArgs e)
        {
            if (txtTenSach.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên cuốn sách.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenSach.Focus();
                return;
            }

            if ((MessageBox.Show("Bạn có muốn cập nhật thông tin cuốn sách không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                if (ktThem == true)
                    sql = "Insert Into Sach(MaSach,TenSach,MaMuc,MaTG,MaNXB,ViTri,NoiDung,DaChoMuon,DaBiHong) " +
                        "Values(@MaSach, @TenSach, @MaMuc, @MaTG, @MaNXB, @ViTri, @NoiDung, @DaChoMuon, @DaBiHong)";
                else
                    sql = "Update Sach Set TenSach=@TenSach, MaMuc=@MaMuc, MaTG=@MaTG, MaNXB=@MaNXB, " +
                        "ViTri=@ViTri, NoiDung=@NoiDung, DaChoMuon=@DaChoMuon, DaBiHong=@DaBiHong Where MaSach = @MaSach";
                SqlConnection conn = Public.KetNoi();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@MaSach", SqlDbType.NVarChar).Value = txtMaSach.Text;
                cmd.Parameters.Add("@TenSach", SqlDbType.NVarChar).Value = txtTenSach.Text;
                cmd.Parameters.Add("@MaMuc", SqlDbType.NVarChar).Value = cboChuyenMuc.SelectedValue.ToString();
                cmd.Parameters.Add("@MaTG", SqlDbType.NVarChar).Value = cboTacGia.SelectedValue.ToString();
                cmd.Parameters.Add("@MaNXB", SqlDbType.NVarChar).Value = cboNhaXB.SelectedValue.ToString();
                cmd.Parameters.Add("@ViTri", SqlDbType.NVarChar).Value = txtViTri.Text;
                cmd.Parameters.Add("@NoiDung", SqlDbType.NVarChar).Value = txtNoiDung.Text;
                cmd.Parameters.Add("@DaChoMuon", SqlDbType.Bit).Value = cboMuonTra.SelectedIndex;
                cmd.Parameters.Add("@DaBiHong", SqlDbType.Bit).Value = cboTinhTrang.SelectedIndex;
                if (conn.State != ConnectionState.Open) conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Bạn cập nhật thông tin cuốn sách thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                XoaTrang();
                KhoaMo(true);
                LayNguon();
                try
                {
                    dgDanhSach_CellMouseClick(sender, vt);
                }
                catch (Exception ex) { Console.WriteLine("Error : " + ex.Message.ToString()); }
            }
        }

        private void cboFMuonTra_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LayNguon();
            }
            catch (Exception ex) { Console.WriteLine("Error : " + ex.Message.ToString()); }
        }

        private void cboFTinhTrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LayNguon();
            }
            catch (Exception ex) { Console.WriteLine("Error : " + ex.Message.ToString()); }
        }

        private void cmdKhong_Click(object sender, EventArgs e)
        {
            try
            {
                XoaTrang();
                KhoaMo(true);
                dgDanhSach_CellMouseClick(sender, vt);
            }
            catch (Exception ex) { Console.WriteLine("Error : " + ex.Message.ToString()); }
        }

        private void cmdKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
