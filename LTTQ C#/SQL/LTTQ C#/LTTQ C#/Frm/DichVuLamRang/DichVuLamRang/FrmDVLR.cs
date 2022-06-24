using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DichVuLamRang
{
    public partial class FrmDVLR : Form
    {
        public FrmDVLR()
        {
            InitializeComponent();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void btn_TinhTien_Click(object sender, EventArgs e)
        {
            if (txtTenKH.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên khách hàng", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenKH.Focus();
                return;
            }
            double tong = 0;
            if (chkCaoVoi.Checked == true) tong = +100000 ;
            if (chkTayTrang.Checked == true) tong = +1200000;
            if (chkChupHinhRang.Checked == true) tong = +200000;
            int sl = (int)txtTramRang.Value;
            tong += sl * 80000;
            txtTong.Text = tong.ToString("0.0");
        }

        private void FrmDVLR_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn kết thúc không?", "Kết Thúc",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
