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
    public partial class frmDatPhong : Form
    {
        public string chuoi = "Select MaPhong,TenPhong,Phong.loaiphong,Phong.Mota,songtoida,dbo.LPhong.giaphong ,trangthai  from phong,Lphong where phong.Loaiphong = Lphong.Loaiphong AND trangthai = N'Trống'";
        public string sql_datphong = "Select id_hoadon,MaPhong,Makh,Manv,TenKH,Ngaysinh,Datcoc,Ngaydatphong,soluongnguoi,trangthai from  Hoadon where trangthai = N'Đã đặt' ";
        public string phiphong = "0";
        public string phuthu = "0";
        public string thanhtien = "0";
        string id_phong_old = "";
        public string trangthai = "Đã đặt";
        int index = 0;
        int last = 0;

        public frmDatPhong()
        {
            InitializeComponent();
            KetnoiDataBase.Chuoiketnoi(chuoi, dtgPhong);
            AddCombox();
            txtHoadon.Enabled = false;
            btnSua.Enabled = false;
            btnHuy.Enabled = false;
            txtTongsoPD.Enabled = false;
            txtHoadon.Focus();
            Namecolumn();
            KetnoiDataBase.Chuoiketnoi(sql_datphong, dtgDatPhong);
            Name_colums_datphong();
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


        private void Namecolumn()
        {
            dtgPhong.EnableHeadersVisualStyles = false; //Gets or sets a value indicating whether row and column headers use the visual styles of the user's current theme if visual styles are enabled for the application.
            dtgPhong.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue; // gán cột màu header = color
            int sc = dtgPhong.Rows.Count;
            dtgPhong.Columns[0].HeaderText = "Mã phòng"; dtgPhong.Columns[0].Width = 100;
            dtgPhong.Columns[1].HeaderText = "Tên phòng"; dtgPhong.Columns[1].Width = 200;
            dtgPhong.Columns[2].HeaderText = "Loại phòng"; dtgPhong.Columns[2].Width = 150;
            dtgPhong.Columns[3].HeaderText = "Mô tả"; dtgPhong.Columns[3].Width = 550;
            dtgPhong.Columns[4].HeaderText = "Số ng tối đa"; dtgPhong.Columns[4].Width = 150;
            dtgPhong.Columns[5].HeaderText = "Giá phòng"; dtgPhong.Columns[5].Width = 200;
            dtgPhong.Columns[6].HeaderText = "Trạng Thái"; dtgPhong.Columns[6].Width = 150 ;

        }
        private void Name_colums_datphong()
        {
            dtgDatPhong.EnableHeadersVisualStyles = false; //Gets or sets a value indicating whether row and column headers use the visual styles of the user's current theme if visual styles are enabled for the application.
            dtgDatPhong.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue; // gán cột màu header = color

            dtgDatPhong.Columns[0].HeaderText = "Hóa đơn"; dtgDatPhong.Columns[0].Width = 120;
            dtgDatPhong.Columns[1].HeaderText = "Mã phòng"; dtgDatPhong.Columns[1].Width = 120;
            dtgDatPhong.Columns[2].HeaderText = "Mã khách"; dtgDatPhong.Columns[2].Width = 150;
            dtgDatPhong.Columns[3].HeaderText = "Mã nhân viên"; dtgDatPhong.Columns[3].Width = 150;
            dtgDatPhong.Columns[4].HeaderText = "Tên KH"; dtgDatPhong.Columns[4].Width = 220;
            dtgDatPhong.Columns[5].HeaderText = "Ngày sinh"; dtgDatPhong.Columns[5].Width = 192;
            dtgDatPhong.Columns[6].HeaderText = "Đặt cọc"; dtgDatPhong.Columns[6].Width = 150;
            dtgDatPhong.Columns[7].HeaderText = "Ngày đặt phòng"; dtgDatPhong.Columns[7].Width = 150;
            dtgDatPhong.Columns[8].HeaderText = "Số lương người"; dtgDatPhong.Columns[8].Width = 100;
            dtgDatPhong.Columns[9].HeaderText = "Trạng Thái"; dtgDatPhong.Columns[9].Width = 150;
            int sc = dtgDatPhong.Rows.Count;
            index = 0;
            last = sc - 1;
            txtTongsoPD.Text = (sc - 1) + "";




        }
        private void load_makh()
        {

            string load_makhach = "select MaKH from khachhang";
            KetnoiDataBase.xulycbx(load_makhach, cboMaKH);
            cboMaKH.DisplayMember = "MaKH";
            cboMaKH.ValueMember = "MaKH";

        }
        private void load_nv()
        {

            string load_nhanvien = "Select MaNV from Nhanvien";
            KetnoiDataBase.xulycbx(load_nhanvien, cboMaNV);
            cboMaNV.DisplayMember = "MaNV";
            cboMaNV.ValueMember = "MaNV";

        }
        public void Clear()
        {

            txtHoadon.Text = "";
            txtHoadon.Enabled = false;
            cboMaNV.Text = "";
            cboMaKH.Text = "";
            txtTenPhong.Text = "";
            txtMaPhong.Text = "";

            dateNgayDatPhong.Value = DateTime.Now;
            dateNgaySinh.Value = DateTime.Now;
            txtTenNV.Text = "";
            txtKhachHang.Text = "";
            txtDatcoc.Value = 0;
            txtSoNg.Value = 0;
            btnThem.Enabled = true;
            txtHoadon.Enabled = true;
            btnSua.Enabled = false;
            btnHuy.Enabled = false;
            txtTongsoPD.Enabled = false;


        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaPhong.Text == "" || cboMaNV.Text == "" || cboMaKH.Text == "" || txtSoNg.Text == "" || txtDatcoc.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin ! ", "Thông báo ", MessageBoxButtons.OK);


            }
            else
            {
                string full_name = "";
                string ma_p = txtMaPhong.Text.Trim();
                string cot = "songtoida";
                string chuoi4 = "Select songtoida from Phong where MaPhong ='" + ma_p.Trim() + "'";
                double songtoida = Convert.ToDouble(HamHoTro.load_one_colums(chuoi4, full_name, cot));
                double songuoi = Convert.ToDouble(txtSoNg.Text.Trim());
                string ma_hd = txtHoadon.Text.Trim();
                string datcoc = txtDatcoc.Value.ToString();
                string ma_k = cboMaKH.Text.Trim();
                string ma_nv = cboMaNV.Text.Trim();
                string ten_kh = txtKhachHang.Text;
                string ngaydatphong = dateNgayDatPhong.Value.ToString();
                Regex digitsOnly = new Regex(@"[^\d]");
                string ten_nv = txtTenNV.Text.Trim();
                string song = txtSoNg.Value.ToString();
                if (songuoi > songtoida)
                {
                    MessageBox.Show("Bạn quá đông người không thể đặt được phòng ! Bạn hãy thuê phòng khác ! ", "Thông báo", MessageBoxButtons.OK);
                    txtSoNg.Text = "";
                    txtSoNg.Focus();
                }
                else
                {
                    int count = 0;
                    count = dtgPhong.Rows.Count;//Dem tat ca cac dong roi gan cho count
                    string chuoi01 = "";
                    int chuoi2 = 0;

                    string query = "SELECT TOP 1 id_hoadon FROM dbo.Hoadon ORDER BY id_hoadon DESC";

                    string codesHD = KetnoiDataBase.ketnoi<string>(query) ?? "1";
                    var numstr = digitsOnly.Replace(codesHD, "");
                    var rsNum = Int32.Parse(numstr) + 1;
                    txtHoadon.Text = "HD" + rsNum.ToString("D4");
                    string sql = "Select count(*) from Hoadon where id_hoadon ='" + txtHoadon.Text.Trim() + "'";
                    string sql1 = "Insert into Hoadon values (N'" + txtHoadon.Text.Trim() + "','" + ma_p + "','" + ma_nv + "',N'" + ten_nv + "','" + ma_k + "',N'" + ten_kh + "','" + Convert.ToDateTime(dateNgaySinh.Value).ToString("yyyy-MM-dd") + "','" + Convert.ToDateTime(dateNgayDatPhong.Value).ToString("yyyy-MM-dd") + "','" + Convert.ToInt32(datcoc) + "','" + Convert.ToDateTime(dateNgayDatPhong.Value).ToString("yyyy-MM-dd") + "','" + Convert.ToDateTime(dateNgayDatPhong.Value).ToString("yyyy-MM-dd") + "','" + song + "','" + phiphong + "','" + phuthu + "','" + thanhtien + "',N'" + trangthai + "')";
                    string sq2 = "Update Phong set trangthai = N'Đã đặt' where MaPhong = '" + ma_p + "'";
                    KetnoiDataBase.update(sq2);

                    KetnoiDataBase.them(sql, sql1, dtgDatPhong);
                    KetnoiDataBase.Chuoiketnoi(chuoi, dtgPhong);
                    Namecolumn();
                    KetnoiDataBase.Chuoiketnoi(sql_datphong, dtgDatPhong);
                    Name_colums_datphong();

                    load_makh();
                    load_nv();
                    Clear();
                    txtHoadon.Enabled = false;


                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string full_name = "";
            string ma_p = txtMaPhong.Text.Trim();
            string cot = "songtoida";
            string chuoi4 = "Select songtoida from Phong where MaPhong ='" + ma_p.Trim() + "'";
            double songtoida = Convert.ToDouble(HamHoTro.load_one_colums(chuoi4, full_name, cot));
            double songuoi = Convert.ToDouble(txtSoNg.Text.Trim());
            string ma_hd = txtHoadon.Text.Trim();

            string ma_k = cboMaKH.Text.Trim();
            string ma_nv = cboMaNV.Text.Trim();
            string ten_nv = txtTenNV.Text.Trim();
            string ten_kh = txtKhachHang.Text.Trim();
            string ngaydatphong = dateNgayDatPhong.Value.ToString();
            string song = txtSoNg.Value.ToString();
            string a = txtDatcoc.Value.ToString();

            // Format string theo ý định
            // loại bỏ chữ trong chuỗi
            Regex digitsOnly = new Regex(@"[^\d]");
            int curow = dtgDatPhong.CurrentRow.Index;
            var numstr = digitsOnly.Replace(txtDatcoc.Text, "");
            string datcoc = numstr + "";
            if (txtHoadon.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập ID .Vui lòng kiểm tra lại  ! ", "Thông báo", MessageBoxButtons.OK);

                txtHoadon.Focus();
            }
            else if (songuoi > songtoida)
            {
                MessageBox.Show("Bạn quá đông người không thể đặt được phòng ! Bạn hãy thuê phòng khác ! ", "Thông báo", MessageBoxButtons.OK);
                txtSoNg.Text = "";
                txtSoNg.Focus();
            }
            else
            {

                string sql = "Update Hoadon set MaPhong = N'" + ma_p + "',Manv = '" + ma_nv + "',TenNV = N'" + ten_nv + "',Makh = '" + ma_k + "',TenKH = N'" + ten_kh + "',Ngaysinh ='" + Convert.ToDateTime(dateNgaySinh.Value).ToString("yyyy-MM-dd") + "',Ngaydatphong ='" + Convert.ToDateTime(dateNgayDatPhong.Value).ToString("yyyy-MM-dd") + "',Datcoc = '" + Convert.ToInt32(datcoc) + "',Ngaynhanphong ='" + Convert.ToDateTime(dateNgayDatPhong.Value).ToString("yyyy-MM-dd") + "',Ngaytraphong='" + Convert.ToDateTime(dateNgayDatPhong.Value).ToString("yyyy-MM-dd") + "',soluongnguoi='" + song + "' where id_hoadon = '" + ma_hd + "'";
                KetnoiDataBase.Sua(sql);
                string sq2 = "Update Phong set trangthai = N'Đã đặt' where MaPhong = '" + ma_p + "'";
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
                txtHoadon.Enabled = false;
            }
        }

        private void dtgDatPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int curow = dtgDatPhong.CurrentRow.Index;
            txtHoadon.Text = dtgDatPhong.Rows[curow].Cells[0].Value.ToString();
            txtMaPhong.Text = dtgDatPhong.Rows[curow].Cells[1].Value.ToString();


            cboMaKH.Text = dtgDatPhong.Rows[curow].Cells[2].Value.ToString();
            cboMaNV.Text = dtgDatPhong.Rows[curow].Cells[3].Value.ToString();
            dateNgayDatPhong.Value = dtgDatPhong.Rows[curow].Cells[7].Value.ToString();
            txtSoNg.Value = Convert.ToInt32(dtgDatPhong.Rows[curow].Cells[8].Value.ToString());
            txtDatcoc.Value = dtgDatPhong.Rows[curow].Cells[6].Value.ToString();
            id_phong_old = txtMaPhong.Text;
            txtHoadon.Enabled = false;
            txtHoadon.Focus();
            btnThem.Enabled = false;
            txtHoadon.Enabled = false;
            btnHuy.Enabled = true;
            btnSua.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chăn muốn thoát không ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clear();
            txtHoadon.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            string ma_p = txtMaPhong.Text.Trim();
            if (txtHoadon.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập id hóa đơn , Vui lòng kiểm tra lại", "Thông báo ", MessageBoxButtons.OK);
                txtHoadon.Focus();
            }
            else
            {
                string sql = "Delete from Hoadon where id_hoadon = N'" + txtHoadon.Text.Trim() + "'";
                string sq2 = "Update Phong set trangthai = N'Trống' where MaPhong = '" + ma_p + "'";

                KetnoiDataBase.Xoa(sql);
                KetnoiDataBase.update(sq2);
                KetnoiDataBase.Chuoiketnoi(chuoi, dtgPhong);
                Namecolumn();
                KetnoiDataBase.Chuoiketnoi(sql_datphong, dtgDatPhong);
                Name_colums_datphong();
                load_makh();
                load_nv();
                Clear();
            }
        }

        private void dtgPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int curow = dtgPhong.CurrentRow.Index;
            txtMaPhong.Text = dtgPhong.Rows[curow].Cells[0].Value.ToString();
            string trangthai = dtgPhong.Rows[curow].Cells[5].Value.ToString();
            if (String.Compare(trangthai, "Trống", true) != 0)
            {
                btnThem.Enabled = true;
            }

            else
            {
                btnThem.Enabled = false;
            }
        }

       
        

        
        private void PopulateData(int curow)
        {


            txtHoadon.Text = dtgDatPhong.Rows[curow].Cells[0].Value.ToString();
            txtMaPhong.Text = dtgDatPhong.Rows[curow].Cells[1].Value.ToString();


            cboMaKH.Text = dtgDatPhong.Rows[curow].Cells[2].Value.ToString();
            cboMaNV.Text = dtgDatPhong.Rows[curow].Cells[3].Value.ToString();
            dateNgayDatPhong.Value = dtgDatPhong.Rows[curow].Cells[7].Value.ToString();
            txtSoNg.Value = Convert.ToInt32(dtgDatPhong.Rows[curow].Cells[8].Value.ToString());
            txtDatcoc.Value = dtgDatPhong.Rows[curow].Cells[6].Value.ToString();

            id_phong_old = txtMaPhong.Text;
            btnThem.Enabled = false;
            txtHoadon.Enabled = false;
            btnHuy.Enabled = true;
            btnSua.Enabled = true;
            txtHoadon.Enabled = false;

        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            index--;
            index = index < 0 ? 0 : index;
            PopulateData(index);
            dtgDatPhong.CurrentCell = dtgDatPhong.Rows[index].Cells[0];
        }

        private void btnSau_Click(object sender, EventArgs e)
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

        private void btnDau_Click(object sender, EventArgs e)
        {
            index = 0;
            PopulateData(index);
            dtgDatPhong.CurrentCell = dtgDatPhong.Rows[index].Cells[0];
        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            index = last - 1;
            PopulateData(index);
            dtgDatPhong.CurrentCell = dtgDatPhong.Rows[index].Cells[0];
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

        private void btnThem_Click_1(object sender, EventArgs e)
        {

        }

        private void txtMaPhong_TextChanged_1(object sender, EventArgs e)
        {
            string a = txtMaPhong.Text.ToString();
            string full_name = "";
            string cot = "TenPhong";
            if (txtMaPhong.Text != "")
            {

                string id = txtMaPhong.Text.ToString(); //Select MaKh from Khachhang
                string chuoi4 = "Select TenPhong from Phong where MaPhong ='" + a.Trim() + "'";
                string tendaydu = HamHoTro.load_one_colums(chuoi4, full_name, cot);
                txtTenPhong.Text = "Phòng: " + tendaydu;
            }

        }

        private void cboMaKH_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string a = cboMaKH.SelectedValue.ToString();
            string full_name = "";
            string cot = "Tenkh";
            if (cboMaKH.SelectedValue.ToString() != "System.Data.DataRowView")
            {

                string id = cboMaKH.SelectedValue.ToString(); //Select MaKh from Khachhang
                string chuoi4 = "Select Tenkh from Khachhang where MaKh ='" + id.Trim() + "'";
                string tendaydu = HamHoTro.load_one_colums(chuoi4, full_name, cot);
                txtKhachHang.Text = tendaydu;
            }
            else
            {
                string id = "kh01"; //Select MaKh from Khachhang
                string chuoi4 = "Select Tenkh from Khachhang where MaKh ='" + id.Trim() + "'";
                string tendaydu = HamHoTro.load_one_colums(chuoi4, full_name, cot);
                txtKhachHang.Text = tendaydu;
            }

            string cotNg = "Ngaysinh";
            if (cboMaKH.SelectedValue.ToString() != "System.Data.DataRowView")
            {

                string id = cboMaKH.SelectedValue.ToString(); //Select MaKh from Khachhang
                string chuoi4 = "Select Ngaysinh from Khachhang where MaKh ='" + id.Trim() + "'";
                DateTime tendayduc = HamHoTro.load_Date(chuoi4, cotNg);
                dateNgaySinh.Value = tendayduc;
            }
            else
            {
                string id = "kh01"; //Select MaKh from Khachhang
                string chuoi4 = "Select Ngaysinh from Khachhang where MaKh ='" + id.Trim() + "'";
                DateTime tendayduc = HamHoTro.load_Date(chuoi4, cotNg);
                dateNgaySinh.Value = tendayduc;
            }
        }

        private void cboMaNV_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string a = cboMaNV.SelectedValue.ToString();
            string full_name = "";
            string cot = "Tennv";
            if (cboMaNV.SelectedValue.ToString() != "System.Data.DataRowView")
            {

                string id = cboMaNV.SelectedValue.ToString(); //Select MaKh from Khachhang
                string chuoi4 = "Select Tennv from Nhanvien where Manv ='" + id.Trim() + "'";
                string tendaydu = HamHoTro.load_one_colums(chuoi4, full_name, cot);
                txtTenNV.Text = tendaydu;
            }
            else
            {
                string id = "nv01"; //Select MaKh from Khachhang
                string chuoi4 = "Select Tennv from Nhanvien where Manv ='" + id.Trim() + "'";
                string tendaydu = HamHoTro.load_one_colums(chuoi4, full_name, cot); ;
                txtTenNV.Text = tendaydu;

            }
        }
    }
}
