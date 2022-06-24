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

namespace BTL_QLNS_NHOM1
{
    public partial class FrmThongTinCoBan : Form
    {
        public FrmThongTinCoBan()
        {
            InitializeComponent();
        }
        DataBase dataBase = new DataBase();
        public static SqlConnection Con;
        

        private void FrmThongTinCoBan_Load(object sender, EventArgs e)
        {
            Con = new SqlConnection();
            Con.ConnectionString = @"Data Source=DESKTOP-63TNGNI\SQLEXPRESS;Initial Catalog=QLNS;Integrated Security=True";
            dtNgaySinh.CustomFormat = " MM / dd / yyyy ";
            dtNgayKy.CustomFormat = " MM / dd / yyyy ";
            dtNgayHetHan.CustomFormat = " MM / dd / yyyy ";
            dataBase.loadcombobox(txtMaLuong, "select MaLuong from TblBangLuongCTy", 0);

            FrmThongTinCoBan.FillCombo("SELECT MaBoPhan FROM TblBoPhan", cbMaBoPhan, "MaBoPhan", "MaBoPhan");
            cbMaBoPhan.SelectedIndex = -1;

            dataBase.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            FrmThongTinCoBan.FillCombo("select p.MaPhong from TblBoPhan b,TblPhongBan p where b.MaBoPhan=p.MaBoPhan and p.MaBoPhan=N'" + cbMaBoPhan.SelectedValue + "'", cbMaPhong, "MaPhong", "MaPhong");
            cbMaPhong.DisplayMember = "MaPhong";
            cbMaPhong.ValueMember = "MaPhong";
        }
        public static void FillCombo(string sql, ComboBox cbo, string ma, string ten)
        {

            SqlDataAdapter Mydata = new SqlDataAdapter(sql, Con);
            DataTable table = new DataTable();
            Mydata.Fill(table);
            cbo.DataSource = table;
            cbo.ValueMember = ma; //Trường giá trị
            cbo.DisplayMember = ten; //Trường hiển thị

        }

        

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hang = e.RowIndex;
                cbMaBoPhan.Text = dataGridView1.Rows[hang].Cells[0].Value.ToString();
                cbMaPhong.Text = dataGridView1.Rows[hang].Cells[1].Value.ToString();
                txtMaNV.Text = dataGridView1.Rows[hang].Cells[2].Value.ToString();
                txtHoTen.Text = dataGridView1.Rows[hang].Cells[3].Value.ToString();
                txtMaLuong.Text = dataGridView1.Rows[hang].Cells[4].Value.ToString();
                dtNgaySinh.Text = dataGridView1.Rows[hang].Cells[5].Value.ToString();
                cbGioiTinh.Text = dataGridView1.Rows[hang].Cells[6].Value.ToString();
                txtTTHonNhan.Text = dataGridView1.Rows[hang].Cells[7].Value.ToString();
                txtCMND.Text = dataGridView1.Rows[hang].Cells[8].Value.ToString();
                txtNoiCap.Text = dataGridView1.Rows[hang].Cells[9].Value.ToString();
                txtChucVu.Text = dataGridView1.Rows[hang].Cells[10].Value.ToString();
                txtLoaiHD.Text = dataGridView1.Rows[hang].Cells[11].Value.ToString();
                txtThoiGian.Text = dataGridView1.Rows[hang].Cells[12].Value.ToString();
                dtNgayKy.Text = dataGridView1.Rows[hang].Cells[13].Value.ToString();
                dtNgayHetHan.Text = dataGridView1.Rows[hang].Cells[14].Value.ToString();
                txtGhiChu.Text = dataGridView1.Rows[hang].Cells[15].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("");
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            string insert = "insert into TblTTNVCoBan values(N'" + cbMaBoPhan.Text + "',N'" + cbMaPhong.Text + "',N'" + txtMaNV.Text + "',N'" + txtHoTen.Text + "',N'" + txtMaLuong.Text + "',N'" + dtNgaySinh.Text + "',N'" + cbGioiTinh.Text + "',N'" + txtTTHonNhan.Text + "',N'" + txtCMND.Text + "',N'" + txtNoiCap.Text + "',N'" + txtChucVu.Text + "',N'" + txtLoaiHD.Text + "',N'" + txtThoiGian.Text + "',N'" + dtNgayKy.Text + "',N'" + dtNgayHetHan.Text + "',N'" + txtGhiChu.Text + "')";

