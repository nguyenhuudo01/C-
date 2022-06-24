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
    public partial class frmDoiMatKhau : Form
    {
        string sql;
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            txtTaiKhoan.Text = Public.TaiKhoan;
            txtHoTen.Text = Public.HoDem + " " + Public.Ten;
        }

        private void cmdDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.Text.ToUpper().Equals(Public.MatKhau.ToUpper()) == false)
            {
                MessageBox.Show("Bạn nhập mật khẩu cũ bị sai.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Focus();
                return;
            }
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
            if (MessageBox.Show("Bạn có muốn thay đổi mật khẩu không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            sql = "Update CanBo Set MatKhau='" + txtMatKhau1.Text + "' Where MaCB = '" + Public.MaCB + "'";
            if (Public.ThucHienSQL(sql) == true)
            {
                MessageBox.Show("Cập nhật mật khẩu mới thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Public.MatKhau = txtMatKhau1.Text;
                txtMatKhau.Text = ""; txtMatKhau1.Text = ""; txtMatKhau2.Text = "";
                txtMatKhau.Focus();
                return;
            }
        }

        private void cmdKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
