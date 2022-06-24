using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QLNS_NHOM1
{
    public partial class FrmDoiMatKhau : Form
    {
        public FrmDoiMatKhau()
        {
            InitializeComponent();
        }
        public FrmDoiMatKhau(string username)
        {
            InitializeComponent();
            txtUser.Text = username;
        }
        DataBase dataBase = new DataBase();
        private void FrmDoiMatKhau_Load(object sender, EventArgs e)
        {
            txtUser.Text = Public.un;
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            string update = "update tbuser set Pass='" + txtPassNew.Text + "' where(Username=N'" + txtUser.Text + "' and Pass='" + txtPass.Text + "')";
            string ten = txtUser.Text;
            if (ten == "")
            {
                MessageBox.Show("Bạn chưa nhập tên truy cập");
            }
            else
            {
                if (txtPass.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mật khẩu");
                }
                else
                {
                    if (txtPassNew.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập mật khẩu mới");
                    }
                    else
                    {
                        if (txtPassUpdate.Text == "")
                        {
                            MessageBox.Show("Bạn chưa nhập lại mật khẩu");
                        }
                        else
                        {
                            if (txtPassNew.Text == txtPassUpdate.Text)
                            {
                                dataBase.thucthiketnoi(update);
                                MessageBox.Show("Bạn đã thay đổi mật khẩu thành công");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Bạn nhập lại mật khẩu không đúng");
                            }
                        }
                    }
                }
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if ((ctr is TextBox) || (ctr is DateTimePicker))
                {
                    ctr.Text = "";
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
