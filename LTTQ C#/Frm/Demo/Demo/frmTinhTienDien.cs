using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class frmTinhTienDien : Form
    {
        double a, b, cong, tru, nhan, chia;

        private void cmd_Chia_Click(object sender, EventArgs e)
        {
            a = double.Parse(txtA.Text);
            b = double.Parse(txtB.Text);
            chia = a / b;
            txtKetQua.Text = chia.ToString();
        }

        private void frmTinhTienDien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn kết thúc không?", "Kết Thúc",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        private void cmd_Nhan_Click(object sender, EventArgs e)
        {
            a = double.Parse(txtA.Text);
            b = double.Parse(txtB.Text);
            nhan = a * b;
            txtKetQua.Text = nhan.ToString();
        }

        private void cmd_Tru_Click(object sender, EventArgs e)
        {
            a = double.Parse(txtA.Text);
            b = double.Parse(txtB.Text);
            tru = a - b;
            txtKetQua.Text = tru.ToString();
        }

        public frmTinhTienDien()
        {
            InitializeComponent();
        }

        private void cmd_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmd_Cong_Click(object sender, EventArgs e)
        {
            a = double.Parse(txtA.Text);
            b = double.Parse(txtB.Text);
            cong = a + b;
            txtKetQua.Text = cong.ToString();
        }
    }
}
