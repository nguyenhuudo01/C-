using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using app = Microsoft.Office.Interop.Excel.Application;

namespace BTL_QLNS_NHOM1
{
    public partial class FrmBangCong : Form
    {
        public FrmBangCong()
        {
            InitializeComponent();
        }
        public static SqlConnection Con;
        DataBase dtb = new DataBase();

        DataSet ds1 = new DataSet();
        DataSet ds2 = new DataSet();
        DataSet ds3 = new DataSet();
        DataSet ds4 = new DataSet();
        DataSet ds5 = new DataSet();

        public static void FillCombo(string sql, ComboBox cbo, string ma, string ten)
        {

            SqlDataAdapter Mydata = new SqlDataAdapter(sql, Con);
            DataTable table = new DataTable();
            Mydata.Fill(table);
            cbo.DataSource = table;
            cbo.ValueMember = ma; //Trường giá trị
            cbo.DisplayMember = ten; //Trường hiển thị

        }
        private void FrmBangCong_Load(object sender, EventArgs e)
        {
            Con = new SqlConnection();
            Con.ConnectionString = @"Data Source=DESKTOP-7FA0GLO\SQLBAO;Initial Catalog=QLNS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            dtb.loaddatagridview1(dgvBangThuViec, ds1, "select * from TblBangCongThuViec");
            dtb.loaddatagridview1(dgvBangChinhThuc, ds2, "select * from TblCongKhoiDieuHanh ");
            dtb.loadcombobox(cbTenBoPhan, "select * from TblBoPhan",1);
            dtb.loadcombobox(cbMaNhanVien, "select * from TblHoSoThuViec",1);
            dtb.loadcombobox(cbMaLuong, "select * from TblBangLuongCTy", 0);
            dtb.loadcombobox(cbMaNhanVienCT, "select * from TblTTNVCoBan",2);
            dtb.loadcombobox(cbTenPhongCT, "select * from TblPhongBan", 2);
            dtb.loadcombobox(cbTenPhong, "select * from TblPhongBan", 2);
        }

        private void dgvBangThuViec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            cbTenBoPhan.Text = dgvBangThuViec.Rows[i].Cells[0].Value.ToString();
            cbTenPhong.Text = dgvBangThuViec.Rows[i].Cells[1].Value.ToString();
            cbMaNhanVien.Text = dgvBangThuViec.Rows[i].Cells[2].Value.ToString();
            txtLuongThuViec.Text = dgvBangThuViec.Rows[i].Cells[3].Value.ToString();
            txtThang.Text = dgvBangThuViec.Rows[i].Cells[4].Value.ToString();
            txtNam.Text = dgvBangThuViec.Rows[i].Cells[5].Value.ToString();
            txtSoNgayCong.Text = dgvBangThuViec.Rows[i].Cells[6].Value.ToString();
            txtSoNgayNghi.Text = dgvBangThuViec.Rows[i].Cells[7].Value.ToString();
            txtSoGioLamThem.Text = dgvBangThuViec.Rows[i].Cells[8].Value.ToString();
            txtLuong.Text = dgvBangThuViec.Rows[i].Cells[9].Value.ToString();
            txtGhiChu.Text = dgvBangThuViec.Rows[i].Cells[10].Value.ToString();
        }

