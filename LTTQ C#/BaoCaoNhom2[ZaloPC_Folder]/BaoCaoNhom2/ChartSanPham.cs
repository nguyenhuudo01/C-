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

namespace BaoCaoNhom2.DoanhThuFull
{
    public partial class ChartSanPham : Form
    {
        public string connectionString = KetnoiDataBase.sqlcon;
        SqlConnection conn;
        SqlDataAdapter da;
        public ChartSanPham()
        {
            InitializeComponent();
            getUI();
        }

        private void getUI()
        {
            conn = new SqlConnection(connectionString);
            //string query = "select month(Ngaytraphong) as Ngaytraphong, sum(thanhtien) as thanhtien from Hoadon where month(Ngaytraphong) between "+ Convert.ToDateTime(dtpBatDau.Value).ToString("MM") + " and "+ Convert.ToDateTime(dtpKetThuc.Value).ToString("MM") + "   group by month(Ngaytraphong) ";
            string query = "select sum(soLuongNhap) as soLuongNhap,month(ngayNhap) as ngayNhap,tenSPNhap from NhapKho group by tenSPNhap,ngayNhap";
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(query, conn);
            da.Fill(dt);
            chtDoanhThu.DataSource = dt;
            chtDoanhThu.ChartAreas["ChartArea1"].AxisX.Title = "Sản phẩm";
            chtDoanhThu.ChartAreas["ChartArea1"].AxisY.Title = "Số lượng";

            chtDoanhThu.Series["Số lượng"].XValueMember = "tenSPNhap";
            chtDoanhThu.Series["Số lượng"].YValueMembers = "soLuongNhap";

            //-------------------------------Load label top 1 tháng----------------------------------
            string queryTop1Thang = "select top 1 sum(soLuongNhap) as soLuongNhap,month(ngayNhap) as ngayNhap,tenSPNhap from NhapKho group by tenSPNhap,ngayNhap order by soLuongNhap desc";
            conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmdThang = new SqlCommand(queryTop1Thang, conn);
            cmdThang.ExecuteNonQuery();
            DataTable dtTop1 = new DataTable();
            da = new SqlDataAdapter(cmdThang);
            da.Fill(dtTop1);
            foreach (DataRow dr in dtTop1.Rows)
            {
                lblTop1Thang.Text = dr["tenSPNhap"].ToString();
                lblDoanhThuMax.Text = string.Format("{0:#,##0}", double.Parse(dr["soLuongNhap"].ToString())) + " sản phẩm";
            }
            conn.Close();

            //-------------------------------Load label top cuối tháng----------------------------------
            string queryTopCuoi = "select top 1 sum(soLuongNhap) as soLuongNhap,month(ngayNhap) as ngayNhap,tenSPNhap from NhapKho group by tenSPNhap,ngayNhap order by soLuongNhap asc";
            conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmdCuoi = new SqlCommand(queryTopCuoi, conn);
            cmdCuoi.ExecuteNonQuery();
            DataTable dtTopCuoi = new DataTable();
            da = new SqlDataAdapter(cmdCuoi);
            da.Fill(dtTopCuoi);
            foreach (DataRow dr in dtTopCuoi.Rows)
            {
                lblThangMin.Text = dr["tenSPNhap"].ToString();
                lblDoanhThuMin.Text = string.Format("{0:#,##0}", double.Parse(dr["soLuongNhap"].ToString())) + " sản phẩm";
            }
            conn.Close();
        }

        private void ChartSanPham_Load(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            //-------------------------------Load label top 1 tháng----------------------------------
            string queryTop1Thang = "select top 1 sum(soLuongNhap) as soLuongNhap,tenSPNhap from NhapKho where month(ngayNhap) between " +
               Convert.ToDateTime(dtpBatDau.Value).ToString("MM") + " and " + Convert.ToDateTime(dtpKetThuc.Value).ToString("MM") + " group by tenSPNhap,ngayNhap  order by soLuongNhap desc ";
            conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmdThang = new SqlCommand(queryTop1Thang, conn);
            cmdThang.ExecuteNonQuery();
            DataTable dtTop1 = new DataTable();
            da = new SqlDataAdapter(cmdThang);
            da.Fill(dtTop1);
            foreach (DataRow dr in dtTop1.Rows)
            {
                lblTop1Thang.Text = dr["tenSPNhap"].ToString();
                lblDoanhThuMax.Text = string.Format("{0:#,##0}", double.Parse(dr["soLuongNhap"].ToString())) + " sản phẩm";
            }
            conn.Close();

            //-------------------------------Load label top cuối tháng----------------------------------
            string queryTopCuoi = "select top 1 sum(soLuongNhap) as soLuongNhap,tenSPNhap from NhapKho where month(ngayNhap) between " +
               Convert.ToDateTime(dtpBatDau.Value).ToString("MM") + " and " + Convert.ToDateTime(dtpKetThuc.Value).ToString("MM") + " group by tenSPNhap,ngayNhap  order by soLuongNhap asc ";
            conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmdCuoi = new SqlCommand(queryTopCuoi, conn);
            cmdCuoi.ExecuteNonQuery();
            DataTable dtTopCuoi = new DataTable();
            da = new SqlDataAdapter(cmdCuoi);
            da.Fill(dtTopCuoi);
            foreach (DataRow dr in dtTopCuoi.Rows)
            {
                lblThangMin.Text = dr["tenSPNhap"].ToString();
                lblDoanhThuMin.Text = string.Format("{0:#,##0}", double.Parse(dr["soLuongNhap"].ToString())) + " sản phẩm";
            }
            conn.Close();
            getUI();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
