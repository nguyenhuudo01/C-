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
    public partial class FrmQLTaiKhoan : Form
    {
        public FrmQLTaiKhoan()
        {
            InitializeComponent();
            var daysOfWeek =
               new[] { "admin", "user" };
            comboBox1.DataSource = daysOfWeek;
        }
        DataBase dataBase = new DataBase();
        private void FrmQLTaiKhoan_Load(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = " MM / dd / yyyy ";
            dataBase.loaddatagridview(dataGridView1, "select * from tbuser", "pass");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                txtUser.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                txtPass.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                txtTen.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                //  txtQuyen.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();

                if (dataGridView1.Rows[i].Cells[2].Value.ToString().Trim().ToLower().Contains("admin"))
                {

                    comboBox1.SelectedIndex = 0;
                }
                else if (dataGridView1.Rows[i].Cells[2].Value.ToString().Trim().ToLower().Contains("user"))
                {
                    comboBox1.SelectedIndex = 1;

                }


                dateTimePicker1.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPass.Text = "";
            txtTen.Text = "";
            comboBox1.SelectedIndex = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var quyen = comboBox1.Text;
            try
            {
                dateTimePicker1.CustomFormat = "dd/MM/yyyy";
                string insert = "insert into tbuser values(N'" + txtUser.Text + "',N'" + txtPass.Text + "',N'" + quyen + "',N'" + txtTen.Text + "','" + dateTimePicker1.Text + "')";
                if (dataBase.kttrungkhoa(txtPass.Text, "select * from tbuser") == true)
                    MessageBox.Show("Tên đăng nhập này đã tồn tại. Bạn có thể thử tên khác");
                else
                {
                    dataBase.thucthiketnoi(insert);
                    MessageBox.Show("Chúc mừng bạn đã đăng kí thành công");
                    dataBase.loaddatagridview(dataGridView1, "select * from tbuser");
                    //this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var quyen = comboBox1.Text;
            try
            {
                string update = "update tbuser set Username=N'" + txtUser.Text + "',Pass=N'" + txtPass.Text + "',Quyen=N'" + quyen + "',Ten=N'" + txtTen.Text + "',Ngaysinh='" + dateTimePicker1.Text + "' where Username='" + txtUser.Text + "'";
                dataBase.thucthiketnoi(update);
                dataBase.loaddatagridview(dataGridView1, "select * from tbuser");
                MessageBox.Show("Sửa thành công");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text.Trim().ToLower().Contains("admin"))
            {
                MessageBox.Show("Không được xóa tài khoản admin");
            }
            else
            {
                string delete = "delete from tbuser where Username=N'" + txtPass.Text + "'";
                if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    dataBase.thucthiketnoi(delete);
                    dataBase.loaddatagridview(dataGridView1, "select * from tbuser");
                }
                MessageBox.Show("Đã xóa dữ liệu ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
