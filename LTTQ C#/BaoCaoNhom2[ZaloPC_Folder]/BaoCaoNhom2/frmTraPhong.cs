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

namespace BaoCaoNhom2
{
    public partial class frmTraPhong : Form
    {
        public string sql_traphong = "Select * from Hoadon  where trangthai = N'Đang thuê' or trangthai = N'Đã thanh toán'";
        public double phiphong = 1;
        public double song = 0;
        public string phuthu = "0";
        public string thanhtien = "0";
        public double tien_phuthu = 0;

        // string id_phong_old = "";
        public string trangthai = "Đã đặt";
        public string trangthai1 = "";
        int index = 0;
        int last = 0;
        public frmTraPhong()
        {
            InitializeComponent();
            KetnoiDataBase.Chuoiketnoi(sql_traphong, dtgTTPhongThue);
            Namecolumn();
            btnXuat.Enabled = false;
            txtTongTien.Enabled = false;
            txtPhiPhuThu.Value = 0;
        }
        private void Namecolumn()
        {
            //id_hoadon,MaPhong,Makh,Manv,Ngaydatphong,Ngaynhanphong,Ngaytraphong,soluongnguoi,phiphong,phiphuthu,thanhtien,trangthai
            dtgTTPhongThue.EnableHeadersVisualStyles = false; //Gets or sets a value indicating whether row and column headers use the visual styles of the user's current theme if visual styles are enabled for the application.
            dtgTTPhongThue.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue; // gán cột màu header = color

            dtgTTPhongThue.Columns[0].HeaderText = "Hóa đơn"; dtgTTPhongThue.Columns[0].Width = 130;
            dtgTTPhongThue.Columns[1].HeaderText = "Mã phòng"; dtgTTPhongThue.Columns[1].Width = 130;
            dtgTTPhongThue.Columns[2].HeaderText = "Mã nhân viên"; dtgTTPhongThue.Columns[2].Width = 120;
            dtgTTPhongThue.Columns[3].HeaderText = "Tên nhân viên"; dtgTTPhongThue.Columns[3].Width = 240;
            dtgTTPhongThue.Columns[4].HeaderText = "Mã khách "; dtgTTPhongThue.Columns[4].Width = 120;
            dtgTTPhongThue.Columns[5].HeaderText = "Tên khách"; dtgTTPhongThue.Columns[5].Width = 230;
            dtgTTPhongThue.Columns[6].HeaderText = "Ngày sinh"; dtgTTPhongThue.Columns[6].Width = 150;
            dtgTTPhongThue.Columns[7].HeaderText = "Ngày đặt "; dtgTTPhongThue.Columns[7].Width = 150;
            dtgTTPhongThue.Columns[8].HeaderText = "Đặt cọc"; dtgTTPhongThue.Columns[8].Width = 130;
            dtgTTPhongThue.Columns[9].HeaderText = "Ngày nhận "; dtgTTPhongThue.Columns[9].Width = 150;
            dtgTTPhongThue.Columns[10].HeaderText = "Ngày trả "; dtgTTPhongThue.Columns[10].Width = 150;
            dtgTTPhongThue.Columns[11].HeaderText = "Số người"; dtgTTPhongThue.Columns[11].Width = 70;
            dtgTTPhongThue.Columns[12].HeaderText = "Phí phòng"; dtgTTPhongThue.Columns[12].Width = 140;
            dtgTTPhongThue.Columns[13].HeaderText = "Phí phị thu"; dtgTTPhongThue.Columns[13].Width = 150;
            dtgTTPhongThue.Columns[14].HeaderText = "Thành tiền"; dtgTTPhongThue.Columns[14].Width = 180;
            dtgTTPhongThue.Columns[15].HeaderText = "Trạng thái"; dtgTTPhongThue.Columns[15].Width = 200;
            int sc = dtgTTPhongThue.Rows.Count;
            index = 0;
            last = sc - 1;

        }

        private void dtgTTPhongThue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string name = "";
            int curow = dtgTTPhongThue.CurrentRow.Index;
            txtHoadon.Text = dtgTTPhongThue.Rows[curow].Cells[0].Value.ToString();
            txtMaPhong.Text = dtgTTPhongThue.Rows[curow].Cells[1].Value.ToString();

