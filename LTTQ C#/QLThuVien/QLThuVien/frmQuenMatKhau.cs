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
    public partial class frmQuenMatKhau : Form
    {
        string email;
        public frmQuenMatKhau()
        {
            InitializeComponent();
        }

        private void cmdKetThuc1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cmdKetThuc2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cmdLayMa_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Bạn phải nhập email của tài khoản.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            if (Public.ktEmail(txtEmail.Text) == false)
            {
                MessageBox.Show("Bạn nhập email bị sai quy định.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            if (Public.ktTrungMa("Email", "CanBo", true, txtEmail.Text, "") == false)
            {
                MessageBox.Show("Bạn nhập sai email của cán bộ thư viện.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            cmdKiemTraOTP.Enabled = false;
            if (TaiKhoan.GuiOPTEmail(txtEmail.Text) == true)
            {
                email = txtEmail.Text;
                cmdLayMa.Enabled = false;
                cmdKiemTraOTP.Enabled = true;
            }

        }

        private void cmdKiemTraOTP_Click(object sender, EventArgs e)
        {
            if (txtOTP.Text == "" || Public.maOTP == "") return;
           
            if (Public.maOTP.Equals(txtOTP.Text))
            {
                grpLayOTP.Visible = false;
                grpDoiMatKhau.Visible = true;
                txtMatKhau1.Focus();
            }
            else
            {
                MessageBox.Show("Bạn nhập sai mã OPT.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOTP.Focus();
                return;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            cmdLayMa.Enabled = true;
        }

        private void cmdDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (txtMatKhau1.Text == "" || txtMatKhau2.Text == "")
            {
                MessageBox.Show("Bạn nhập chưa nhập đủ mật khẩu mới.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau1.Focus();
                return;
            }
            if (txtMatKhau1.Text.ToUpper().Equals(txtMatKhau2.Text.ToUpper()) == false)
            {
                MessageBox.Show("Bạn nhập mật khẩu mới không giống nhau.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau2.Focus();
                return;
            }
            if (MessageBox.Show("Bạn có muốn nhập mật khẩu mới không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            string sql = "Update CanBo Set MatKhau='" + txtMatKhau1.Text + "' Where Email = '" + email + "'";
            if (Public.ThucHienSQL(sql) == true)
            {
                MessageBox.Show("Cập nhật mật khẩu mới thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
        }
    }
}
