using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai001_Frm
{
    public partial class FrmTinhToan : Form
    {
        double a, b, tong, hieu, tich, thuong;

        private void cmdXoa_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtKQ.Text = "";
        }

        private void cmdThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTinhToan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn kết thúc không?", "Kết Thúc",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void cmdChia_Click(object sender, EventArgs e)
        {
            a = Double.Parse(txtA.Text);
            b = Double.Parse(txtB.Text);
            thuong = a / b;
            txtKQ.Text = thuong.ToString();
        }

        private void cmdNhan_Click(object sender, EventArgs e)
        {
            a = Double.Parse(txtA.Text);
            b = Double.Parse(txtB.Text);
            tich = a * b;
            txtKQ.Text = tich.ToString();
        }

        private void cmdTru_Click(object sender, EventArgs e)
        {
            a = Double.Parse(txtA.Text);
            b = Double.Parse(txtB.Text);
            hieu = a - b;
            txtKQ.Text = hieu.ToString();
        }

        public FrmTinhToan()
        {
            InitializeComponent();
        }
        private void cmdCong_Click(object sender, EventArgs e)
        {
            a = Double.Parse(txtA.Text);
            b = Double.Parse(txtB.Text);
            tong = a + b;
            txtKQ.Text = tong.ToString();
        }
    }
}
