using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaoCaoNhom2
{
    public partial class frmRepass : Form
    {
        public static SqlConnection mycon;
        private string tk1;
        public frmRepass()
        {
            InitializeComponent();
            txtOPass.Focus();
            lblErro.Text = "";
            txtOPass.PasswordChar = '●';
            txtNPass.PasswordChar = '●';
            txtNhapLai.PasswordChar = '●';
        }
        public frmRepass(string tk) : this()
        {
            txtOPass.Focus();
            lblErro.Text = "";
            txtOPass.PasswordChar = '●';
            txtNPass.PasswordChar = '●';
            txtNhapLai.PasswordChar = '●';
            tk1 = tk;
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void ptbAn_Click(object sender, EventArgs e)
        {
            if (txtOPass.UseSystemPasswordChar == false)
            {
                txtOPass.UseSystemPasswordChar = true;
                txtNPass.UseSystemPasswordChar = true;
                txtNhapLai.UseSystemPasswordChar = true;
            }
            else
            {
                txtOPass.UseSystemPasswordChar = true;
                txtNPass.UseSystemPasswordChar = true;
                txtNhapLai.UseSystemPasswordChar = true;
            }
        }
        private void SaveMaHoaMK(string key)
        {
            string mk = key;
            string mh = BaoCaoNhom2.MD5.MaHoa(key);
            string sqlSave = "Insert into MaHoa (Matkhau, Mahoa) values(N'" + mk + "','" + mh + "' )";

            try
            {
                SqlConnection conn = new SqlConnection(KetnoiDataBase.sqlcon);
                conn.Open();

                SqlCommand cmd = new SqlCommand(sqlSave, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "" + ex);
            }
        }

        private void SaveMaHoaMKFile()
        {
            //Kiem tra mật khau mã hóa đã có trong file chưa
            string filePath = @"D:/matkhau.txt";
            if (!File.Exists(filePath))
            {
                File.Create(filePath);
            }
            string mahoa = "";
            string tk1 = txtNPass.Text.Trim();
            string mahoa1 = BaoCaoNhom2.MD5.MaHoa(txtNPass.Text.Trim());
            if (cboRemember.Checked == true && Doc_ghi_file.kiemtra(tk1) == false)
                BaoCaoNhom2.Doc_ghi_file.Ghi_file(tk1, mahoa1);
        }
        private void btnChange_Click(object sender, EventArgs e)
        {
            
            //Kiểm tra đã điền tài khoản hoặc mật khẩu chưa
            if (txtOPass.Text == "")
            {
                lblErro.Text = "Bạn chưa nhập mật khẩu cũ!!! ";
            }
            else if (txtNPass.Text == "")
                lblErro.Text = "Bạn chưa nhập mật khẩu mới!!! ";
            else if (txtNhapLai.Text == "")
                lblErro.Text = "Bạn chưa nhập lại mật khẩu mới!!! ";
            else if (txtOPass.Text == txtNPass.Text)
                lblErro.Text = "Mật khẩu mới trung với mật khẩu cũ!!! ";
            else if (txtNhapLai.Text != txtNPass.Text)
                lblErro.Text = "Bạn nhập lại sai mật khẩu mới!!! ";
            else
            {
                lblErro.Text = "";
                string mk = "";
                string sqlmk = "Select * from DangNhap where Taikhoan='" + tk1 + "'";
                SqlConnection conn = new SqlConnection(KetnoiDataBase.sqlcon);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlmk, conn);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                   mk = dr["Matkhau"].ToString();
                }
                conn.Close();
                if (txtOPass.Text == mk)
                {
                    string sql = "Update DangNhap set Matkhau = N'" + txtNPass.Text.Trim() +"'"+
                    "where Taikhoan = '" + tk1 + "'";
                    
                        KetnoiDataBase.Sua(sql);
                    mycon = new SqlConnection(KetnoiDataBase.sqlcon);
                    mycon.Open();
                    //Kiểm tra xem mật khẩu của tài khoàn này đã từng được mã hóa chưa
                    int f = 0;
                    string sql5 = "Select count(*)from MaHoa where Matkhau ='" + txtNPass.Text.Trim() + "'";
                    SqlCommand com5 = new SqlCommand(sql5, mycon);
                    f = (int)com5.ExecuteScalar();
                    if (cboRemember.Checked == true)
                    {
                        if (f == 0)
                            SaveMaHoaMK(txtNPass.Text.Trim());
                        
                    }
                    
                    //Kiem tra mật khau mã hóa đã có trong file chưa
                    string filePath = @"D:/matkhau.txt";
                    if (!File.Exists(filePath))
                    {
                        File.Create(filePath);
                    }
                    string mahoa1 = BaoCaoNhom2.MD5.MaHoa(txtNPass.Text.Trim());
                    if (cboRemember.Checked == true)
                            BaoCaoNhom2.Doc_ghi_file.Ghi_de_file(tk1, mahoa1);
                    if (MessageBox.Show("Bạn sẽ quay về Home!!! ", "Thông báo ", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        this.Dispose();
                    }
                        
                    
                   
                }
                else
                    lblErro.Text = "Bạn đã nhập sai mật khẩu cũ!!!";
            }
        }

        private void lblKeo_Click(object sender, EventArgs e)
        {

        }

        private void lblKeo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Thả chuột bắt đầu chụp bằng mouse down.
                lblKeo.Capture = false;

                // Tạo và gửi một WM_NCLBUTTONDOWN message.
                // WM_NCLBUTTONDOWN message: Được đăng khi người dùng nhấn nút chuột trái trong khi con trỏ ở trong vùng không phải của cửa sổ.
                //Thông báo này được đăng lên cửa sổ có chứa con trỏ.
                //Nếu một cửa sổ đã bắt được chuột, thông báo này sẽ không được đăng.
                const int WM_NCLBUTTONDOWN = 0x00A1;
                const int HTCAPTION = 2;
                Message msg = Message.Create(this.Handle, WM_NCLBUTTONDOWN,
                        new IntPtr(HTCAPTION), IntPtr.Zero);
                //Sau khi tạo mess, ta gửi nó đến window procedure mặc định
                this.DefWndProc(ref msg);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn thoát đổi mật khẩu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                this.Dispose();
                
            }
        }
    }
}
