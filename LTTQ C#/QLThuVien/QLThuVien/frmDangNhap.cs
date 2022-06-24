using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVien
{
    public partial class frmDangNhap : Form
    {
        string sql;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void cmdDangNhap_Click(object sender, EventArgs e)
        {
            string un = txtTaiKhoan.Text.Trim().ToUpper();
            string pw = txtMatKhau.Text.Trim().ToUpper();
            sql = "Select * from CanBo Where TaiKhoan='" + un + "' and MatKhau='" + pw + "'";
            DataTable daTaiKhoan = Public.LayDuLieu(sql);
            if (daTaiKhoan.Rows.Count > 0)
            {
                Public.TaiKhoan = daTaiKhoan.Rows[0]["TaiKhoan"].ToString();
                Public.MatKhau = daTaiKhoan.Rows[0]["MatKhau"].ToString();
                Public.MaCB = daTaiKhoan.Rows[0]["MaCB"].ToString();
                Public.HoDem = daTaiKhoan.Rows[0]["HoDem"].ToString();
                Public.Ten = daTaiKhoan.Rows[0]["Ten"].ToString();
                if (chkLuuMatKhau.Checked == true)
                {
                    Properties.Settings.Default.UName = Public.TaiKhoan;
                    Properties.Settings.Default.PWord = Public.MatKhau;
                    Properties.Settings.Default.SaveUS = true;
                }
                else
                {
                    Properties.Settings.Default.UName = "";
                    Properties.Settings.Default.PWord = "";
                    Properties.Settings.Default.SaveUS = false;
                }
                Properties.Settings.Default.Save();
                this.Hide();
                MDIForm frm = new MDIForm();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn nhập sai tài khoản", "Thông Báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTaiKhoan.Focus();
            }
        }

        private void cmdKetThuc_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtTaiKhoan.Text = Properties.Settings.Default.UName;
            txtMatKhau.Text = Properties.Settings.Default.PWord;
            chkLuuMatKhau.Checked = Properties.Settings.Default.SaveUS;
        }

        private void cmdQuenMatKhau_Click(object sender, EventArgs e)
        {
            frmQuenMatKhau frm = new frmQuenMatKhau();
            frm.ShowDialog();            
        }
    }
}
