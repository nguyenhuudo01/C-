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
    public partial class frmDocGia : Form
    {
        string sql, macu, dk;
        DataGridViewCellMouseEventArgs vt;
        bool ktThem;
        public frmDocGia()
        {
            InitializeComponent();
        }

        private void frmDocGia_Load(object sender, EventArgs e)
        {
            KhoaMo(true);
            dk = "";
            LayNguon();
        }

        void LayNguon()
        {
            sql = "select thedg,hodem,ten,ngaysinh, case gioitinh when 1 then 'Nam' else N'Nữ' end as phai, lop, sdt, diachi, ngaymuathe, ngayhethan" +
                " from DocGia";
            if (dk != "")
                sql = sql + " where thedg like '%" + dk + "%' or hodem like N'%" + dk + "%' or ten like N'%" + dk + "%' or lop like N'%" + dk + "%'";
            sql = sql + " order by Ten, HoDem";
            Public.GanNguonDataGridView(dgDanhSach, sql);
            if (dgDanhSach.RowCount > 0)
                lblThongBao.Text = "Danh sách có " + dgDanhSach.RowCount + " dòng.";
            else
                lblThongBao.Text = "";
        }

        void KhoaMo(bool b)
        {
            dgDanhSach.Enabled = b;
            txtHoDem.ReadOnly = b; txtTen.ReadOnly = b;txtLop.ReadOnly = b;
            chkNgaySinh.Enabled = !b; dtpNgaySinh.Enabled = !b; cboGioiTinh.Enabled = !b;
            txtSDT.ReadOnly = b; txtDiaChi.ReadOnly = b;
            chkNgayMuaThe.Enabled = !b; dtpNgayMuaThe.Enabled = !b;
            chkNgayHetHan.Enabled = !b; dtpNgayHetHan.Enabled = !b;
            cmdInDS.Enabled = b;
            cmdThem.Enabled = b; cmdSua.Enabled = b;
            cmdXoa.Enabled = b; cmdKetThuc.Enabled = b;
            cmdGhi.Enabled = !b; cmdKhong.Enabled = !b;
        }

        void XoaTrang()
        {
            txtTheDG.Text = ""; txtHoDem.Text = ""; txtTen.Text = "";
            txtLop.Text = ""; txtSDT.Text = ""; txtDiaChi.Text = "";
        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                dk = txtTimKiem.Text.Trim();
                LayNguon();
            }
        }

        private void dgDanhSach_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgDanhSach.RowCount <= 0) return;
            if (e.RowIndex >= 0)
            {
                vt = e;
                DataGridViewRow row = dgDanhSach.Rows[e.RowIndex];
                txtTheDG.Text = row.Cells[0].Value.ToString();
                txtHoDem.Text = row.Cells[1].Value.ToString();
                txtTen.Text = row.Cells[2].Value.ToString();
                if (row.Cells[3].Value.ToString() != "")
                {
                    chkNgaySinh.Checked = true;
                    dtpNgaySinh.Value = DateTime.Parse(row.Cells[3].Value.ToString());
                }
                else
                {
                    chkNgaySinh.Checked = false;
                    dtpNgaySinh.Value = DateTime.Now;
                }
                if (row.Cells[4].Value.Equals("Nam") == true)
                    cboGioiTinh.SelectedIndex = 1;
                else
                    cboGioiTinh.SelectedIndex = 0;
                txtLop.Text = row.Cells[5].Value.ToString();
                txtSDT.Text = row.Cells[6].Value.ToString();
                txtDiaChi.Text = row.Cells[7].Value.ToString();
                if (row.Cells[8].Value.ToString() != "")
                {
                    chkNgayMuaThe.Checked = true;
                    dtpNgayMuaThe.Value = DateTime.Parse(row.Cells[8].Value.ToString());
                }
                else
                {
                    chkNgayMuaThe.Checked = false;
                    dtpNgayMuaThe.Value = DateTime.Now;
                }
                if (row.Cells[9].Value.ToString() != "")
                {
                    chkNgayHetHan.Checked = true;
                    dtpNgayHetHan.Value = DateTime.Parse(row.Cells[9].Value.ToString());
                }
                else
                {
                    chkNgayHetHan.Checked = false;
                    dtpNgayHetHan.Value = DateTime.Now;
                }
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }

        private void cmdThem_Click(object sender, EventArgs e)
        {
            ktThem = true;
            KhoaMo(false);
            XoaTrang();
            txtTheDG.Text = Public.TaoMa("TheDG", "DocGia");
            chkNgaySinh.Checked = true;chkNgayMuaThe.Checked = true;chkNgayHetHan.Checked = true;
            dtpNgayMuaThe.Value = DateTime.Now;
            dtpNgayHetHan.Value = DateTime.Now.AddMonths(6);
            txtHoDem.Focus();
        }

        private void cmdSua_Click(object sender, EventArgs e)
        {
            if (txtTheDG.Text == "") return;
            ktThem = false;
            macu = txtTheDG.Text;
            KhoaMo(false);
            txtHoDem.Focus();
        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {
            if (txtTheDG.Text == "") return;
            macu = txtTheDG.Text;
            if (MessageBox.Show("Bạn có muốn xóa độc giả đang chọn không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "Delete From DocGia Where TheDG='" + macu + "'";
                if (Public.ThucHienSQL(sql) == true)
                {
                    MessageBox.Show("Bạn thực hiện xóa thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    XoaTrang();
                    LayNguon();
                }
            }
        }

        private void cmdGhi_Click(object sender, EventArgs e)
        {
            if (txtTen.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên độc giả.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return;
            }
            /*
            if (Public.ktTrungMa("TheDG", "DocGia", ktThem, txtTheDG.Text, macu) == true)
            {
                MessageBox.Show("Bạn nhập mã độc giả trùng với mã độc giả đã tồn tại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTheDG.Focus();
                return;
            }
            */
            if ((MessageBox.Show("Bạn có muốn cập nhật hồ sơ độc giả không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                if (ktThem == true)
                    sql = "Insert Into DocGia(TheDG, HoDem, Ten, NgaySinh, GioiTinh, Lop, SDT, DiaChi, NgayMuaThe, NgayHetHan) " +
                        "Values(@TheDG, @HoDem, @Ten, @NgaySinh, @GioiTinh, @Lop, @SDT, @DiaChi, @NgayMuaThe, @NgayHetHan)";
                else
                    sql = "Update DocGia Set TheDG=@TheDG, HoDem=@HoDem, Ten=@Ten, NgaySinh=@NgaySinh, GioiTinh=@GioiTinh, " +
                        "Lop=@Lop, SDT=@SDT, DiaChi=@DiaChi, NgayMuaThe=@NgayMuaThe, NgayHetHan=@NgayHetHan Where TheDG = @macu";
                SqlConnection conn = Public.KetNoi();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@TheDG", SqlDbType.NVarChar).Value = txtTheDG.Text;
                cmd.Parameters.Add("@HoDem", SqlDbType.NVarChar).Value = txtHoDem.Text;
                cmd.Parameters.Add("@Ten", SqlDbType.NVarChar).Value = txtTen.Text;
                if (chkNgaySinh.Checked == true)
                    cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = dtpNgaySinh.Value;
                else
                    cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = DBNull.Value;
                cmd.Parameters.Add("@GioiTinh", SqlDbType.Bit).Value = cboGioiTinh.SelectedIndex;
                cmd.Parameters.Add("@Lop", SqlDbType.NVarChar).Value = txtLop.Text;
                cmd.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = txtSDT.Text;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = txtDiaChi.Text;
                if (chkNgayMuaThe.Checked == true)
                    cmd.Parameters.Add("@NgayMuaThe", SqlDbType.Date).Value = dtpNgayMuaThe.Value;
                else
                    cmd.Parameters.Add("@NgayMuaThe", SqlDbType.Date).Value = DBNull.Value;
                if (chkNgayHetHan.Checked == true)
                    cmd.Parameters.Add("@NgayHetHan", SqlDbType.Date).Value = dtpNgayHetHan.Value;
                else
                    cmd.Parameters.Add("@NgayHetHan", SqlDbType.Date).Value = DBNull.Value;
                if (ktThem == false) cmd.Parameters.Add("@macu", SqlDbType.NVarChar).Value = macu;
                if (conn.State != ConnectionState.Open) conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Bạn cập nhật hồ sơ độc giả thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void cmdInDS_Click(object sender, EventArgs e)
        {
            if (dgDanhSach.RowCount <= 0) return;
            if (MessageBox.Show("Bạn có muốn xuất danh sách ra excel không?", "Thông Báo",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            Public.XuatFileExcel(dgDanhSach, "DocGia.xls");
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
