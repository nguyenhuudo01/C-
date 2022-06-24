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
    public partial class ChartsRoomMonth : Form
    {
        public string connectionString = KetnoiDataBase.sqlcon;
        SqlConnection conn;
        SqlDataAdapter da;
        public ChartsRoomMonth()
        {
            InitializeComponent();
            getUI();

        }

        private void getUI()
        {
            //-------------------------------Load label top 1 phòng----------------------------------
            string queryTop1Phong = "select top 1 sum(Hoadon.thanhtien) as thanhtien, Phong.TenPhong from Hoadon,Phong  where Hoadon.MaPhong=Phong.MaPhong group by Phong.TenPhong order by thanhtien desc";
            conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(queryTop1Phong, conn);
            cmd.ExecuteNonQuery();
            DataTable dtTop1Phong = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dtTop1Phong);
            foreach (DataRow dr in dtTop1Phong.Rows)
            {
                lblRomtop1.Text = dr["TenPhong"].ToString();
                lblDoanhThuMax.Text = string.Format("{0:#,##0}", double.Parse(dr["thanhtien"].ToString())) + " VNĐ";
            }
            conn.Close();

            //-------------------------------Load label top min phòng----------------------------------
            string queryTopMinPhong = "select top 1 sum(Hoadon.thanhtien) as thanhtien, Phong.TenPhong from Hoadon,Phong  where Hoadon.MaPhong=Phong.MaPhong group by Phong.TenPhong order by thanhtien asc";
            conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmdTopMin = new SqlCommand(queryTopMinPhong, conn);
            cmdTopMin.ExecuteNonQuery();
            DataTable dtTopMinPhong = new DataTable();
            da = new SqlDataAdapter(cmdTopMin);
            da.Fill(dtTopMinPhong);
            foreach (DataRow dr in dtTopMinPhong.Rows)
            {
                lblRoomTopCuoi.Text = dr["TenPhong"].ToString();
                lblDoanhThuMin.Text = string.Format("{0:#,##0}", double.Parse(dr["thanhtien"].ToString())) + " VNĐ";
            }
            conn.Close();

            //-------------------------------Load charts--------------------------------------------
            conn = new SqlConnection(connectionString);
            //string query = "select month(Ngaytraphong) as Ngaytraphong, sum(thanhtien) as thanhtien from Hoadon where month(Ngaytraphong) between "+ Convert.ToDateTime(dtpBatDau.Value).ToString("MM") + " and "+ Convert.ToDateTime(dtpKetThuc.Value).ToString("MM") + "   group by month(Ngaytraphong) ";
            string query = "select TenPhong, sum(thanhtien) as 'thanhtien' from Phong,Hoadon where Hoadon.MaPhong=Phong.MaPhong group by TenPhong ";
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(query, conn);
            da.Fill(dt);
            chtRoom.DataSource = dt;
            chtRoom.ChartAreas["ChartArea1"].AxisX.Title = "Phòng";
            chtRoom.ChartAreas["ChartArea1"].AxisY.Title = "Tiền (VNĐ)";

            chtRoom.Series["Phòng"].XValueMember = "TenPhong";
            chtRoom.Series["Phòng"].YValueMembers = "thanhtien";
        }

        private void ChartsRoomMonth_Load(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            //-------------------------------Load label top 1 phòng----------------------------------
            if (Convert.ToDateTime(dtpBatDau.Value).ToString("yyyy") != Convert.ToDateTime(dtpKetThuc.Value).ToString("yyyy"))
                MessageBox.Show("Bạn cần nhập 2 năm giống nhau", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                string queryTop1Phong = "select sum(Hoadon.thanhtien) as thanhtien, Phong.TenPhong from Hoadon,Phong  where Hoadon.MaPhong=Phong.MaPhong and (month(Hoadon.Ngaytraphong) between "
                    + Convert.ToDateTime(dtpBatDau.Value).ToString("MM") + " and " + Convert.ToDateTime(dtpKetThuc.Value).ToString("MM") + ") group by Phong.TenPhong order by thanhtien desc";
                conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(queryTop1Phong, conn);
                cmd.ExecuteNonQuery();
                DataTable dtTop1Phong = new DataTable();
                da = new SqlDataAdapter(cmd);
                da.Fill(dtTop1Phong);
                foreach (DataRow dr in dtTop1Phong.Rows)
                {
                    lblRomtop1.Text = dr["TenPhong"].ToString();
                    lblDoanhThuMax.Text = string.Format("{0:#,##0}", double.Parse(dr["thanhtien"].ToString())) + " VNĐ";
                }
                conn.Close();
                //-------------------------------Load label top min phòng----------------------------------
                string queryTopMinPhong = "select sum(Hoadon.thanhtien) as thanhtien, Phong.TenPhong from Hoadon,Phong where Hoadon.MaPhong = Phong.MaPhong and(month(Hoadon.Ngaytraphong) between "
                     + Convert.ToDateTime(dtpBatDau.Value).ToString("MM") + " and " + Convert.ToDateTime(dtpKetThuc.Value).ToString("MM") + ") group by Phong.TenPhong order by thanhtien asc";
                conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand cmdTopMin = new SqlCommand(queryTopMinPhong, conn);
                cmdTopMin.ExecuteNonQuery();
                DataTable dtTopMinPhong = new DataTable();
                da = new SqlDataAdapter(cmdTopMin);
                da.Fill(dtTopMinPhong);
                foreach (DataRow dr in dtTopMinPhong.Rows)
                {
                    lblRoomTopCuoi.Text = dr["TenPhong"].ToString();
                    lblDoanhThuMin.Text = string.Format("{0:#,##0}", double.Parse(dr["thanhtien"].ToString())) + " VNĐ";
                }
                conn.Close();
                //-------------------------------Load charts--------------------------------------------
                conn = new SqlConnection(connectionString);
                //string query = "select month(Ngaytraphong) as Ngaytraphong, sum(thanhtien) as thanhtien from Hoadon where month(Ngaytraphong) between "+ Convert.ToDateTime(dtpBatDau.Value).ToString("MM") + " and "+ Convert.ToDateTime(dtpKetThuc.Value).ToString("MM") + "   group by month(Ngaytraphong) ";
                string query = "select TenPhong, sum(thanhtien) as 'thanhtien' from Phong,Hoadon where Hoadon.MaPhong=Phong.MaPhong and(month(Hoadon.Ngaytraphong) between "
                     + Convert.ToDateTime(dtpBatDau.Value).ToString("MM") + " and " + Convert.ToDateTime(dtpKetThuc.Value).ToString("MM") + ") group by TenPhong";
                DataTable dt = new DataTable();
                da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
                chtRoom.DataSource = dt;
                chtRoom.ChartAreas["ChartArea1"].AxisX.Title = "Phòng";
                chtRoom.ChartAreas["ChartArea1"].AxisY.Title = "Tiền (VNĐ)";

                chtRoom.Series["Phòng"].XValueMember = "TenPhong";
                chtRoom.Series["Phòng"].YValueMembers = "thanhtien";
            }

        }
    }
}
