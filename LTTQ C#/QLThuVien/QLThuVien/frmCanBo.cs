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
    public partial class frmCanBo : Form
    {
        string sql, macu, taikhoancu, emailcu, dk;
        DataGridViewCellMouseEventArgs vt;
        bool ktThem;
        public frmCanBo()
        {
            InitializeComponent();
        }

        private void frmCanBo_Load(object sender, EventArgs e)
        {
            KhoaMo(true);
            dk = "";
            LayNguon();
        }

        void LayNguon()
        {
            sql = "select macb,hodem,ten,taikhoan,matkhau, ngaysinh, case gioitinh when 1 then 'Nam' else N'Nữ' end as phai, chucvu, sdt, email, diachi" +
                " from CanBo";
            if (dk != "")
                sql = sql + " where macb like '%" + dk + "%' or hodem like N'%" + dk + "%' or ten like N'%" + dk + "%' or taikhoan like N'%" + dk + "%'";
            sql = sql + " order by Ten, TaiKhoan";
            Public.GanNguonDataGridView(dgDanhSach, sql);
            if (dgDanhSach.RowCount > 0)
                lblThongBao.Text = "Danh sách có " + dgDanhSach.RowCount + " dòng.";
            else
                lblThongBao.Text = "";
        }

        void KhoaMo(bool b)
        {
            dgDanhSach.Enabled = b;
            txtHoDem.ReadOnly = b; txtTen.ReadOnly = b;
            txtTaiKhoan.ReadOnly = b; txtMatKhau.ReadOnly = b;txtEmail.ReadOnly = b;
            chkNgaySinh.Enabled = !b; dtpNgaySinh.Enabled = !b; cboGioiTinh.Enabled = !b;
            cboChucVu.Enabled = !b; txtSDT.ReadOnly = b; txtDiaChi.ReadOnly = b;

            cmdInDS.Enabled = b;
            cmdThem.Enabled = b; cmdSua.Enabled = b;
            cmdXoa.Enabled = b; cmdKetThuc.Enabled = b;
            cmdGhi.Enabled = !b; cmdKhong.Enabled = !b;
        }

        void XoaTrang()
        {
            txtMaCB.Text = ""; txtHoDem.Text = ""; txtTen.Text = "";
            txtTaiKhoan.Text = ""; txtMatKhau.Text = "";
            cboChucVu.Text = ""; txtSDT.Text = ""; txtDiaChi.Text = "";
        }
        private void dgDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgDanhSach_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgDanhSach.RowCount <= 0) return;
            if (e.RowIndex >= 0)
            {
                vt = e;
                DataGridViewRow row = dgDanhSach.Rows[e.RowIndex];
                txtMaCB.Text = row.Cells[0].Value.ToString();
                txtHoDem.Text = row.Cells[1].Value.ToString();
                txtTen.Text = row.Cells[2].Value.ToString();
                txtTaiKhoan.Text = row.Cells[3].Value.ToString();
                txtMatKhau.Text = row.Cells[4].Value.ToString();
                if (row.Cells[5].Value.ToString()!="")
                {
                    chkNgaySinh.Checked = true;
                    dtpNgaySinh.Value = DateTime.Parse(row.Cells[5].Value.ToString());
                }
                else
                {
                    chkNgaySinh.Checked = false;
                    dtpNgaySinh.Value = DateTime.Now;
                }
                if (row.Cells[6].Value.Equals("Nam") == true)
                    cboGioiTinh.SelectedIndex = 1;
                else
                    cboGioiTinh.SelectedIndex = 0;
                cboChucVu.Text = row.Cells[7].Value.ToString();
                txtSDT.Text = row.Cells[8].Value.ToString();
                txtEmail.Text = row.Cells[9].Value.ToString();
                txtDiaChi.Text = row.Cells[10].Value.ToString();
            }
        }

        private void cmdThem_Click(object sender, EventArgs e)
        {
            ktThem = true;
            KhoaMo(false);
            XoaTrang();
            txtMaCB.Text = Public.TaoMa("MaCB", "CanBo");
            chkNgaySinh.Checked = true;
            txtHoDem.Focus();
        }

        private void cmdSua_Click(object sender, EventArgs e)
        {
            if (txtMaCB.Text == "") return;
            ktThem = false;
            macu = txtMaCB.Text;
            taikhoancu = txtTaiKhoan.Text;
            emailcu = txtEmail.Text;
            KhoaMo(false);
            txtHoDem.Focus();
        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {
            if (txtMaCB.Text == "") return;
            macu = txtMaCB.Text;
            if (MessageBox.Show("Bạn có muốn xóa cán bộ đang chọn không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "Delete From CanBo Where MaCB='" + macu + "'";
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
                MessageBox.Show("Bạn chưa nhập tên cán bộ.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return;
            }
            /*
            if (Public.ktTrungMa("MaCB", "CanBo", ktThem, txtMaCB.Text, macu) == true)
            {
                MessageBox.Show("Bạn nhập mã cán bộ trùng với mã cán bộ đã tồn tại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaCB.Focus();
                return;
            }*/
            if (txtTaiKhoan.Text != "")
            {
                if (Public.ktTrungMa("TaiKhoan", "CanBo", ktThem, txtTaiKhoan.Text, taikhoancu) == true)
                {
                    MessageBox.Show("Bạn nhập tài khoản trùng với tài khoản đã tồn tại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaCB.Focus();
                    return;
                }
            }
            if (txtEmail.Text != "")
            {
                if (Public.ktEmail(txtEmail.Text) == false)
                {
                    MessageBox.Show("Bạn nhập email bị sai quy định.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Focus();
                    return;
                }
                if (Public.ktTrungMa("Email", "CanBo", ktThem, txtEmail.Text, emailcu) == true)
                {
                    MessageBox.Show("Bạn nhập email trùng với email đã tồn tại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Focus();
                    return;
                }
            }
            if ((MessageBox.Show("Bạn có muốn cập nhật hồ sơ cán bộ không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                if (ktThem == true)
                    sql = "Insert Into CanBo(MaCB, HoDem, Ten, TaiKhoan, MatKhau, NgaySinh, GioiTinh, ChucVu, SDT, Email, DiaChi) " +
                        "Values(@MaCB, @HoDem, @Ten, @TaiKhoan, @MatKhau, @NgaySinh, @GioiTinh, @ChucVu, @SDT, @Email, @DiaChi)";
                else
                    sql = "Update CanBo Set MaCB=@MaCB, HoDem=@HoDem, Ten=@Ten, TaiKhoan=@TaiKhoan, MatKhau=@MatKhau, " +
                        "NgaySinh=@NgaySinh, GioiTinh=@GioiTinh, ChucVu=@ChucVu, SDT=@SDT, Email=@Email, DiaChi=@DiaChi Where MaCB = @macu";
                SqlConnection conn = Public.KetNoi();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@MaCB", SqlDbType.NVarChar).Value = txtMaCB.Text;
                cmd.Parameters.Add("@HoDem", SqlDbType.NVarChar).Value = txtHoDem.Text;
                cmd.Parameters.Add("@Ten", SqlDbType.NVarChar).Value = txtTen.Text;
                cmd.Parameters.Add("@TaiKhoan", SqlDbType.NVarChar).Value = txtTaiKhoan.Text;
                cmd.Parameters.Add("@MatKhau", SqlDbType.NVarChar).Value = txtMatKhau.Text;
                if (chkNgaySinh.Checked == true)
                    cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = dtpNgaySinh.Value;
                else
                    cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = DBNull.Value;
                cmd.Parameters.Add("@GioiTinh", SqlDbType.Bit).Value = cboGioiTinh.SelectedIndex;
                cmd.Parameters.Add("@ChucVu", SqlDbType.NVarChar).Value = cboChucVu.Text;
                cmd.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = txtSDT.Text;
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = txtEmail.Text;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = txtDiaChi.Text;
                if (ktThem == false) cmd.Parameters.Add("@macu", SqlDbType.NVarChar).Value = macu;
                if (conn.State != ConnectionState.Open) conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Bạn cập nhật hồ sơ cán bộ thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }

        private void cmdInDS_Click(object sender, EventArgs e)
        {
            if (dgDanhSach.RowCount <= 0) return;
            if (MessageBox.Show("Bạn có muốn xuất danh sách ra excel không?", "Thông Báo",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            Public.XuatFileExcel(dgDanhSach, "CanBo.xls");
        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                dk = txtTimKiem.Text.Trim();
                LayNguon();
            }
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