            if ((!dataBase.kttrungkhoa(txtMaNV.Text, "select MaNV from TblTTNVCoBan")) && (!dataBase.kttrungkhoa(txtCMND.Text, "select CMTND from TblNVThoiViec")))
            {
                if (txtMaNV.Text != "" && txtCMND.Text != "")
                {
                    dataBase.thucthiketnoi(insert);
                    dataGridView1.Refresh();
                    dataBase.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan");
                    MessageBox.Show("Thêm thành công");
                }
                else if (txtMaNV.Text == "") MessageBox.Show("Bạn chưa nhập Mã nhân viên");
                else if (txtCMND.Text == "") MessageBox.Show("Bạn chưa nhập số CMTND");
            }
            else if ((!dataBase.kttrungkhoa(txtMaNV.Text, "select MaNV from TblTTNVCoBan")) && (dataBase.kttrungkhoa(txtCMND.Text, "select CMTND from TblNVThoiViec")))
            {
                if (MessageBox.Show("Nhân viên này đã từng làm ở công ty, bạn có chắc muốn thêm?", "Thêm thất bại", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    dataBase.thucthiketnoi(insert);
                    dataBase.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan");
                    MessageBox.Show("Thêm thành công");
                    string delete = "delete from TblNVThoiViec where CMTND='" + txtCMND.Text + "'";
                    dataBase.thucthiketnoi(delete);
                }
            }
            else if ((dataBase.kttrungkhoa(txtMaNV.Text, "select MaNV from TblTTNVCoBan")) && (!dataBase.kttrungkhoa(txtCMND.Text, "select CMTND from TblNVThoiViec")))
                MessageBox.Show("Mã nhân viên này đã tồn tại", "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            string ine = "insert into TblTTCaNhan(MaNV,HoTen) select MaNV,HoTen from TblTTNVCoBan where MaNV='" + txtMaNV.Text + "'";
            if ((!dataBase.kttrungkhoa(txtMaNV.Text, "select MaNV from TblTTCaNhan")))
            {
                if (txtMaNV.Text != "")
                {
                    dataBase.thucthiketnoi(ine);
                    dataGridView1.Refresh();
                }
                else MessageBox.Show("Bạn chưa nhập Mã nhân viên");
            }
            else
                MessageBox.Show("Mã nhân viên này đã tồn tại", "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            string ins = "insert into TblCongKhoiDieuhanh(MaNV,HoTen,MaLuong) select MaNV,HoTen,MaLuong from TblTTNVCoBan where MaNV='" + txtMaNV.Text + "'";
            if ((!dataBase.kttrungkhoa(txtMaNV.Text, "select MaNV from TblCongKhoiDieuHanh")))
            {
                if (txtMaNV.Text != "")
                {
                    dataBase.thucthiketnoi(ins);
                    dataGridView1.Refresh();
                }
                else MessageBox.Show("Bạn chưa nhập Mã nhân viên");
            }
            else
                MessageBox.Show("Mã nhân viên này đã tồn tại", "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            string updata = " update TblCongKhoiDieuHanh set TenPhong = (select top(1) TenPhong from TblPhongBan a,TblTTNVCoBan b where a.MaPhong=b.MaPhong and a.MaPhong=N'" + cbMaPhong.Text + "' group by TenPhong) where MaNV='" + txtMaNV.Text + "'";

            dataBase.thucthiketnoi(updata);
            dataGridView1.Refresh();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
            string update = "update TblTTNVCoBan set MaBoPhan=N'" + cbMaBoPhan.Text + "',MaPhong=N'" + cbMaPhong.Text + "',HoTen=N'" + txtHoTen.Text + "',MaLuong=N'" + txtMaLuong.Text + "',NgaySinh='" + dtNgaySinh.Text + "',GioiTinh=N'" + cbGioiTinh.Text + "',TTHonNhan=N'" + txtTTHonNhan.Text + "',CMTND=N'" + txtCMND.Text + "',NoiCap=N'" + txtNoiCap.Text + "',ChucVu=N'" + txtChucVu.Text + "',LoaiHD=N'" + txtLoaiHD.Text + "',ThoiGian=N'" + txtThoiGian.Text + "',NgayKy='" + dtNgayKy.Text + "',NgayHetHan='" + dtNgayHetHan.Text + "',GhiChu=N'" + txtGhiChu.Text + "' where MaNV=N'" + txtMaNV.Text + "'";
            dataBase.thucthiketnoi(update);
            dataGridView1.Refresh();
            dataBase.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan");
            MessageBox.Show("Sửa thành công");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");

            }
            string upd = "update TblCongKhoiDieuHanh set HoTen=N'" + txtHoTen.Text + "',MaLuong=N'" + txtMaLuong.Text + "' where MaNV=N'" + txtMaNV.Text + "'";
            dataBase.thucthiketnoi(upd);
            dataBase.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan");
            string ds = "update TblCongKhoiDieuHanh set TenPhong = (select top(1) TenPhong from TblPhongBan a,TblTTNVCoBan b where a.MaPhong=b.MaPhong and a.MaPhong=N'" + cbMaPhong.Text + "' group by TenPhong) where MaNV='" + txtMaNV.Text + "'";

            dataBase.thucthiketnoi(ds);
            dataGridView1.Refresh();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string delete = "delete from TblTTNVCoBan where MaNV=N'" + txtMaNV.Text + "'";
            if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                dataBase.thucthiketnoi(delete);
                dataBase.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan");
                MessageBox.Show("Đã xóa dữ liệu ");
            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnXuatExcel1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount <= 0) return;
            if (MessageBox.Show("Bạn có muốn xuất danh sách ra excel không?", "Thông Báo",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            DataBase.XuatFileExcel(dataGridView1, "TTCB.xls");
        }

        private void txtMaLuong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtLoaiHD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }   
}