            cboMaNV.Text = dtgTTPhongThue.Rows[curow].Cells[2].Value.ToString();
            txtTenNV.Text = dtgTTPhongThue.Rows[curow].Cells[3].Value.ToString();
            cboMaKH.Text = dtgTTPhongThue.Rows[curow].Cells[4].Value.ToString();
            txtKhachHang.Text = dtgTTPhongThue.Rows[curow].Cells[5].Value.ToString();

            dateNgaySinh.Value = dtgTTPhongThue.Rows[curow].Cells[6].Value.ToString();
            txtSoNg.Value = Convert.ToInt32(dtgTTPhongThue.Rows[curow].Cells[11].Value.ToString());
            txtDatcoc.Text = dtgTTPhongThue.Rows[curow].Cells[8].Value.ToString();
            dateNgayDatPhong.Value = dtgTTPhongThue.Rows[curow].Cells[7].Value.ToString();
            dateNgayNhan.Value = dtgTTPhongThue.Rows[curow].Cells[9].Value.ToString();
            dateNgaytra.Value = dtgTTPhongThue.Rows[curow].Cells[10].Value.ToString();
            trangthai1 = dtgTTPhongThue.Rows[curow].Cells[15].Value.ToString();
            if (String.Compare(trangthai1, "Đã thanh toán", true) == 0)
            {
                btnTra.Enabled = false;
                btnXuat.Enabled = true;
                txtPhiPhong.Value = dtgTTPhongThue.Rows[curow].Cells[12].Value.ToString();
                txtPhiPhuThu.Value = dtgTTPhongThue.Rows[curow].Cells[13].Value.ToString();
                txtTongTien.Value = dtgTTPhongThue.Rows[curow].Cells[14].Value.ToString();

            }
            else
            {
                btnTra.Enabled = true;
                btnXuat.Enabled = false;
            }
            string a = cboMaKH.Text.ToString();
            string full_name = "";
            string cot = "Tenkh";
            if (cboMaKH.Text != "")
            {

                string id = cboMaKH.Text.ToString(); //Select MaKh from Khachhang
                string chuoi4 = "Select Tenkh from Khachhang where MaKh ='" + a.Trim() + "'";
                string tendaydu = HamHoTro.load_one_colums(chuoi4, full_name, cot);
                txtTenNV.Text = "" + tendaydu;
            }
            string chuoi1 = "Select MaKh,tensp,gia,soluongPhuThu,thanhtien from Phuthu where MaKh = N'" + a + "' "; //MaKh,TenItem,gia,soluongPhuThu,thanhtien from Phuthu,Khohang where hoadon.Maitem = Khohang.Maitem
            KetnoiDataBase.Chuoiketnoi(chuoi1, dtgPhuThu);
            Name_colums_phuthu();
        }

        private void txtMaPhong_TextChanged(object sender, EventArgs e)
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
            string cot1 = "Giaphong";
            string searchGiaPhong = "SELECT dbo.LPhong.giaphong FROM dbo.LPhong, dbo.Phong WHERE dbo.LPhong.loaiphong = dbo.Phong.loaiphong AND MaPhong = '" + txtMaPhong.Text + "'";
            float tendaydu2 = Convert.ToInt32(HamHoTro.load_one_GiaPhong(searchGiaPhong, cot1));
            txtPhiPhong.Text = tendaydu2 + "";
        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            if (txtSoNgayThue.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin . Vui lòng kiểm tra lại ! ", "Thông báo ", MessageBoxButtons.OK);
            }
            else
            {
                string id_phong = txtMaPhong.Text.Trim();

                string sql = "Update Hoadon set Ngaytraphong ='" + Convert.ToDateTime(dateNgaytra.Value).ToString("yyyy-MM-dd") + "',phiphong='" + txtPhiPhong.Value + "',phiphuthu='" + txtPhiPhuThu.Value + "',thanhtien='" + txtTongTien.Value + "',trangthai = N'Đã thanh toán' where id_hoadon = '" + txtHoadon.Text + "'";

                String sql2 = "Update Phong set Trangthai = N'Trống' where MaPhong = '" + id_phong + "'";
                if (MessageBox.Show("Bạn có muốn thanh toán không ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    HamHoTro.update(sql);
                    HamHoTro.update(sql2);
                    MessageBox.Show("Bạn đã thanh toán thành công ! ", "Thông báo ", MessageBoxButtons.OK);
                    KetnoiDataBase.Chuoiketnoi(sql_traphong, dtgTTPhongThue);
                    Namecolumn();
                }
            }
        }

