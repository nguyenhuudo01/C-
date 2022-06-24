using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaoCaoNhom2
{
    public partial class frmThuePhong : Form
    {
        public string chuoi = "Select MaPhong,TenPhong,Phong.loaiphong,Phong.Mota,songtoida,dbo.LPhong.giaphong ,trangthai  from phong,Lphong where phong.Loaiphong = Lphong.Loaiphong AND trangthai = N'Trống'";
        public string sql_datphong = "Select id_hoadon,MaPhong,Manv,Makh,TenKH,Ngaysinh,Datcoc,Ngaynhanphong,soluongnguoi,trangthai from Hoadon where trangthai = N'Đang thuê'";
        public string sql_datphong2 = "Select id_hoadon,MaPhong,Manv,Makh,TenKH,Ngaysinh,Datcoc,Ngaydatphong,Ngaynhanphong,soluongnguoi,trangthai from Hoadon where trangthai = N'Đã đặt' or trangthai = N'Đang thuê' ";
        public string phiphong = "0";
        public string phuthu = "0";
        public string thanhtien = "0";
        string id_phong_old = "";
        public string trangthai = "Đang thuê";
        int index = 0;
        int last = 0;

        public frmThuePhong()
        {
            InitializeComponent();
            KetnoiDataBase.Chuoiketnoi(chuoi, dtgPhong);
            Namecolumn();
            KetnoiDataBase.Chuoiketnoi(sql_datphong, dtgPhongThue);
            AddCombox();
            Name_colums_datphong();
            txtMaHD1.Enabled = false;
            txtMaHD2.Enabled = false;
            btnSua1.Enabled = false;
            btnHuy1.Enabled = false;
            txtMaHD1.Focus();
            txtMaHD2.Focus();
            btnSua2.Enabled = false;
            btnHuy2.Enabled = false;
            load_makh();
            load_nv();
        }
        public void AddCombox()
        {
            cboLuaChon.Items.Add("Mã phòng");
            cboLuaChon.Items.Add("Tên phòng");
            cboLuaChon.Items.Add("Loại phòng");
            cboLuaChon.Items.Add("Mô tả phòng");
            cboLuaChon.Items.Add("Số người tối đa");
            cboLuaChon.Items.Add("Giá phòng");
            cboLuaChon.Items.Add("Trạng thái");
        }
        private void load_makh()
        {
            string load_makhach = "Select MaKh from Khachhang";
            KetnoiDataBase.xulycbx(load_makhach, cboMaKH1);
            cboMaKH1.DisplayMember = "MaKh";
            cboMaKH1.ValueMember = "MaKh";

        }
        private void load_makh2()
        {

            string load_makhach = "Select MaKh from Khachhang";
            KetnoiDataBase.xulycbx(load_makhach, cboMaKH2);
            cboMaKH2.DisplayMember = "MaKh";
            cboMaKH2.ValueMember = "MaKh";
        }
        private void load_nv()
        {

            string load_nhanvien = "Select Manv from Nhanvien";
            KetnoiDataBase.xulycbx(load_nhanvien, cboMaNV1);
            cboMaNV1.DisplayMember = "Manv";
            cboMaNV1.ValueMember = "Manv";

        }
        private void load_nv2()
        {

            string load_nhanvien = "Select Manv from Nhanvien";
            KetnoiDataBase.xulycbx(load_nhanvien, cboMaNV2);
            cboMaNV2.DisplayMember = "Manv";
            cboMaNV2.ValueMember = "Manv";
        }
        private void Namecolumn()
        {
            dtgPhong.EnableHeadersVisualStyles = false; //Gets or sets a value indicating whether row and column headers use the visual styles of the user's current theme if visual styles are enabled for the application.
            dtgPhong.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue; // gán cột màu header = color
            int sc = dtgPhong.Rows.Count;
            dtgPhong.Columns[0].HeaderText = "Mã phòng"; dtgPhong.Columns[0].Width = 127;
            dtgPhong.Columns[1].HeaderText = "Tên phòng"; dtgPhong.Columns[1].Width = 120;
            dtgPhong.Columns[2].HeaderText = "Loại phòng"; dtgPhong.Columns[2].Width = 170;
            dtgPhong.Columns[3].HeaderText = "Mô tả"; dtgPhong.Columns[3].Width = 650;
            dtgPhong.Columns[4].HeaderText = "Số ng tối đa"; dtgPhong.Columns[4].Width = 120;
            dtgPhong.Columns[5].HeaderText = "Giá phòng"; dtgPhong.Columns[5].Width = 150;
            dtgPhong.Columns[6].HeaderText = "Trạng Thái"; dtgPhong.Columns[6].Width = 130;

        }
        private void Name_colums_datphong()
        {
            dtgPhongThue.EnableHeadersVisualStyles = false; //Gets or sets a value indicating whether row and column headers use the visual styles of the user's current theme if visual styles are enabled for the application.
            dtgPhongThue.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue; // gán cột màu header = color
            dtgPhongThue.Columns[0].HeaderText = "Hóa đơn"; dtgPhongThue.Columns[0].Width = 130;
            dtgPhongThue.Columns[1].HeaderText = "Mã phòng"; dtgPhongThue.Columns[1].Width = 120;
            dtgPhongThue.Columns[2].HeaderText = "Mã khách"; dtgPhongThue.Columns[2].Width = 120;
            dtgPhongThue.Columns[3].HeaderText = "Mã nhân viên"; dtgPhongThue.Columns[3].Width = 140;
            dtgPhongThue.Columns[4].HeaderText = "Tên KH"; dtgPhongThue.Columns[4].Width = 252;
            dtgPhongThue.Columns[5].HeaderText = "Ngày sinh"; dtgPhongThue.Columns[5].Width = 160;
            dtgPhongThue.Columns[6].HeaderText = "Đặt cọc"; dtgPhongThue.Columns[6].Width = 150;
            dtgPhongThue.Columns[7].HeaderText = "Ngày nhận phòng"; dtgPhongThue.Columns[7].Width = 160;
            dtgPhongThue.Columns[8].HeaderText = "Số lương người"; dtgPhongThue.Columns[8].Width = 110;
            dtgPhongThue.Columns[9].HeaderText = "Trạng Thái"; dtgPhongThue.Columns[9].Width = 150;
            int sc = dtgPhongThue.Rows.Count;

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chăn muốn thoát không ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chăn muốn thoát không ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void txtMaPhong1_TextChanged(object sender, EventArgs e)
        {
            string a = txtMaPhong1.Text.ToString();
            string full_name = "";
            string cot = "TenPhong";
            if (txtMaPhong1.Text != "")
            {

                string id = txtMaPhong1.Text.ToString(); //Select MaKh from Khachhang
                string chuoi4 = "Select TenPhong from Phong where MaPhong ='" + a.Trim() + "'";
                string tendaydu = HamHoTro.load_one_colums(chuoi4, full_name, cot);
                txtTenPhong1.Text = "Phòng: " + tendaydu;
            }
        }
            public void Clear()
            {
                txtMaHD1.Text = "";
                txtMaHD1.Enabled = false;
                cboMaNV1.Text = "";
                cboMaKH1.Text = "";
                txtTenPhong1.Text = "";
                txtMaPhong1.Text = "";
                txtMaHD1.Enabled = false;
                dateNgayThuePhong.Value = DateTime.Now;
                dateNgaySinh1.Value = DateTime.Now;
                txtSong1.Value = 0;
                txtTenNV1.Text = "";
                txtTenKH1.Text = "";
                txtDatCoc1.Value = 0;
                txtMaHD1.Focus();
                btnThem1.Enabled = true;
                txtMaHD1.Enabled = true;
                btnSua1.Enabled = false;
                btnHuy1.Enabled = false;


            }


        private void btnThem1_Click(object sender, EventArgs e)
        {
            if (txtMaPhong1.Text == "" || cboMaNV1.Text == "" || cboMaKH1.Text == "" || txtSong1.Text == "" || txtDatCoc1.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin ! ", "Thông báo ", MessageBoxButtons.OK);
                txtMaHD1.Focus();

            }
            else
            {



                string full_name = "";
                string ma_p = txtMaPhong1.Text.Trim();
                string cot = "songtoida";
                string chuoi4 = "Select songtoida from Phong where MaPhong ='" + ma_p.Trim() + "'";
                double songtoida = Convert.ToDouble(HamHoTro.load_one_colums(chuoi4, full_name, cot));
                double songuoi = Convert.ToDouble(txtSong1.Text.Trim());
                string ma_hd = txtMaHD1.Text.Trim();
                string datcoc = txtDatCoc1.Value.ToString().Trim();
                string ma_k = cboMaKH1.Text.Trim();
                string ma_nv = cboMaNV1.Text.Trim();
                string ten_kh = txtTenKH1.Text;
                string ngaythuephong = dateNgayThuePhong.Value.ToString();
                Regex digitsOnly = new Regex(@"[^\d]");

                string ten_nv = txtTenNV1.Text.Trim();
                string song = txtSong1.Value.ToString().Trim();
                if (songuoi > songtoida)
                {
                    MessageBox.Show("Bạn quá đông người không thể đặt được phòng ! Bạn hãy thuê phòng khác ! ", "Thông báo", MessageBoxButtons.OK);
                    txtSong1.Value = 0;
                    txtSong1.Focus();
                }
                else
                {
                    string query = "SELECT TOP 1 id_hoadon FROM dbo.Hoadon ORDER BY id_hoadon DESC";

                    string codesHD = KetnoiDataBase.ketnoi<string>(query) ?? "1";
                    var numstr = digitsOnly.Replace(codesHD, "");
                    var rsNum = Int32.Parse(numstr) + 1;
                    txtMaHD1.Text = "HD" + rsNum.ToString("D4");

                    int count = 0;
                    count = dtgPhong.Rows.Count;//Dem tat ca cac dong roi gan cho count
                    string chuoi01 = "";
                    int chuoi2 = 0;
                    var saveNum = 0;

                    string sql = "Select count(*) from Hoadon where id_hoadon ='" + txtMaHD1.Text.Trim() + "'";
                    string sql1 = "Insert into Hoadon values (N'" + txtMaHD1.Text.Trim() + "',N'" + ma_p + "',N'" + ma_nv + "',N'" + ten_nv + "','" + ma_k + "',N'" + ten_kh + "','" + Convert.ToDateTime(dateNgaySinh1.Value).ToString("yyyy-MM-dd") + "','" + Convert.ToDateTime(dateNgayThuePhong.Value).ToString("yyyy-MM-dd") + "','" + Convert.ToInt32(datcoc) + "','" + Convert.ToDateTime(dateNgayThuePhong.Value).ToString("yyyy-MM-dd") + "','" + Convert.ToDateTime(dateNgayThuePhong.Value).ToString("yyyy-MM-dd") + "','" + Convert.ToInt32(song) + "','" + phiphong + "','" + phuthu + "','" + thanhtien + "',N'" + trangthai + "')";
                    string sq2 = "Update Phong set trangthai = N'Đang thuê' where MaPhong = '" + ma_p + "'";

                    KetnoiDataBase.update(sq2);

                    KetnoiDataBase.them(sql, sql1, dtgPhongThue);
                    KetnoiDataBase.Chuoiketnoi(chuoi, dtgPhong);
                    Namecolumn();
                    KetnoiDataBase.Chuoiketnoi(sql_datphong, dtgPhongThue);
                    Name_colums_datphong();

                    load_makh();
                    load_nv();
                    Clear();
                    txtMaHD1.Enabled = false;
                }
            }
        }

        private void btnSua1_Click(object sender, EventArgs e)
        {
            string full_name = "";
            string ma_p = txtMaPhong1.Text.Trim();
            string cot = "songtoida";
            string chuoi4 = "Select songtoida from Phong where MaPhong ='" + ma_p.Trim() + "'";
            double songtoida = Convert.ToDouble(HamHoTro.load_one_colums(chuoi4, full_name, cot));
            double songuoi = Convert.ToDouble(txtSong1.Text.Trim());
            string ma_hd = txtMaHD1.Text.Trim();

            string ma_k = cboMaKH1.Text.Trim();
            string ma_nv = cboMaNV1.Text.Trim();
            string ten_nv = txtTenNV1.Text.Trim();
            string ten_kh = txtTenKH1.Text.Trim();
            string ngaydatphong = dateNgayThuePhong.Value.ToString();
            int song = Convert.ToInt32(txtSong1.Value.ToString());


            // Format string theo ý định
            // loại bỏ chữ trong chuỗi
            Regex digitsOnly = new Regex(@"[^\d]");
            int curow = dtgDatPhong.CurrentRow.Index;
            var numstr = digitsOnly.Replace(txtDatCoc1.Text, "");
            string datcoc = numstr + "";
            if (txtMaHD1.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập ID .Vui lòng kiểm tra lại  ! ", "Thông báo", MessageBoxButtons.OK);

                txtMaHD1.Focus();
            }
            else if (songuoi > songtoida)
            {
                MessageBox.Show("Bạn quá đông người không thể đặt được phòng ! Bạn hãy thuê phòng khác ! ", "Thông báo", MessageBoxButtons.OK);
                txtSong1.Text = "";
                txtSong1.Focus();
            }
            else
            {

                string sql = "Update Hoadon set MaPhong = N'" + ma_p + "',Manv = '" + ma_nv + "',TenNV = N'" + ten_nv + "',Makh = N'" + ma_k + "',TenKH = N'" + ten_kh + "',Ngaysinh ='" + Convert.ToDateTime(dateNgayThuePhong.Value).ToString("yyyy-MM-dd") + "',Ngaydatphong ='" + Convert.ToDateTime(dateNgayThuePhong.Value).ToString("yyyy-MM-dd") + "',Datcoc = '" + Convert.ToInt32(datcoc) + "',Ngaynhanphong ='" + Convert.ToDateTime(dateNgayThuePhong.Value).ToString("yyyy-MM-dd") + "',Ngaytraphong='" + Convert.ToDateTime(dateNgayThuePhong.Value).ToString("yyyy-MM-dd") + "',soluongnguoi ='" + Convert.ToInt32(song) + "' where id_hoadon = '" + ma_hd + "'";
                KetnoiDataBase.Sua(sql);
                string sq2 = "Update Phong set trangthai = N'Đang Thuê' where MaPhong = '" + ma_p + "'";
                string sq3 = "Update Phong set trangthai = N'Trống' where MaPhong = '" + id_phong_old + "'";
                if (String.Compare(id_phong_old, ma_p, true) != 0)
                {
                    KetnoiDataBase.update(sq2);
                    KetnoiDataBase.update(sq3);
                }
                else
                {
                    KetnoiDataBase.update(sq2);
                }
                KetnoiDataBase.Chuoiketnoi(chuoi, dtgPhong);
                Namecolumn();
                KetnoiDataBase.Chuoiketnoi(sql_datphong, dtgDatPhong);
                Name_colums_datphong();
                load_makh();
                load_nv();
                Clear();
            }
        }

        private void btnHuy1_Click(object sender, EventArgs e)
        {
            string ma_p = txtMaPhong1.Text.Trim();
            if (txtMaHD1.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập id hóa đơn , Vui lòng kiểm tra lại", "Thông báo ", MessageBoxButtons.OK);
                txtMaHD1.Focus();
            }
            else
            {
                string sq2 = "Update Phong set trangthai = N'Trống' where MaPhong = '" + ma_p + "'";
                string sql = "Delete from Hoadon where id_hoadon = N'" + txtMaHD1.Text.Trim() + "'";
                KetnoiDataBase.Xoa(sql);
                HamHoTro.update(sq2);
                KetnoiDataBase.Chuoiketnoi(chuoi, dtgPhongThue);
                Namecolumn();
                KetnoiDataBase.Chuoiketnoi(sql_datphong, dtgPhongThue);
                Name_colums_datphong();
                load_makh();
                load_nv();
                Clear();
            }
        }

        private void Name_colums_thuephong2()
        {
            dtgDatPhong.EnableHeadersVisualStyles = false; //Gets or sets a value indicating whether row and column headers use the visual styles of the user's current theme if visual styles are enabled for the application.
            dtgDatPhong.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue; // gán cột màu header = color

            dtgDatPhong.Columns[0].HeaderText = "Hóa đơn"; dtgDatPhong.Columns[0].Width = 120;
            dtgDatPhong.Columns[1].HeaderText = "Mã phòng"; dtgDatPhong.Columns[1].Width = 120;
            dtgDatPhong.Columns[2].HeaderText = "Mã nhân viên"; dtgDatPhong.Columns[2].Width = 110;
            dtgDatPhong.Columns[3].HeaderText = "Mã khách"; dtgDatPhong.Columns[3].Width = 90;
            dtgDatPhong.Columns[4].HeaderText = "Tên khách hàng"; dtgDatPhong.Columns[4].Width = 260;
            dtgDatPhong.Columns[5].HeaderText = "Ngày sinh"; dtgDatPhong.Columns[5].Width = 140;
            dtgDatPhong.Columns[6].HeaderText = "Đặt cọc"; dtgDatPhong.Columns[6].Width = 140;
            dtgDatPhong.Columns[7].HeaderText = "Ngày đặt phòng"; dtgDatPhong.Columns[7].Width = 150;
            dtgDatPhong.Columns[8].HeaderText = "Ngày nhận phòng"; dtgDatPhong.Columns[8].Width = 140;
            dtgDatPhong.Columns[9].HeaderText = "Số lương người"; dtgDatPhong.Columns[9].Width = 90;
            dtgDatPhong.Columns[10].HeaderText = "Trạng Thái"; dtgDatPhong.Columns[10].Width = 140;
            int sc = dtgDatPhong.Rows.Count;

            index = 0;
            last = sc - 1;


        }

        private void cboMaKH1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = cboMaKH1.SelectedValue.ToString();
            string full_name = "";
            string cot = "Tenkh";
            if (cboMaKH1.SelectedValue.ToString() != "System.Data.DataRowView")
            {

                string id = cboMaKH1.SelectedValue.ToString(); //Select MaKh from Khachhang
                string chuoi4 = "Select Tenkh from Khachhang where MaKh ='" + id.Trim() + "'";
                string tendaydu = HamHoTro.load_one_colums(chuoi4, full_name, cot);
                txtTenKH1.Text = tendaydu;
            }
            else
            {
                string id = "kh01"; //Select MaKh from Khachhang
                string chuoi4 = "Select Tenkh from Khachhang where MaKh ='" + id.Trim() + "'";
                string tendaydu = HamHoTro.load_one_colums(chuoi4, full_name, cot);
                txtTenKH1.Text = tendaydu;
            }
            string cotNg = "Ngaysinh";
            if (cboMaKH1.SelectedValue.ToString() != "System.Data.DataRowView")
            {

                string id = cboMaKH1.SelectedValue.ToString(); //Select MaKh from Khachhang
                string chuoi5 = "Select Ngaysinh from Khachhang where MaKh = '" + id.Trim() + "'";
                DateTime tendayduc = HamHoTro.load_Date(chuoi5, cotNg);
                dateNgaySinh1.Value = tendayduc;
            }
            else
            {
                string id = "kh01"; //Select MaKh from Khachhang
                string chuoi4 = "Select Ngaysinh from Khachhang where MaKh ='" + id.Trim() + "'";
                DateTime tendayduc = HamHoTro.load_Date(chuoi4, cotNg);
                dateNgaySinh1.Value = tendayduc;
            }
        }

        private void cboMaNV1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = cboMaNV1.SelectedValue.ToString();
            string full_name = "";
            string cot = "Tennv";
            if (cboMaNV1.SelectedValue.ToString() != "System.Data.DataRowView")
            {

                string id = cboMaNV1.SelectedValue.ToString(); //Select MaKh from Khachhang
                string chuoi4 = "Select Tennv from Nhanvien where Manv ='" + id.Trim() + "'";
                string tendaydu = HamHoTro.load_one_colums(chuoi4, full_name, cot);
                txtTenNV1.Text = tendaydu;
            }
            else
            {
                string id = "nv01"; //Select MaKh from Khachhang
                string chuoi4 = "Select Tennv from Nhanvien where Manv ='" + id.Trim() + "'";
                string tendaydu = HamHoTro.load_one_colums(chuoi4, full_name, cot); ;
                txtTenNV1.Text = tendaydu;

            }
        }

        private void dtgPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int curow = dtgPhong.CurrentRow.Index;
            txtMaPhong1.Text = dtgPhong.Rows[curow].Cells[0].Value.ToString();
            string trangthai = dtgPhong.Rows[curow].Cells[5].Value.ToString();
            if (String.Compare(trangthai, "Trống", true) != 0)
            {
                btnThem1.Enabled = true;
            }

            else
            {
                btnThem1.Enabled = false;
            }
        }

        private void ultraTabControl1_SelectedTabChanged(object sender, Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs e)
        {
            KetnoiDataBase.Chuoiketnoi(sql_datphong2, dtgDatPhong);
            Name_colums_thuephong2();
            load_makh2();
            load_nv2();
        }
        public void Clear2()
        {
            txtMaHD2.Text = "";
            txtMaHD2.Enabled = false;
            txtMaHD2.Focus();
            cboMaNV2.Text = "";
            cboMaKH2.Text = "";
            txtTenPhong2.Text = "";
            txtMaPhong2.Text = "";

            dateNgayThuePhong2.Value = DateTime.Now;
            dateNgaySinh2.Value = DateTime.Now;
            txtSong2.Value = 0;
            txtTenNV2.Text = "";
            txtTenKH2.Text = "";
            txtDatCoc2.Value = 0;
            txtMaHD2.Focus();
            btnThem2.Enabled = true;
            txtMaHD2.Enabled = true;
            btnSua2.Enabled = false;
            btnHuy2.Enabled = false;

        }

        private void btnHuy2_Click(object sender, EventArgs e)
        {
            string ma_p = txtMaPhong2.Text.Trim();
            if (txtMaHD2.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập id hóa đơn , Vui lòng kiểm tra lại", "Thông báo ", MessageBoxButtons.OK);
                txtMaHD2.Focus();
            }
            else
            {
                string sq2 = "Update Phong set trangthai = N'Trống' where MaPhong = '" + ma_p + "'";
                string sql = "Delete from Hoadon where id_hoadon = N'" + txtMaHD2.Text.Trim() + "'";
                KetnoiDataBase.Xoa(sql);
                HamHoTro.update(sq2);
                KetnoiDataBase.Chuoiketnoi(sql_datphong2, dtgDatPhong);
                Name_colums_thuephong2();
                load_makh2();
                load_nv2();
                Clear2();

            }
        }

        private void dtgDatPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int curow = dtgDatPhong.CurrentRow.Index;
            txtMaHD2.Text = dtgDatPhong.Rows[curow].Cells[0].Value.ToString();
            txtMaPhong2.Text = dtgDatPhong.Rows[curow].Cells[1].Value.ToString();

            cboMaKH2.Text = dtgDatPhong.Rows[curow].Cells[3].Value.ToString();
            txtTenKH2.Text = dtgDatPhong.Rows[curow].Cells[4].Value.ToString();
            cboMaNV2.Text = dtgDatPhong.Rows[curow].Cells[2].Value.ToString();
            dateNgaySinh2.Value = dtgDatPhong.Rows[curow].Cells[5].Value.ToString();
            dateNgayDatPhong.Value = dtgDatPhong.Rows[curow].Cells[7].Value.ToString();
            dateNgayThuePhong2.Value = dtgDatPhong.Rows[curow].Cells[8].Value.ToString();
            txtSong2.Value = Convert.ToInt32(dtgDatPhong.Rows[curow].Cells[9].Value.ToString());
            txtDatCoc2.Value = dtgDatPhong.Rows[curow].Cells[6].Value.ToString();
            string trangthai = dtgDatPhong.Rows[curow].Cells[10].Value.ToString();
            txtMaHD2.Enabled = false;
            if (String.Compare(trangthai, "Đang thuê", true) == 0)
            {
                btnThem2.Enabled = false;
                btnSua2.Enabled = true;
                btnHuy2.Enabled = true;
            }
            else
            {
                btnThem2.Enabled = true;
                btnSua2.Enabled = false;
                btnHuy2.Enabled = true;
            }
        }

        private void txtMaPhong2_TextChanged(object sender, EventArgs e)
        {
            string a = txtMaPhong2.Text.ToString();
            string full_name = "";
            string cot = "TenPhong";
            if (txtMaPhong2.Text != "")
            {

                string id = txtMaPhong2.Text.ToString(); //Select MaKh from Khachhang
                string chuoi4 = "Select TenPhong from Phong where MaPhong ='" + a.Trim() + "'";
                string tendaydu = HamHoTro.load_one_colums(chuoi4, full_name, cot);
                txtTenPhong2.Text = "Phòng: " + tendaydu;
            }
        }

        private void cboMaKH2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = cboMaKH2.SelectedValue.ToString();
            string full_name = "";
            string cot = "Tenkh";
            if (cboMaKH2.SelectedValue.ToString() != "System.Data.DataRowView")
            {

                string id = cboMaKH2.SelectedValue.ToString(); //Select MaKh from Khachhang
                string chuoi4 = "Select Tenkh from Khachhang where MaKh ='" + id.Trim() + "'";
                string tendaydu = HamHoTro.load_one_colums(chuoi4, full_name, cot);
                txtTenKH2.Text = tendaydu;
            }
            else
            {
                string id = "kh01"; //Select MaKh from Khachhang
                string chuoi4 = "Select Tenkh from Khachhang where MaKh ='" + id.Trim() + "'";
                string tendaydu = HamHoTro.load_one_colums(chuoi4, full_name, cot);
                txtTenKH2.Text = tendaydu;
            }

            string cotNg = "Ngaysinh";
            if (cboMaKH2.SelectedValue.ToString() != "System.Data.DataRowView")
            {

                string id = cboMaKH2.SelectedValue.ToString(); //Select MaKh from Khachhang
                string chuoi4 = "Select Ngaysinh from Khachhang where MaKh ='" + id.Trim() + "'";
                DateTime tendayduc = HamHoTro.load_Date(chuoi4, cotNg);
                dateNgaySinh2.Value = tendayduc;
            }
            else
            {
                string id = "kh01"; //Select MaKh from Khachhang
                string chuoi4 = "Select Ngaysinh from Khachhang where MaKh ='" + id.Trim() + "'";
                DateTime tendayduc = HamHoTro.load_Date(chuoi4, cotNg);
                dateNgaySinh2.Value = tendayduc;
            }
        }

        private void cboMaNV2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = cboMaNV2.SelectedValue.ToString();
            string full_name = "";
            string cot = "Tennv";
            if (cboMaNV2.SelectedValue.ToString() != "System.Data.DataRowView")
            {

                string id = cboMaNV2.SelectedValue.ToString(); //Select MaKh from Khachhang
                string chuoi4 = "Select Tennv from Nhanvien where Manv ='" + id.Trim() + "'";
                string tendaydu = HamHoTro.load_one_colums(chuoi4, full_name, cot);
                txtTenNV2.Text = tendaydu;
            }
            else
            {
                string id = "nv01"; //Select MaKh from Khachhang
                string chuoi4 = "Select Tennv from Nhanvien where Manv ='" + id.Trim() + "'";
                string tendaydu = HamHoTro.load_one_colums(chuoi4, full_name, cot); ;
                txtTenNV2.Text = tendaydu;

            }
        }

        private void tab1(object sender, EventArgs e)
        {
            KetnoiDataBase.Chuoiketnoi(chuoi, dtgPhong);

            Namecolumn();
            KetnoiDataBase.Chuoiketnoi(sql_datphong, dtgPhongThue);
            Name_colums_datphong();
            load_makh();
            load_nv();
        }

        private void dtgPhongThue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int curow = dtgPhongThue.CurrentRow.Index;
            txtMaHD1.Text = dtgPhongThue.Rows[curow].Cells[0].Value.ToString();
            txtMaPhong1.Text = dtgPhongThue.Rows[curow].Cells[1].Value.ToString();
            cboMaKH1.Text = dtgPhongThue.Rows[curow].Cells[3].Value.ToString();
            txtTenKH1.Text = dtgPhongThue.Rows[curow].Cells[4].Value.ToString();
            dateNgaySinh1.Value = dtgPhongThue.Rows[curow].Cells[4].Value.ToString();
            cboMaNV1.Text = dtgPhongThue.Rows[curow].Cells[2].Value.ToString();

            dateNgayThuePhong.Value = dtgPhongThue.Rows[curow].Cells[7].Value.ToString();
            txtSong1.Value = Convert.ToInt32(dtgPhongThue.Rows[curow].Cells[8].Value.ToString());

            txtDatCoc1.Value = dtgPhongThue.Rows[curow].Cells[6].Value.ToString();

            string trangthai = dtgPhongThue.Rows[curow].Cells[9].Value.ToString();
            txtMaHD1.Enabled = false;
            if (string.Compare(trangthai, "đang thuê", true) == 0)
            {
                btnThem1.Enabled = false;
                btnSua1.Enabled = true;
                btnHuy1.Enabled = true;
            }
            else
            {
                btnThem1.Enabled = true;
                btnSua1.Enabled = false;
                btnHuy1.Enabled = true;
            }
        }

        private void btnSua2_Click(object sender, EventArgs e)
        {
            string full_name = "";
            string ma_p = txtMaPhong2.Text.Trim();
            string cot = "songtoida";
            string chuoi4 = "Select songtoida from Phong where MaPhong ='" + ma_p.Trim() + "'";
            double songtoida = Convert.ToDouble(HamHoTro.load_one_colums(chuoi4, full_name, cot));
            double songuoi = Convert.ToDouble(txtSong1.Text.Trim());
            string ma_hd = txtMaHD2.Text.Trim();

            string ma_k = cboMaKH2.Text.Trim();
            string ma_nv = cboMaNV2.Text.Trim();
            string ten_nv = txtTenNV2.Text.Trim();
            string ten_kh = txtTenKH2.Text.Trim();
            string ngaydatphong = dateNgayThuePhong2.Value.ToString();
            int song = Convert.ToInt32(txtSong2.Value.ToString());
            // Format string theo ý định
            // loại bỏ chữ trong chuỗi
            Regex digitsOnly = new Regex(@"[^\d]");
            int curow = dtgDatPhong.CurrentRow.Index;
            var numstr = digitsOnly.Replace(txtDatCoc2.Text, "");
            string datcoc = numstr + "";
            if (txtMaHD2.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập ID .Vui lòng kiểm tra lại  ! ", "Thông báo", MessageBoxButtons.OK);

                txtMaHD2.Focus();
            }
            else if (songuoi > songtoida)
            {
                MessageBox.Show("Bạn quá đông người không thể đặt được phòng ! Bạn hãy thuê phòng khác ! ", "Thông báo", MessageBoxButtons.OK);
                txtSong2.Text = "";
                txtSong2.Focus();
            }
            else
            {
                //Hoadon (id_hoadon,MaPhong,Makh,Manv,Ngaydatphong,Ngaynhanphong,Ngaytraphong,soluongnguoi,phiphong,phiphuthu,thanhtien,trangthai)
                //id_hoadon,MaPhong,Makh,Manv,Ngaydatphong,soluongnguoi,trangthai
                string sql = "Update Hoadon set MaPhong = N'" + ma_p + "',Manv = '" + ma_nv + "',TenNV = N'" + ten_nv + "',Makh = '" + ma_k + "',TenKH = N'" + ten_kh + "',Ngaysinh ='" + Convert.ToDateTime(dateNgaySinh2.Value).ToString("yyyy-MM-dd") + "',Ngaydatphong ='" + Convert.ToDateTime(dateNgayDatPhong.Value).ToString("yyyy-MM-dd") + "',Datcoc = '" + Convert.ToInt32(datcoc) + "',Ngaynhanphong ='" + Convert.ToDateTime(dateNgayThuePhong2.Value).ToString("yyyy-MM-dd") + "',Ngaytraphong='" + Convert.ToDateTime(dateNgayThuePhong2.Value).ToString("yyyy-MM-dd") + "',soluongnguoi='" + Convert.ToInt32(song) + "' where id_hoadon = '" + ma_hd + "'";
                KetnoiDataBase.Sua(sql);
                string sq2 = "Update Phong set trangthai = N'Đang Thuê' where MaPhong = '" + ma_p + "'";
                string sq3 = "Update Phong set trangthai = N'Trống' where MaPhong = '" + id_phong_old + "'";
                if (String.Compare(id_phong_old, ma_p, true) != 0)
                {
                    HamHoTro.update(sq2);
                    HamHoTro.update(sq3);
                }
                else
                {
                    HamHoTro.update(sq2);
                }

                KetnoiDataBase.Chuoiketnoi(sql_datphong2, dtgDatPhong);
                Name_colums_thuephong2();
                load_makh2();
                load_nv2();
                Clear2();

            }
        }

        private void btnThem2_Click(object sender, EventArgs e)
        {
            if (txtMaPhong2.Text == "" || cboMaNV2.Text == "" || cboMaKH2.Text == "" || txtSong2.Text == "" || txtDatCoc2.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin ! ", "Thông báo ", MessageBoxButtons.OK);
                txtMaHD2.Focus();

            }
            else
            {
                string full_name = "";
                string ma_p = txtMaPhong2.Text.Trim();
                string cot = "songtoida";
                string chuoi4 = "Select songtoida from Phong where MaPhong ='" + ma_p.Trim() + "'";
                double songtoida = Convert.ToDouble(HamHoTro.load_one_colums(chuoi4, full_name, cot));
                double songuoi = Convert.ToDouble(txtSong2.Text.Trim());
                string ma_hd = txtMaHD2.Text.Trim();
                string datcoc = txtDatCoc2.Value.ToString().Trim();
                string ma_k = cboMaKH2.Text.Trim();
                string ma_nv = cboMaNV2.Text.Trim();
                string ten_kh = txtTenKH2.Text;
                string ngaythuephong = dateNgayThuePhong2.Value.ToString();

                string ten_nv = txtTenNV2.Text.Trim();
                string song = txtSong2.Value.ToString().Trim();
                if (songuoi > songtoida)
                {
                    MessageBox.Show("Bạn quá đông người không thể đặt được phòng ! Bạn hãy thuê phòng khác ! ", "Thông báo", MessageBoxButtons.OK);
                    txtSong2.Value = 0;
                    txtSong2.Focus();
                }
                else
                {
                    //Hoadon (id_hoadon,MaPhong,Makh,Manv,Ngaydatphong,Ngaynhanphong,Ngaytraphong,soluongnguoi,phiphong,phiphuthu,thanhtien,trangthai)
                    string sql = "Select count(*) from Hoadon where id_hoadon ='" + txtMaHD2.Text.Trim() + "'";
                    string sql1 = "Update Hoadon set trangthai = N'Đang thuê', Ngaynhanphong='" + Convert.ToDateTime(dateNgayThuePhong.Value).ToString("yyyy-MM-dd") + "' where id_hoadon = '" + ma_hd.Trim() + "' ";
                    string sq2 = "Update Phong set trangthai = N'Đang thuê' where MaPhong = '" + ma_p + "'";
                    HamHoTro.update(sq2);
                    HamHoTro.update(sql1);
                    MessageBox.Show("Bạn thuê phòng thành công ! ", "Thông báo", MessageBoxButtons.OK);
                    // chuoiketnoi.them(sql, sql1, dtgDatPhong);

                    KetnoiDataBase.Chuoiketnoi(sql_datphong2, dtgDatPhong);
                    Name_colums_thuephong2();
                    load_makh2();
                    load_nv2();
                    Clear2();

                }
            }
        }
        private void PopulateData(int curow)
        {


            txtMaHD2.Text = dtgDatPhong.Rows[curow].Cells[0].Value.ToString();
            txtMaPhong2.Text = dtgDatPhong.Rows[curow].Cells[1].Value.ToString();

            cboMaKH2.Text = dtgDatPhong.Rows[curow].Cells[3].Value.ToString();
            txtTenKH2.Text = dtgDatPhong.Rows[curow].Cells[4].Value.ToString();
            cboMaNV2.Text = dtgDatPhong.Rows[curow].Cells[2].Value.ToString();
            dateNgaySinh2.Value = dtgDatPhong.Rows[curow].Cells[5].Value.ToString();
            dateNgayDatPhong.Value = dtgDatPhong.Rows[curow].Cells[7].Value.ToString();
            dateNgayThuePhong2.Value = dtgDatPhong.Rows[curow].Cells[8].Value.ToString();
            txtSong2.Value = Convert.ToInt32(dtgDatPhong.Rows[curow].Cells[9].Value.ToString());
            txtDatCoc2.Value = dtgDatPhong.Rows[curow].Cells[6].Value.ToString();
            id_phong_old = txtMaPhong2.Text;
            btnThem2.Enabled = false;
            txtMaHD2.Enabled = false;
            btnHuy2.Enabled = true;
            btnSua2.Enabled = true;


        }

        private void btnTruoc2_Click(object sender, EventArgs e)
        {
            index--;
            index = index < 0 ? 0 : index;
            PopulateData(index);
            dtgDatPhong.CurrentCell = dtgDatPhong.Rows[index].Cells[0];
        }

        private void btnSau2_Click(object sender, EventArgs e)
        {
            index = index + 1;
            if (index >= last)
            {
                index = 0;

                PopulateData(index);
                dtgDatPhong.CurrentCell = dtgDatPhong.Rows[index].Cells[0];
            }
            else
            {
                PopulateData(index);
                dtgDatPhong.CurrentCell = dtgDatPhong.Rows[index].Cells[0];
            }
        }

        private void btnDau2_Click(object sender, EventArgs e)
        {
            index = 0;
            PopulateData(index);
            dtgDatPhong.CurrentCell = dtgDatPhong.Rows[index].Cells[0];
        }

        private void btnCuoi2_Click(object sender, EventArgs e)
        {
            index = last - 1;
            PopulateData(index);
            dtgDatPhong.CurrentCell = dtgDatPhong.Rows[index].Cells[0];
        }
        private void btnReset1_Click(object sender, EventArgs e)
        {
            Clear();
            txtMaHD1.Enabled = false;
            btnThem1.Enabled = true;
        }

        private void txt_search2_TextChanged(object sender, EventArgs e)
        {
            string tukhoa = txt_search2.Text;
            String chuoi1 = "";
            if (String.Compare(cboLuaChon2.Text, "Mã phòng", true) == 0 || cboLuaChon2.SelectedItem == null)
            {
                chuoi1 = "Select id_hoadon,MaPhong,Manv,Makh,TenKH,Ngaysinh,Datcoc,Ngaydatphong,Ngaynhanphong,soluongnguoi,trangthai from Hoadon Where (  trangthai = N'Đang thuê' or trangthai = N'Đã đặt' ) AND MaPhong like N'%" + tukhoa + "%'";
            }
            else if (String.Compare(cboLuaChon2.Text, "Mã khách", true) == 0)
            {
                chuoi1 = "Select id_hoadon,MaPhong,Manv,Makh,TenKH,Ngaysinh,Datcoc,Ngaydatphong,Ngaynhanphong,soluongnguoi,trangthai from Hoadon Where (  trangthai = N'Đang thuê' or trangthai = N'Đã đặt' ) AND Makh like N'%" + tukhoa + "%'";
            }
            else if (String.Compare(cboLuaChon2.Text, "Trạng thái", true) == 0)
            {
                chuoi1 = "Select id_hoadon,MaPhong,Manv,Makh,TenKH,Ngaysinh,Datcoc,Ngaydatphong,Ngaynhanphong,soluongnguoi,trangthai from Hoadon Where (  trangthai = N'Đang thuê' or trangthai = N'Đã đặt' ) AND  trangthai like N'%" + tukhoa + "%'";
            }
            else
            {
                chuoi1 = "Select id_hoadon,MaPhong,Manv,Makh,TenKH,Ngaysinh,Datcoc,Ngaydatphong,Ngaynhanphong,soluongnguoi,trangthai from Hoadon where trangthai = N'Đã đặt' or trangthai = N'Đang thuê' ";
            }
            KetnoiDataBase.timkiem(chuoi1, dtgDatPhong);
            Name_colums_datphong();

        }

        private void ultraGroupBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clear();
            txtMaHD1.Enabled = false;

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string tukhoa = txt_search.Text;
            String chuoi1 = "";
            if (String.Compare(cboLuaChon.Text, "Mã phòng", true) == 0 || cboLuaChon.SelectedItem == null)
            {
                chuoi1 = "SELECT p.MaPhong,p.TenPhong,l.loaiphong,p.mota,p.songtoida,l.giaphong,p.trangthai FROM dbo.Phong p LEFT JOIN dbo.LPhong l ON l.loaiphong = p.loaiphong where p.MaPhong like  N'%" + tukhoa + "%'";
            }
            else if (String.Compare(cboLuaChon.Text, "Tên phòng", true) == 0)
            {
                chuoi1 = "SELECT p.MaPhong,p.TenPhong,l.loaiphong,p.mota,p.songtoida,l.giaphong,p.trangthai FROM dbo.Phong p LEFT JOIN dbo.LPhong l ON l.loaiphong = p.loaiphong where TenPhong like N'%" + tukhoa + "%'";
            }
            else if (String.Compare(cboLuaChon.Text, "Loại phòng", true) == 0)
            {
                chuoi1 = "SELECT p.MaPhong,p.TenPhong,l.loaiphong,p.mota,p.songtoida,l.giaphong,p.trangthai FROM dbo.Phong p LEFT JOIN dbo.LPhong l ON l.loaiphong = p.loaiphong where l.loaiphong like N'%" + tukhoa + "%'";
            }
            else if (String.Compare(cboLuaChon.Text, "Mô tả phòng", true) == 0)
            {
                chuoi1 = "SELECT p.MaPhong,p.TenPhong,l.loaiphong,p.mota,p.songtoida,l.giaphong,p.trangthai FROM dbo.Phong p LEFT JOIN dbo.LPhong l ON l.loaiphong = p.loaiphong where p.Mota like N'%" + tukhoa + "%'";
            }
            else if (String.Compare(cboLuaChon.Text, "Số người tối đa", true) == 0)
            {
                chuoi1 = "SELECT p.MaPhong,p.TenPhong,l.loaiphong,p.mota,p.songtoida,l.giaphong,p.trangthai FROM dbo.Phong p LEFT JOIN dbo.LPhong l ON l.loaiphong = p.loaiphong where p.songtoida like N'%" + tukhoa + "%'";
            }
            else if (String.Compare(cboLuaChon.Text, "Giá phòng", true) == 0)
            {
                chuoi1 = "SELECT  dbo.Phong.MaPhong,dbo.Phong.loaiphong,dbo.Phong.TenPhong,dbo.Phong.Mota,dbo.Phong.songtoida, dbo.LPhong.giaphong,dbo.Phong.trangthai  FROM dbo.Phong , dbo.LPhong WHERE dbo.Phong.loaiphong = dbo.LPhong.loaiphong AND giaphong like N'%" + tukhoa + "%'";
            }
            else
            {
                chuoi1 = "SELECT p.MaPhong,p.TenPhong,l.loaiphong,p.mota,p.songtoida,l.giaphong,p.trangthai FROM dbo.Phong p LEFT JOIN dbo.LPhong l ON l.loaiphong = p.loaiphong where p.trangthai like N'%" + tukhoa + "%'";
            }
            KetnoiDataBase.timkiem(chuoi1, dtgPhong);
            Namecolumn();
        }

        private void txtDatCoc1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
