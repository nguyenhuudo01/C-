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
    public partial class ChartsMonth : Form
    {
        public string connectionString = KetnoiDataBase.sqlcon;
        SqlConnection conn;
        SqlDataAdapter da;
        public ChartsMonth()
        {
            InitializeComponent();
            getUI();
        }

        private void getUI()
        {
            conn = new SqlConnection(connectionString);
            //string query = "select month(Ngaytraphong) as Ngaytraphong, sum(thanhtien) as thanhtien from Hoadon where month(Ngaytraphong) between "+ Convert.ToDateTime(dtpBatDau.Value).ToString("MM") + " and "+ Convert.ToDateTime(dtpKetThuc.Value).ToString("MM") + "   group by month(Ngaytraphong) ";
            string query = "select month(Ngaytraphong) as Ngaytraphong, sum(thanhtien) as thanhtien from Hoadon group by month(Ngaytraphong) ";
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(query, conn);
            da.Fill(dt);
            chtDoanhThu.DataSource = dt;
            chtDoanhThu.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";
            chtDoanhThu.ChartAreas["ChartArea1"].AxisY.Title = "Tiền (VNĐ)";

            chtDoanhThu.Series["Doanh Thu"].XValueMember = "Ngaytraphong";
            chtDoanhThu.Series["Doanh Thu"].YValueMembers = "thanhtien";



            //-------------------------------Load label top 1 tháng----------------------------------
            string queryTop1Thang = "select top 1 month(Ngaytraphong) as Ngaytraphong, sum(thanhtien) as thanhtien from Hoadon group by month(Ngaytraphong) order by thanhtien desc";
            conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmdThang = new SqlCommand(queryTop1Thang, conn);
            cmdThang.ExecuteNonQuery();
            DataTable dtTop1 = new DataTable();
            da = new SqlDataAdapter(cmdThang);
            da.Fill(dtTop1);
            foreach (DataRow dr in dtTop1.Rows)
            {
                lblTop1Thang.Text = dr["Ngaytraphong"].ToString();
                lblDoanhThuMax.Text = string.Format("{0:#,##0}", double.Parse(dr["thanhtien"].ToString())) + " VNĐ";
            }
            conn.Close();


            //-------------------------------Load label top min tháng----------------------------------
            string queryMinMonth = "select top 1 month(Ngaytraphong) as Ngaytraphong, sum(thanhtien) as thanhtien from Hoadon group by month(Ngaytraphong) order by thanhtien asc";
            conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmdThangMin = new SqlCommand(queryMinMonth, conn);
            cmdThangMin.ExecuteNonQuery();
            DataTable dtTopMinMonth = new DataTable();
            da = new SqlDataAdapter(cmdThangMin);
            da.Fill(dtTopMinMonth);
            foreach (DataRow dr1 in dtTopMinMonth.Rows)
            {
                lblThangMin.Text = dr1["Ngaytraphong"].ToString();
                //lblDoanhThuMin.Text= dr1["thanhtien"].ToString()+" VNĐ";
                lblDoanhThuMin.Text = string.Format("{0:#,##0}", double.Parse(dr1["thanhtien"].ToString())) + " VNĐ";
            }
            conn.Close();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

            //chtDoanhThu.Series["Series1"].Points.AddXY("1", "231231");
            //chtDoanhThu.Series["Series1"].Points.AddXY("2", "63463");
        }


        private void BieuDoDoanhThu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (Convert.ToDateTime(dtpBatDau.Value).ToString("yyyy") != Convert.ToDateTime(dtpKetThuc.Value).ToString("yyyy"))
                MessageBox.Show("Bạn cần nhập 2 năm giống nhau", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                conn = new SqlConnection(connectionString);
                string query = "select month(Ngaytraphong) as Ngaytraphong, sum(thanhtien) as thanhtien from Hoadon where month(Ngaytraphong) between " +
                Convert.ToDateTime(dtpBatDau.Value).ToString("MM") + " and " + Convert.ToDateTime(dtpKetThuc.Value).ToString("MM") + "and year(Ngaytraphong)=" + Convert.ToDateTime(dtpKetThuc.Value).ToString("yyyy") + " group by month(Ngaytraphong) ";
                //string query = "select month(Ngaytraphong) as Ngaytraphong, sum(thanhtien) as thanhtien from Hoadon group by month(Ngaytraphong) ";
                DataTable dt = new DataTable();
                da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
                chtDoanhThu.DataSource = dt;
                chtDoanhThu.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";
                chtDoanhThu.ChartAreas["ChartArea1"].AxisY.Title = "Tiền (VNĐ)";

                chtDoanhThu.Series["Doanh Thu"].XValueMember = "Ngaytraphong";
                chtDoanhThu.Series["Doanh Thu"].YValueMembers = "thanhtien";



                //-------------------------------Load label top 1 tháng----------------------------------
                string queryTop1Thang = "select top 1 month(Ngaytraphong) as Ngaytraphong, sum(thanhtien) as thanhtien from Hoadon where month(Ngaytraphong) between "
                    + Convert.ToDateTime(dtpBatDau.Value).ToString("MM") + " and " + Convert.ToDateTime(dtpKetThuc.Value).ToString("MM") + "and year(Ngaytraphong)=" + Convert.ToDateTime(dtpKetThuc.Value).ToString("yyyy") + " group by month(Ngaytraphong) order by thanhtien desc";
                conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand cmdThang = new SqlCommand(queryTop1Thang, conn);
                cmdThang.ExecuteNonQuery();
                DataTable dtTop1 = new DataTable();
                da = new SqlDataAdapter(cmdThang);
                da.Fill(dtTop1);
                foreach (DataRow dr in dtTop1.Rows)
                {
                    lblTop1Thang.Text = dr["Ngaytraphong"].ToString();
                    lblDoanhThuMax.Text = string.Format("{0:#,##0}", double.Parse(dr["thanhtien"].ToString())) + " VNĐ";
                }
                conn.Close();


                //-------------------------------Load label top min tháng----------------------------------
                string queryMinMonth = "select top 1 month(Ngaytraphong) as Ngaytraphong, sum(thanhtien) as thanhtien from Hoadon where month(Ngaytraphong) between "
                    + Convert.ToDateTime(dtpBatDau.Value).ToString("MM") + " and " + Convert.ToDateTime(dtpKetThuc.Value).ToString("MM") + "and year(Ngaytraphong)=" + Convert.ToDateTime(dtpKetThuc.Value).ToString("yyyy") + " group by month(Ngaytraphong) order by thanhtien asc";
                conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand cmdThangMin = new SqlCommand(queryMinMonth, conn);
                cmdThangMin.ExecuteNonQuery();
                DataTable dtTopMinMonth = new DataTable();
                da = new SqlDataAdapter(cmdThangMin);
                da.Fill(dtTopMinMonth);
                foreach (DataRow dr1 in dtTopMinMonth.Rows)
                {
                    lblThangMin.Text = dr1["Ngaytraphong"].ToString();
                    //lblDoanhThuMin.Text= dr1["thanhtien"].ToString()+" VNĐ";
                    lblDoanhThuMin.Text = string.Format("{0:#,##0}", double.Parse(dr1["thanhtien"].ToString())) + " VNĐ";
                }
                conn.Close();
            }
        }

        private void lblTop1Thang_Click(object sender, EventArgs e)
        {

        }
    }
}
