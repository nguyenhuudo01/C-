using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTBN
{
    public partial class FrmGiaiPTBN : Form
    {
        public FrmGiaiPTBN()
        {
            InitializeComponent();
        }

        private void btn_KetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void brn_Xoa_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtKetQua.Text = "";
        }

        private void btn_Giai_Click(object sender, EventArgs e)
        {
            double a, b, x;
            a = Double.Parse(txtA.Text);
            b = Double.Parse(txtB.Text);

            if(a ==0)
            {
                if(b==0)
                {
                    txtKetQua.Text = "Phuong trinh vo so nghiem";
                }
                else
                {
                    txtKetQua.Text = "Phuong trinh vo nghiem";
                }
            }
            else
            {
                x = -b / a;
                txtKetQua.Text = "phuong trinh co nghiem: " + Environment.NewLine +
                    " x =" +x.ToString("0,0)";
            }
        }
    }
}