        private void dgvBangChinhThuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //cbMaNhanVienCT.ReadOnly = true;
            int i = e.RowIndex;
            cbMaNhanVienCT.Text = dgvBangChinhThuc.Rows[i].Cells[0].Value.ToString();
            cbTenPhongCT.Text = dgvBangChinhThuc.Rows[i].Cells[1].Value.ToString();
            txtHoTenCT.Text = dgvBangChinhThuc.Rows[i].Cells[2].Value.ToString();
            cbMaLuong.Text = dgvBangChinhThuc.Rows[i].Cells[3].Value.ToString();
            txtLuongCoBanCT.Text = dgvBangChinhThuc.Rows[i].Cells[4].Value.ToString();
            txtPhuCapCT.Text = dgvBangChinhThuc.Rows[i].Cells[5].Value.ToString();
            txtPhuCapKhac.Text = dgvBangChinhThuc.Rows[i].Cells[6].Value.ToString();
            txtThuongCT.Text = dgvBangChinhThuc.Rows[i].Cells[7].Value.ToString();
            txtKiLuatCT.Text = dgvBangChinhThuc.Rows[i].Cells[8].Value.ToString();
            txtThangCT.Text = dgvBangChinhThuc.Rows[i].Cells[9].Value.ToString();
            txtNamCT.Text = dgvBangChinhThuc.Rows[i].Cells[10].Value.ToString();
            txtSoNgayCongCT.Text = dgvBangChinhThuc.Rows[i].Cells[11].Value.ToString();
            txtSoNgayNghiCT.Text = dgvBangChinhThuc.Rows[i].Cells[12].Value.ToString();
            txtSoGioLamThemCT.Text = dgvBangChinhThuc.Rows[i].Cells[13].Value.ToString();
            txtTongLuongCT.Text = dgvBangChinhThuc.Rows[i].Cells[14].Value.ToString();
            txtGhiChu.Text = dgvBangChinhThuc.Rows[i].Cells[15].Value.ToString();
        }

        private void btnMoiCT_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox3.Controls)
            {
                if ((ctr is TextBox) || (ctr is DateTimePicker) || (ctr is ComboBox))
                {
                    ctr.Text = "";
                }
            }
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if ((ctr is TextBox) || (ctr is DateTimePicker) || (ctr is ComboBox))
                {
                    ctr.Text = "";
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThoatCT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string insert = "insert into TblBangCongThuViec values(N'" + cbTenBoPhan.Text + "',N'" + cbTenPhong.Text + "',N'" + cbMaNhanVien.Text + "',N'" + txtLuongThuViec.Text + "',N'" + txtThang.Text + "',N'" + txtNam.Text + "',N'" + txtSoNgayCong.Text + "',N'" + txtSoNgayNghi.Text + "',N'" + txtSoGioLamThem.Text + "',N'" + txtLuong.Text + "',N'" + txtGhiChu.Text + "')";
            if (!dtb.kttrungkhoa(cbMaNhanVien.Text, "select MaNVTV from TblBangCongThuViec"))
            {
                if (cbMaNhanVien.Text != "")
                {
                    dtb.thucthiketnoi(insert);
                    dgvBangThuViec.Refresh();
                    dtb.loaddatagridview1(dgvBangThuViec, ds1, "select * from TblBangCongThuViec");
                    MessageBox.Show("Thêm thành công");

                }
                else MessageBox.Show("Bạn chưa nhập Mã nhân viên");
            }
            else
                MessageBox.Show("Mã nhân viên này đã tồn tại", "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "update TblBangCongThuViec set TenBoPhan=N'" + cbTenBoPhan.Text + "',TenPhong=N'" + cbTenPhong.Text + "',LuongTViec=N'" + txtLuongThuViec.Text + "',Thang=N'" + txtThang.Text + "',Nam='" + txtNam.Text + "',SoNgayCong=N'" + txtSoNgayCong.Text + "',SoNgayNghi=N'" + txtSoNgayNghi.Text + "',SoGioLamThem=N'" + txtSoGioLamThem.Text + "',Luong=N'" + txtLuong.Text + "',GhiChu='" + txtGhiChu.Text + "' where MaNVTV=N'" + cbMaNhanVien.Text + "'";
                if (MessageBox.Show("Bạn có muốn sửa không", "Sửa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    dtb.thucthiketnoi(update);
                    dtb.loaddatagridview1(dgvBangThuViec, ds1, "select * from TblBangCongThuViec");
                    MessageBox.Show("Sửa thành công");
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string delete = "delete from TblBangCongThuViec where MaNVTV=N'" + cbMaNhanVien.Text + "'";
                if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    dtb.thucthiketnoi(delete);
                    dtb.loaddatagridview1(dgvBangThuViec, ds1, "select * from TblBangCongThuViec");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            int ltv = Convert.ToInt32(txtLuongThuViec.Text);
            int snc = Convert.ToInt32(txtSoNgayCong.Text);
            int sglt = Convert.ToInt32(txtSoGioLamThem.Text);
            float luong = ((ltv / 26) * snc + (sglt * 40000));
            txtLuong.Text = luong.ToString();
            string update = "update TblBangCongThuViec set TenBoPhan=N'" + cbTenBoPhan.Text + "',TenPhong=N'" + cbTenPhong.Text + "',LuongTViec=N'" + txtLuongThuViec.Text + "',Thang=N'" + txtThang.Text + "',Nam='" + txtNam.Text + "',SoNgayCong=N'" + txtSoNgayCong.Text + "',SoNgayNghi=N'" + txtSoNgayNghi.Text + "',SoGioLamThem=N'" + txtSoGioLamThem.Text + "',Luong=N'" + txtLuong.Text + "',GhiChu='" + txtGhiChu.Text + "' where MaNVTV=N'" + cbMaNhanVien.Text + "'";
            dtb.thucthiketnoi(update);
            dtb.loaddatagridview1(dgvBangThuViec, ds1, "select * from TblBangCongThuViec");
            MessageBox.Show("Tính lương thành công");
        }

        private void btnSuaCT_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "update TblCongKhoiDieuHanh set MaNV='" + cbMaNhanVienCT.Text + "', MaLuong=N'" + cbMaLuong.Text + "',TenPhong=N'" + cbTenPhongCT.Text + "', HoTen=N'" + txtHoTenCT.Text + "',LCB=N'" + txtLuongCoBanCT.Text + "',PCChucVu=N'" + txtPhuCapCT.Text + "',PCapKhac=N'" + txtPhuCapKhac.Text + "',Thuong=N'" + txtThuongCT.Text + "',KyLuat='" + txtKiLuatCT.Text + "',Thang=N'" + txtThangCT.Text + "',Nam='" + txtNamCT.Text + "',SoNgayCongThang=N'" + txtSoNgayCongCT.Text + "',SoNgayNghi=N'" + txtSoNgayNghiCT.Text + "',SoGioLamThem=N'" + txtSoGioLamThemCT.Text + "',Luong=N'" + txtTongLuongCT.Text + "',GhiChu='" + txtGhiChuCT.Text + "' where MaNV=N'" + cbMaNhanVienCT.Text + "'";
                dtb.thucthiketnoi(update);
                dtb.loaddatagridview1(dgvBangChinhThuc, ds2, "select * from TblCongKhoiDieuHanh");
                MessageBox.Show("Sửa thành công");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void btnTinhLuongCT_Click(object sender, EventArgs e)
        {
            int lcb = Convert.ToInt32(txtLuongCoBanCT.Text);
            int pc = Convert.ToInt32(txtPhuCapCT.Text);
            int pck = Convert.ToInt32(txtPhuCapKhac.Text);
            int nc = Convert.ToInt32(txtSoNgayCongCT.Text);
            int lt = Convert.ToInt32(txtSoGioLamThemCT.Text);
            int th = Convert.ToInt32(txtThuongCT.Text);
            int kl = Convert.ToInt32(txtKiLuatCT.Text);

            float luong = ((lcb / 26) * nc + (lt * 40000) + pc + pck + th - kl);
            txtTongLuongCT.Text = luong.ToString();
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            try
            {
                string delete = "delete from TblCongKhoiDieuHanh where MaNV=N'" + cbMaNhanVienCT.Text + "'";
                if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    dtb.thucthiketnoi(delete);
                    dtb.loaddatagridview1(dgvBangChinhThuc, ds2, "select * from TblCongKhoiDieuHanh");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }
        private void export2Excel(DataGridView g, string duongDan, string tenTap)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for (int i = 1; i < g.Columns.Count + 1; i++)
            {

                obj.Cells[1, i] = g.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(duongDan + tenTap + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }
        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (dgvBangThuViec.RowCount <= 0) return;
            if (MessageBox.Show("Bạn có muốn xuất danh sách ra excel không?", "Thông Báo",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            DataBase.XuatFileExcel(dgvBangThuViec, "BangCongThuViec.xls");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvBangChinhThuc.RowCount <= 0) return;
            if (MessageBox.Show("Bạn có muốn xuất danh sách ra excel không?", "Thông Báo",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            DataBase.XuatFileExcel(dgvBangChinhThuc, "BangCongNhanVienChinhThuc.xls");
        }

        private void cbMaNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtb.loadcomboboxchiso(cbTenBoPhan, "select * from TblBangCongThuViec where MaNVTV='" + cbMaNhanVien.Text + "'", 0);
            dtb.loadcomboboxchiso(cbTenPhong, "select * from TblBangCongThuViec where MaNVTV='" + cbMaNhanVien.Text + "'", 1);
            dtb.loadtextboxchiso(txtThang, "select * from TblBangCongThuViec where MaNVTV='" + cbMaNhanVien.Text + "'", 4);         
            dtb.loadtextboxchiso(txtNam, "select * from TblBangCongThuViec where MaNVTV='" + cbMaNhanVien.Text + "'", 5);
            dtb.loadtextboxchiso(txtLuongThuViec, "select * from TblBangCongThuViec where MaNVTV='" + cbMaNhanVien.Text + "'", 3);
            dtb.loadtextboxchiso(txtSoGioLamThem, "select * from TblBangCongThuViec where MaNVTV='" + cbMaNhanVien.Text + "'", 8);
            dtb.loadtextboxchiso(txtSoNgayCong, "select * from TblBangCongThuViec where MaNVTV='" + cbMaNhanVien.Text + "'", 6);
            dtb.loadtextboxchiso(txtSoNgayNghi, "select * from TblBangCongThuViec where MaNVTV='" + cbMaNhanVien.Text + "'", 7);
            dtb.loadtextboxchiso(txtLuong, "select * from TblBangCongThuViec where MaNVTV='" + cbMaNhanVien.Text + "'", 9);
            dtb.loadtextboxchiso(txtGhiChu, "select * from TblBangCongThuViec where MaNVTV='" + cbMaNhanVien.Text + "'", 10);

        }

        private void cbMaLuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtb.loadtextboxchiso(txtLuongCoBanCT, "select * from TblBangLuongCTy where MaLuong='" + cbMaLuong.Text + "'", 4 );
            dtb.loadtextboxchiso(txtPhuCapCT, "select * from TblBangLuongCTy where MaLuong='" + cbMaLuong.Text + "'", 2);
        }

        private void txtMaNhanVienCT_TextChanged(object sender, EventArgs e)
        {
            dtb.loadtextboxchiso(txtLuongCoBanCT, "select * from TblBangLuongCTy where MaLuong='" + cbMaLuong.Text + "'", 1);
        }

        private void txtThuongCT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtKiLuatCT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtThangCT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtSoNgayNghiCT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtSoGioLamThemCT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtNamCT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtTongLuongCT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void cbMaNhanVienCT_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtb.loadtextboxchiso(txtHoTenCT, "select * from TblTTNVCoBan where MaNV = '" + cbMaNhanVienCT.Text + "'", 3);
            dtb.loadcomboboxchiso(cbMaLuong, "select * from TblTTNVCoBan where MaNV = '" + cbMaNhanVienCT.Text + "'", 4);
            dtb.loadtextboxchiso(txtLuongCoBanCT, "select * from TblBangLuongCTy where MaLuong = '" + cbMaLuong.Text + "'", 4);
            dtb.loadcomboboxchiso(cbTenPhongCT, "select * from TblCongKhoiDieuHanh where MaNV = '" + cbMaNhanVienCT.Text + "'", 1);
            dtb.loadtextboxchiso(txtPhuCapCT, "select * from TblCongKhoiDieuHanh where MaNV = '" + cbMaNhanVienCT.Text + "'", 5);

        }

        private void txtThang_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtNam_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtLuongThuViec_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtSoGioLamThem_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtSoNgayCong_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtSoNgayNghi_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void dgvBangThuViec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            string insert = "insert into TblCongKhoiDieuHanh values(N'" + cbMaNhanVienCT.Text + "',N'" + cbTenPhongCT.Text + "',N'" + txtHoTenCT.Text + "',N'" + cbMaLuong.Text + "',N'" + txtLuongCoBanCT.Text + "',N'" + txtPhuCapCT.Text + "',N'" + txtPhuCapKhac.Text + "',N'" + txtThuongCT.Text + "',N'" + txtKiLuatCT.Text + "',N'" + txtThangCT.Text + "',N'" + txtNamCT.Text + "',N'" + txtSoNgayCongCT.Text + "',N'" + txtSoNgayNghiCT.Text + "',N'" + txtSoGioLamThemCT.Text + "',N'" + txtTongLuongCT.Text + "',N'" + txtGhiChuCT.Text + "')";
            if (!dtb.kttrungkhoa(cbMaNhanVienCT.Text, "select MaNV from TblCongKhoiDieuHanh"))
            {
                if (cbMaNhanVienCT.Text != "")
                {
                    dtb.thucthiketnoi(insert);
                    dgvBangChinhThuc.Refresh();
                    dtb.loaddatagridview1(dgvBangChinhThuc, ds1, "select * from TblCongKhoiDieuHanh");
                    MessageBox.Show("Thêm thành công");
                        
                }
                else MessageBox.Show("Bạn chưa nhập Mã nhân viên");
            }
            else
                MessageBox.Show("Mã nhân viên này đã tồn tại", "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void cbTenBoPhan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void cbMaNhanVienCT_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dgvBangChinhThuc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbTenBoPhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
