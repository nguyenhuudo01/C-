using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HT21_16_NguyenHuuDo
{
    public partial class frmTinhTienDien : Form
    {
        public frmTinhTienDien()
        {
            InitializeComponent();
        }

        private void txtCsc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
                e.Handled = true;
        }

        private void cmd_TinhTienDien_Click(object sender, EventArgs e)
        {
            int chisocu, chisomoi, sodien, tg;
            int m1 = 0, m2 = 0, m3 = 0, m4 = 0, m5 = 0, m6 = 0;
            double tt1 = 0, tt2 = 0, tt3 = 0, tt4 = 0, tt5 = 0, tt6 = 0;
            do
            {
                chisocu = Convert.ToInt32(txtchisocu.Text);
            } while (chisocu < 0);
            do
            {
                chisomoi = Convert.ToInt32(txtchisomoi.Text);
            } while (chisomoi < chisocu);
            
            sodien = chisomoi - chisocu;
            tg = sodien;
            txtSoDien.Text = sodien.ToString();
            if (Radio_DienSinhHoat.Checked == true)
            {
                if (tg > 400) { m6 = tg - 400; tg = 400; }
                if (tg > 300) { m5 = tg - 300; tg = 300; }
                if (tg > 200) { m4 = tg - 200; tg = 200; }
                if (tg > 100) { m3 = tg - 100; tg = 100; }
                if (tg > 50) { m2 = tg - 50; tg = 50; }
                m1 = tg;
                tt1 = m1 * 1678;
                tt2 = m2 * 1734;
                tt3 = m3 * 2014;
                tt4 = m4 * 2536;
                tt5 = m5 * 2834;
                tt6 = m6 * 2927;
                double tong = tt1 + tt2 + tt3 + tt4 + tt5 + tt6;
                txtTongThanhTienCacMuc.Text = tong.ToString();
                double vat = (0.1 * tong);
                double tongtiennop = tong + vat;
                txtThueVAT.Text = vat.ToString();
                txtThanhTien.Text = tongtiennop.ToString();
            }
            if (Radio_DienKinhDoanh.Checked == true)
            {
                if (tg > 400) { m6 = tg - 400; tg = 400; }
                if (tg > 300) { m5 = tg - 300; tg = 300; }
                if (tg > 200) { m4 = tg - 200; tg = 200; }
                if (tg > 100) { m3 = tg - 100; tg = 100; }
                if (tg > 50) { m2 = tg - 50; tg = 50; }
                m1 = tg;
                tt1 = m1 * 1734;
                tt2 = m2 * 2014;
                tt3 = m3 * 2536;
                tt4 = m4 * 2834;
                tt5 = m5 * 2927;
                tt6 = m6 * 3120;
                double tong = tt1 + tt2 + tt3 + tt4 + tt5 + tt6;
                txtTongThanhTienCacMuc.Text = tong.ToString();
                double vat = (0.1 * tong);
                double tongtiennop = tong + vat;
                txtThueVAT.Text = vat.ToString();
                txtThanhTien.Text = tongtiennop.ToString();
            }
            double thanhtien = tt1 + tt2 + tt3 + tt4 + tt5 + tt6;
            txtTt1.Text = tt1.ToString();
            txtTt2.Text = tt2.ToString();
            txtTt3.Text = tt3.ToString();
            txtTt4.Text = tt4.ToString();
            txtTt5.Text = tt5.ToString();
            txtTt6.Text = tt6.ToString();
            /////
            txtSoDien1.Text = m1.ToString();
            txtSoDien2.Text = m2.ToString();
            txtSoDien3.Text = m3.ToString();
            txtSoDien4.Text = m4.ToString();
            txtSoDien5.Text = m5.ToString();
            txtSoDien6.Text = m6.ToString();
        }

        private void cmd_KetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Radio_DienSinhHoat_CheckedChanged(object sender, EventArgs e)
        {
            txtBac1.Text = "1678";
            txtBac2.Text = "1734";
            txtBac3.Text = "2014";
            txtBac4.Text = "2536";
            txtBac5.Text = "2834";
            txtBac6.Text = "2927";
        }

        private void Radio_DienKinhDoanh_CheckedChanged(object sender, EventArgs e)
        {
            txtBac1.Text = "1734";
            txtBac2.Text = "2014";
            txtBac3.Text = "2536";
            txtBac4.Text = "2834";
            txtBac5.Text = "2927";
            txtBac6.Text = "3120";
        }

        private void frmTinhTienDien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn kết thúc không?","Thông Báo",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                //Application.Exit();
                e.Cancel = true;
            }
        }
    }
}
