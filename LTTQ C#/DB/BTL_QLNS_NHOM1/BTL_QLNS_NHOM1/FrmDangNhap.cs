using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
namespace BTL_QLNS_NHOM1
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }
        DataBase dataBase = new DataBase();
        private SqlConnection Con = null;
        public static string quyen;

        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            if (txtUser.Text.Trim().Length == 0 || txtPass.Text.Trim().Length == 0)
            {
                MessageBox.Show("Đăng nhập thất bại bạn nhập user name hoặc password!", "Thông báo !");
            }
            else
            {
                Con = new SqlConnection();
                Con.ConnectionString = @"Data Source=DESKTOP-7FA0GLO\SQLBAO;Initial Catalog=QLNS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                Con.Open();
                string select = "Select * From tbuser where Username='" + txtUser.Text + "' and Pass='" + txtPass.Text + "' ";
                SqlCommand cmd = new SqlCommand(select, Con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    string quyen = null;
                    while (reader.Read())
                    {
                        quyen = reader[3].ToString();
                    }

                    if (quyen.Contains("admin"))
                    {
                        reader.Read();
                        MessageBox.Show("Đăng nhập vào hệ thống (Quyền Admin) !", "Thông báo !");
                        MDIMain.quyen = "Admin";
                        this.Hide();
                        this.Close();
                    }
                    else if (quyen.Contains("user"))
                    {
                        MessageBox.Show("Đăng nhập vào hệ thống (Quyền user) !", "Thông báo !");
                        MDIMain.quyen = "user";
                        this.Hide();
                        this.Close();
                    }
                    Public.un = txtUser.Text;
                    Public.pw = txtPass.Text;
                    this.Hide();
                    MDIMain frmMain = new MDIMain();
                    frmMain.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại bạn kiểm tra mật khẩu!", "Thông báo !");
                }
            }
        }
    }
}
