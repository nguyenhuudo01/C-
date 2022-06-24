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
using app = Microsoft.Office.Interop.Excel.Application;

namespace BaoCaoNhom2
{
    public partial class NhapKho : Form
    {
        string connectionString = KetnoiDataBase.sqlcon;
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;
        public static string query1 = "Select * from Khohang";
        public static string query2 = "select NhapKho.id,NhapKho.tenSPNhap,NhapKho.soLuongNhap,NhapKho.ngayNhap,NhapKho.thanhTienNhap,Khohang.Maitem  from NhapKho, Khohang where NhapKho.tenSPNhap= Khohang.TenItem";
        public static string state = "";
        public NhapKho()
        {
            InitializeComponent();
            state = "Reset";
            setControl(state);
            getDataSP();
            getDataNhapKho();

        }

        private void getDataNhapKho()
        {
            KetnoiDataBase.Chuoiketnoi(query2, dgvNhapSP);
            dgvNhapSP.EnableHeadersVisualStyles = false; //Gets or sets a value indicating whether row and column headers use the visual styles of the user's current theme if visual styles are enabled for the application.
            dgvNhapSP.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue; // gán cột màu header = color
            dgvNhapSP.Columns["id"].Visible = false;
            dgvNhapSP.Columns["tenSPNhap"].HeaderText = "Tên sản phẩm"; dgvNhapSP.Columns["tenSPNhap"].Width =300;
            dgvNhapSP.Columns["soLuongNhap"].HeaderText = "Số lượng"; dgvNhapSP.Columns["soLuongNhap"].Width = 100;
            dgvNhapSP.Columns["ngayNhap"].HeaderText = "Ngày nhập"; dgvNhapSP.Columns["ngayNhap"].Width = 300;
            dgvNhapSP.Columns["thanhTienNhap"].HeaderText = "Thành tiền"; dgvNhapSP.Columns["thanhTienNhap"].Width=900;
            dgvNhapSP.Columns["Maitem"].Visible = false;
        }

        private void setControl(String state)
        {
           


            switch (state)
            {
                case "Reset":
                    txtMaSP.Text = "";
                    txtChietKhau.Text = "";
                    txtGiaNhap.Text = "";
                    txtSLKho.Text = "";
                    txtSLNhap.Text = "";
                    txtTenSP.Text = "";
                    txtTimKiem.Text = "Nhập từ khóa....";
                    cboTimKiem.Text = "Trường tìm kiếm";
                    lblThanhTien.Text = "0";
                    break;
                case "Add":
                    if (txtChietKhau.Text == "" || txtSLNhap.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập đủ thông tin");
                    }
                    else
                    {
                        string query = "insert into NhapKho values(N'" + txtTenSP.Text.Trim() + "','" + txtSLNhap.Text.Trim() +
                            "','" + Convert.ToDateTime(dtpTime.Value).ToString("yyyy-MM-dd") + "','" + lblThanhTien.Text.Trim() + "')";
                        string queryUpdate = "update Khohang set soluong='" + (Convert.ToInt32(txtSLKho.Text.Trim()) + Convert.ToInt32(txtSLNhap.Text.Trim())) + "' where Maitem ='" + dgvSanPham.CurrentRow.Cells["Maitem"].Value + "'";
                        KetnoiDataBase.Chuoiketnoi(query, dgvNhapSP);
                        KetnoiDataBase.Chuoiketnoi(queryUpdate, dgvSanPham);
                        //conn.Close();
                        getDataNhapKho();
                        getDataSP();
                    }
                    break;
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {

        }
        public void getDataSP()
        {
            KetnoiDataBase.Chuoiketnoi(query1, dgvSanPham);
            dgvSanPham.EnableHeadersVisualStyles = false; //Gets or sets a value indicating whether row and column headers use the visual styles of the user's current theme if visual styles are enabled for the application.
            dgvSanPham.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue; // gán cột màu header = color
            dgvSanPham.Columns["Maitem"].Visible = false;
            dgvSanPham.Columns["TenItem"].HeaderText = "Tên sản phẩm"; dgvSanPham.Columns["TenItem"].Width = 300;
            dgvSanPham.Columns["gianhap"].HeaderText = "Giá nhập"; dgvSanPham.Columns["gianhap"].Width = 200;
            dgvSanPham.Columns["soluong"].HeaderText = "Số lượng"; dgvSanPham.Columns["soluong"].Width = 200;
            dgvSanPham.Columns["giaban"].HeaderText = "Giá bán"; dgvSanPham.Columns["giaban"].Width = 600;

        }
        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            string timKiem = "Select * from Khohang where TenItem like '%" + txtTimKiem.Text.Trim() + "%'";
            KetnoiDataBase.Chuoiketnoi(timKiem, dgvSanPham);

        }



        private void dgvNhapSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = e.RowIndex;
            DataGridViewRow select = dgvNhapSP.Rows[RowIndex];
            txtMaSP.Text = select.Cells["id"].Value.ToString();
            txtTenSP.Text = select.Cells["tenSPNhap"].Value.ToString();
            txtSLNhap.Text = select.Cells["soLuongNhap"].Value.ToString();
            lblThanhTien.Text = select.Cells["thanhTienNhap"].Value.ToString();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            state = "Reset";
            setControl(state);
        }

