using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app = Microsoft.Office.Interop.Excel.Application;
namespace BaoCaoNhom2
{
    public partial class ThongKeNhapKho : Form
    {
        public ThongKeNhapKho()
        {
            InitializeComponent();
            Namecolumn();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            string chuoi = "SELECT * FROM NhapKho WHERE ngayNhap BETWEEN '" + Convert.ToDateTime(dtpBatDau.Value).ToString("yyyy-MM-dd") + "' AND '" + Convert.ToDateTime(dtpKetThuc.Value).ToString("yyyy-MM-dd") + "'";
            KetnoiDataBase.Chuoiketnoi(chuoi, dgvNhapKho);
           
            tinhTien();
        }
        private void Namecolumn()
        {
            string query = "select * from NhapKho";
            KetnoiDataBase.Chuoiketnoi(query, dgvNhapKho);
            dgvNhapKho.EnableHeadersVisualStyles = false; //Gets or sets a value indicating whether row and column headers use the visual styles of the user's current theme if visual styles are enabled for the application.
            dgvNhapKho.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue; // gán cột màu header = color
            dgvNhapKho.Columns["id"].Visible = false;
            tinhTien();
        }
        public void tinhTien()
        {
            int sc = dgvNhapKho.Rows.Count;
            double thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
            {

                thanhtien += float.Parse(dgvNhapKho.Rows[i].Cells[4].Value.ToString());
            }

            lblThanhTien.Text = thanhtien.ToString() + " (VNĐ) ";
        }

        private void btnXuatEx_Click(object sender, EventArgs e)
        {
            try
            {
                export2Excel(dgvNhapKho, @"D:\", "ThongKeNhapKho");
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

        private void biểuĐồNhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void dgvNhapKho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void biểuĐồNhậpKhoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DoanhThuFull.ChartSanPham a = new DoanhThuFull.ChartSanPham();
            a.ShowDialog();
        }
    }
}