        private void dateNgaytra_ValueChanged(object sender, EventArgs e)
        {
            DateTime ngaymuon = Convert.ToDateTime(dateNgayNhan.Value);
            DateTime ngaytra = Convert.ToDateTime(dateNgaytra.Value);
            if (ngaytra < ngaymuon)
            {
                dateNgaytra.Value = dateNgayNhan.Value;
            }
            ngaytra = Convert.ToDateTime(dateNgaytra.Value);
            TimeSpan Time = ngaytra - ngaymuon;
            int TongSoNgay = Time.Days;
            TongSoNgay += 1;

            double tien = (double)Convert.ToInt32(txtPhiPhong.Value.ToString()) * TongSoNgay * Convert.ToInt32(txtSoNg.Value.ToString().Trim());
            double tongtien = Convert.ToInt32(txtPhiPhuThu.Value.ToString()) + tien - Convert.ToInt32(txtDatcoc.Value.ToString());
            txtSoNgayThue.Text = "" + TongSoNgay;
            txtTongTien.Text = "" + tongtien;
        }
        private void Name_colums_phuthu()
        {
            tien_phuthu = 0;
            //MaKh,tensp,gia,soluong,thanhtien
            dtgPhuThu.EnableHeadersVisualStyles = false; //Gets or sets a value indicating whether row and column headers use the visual styles of the user's current theme if visual styles are enabled for the application.
            dtgPhuThu.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue; // gán cột màu header = color

            int sc = dtgPhuThu.Rows.Count;
            dtgPhuThu.Columns[0].HeaderText = "Mã khách"; dtgPhuThu.Columns[0].Width = 130;
            dtgPhuThu.Columns[1].HeaderText = "Tên sản phẩm"; dtgPhuThu.Columns[1].Width = 292;
            dtgPhuThu.Columns[2].HeaderText = "Giá "; dtgPhuThu.Columns[2].Width = 200;
            dtgPhuThu.Columns[3].HeaderText = "Số lượng"; dtgPhuThu.Columns[3].Width = 150;
            dtgPhuThu.Columns[4].HeaderText = "Thành tiền "; dtgPhuThu.Columns[4].Width = 200;
            
            for (int i = 0; i < sc - 1; i++)
            {
                tien_phuthu += Double.Parse(dtgPhuThu.Rows[i].Cells[4].Value.ToString());
            }
            txtPhiPhuThu.Text = "" + tien_phuthu;

        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chăn muốn thoát không ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            //Lấy nguồn dữ liệu cho report
            string query = "select id_hoadon,dbo.Phong.TenPhong,TenKH,NgaySinh,Ngaydatphong,Datcoc,Ngaynhanphong,Ngaytraphong,soluongnguoi,phiphong,phiphuthu,thanhtien from HoaDon,dbo.Phong where id_hoadon = '" + txtHoadon.Text + "' AND HoaDon.MaPhong = dbo.Phong.MaPhong";
            try
            {

                KetnoiDataBase.ad = new SqlDataAdapter(query, KetnoiDataBase.sqlcon);
                KetnoiDataBase.dt = new DataTable();
                KetnoiDataBase.bd = new SqlCommandBuilder(KetnoiDataBase.ad);
                KetnoiDataBase.ad.Fill(KetnoiDataBase.dt);
                //Gán nguồn dữ liệu cho Crystal Report
                XuatPhieuThanhToan sp = new XuatPhieuThanhToan();
                //lấy dữ liệu sql server đổ vào report
                sp.SetDataSource(KetnoiDataBase.dt);
                //Hiện thịu báo cáo
                frmPhieuThanhToan t = new frmPhieuThanhToan();
                t.crystalReportViewer1.ReportSource = sp;
                Home h = new Home();
                t.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối " + ex, "Thông báo ! ");

            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string tukhoa = txt_search.Text;
            String chuoi1 = "";
            if (String.Compare(cboLuaChon.Text, "Mã phòng", true) == 0 || cboLuaChon.SelectedItem == null)
            {
                chuoi1 = "Select * from Hoadon Where (  trangthai = N'Đang thuê' or trangthai = N'Đã thanh toán' ) AND MaPhong like N'%" + tukhoa + "%'";
            }
            else if (String.Compare(cboLuaChon.Text, "Mã khách", true) == 0)
            {
                chuoi1 = "Select * from Hoadon Where (  trangthai = N'Đang thuê' or trangthai = N'Đã thanh toán' ) AND Makh like N'%" + tukhoa + "%'";
            }
            else if (String.Compare(cboLuaChon.Text, "Trạng thái", true) == 0)
            {
                chuoi1 = "Select * from Hoadon Where (  trangthai = N'Đang thuê' or trangthai = N'Đã thanh toán' ) AND  trangthai like N'%" + tukhoa + "%'";
            }
            else
            {
                chuoi1 = "Select id_hoadon,MaPhong,Manv,Makh,TenKH,Ngaysinh,Datcoc,Ngaydatphong,Ngaynhanphong,soluongnguoi,trangthai from Hoadon where trangthai = N'Đã thanh toán' or trangthai = N'Đang thuê' ";
            }

            KetnoiDataBase.timkiem(chuoi1, dtgTTPhongThue);
            Namecolumn();
        }


        private void PopulateData(int curow)
        {


            txtHoadon.Text = dtgTTPhongThue.Rows[curow].Cells[0].Value.ToString();
            txtMaPhong.Text = dtgTTPhongThue.Rows[curow].Cells[1].Value.ToString();

            cboMaNV.Text = dtgTTPhongThue.Rows[curow].Cells[2].Value.ToString();
            txtTenNV.Text = dtgTTPhongThue.Rows[curow].Cells[3].Value.ToString();
            cboMaKH.Text = dtgTTPhongThue.Rows[curow].Cells[4].Value.ToString();
            txtKhachHang.Text = dtgTTPhongThue.Rows[curow].Cells[5].Value.ToString();

            dateNgaySinh.Value = dtgTTPhongThue.Rows[curow].Cells[6].Value.ToString();
            txtSoNg.Value = Convert.ToInt32(dtgTTPhongThue.Rows[curow].Cells[11].Value.ToString());
            txtDatcoc.Text = dtgTTPhongThue.Rows[curow].Cells[8].Value.ToString();
            dateNgayDatPhong.Value = dtgTTPhongThue.Rows[curow].Cells[7].Value.ToString();
            dateNgayNhan.Value = dtgTTPhongThue.Rows[curow].Cells[9].Value.ToString();
            dateNgaytra.Value = dtgTTPhongThue.Rows[curow].Cells[10].Value.ToString();
            trangthai1 = dtgTTPhongThue.Rows[curow].Cells[15].Value.ToString();
            if (String.Compare(trangthai1, "Đã thanh toán", true) == 0)
            {
                btnTra.Enabled = false;
                txtPhiPhong.Value = dtgTTPhongThue.Rows[curow].Cells[12].Value.ToString();
                txtPhiPhuThu.Value = dtgTTPhongThue.Rows[curow].Cells[13].Value.ToString();
                txtTongTien.Value = dtgTTPhongThue.Rows[curow].Cells[14].Value.ToString();
            }

            else
            {
                btnTra.Enabled = true;
            }
        }
        private void btnTruoc_Click(object sender, EventArgs e)
        {
            index--;
            index = index < 0 ? 0 : index;
            PopulateData(index);
            dtgTTPhongThue.CurrentCell = dtgTTPhongThue.Rows[index].Cells[0];
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            index = index + 1;
            if (index >= last)
            {
                index = 0;

                PopulateData(index);
                dtgTTPhongThue.CurrentCell = dtgTTPhongThue.Rows[index].Cells[0];
            }
            else
            {
                PopulateData(index);
                dtgTTPhongThue.CurrentCell = dtgTTPhongThue.Rows[index].Cells[0];
            }
        }

        private void btnDau_Click(object sender, EventArgs e)
        {
            index = 0;
            PopulateData(index);
            dtgTTPhongThue.CurrentCell = dtgTTPhongThue.Rows[index].Cells[0];
        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            index = last - 1;
            PopulateData(index);
            dtgTTPhongThue.CurrentCell = dtgTTPhongThue.Rows[index].Cells[0];
        }
    }
}