        private void lblThanhTien_Click(object sender, EventArgs e)
        {

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



        private void NhapKho_Load(object sender, EventArgs e)
        {

        }

        private void dgvNhapSP_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = e.RowIndex;
            DataGridViewRow select = dgvSanPham.Rows[RowIndex];
            //txtMaSP.Text = select.Cells["Maitem"].Value.ToString();
            txtTenSP.Text = select.Cells["TenItem"].Value.ToString();
            txtSLKho.Text = select.Cells["soluong"].Value.ToString();
            txtGiaNhap.Text = select.Cells["gianhap"].Value.ToString();
            //lblSlKho.Text = "" + select.Cells["soluong"].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var kq = MessageBox.Show("Bạn có thực sự muốn xóa ", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.Yes)
            {
                int b = Convert.ToInt32(txtSLNhap.Text);
                string queryUpdate2 = "update Khohang set soluong = (soluong -" + b + ") where Maitem ='" + dgvNhapSP.CurrentRow.Cells["Maitem"].Value + "'";
                BaoCaoNhom2.KetnoiDataBase.Chuoiketnoi(queryUpdate2, dgvSanPham);
                string query1 = "delete NhapKho where id='" + txtMaSP.Text.Trim() + "'";
                KetnoiDataBase.Chuoiketnoi(query1, dgvNhapSP);
                //string queryXoa = "delete "
                getDataNhapKho();

                getDataSP();
                state = "Reset";
                setControl(state);
            }
        }



        private void btnExcel_Click(object sender, EventArgs e)
        {
            export2Excel(dgvNhapSP, @"D:\", "Nhap_Kho");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            state = "Add";
            setControl(state);
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            state = "Reset";
            setControl(state);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtChietKhau_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

            if (cboTimKiem.Text == "Sản phẩm")
            {
                conn = new SqlConnection(connectionString);
                string query = "Select * from Khohang where TenItem like '%" + txtTimKiem.Text + "%'";
                SqlCommand cmd = new SqlCommand(query, conn);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dgvSanPham.DataSource = ds.Tables[0];
                    dgvSanPham.AutoGenerateColumns = false;
                }
                conn.Close();
            }
            else if (cboTimKiem.Text == "Trường tìm kiếm")
            {
                MessageBox.Show("Yêu cầu chọn trường tìm kiếm", "Cảnh báo", MessageBoxButtons.OK);
            }
            else
            {
                string queryFind = "Select * from NhapKho where TenSPNhap like '%" + txtTimKiem.Text + "%'";
                KetnoiDataBase.Chuoiketnoi(queryFind, dgvNhapSP);
            }
        }

        private void cboTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSLKho_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSLNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void NhapKho_Load_1(object sender, EventArgs e)
        {

        }

        private void txtChietKhau_TextChanged(object sender, EventArgs e)
        {
            if (txtChietKhau.Text != "")
            {
                int giaNhap = Convert.ToInt32(txtGiaNhap.Text.Trim());
                int soLuongNhap = Convert.ToInt32(txtSLNhap.Text.Trim());
                int tongTien;
                int chietKhau = Convert.ToInt32(txtChietKhau.Text.Trim());
                tongTien = giaNhap * soLuongNhap * (100 - chietKhau) / 100;
                lblThanhTien.Text = Convert.ToString(tongTien);
            }
        }
    }
}
