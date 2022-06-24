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
    public partial class DoanhThu : Form
    {
        string connectionString = KetnoiDataBase.sqlcon;
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;
        public string sql_traphong = "Select * from Hoadon  where trangthai = N'Đã thanh toán'";
        public DoanhThu()
        {
            InitializeComponent();
            getData();
        }

        private void biểuĐồDonhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void getData()
        {

            string queryGet = "Select * from Hoadon";
            KetnoiDataBase.Chuoiketnoi(queryGet, dgvDoanhThu);
            dgvDoanhThu.EnableHeadersVisualStyles = false; //Gets or sets a value indicating whether row and column headers use the visual styles of the user's current theme if visual styles are enabled for the application.
            dgvDoanhThu.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue; // gán cột màu header = color
            string query = "select sum(thanhtien) as thanhtien,sum(phiphuthu) as phuthu,sum(phiphong) as phiphong from Hoadon";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                lblThanhTien.Text = dr["thanhtien"].ToString() + " VNĐ";
                lblPhong.Text = dr["phiphong"].ToString() + " VNĐ";
                lblPhuThu.Text = dr["phuthu"].ToString() + " VNĐ";
            }
            conn.Close();
            Namecolumn();
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            string chuoi = "SELECT * FROM Hoadon WHERE Ngaytraphong BETWEEN '" + Convert.ToDateTime(dtpBatDau.Value).ToString("yyyy-MM-dd") + "' AND '" + Convert.ToDateTime(dtpKetThuc.Value).ToString("yyyy-MM-dd") + "' AND trangthai = N'Đã thanh toán'";
            KetnoiDataBase.Chuoiketnoi(chuoi, dgvDoanhThu);
            string query = "select sum(thanhtien) as thanhtien,sum(phiphuthu) as phuthu,sum(phiphong) as phiphong from Hoadon WHERE Ngaytraphong BETWEEN '" + Convert.ToDateTime(dtpBatDau.Value).ToString("yyyy-MM-dd") + "' AND '" + Convert.ToDateTime(dtpKetThuc.Value).ToString("yyyy-MM-dd") + "' AND trangthai = N'Đã thanh toán'";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                lblThanhTien.Text = dr["thanhtien"].ToString() + " VNĐ";
                lblPhong.Text = dr["phiphong"].ToString() + " VNĐ";
                lblPhuThu.Text = dr["phuthu"].ToString() + " VNĐ";
            }
            conn.Close();
            Namecolumn();
        }
        private void Namecolumn()
        {
            //id_hoadon,MaPhong,Makh,Manv,Ngaydatphong,Ngaynhanphong,Ngaytraphong,soluongnguoi,phiphong,phiphuthu,thanhtien,trangthai
            dgvDoanhThu.Columns[0].HeaderText = "Mã hóa đơn"; dgvDoanhThu.Columns[0].Width = 130;
            dgvDoanhThu.Columns[1].HeaderText = "Mã phòng"; dgvDoanhThu.Columns[1].Width = 130;
            
            dgvDoanhThu.Columns[2].HeaderText = "Mã nhân viên"; dgvDoanhThu.Columns[2].Width = 120;
            
            dgvDoanhThu.Columns[3].Visible = false;
            dgvDoanhThu.Columns[4].HeaderText = "Mã khách "; dgvDoanhThu.Columns[4].Width = 120;
            dgvDoanhThu.Columns[5].Visible = false;
            dgvDoanhThu.Columns[6].HeaderText = "Ngày sinh "; dgvDoanhThu.Columns[6].Width = 120;

            dgvDoanhThu.Columns[7].HeaderText = "Ngày đặt "; dgvDoanhThu.Columns[7].Width = 120;
            dgvDoanhThu.Columns[8].HeaderText = "Đặt cọc "; dgvDoanhThu.Columns[8].Width = 120;
            dgvDoanhThu.Columns[9].HeaderText = "Ngày nhận "; dgvDoanhThu.Columns[9].Width = 120;
            dgvDoanhThu.Columns[10].HeaderText = "Ngày trả "; dgvDoanhThu.Columns[10].Width = 120;
            dgvDoanhThu.Columns[11].HeaderText = "Số người"; dgvDoanhThu.Columns[11].Width = 120;
            dgvDoanhThu.Columns[12].HeaderText = "Phí phòng"; dgvDoanhThu.Columns[12].Width = 120;
            dgvDoanhThu.Columns[13].HeaderText = "Phí phị thu"; dgvDoanhThu.Columns[13].Width = 120;
            dgvDoanhThu.Columns[14].HeaderText = "Thành tiền"; dgvDoanhThu.Columns[14].Width = 120;
            dgvDoanhThu.Columns[15].Visible = false;
            //int sc = dgvDoanhThu.Rows.Count;
            //double thanhtien = 0;
            //double phuthu = 0;
            //double phong = 0;
            //for (int i = 0; i < sc - 1; i++)
            //{
            //    if (dgvDoanhThu.Rows[i].Cells[11].Value.ToString() == "Đã thanh toán")
            //    {
            //        thanhtien += float.Parse(dgvDoanhThu.Rows[i].Cells[7].Value.ToString());
            //        phuthu += float.Parse(dgvDoanhThu.Rows[i].Cells["phiphuthu"].Value.ToString());
            //        phong += float.Parse(dgvDoanhThu.Rows[i].Cells["phiphong"].Value.ToString());
            //    }
            //}




        }

        private void btnXuatEx_Click(object sender, EventArgs e)
        {
            try
            {
                export2Excel(dgvDoanhThu, @"D:\", "DoanhThu");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            };
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void bảngDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void doanhThuTheoThángToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void danhThuTheoNămToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void doanhThuPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void dgvDoanhThu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblThanhTien_Click(object sender, EventArgs e)
        {

        }

        private void dtpKetThuc_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpBatDau_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblPhong_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblPhuThu_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void bảngDoanhThuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DoanhThu_Load(object sender, EventArgs e)
        {

        }

        private void doanhThuTheoThángToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DoanhThuFull.ChartsMonth a = new DoanhThuFull.ChartsMonth();
            a.ShowDialog();
        }

        private void danhThuTheoNămToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DoanhThuFull.ChartsYear b = new DoanhThuFull.ChartsYear();
            b.ShowDialog();
        }

        private void doanhThuPhòngToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DoanhThuFull.ChartsRoomMonth c = new DoanhThuFull.ChartsRoomMonth();
            c.ShowDialog();
        }

        private void dgvDoanhThu_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
