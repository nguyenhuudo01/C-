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
namespace QLSV_DB
{
    public partial class frmQLSVDB : Form
    {
        SqlConnection conn;
        DataGridViewCellMouseEventArgs vt;
        public frmQLSVDB()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = KetNoi.connectDB();
            string sql = "Select * from sinhvien";
            DataTable dt = KetNoi.getData(sql);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(dataGridView1.RowCount <= 0) return;
            if (e.RowIndex >= 0) {
                vt = e;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtMaSV.Text = row.Cells[0].Value.ToString();
                txtMaLop.Text = row.Cells[1].Value.ToString();
                txtHoTen.Text = row.Cells[2].Value.ToString();
                if (row.Cells[3].Value.ToString() != "")
                    dtpNgaySinh.Value = DateTime.Parse(row.Cells[3].Value.ToString());
                 else
                    dtpNgaySinh.Value = DateTime.Now;
                 cboGioiTinh.SelectedIndex = Boolean.Parse(row.Cells[4].Value.ToString()) ? 1 : 0;
                
                txtSDT.Text = row.Cells[5].Value.ToString();
                txtDiaChi.Text = row.Cells[6].Value.ToString();
            }
                
        }
        public void XoaTrang()
        {
            txtMaSV.Text = ""; txtMaLop.Text = "";
            txtHoTen.Text = ""; txtDiaChi.Text = "";
            txtSDT.Text = ""; dtpNgaySinh.Text = "";
            cboGioiTinh.Text = "";
        }
        private void cmdKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {
            
        }

        private void cmdThem_Click(object sender, EventArgs e)
        {
            XoaTrang();
            
        }
    }
}
