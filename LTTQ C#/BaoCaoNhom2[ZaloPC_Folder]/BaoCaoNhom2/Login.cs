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
    
    public partial class Login : Form
    {
        public static SqlConnection mycon;
        public static SqlCommand com;
        public static string full_name = "";
        public static int sate = 0, sai = 5;
        public static string pass = "";
        public Login()
        {
            InitializeComponent();
            txtTaiKhoan.Focus();
            lblErro.Text = "";
            txtMatKhau.PasswordChar = '●';
        }

        private void SaveMaHoaMK(string key)
        {
            string tk = txtTaiKhoan.Text.Trim();
            string mk = key;
            string mh = BaoCaoNhom2.MD5.MaHoa(key);
            string sqlSave = "Insert into MaHoa (Matkhau, Mahoa) values(N'"+ txtMatKhau.Text+ "','" + mh + "' )";
            
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
            string tk1 = txtTaiKhoan.Text.Trim();
            string mahoa1 = BaoCaoNhom2.MD5.MaHoa(txtMatKhau.Text.Trim());
            if (cboRemember.Checked == true && Doc_ghi_file.kiemtra(tk1) == false)
                BaoCaoNhom2.Doc_ghi_file.Ghi_file(tk1, mahoa1);
        }

        private void txtMK_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void txtMatKhau_Click(object sender, EventArgs e)
        {
            
        }
        private void cboRemember_Click(object sender, EventArgs e)
        {
            string tk = txtTaiKhoan.Text.Trim();
            if (cboRemember.Checked == true)
            {
                string mh = BaoCaoNhom2.Doc_ghi_file.doc_file(tk);
                string sqlmk = "Select * from MaHoa where Mahoa='" + mh + "'";
                SqlConnection conn = new SqlConnection(KetnoiDataBase.sqlcon);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlmk, conn);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    txtMatKhau.Text = dr["Matkhau"].ToString();
                }
                conn.Close();

            }
            else
                txtMatKhau.Text = "";

        }
        private void cboRemember_CheckedChanged(object sender, EventArgs e)
        {

            


        }


        private void designButton1_Click(object sender, EventArgs e)
        {
            //string tk2 = txtTaiKhoan.Text.Trim();
            //string mahoa2 = BaoCaoNhom2.MD5.MaHoa(txtMatKhau.Text.Trim());
            //BaoCaoNhom2.Doc_ghi_file.Ghi_file(tk2, mahoa2);



            
                          
            


            try
            {
                

                




                //Số lượng tài khoản có quyền số 1 _ Admin
                string sql1 = "Select count(*) from DangNhap where Taikhoan='" + txtTaiKhoan.Text.Trim()
                                + "' and Matkhau='" + txtMatKhau.Text.Trim() + "' and phanquyen = 1  ";

                //Số lượng tài khoản có quyền số 2 _ quản lý
                string sql2 = "Select count(*) from DangNhap where Taikhoan ='" + txtTaiKhoan.Text
                                + "'and Matkhau ='" + txtMatKhau.Text + "' and phanquyen = 2  ";

                //Số lượng tài khoản có quyền số 3 _ nhân viên
                string sql3 = "Select count(*) from DangNhap where Taikhoan='" + txtTaiKhoan.Text
                    + "' and Matkhau ='" + txtMatKhau.Text + "' and phanquyen = 3  ";

                //lấy tên đầy đủ của user
                string chuoi4 = "Select FullName from DangNhap where Taikhoan ='" + txtTaiKhoan.Text.Trim() + "'";

                //Lấy trạng thái của tài khoản
                string chuoi5 = "Select trangthai from DangNhap where Taikhoan ='" + txtTaiKhoan.Text.Trim() + "'";

                string sql4 = "Select count(*)from DangNhap where Taikhoan ='" + txtTaiKhoan.Text.Trim() + "'";
                mycon = new SqlConnection(KetnoiDataBase.sqlcon);
                mycon.Open();

                //executescalar trả về cột đầu của hàng đầu trong tập kết quả trả về của câu lệnh
                

                //Kiểm tra xem mật khẩu của tài khoàn này đã từng được mã hóa chưa
                int f = 0;
                string sql5 = "Select count(*)from MaHoa where Matkhau ='" + txtMatKhau.Text.Trim() + "'";
                SqlCommand com5 = new SqlCommand(sql5, mycon);
                f = (int)com5.ExecuteScalar();
                if (cboRemember.Checked == true)
                {
                    if (f == 0)
                        SaveMaHoaMK(txtMatKhau.Text.Trim());
                    else {
                        
                    }
                }
                else {
                    lblErro.Text = "";
                }

                int d = 0;
                //a là số tài khoản có quyền 1(admin)
                SqlCommand com4 = new SqlCommand(sql4, mycon);
                d = (int)com4.ExecuteScalar();
                //Kiểm tra đã điền tài khoản hoặc mật khẩu chưa
                if (txtTaiKhoan.Text == "")
                {
                    lblErro.Text = "Bạn chưa nhập tên tài khoản!!! ";
                }
                else if (d == 0)
                    lblErro.Text = "Tên tài khoản sai! Vui lòng nhập lại.";
                else if (txtMatKhau.Text == "")
                    lblErro.Text = "Bạn chưa nhập Mật khẩu!!!  ";
                else
                {
                    lblErro.Text = "";
                    //Sai là số lần đăng nhập có thể được sai mk(ban đầu là 5 lần)
                    if (sai > 0)
                    {

                        int a = 0, b = 0, c = 0;
                        mycon = new SqlConnection(KetnoiDataBase.sqlcon);
                        mycon.Open();

                        //executescalar trả về cột đầu của hàng đầu trong tập kết quả trả về của câu lệnh

                        //a là số tài khoản có quyền 1(admin)
                        com = new SqlCommand(sql1, mycon);
                        a = (int)com.ExecuteScalar();

                        //b là số tài khoản có quyền 2(quản lý)
                        SqlCommand com1 = new SqlCommand(sql2, mycon);
                        b = (int)com1.ExecuteScalar();

                        //c là số tài khoản có quyền 3(nhân viên)
                        SqlCommand com2 = new SqlCommand(sql3, mycon);
                        c = (int)com2.ExecuteScalar();

                        //Nếu số tài khoản quyền admin trùng tên và mật khẩu vừa nhập > 0(tài khoản vừa nhập là của admin)
                        if (a > 0)
                        {
                            //check_key trong ketnoidatabase trả về trạng thái của tài khoản vừa nhập
                            int trangthai = KetnoiDataBase.check_key(chuoi5, sate);

                            if (trangthai == 0)
                            {
                                lblErro.Text = "Tài khoản của bạn đang bị khóa ";
                            }
                            else
                            {

                                SaveMaHoaMKFile();
                                //Lấy ra tên của tài khoản
                                string tendaydu = KetnoiDataBase.load(chuoi4, full_name);
                                MessageBox.Show("Ban dang nhap vao tai khoan Admin", "Thong bao ", MessageBoxButtons.OK);
                                string chucvu = "[Admin]";
                                string ten = tendaydu;
                                string tk = txtTaiKhoan.Text.Trim();
                                this.Dispose();
                                //truyền dữ liệu bằng contructor
                                Home h1 = new Home(chucvu, tendaydu,tk);
                                h1.Show();
                                sai = 5;
                            }
                        }
                        //Nếu số tài khoản quyền quản lý trùng tên và mật khẩu vừa nhập > 0(tài khoản vừa nhập là của quản lý)
                        else if (b > 0)
                        {
                            //check_key trong ketnoidatabase trả về trạng thái của tài khoản vừa nhập
                            int trangthai = KetnoiDataBase.check_key(chuoi5, sate);
                            if (trangthai == 0)
                            {
                                lblErro.Text = "Tài khoản của bạn đang bị khóa ";
                            }
                            else
                            {

                                SaveMaHoaMKFile();
                                //Lấy ra tên của tài khoản
                                string tendaydu = KetnoiDataBase.load(chuoi4, full_name);
                                MessageBox.Show("Ban dang nhap vao tai khoan Quản lý", "Thong bao ", MessageBoxButtons.OK);
                                string chucvu = "[Manager]";
                                string ten = tendaydu;
                                this.Dispose();
                                //truyền dữ liệu bằng contructor
                                string tk = txtTaiKhoan.Text.Trim();
                                Home h1 = new Home(chucvu, tendaydu,tk);
                                h1.Show();
                                sai = 5;
                            }
                        }
                        else if (c > 0)
                        {
                            int trangthai = KetnoiDataBase.check_key(chuoi5, sate);
                            if (trangthai == 0)
                            {
                                lblErro.Text = "Tài khoản của bạn đang bị khóa ";
                            }
                            else
                            {
                                SaveMaHoaMKFile();
                                //Lấy ra tên của tài khoản
                                string tendaydu = KetnoiDataBase.load(chuoi4, full_name);
                                MessageBox.Show("Ban dang nhap vao tai khoan Nhân viên", "Thong bao ", MessageBoxButtons.OK);
                                string chucvu = "[Nhân Viên]";
                                string ten = tendaydu;
                                this.Dispose();
                                //truyền dữ liệu bằng contructor
                                string tk = txtTaiKhoan.Text.Trim();
                                Home h1 = new Home(chucvu, tendaydu,tk);
                                h1.Show();
                                sai = 5;
                            }

                        }
                        //Nếu ko tìm thấy tài khoản nào trong sql trùng tài khoản vừa nhập
                        if (a == 0 && b == 0 && c == 0)
                        {
                            sai--;
                            string t = ("Username hoặc password sai!!! 5 lần sai liên tiếp sẽ bị khóa tài khoản.\n Bạn còn " + sai + " lần đăng nhập");
                            MessageBox.Show((t), "thông báo", MessageBoxButtons.OK);
                            txtTaiKhoan.Text = "";
                            txtMatKhau.Text = "";
                            txtTaiKhoan.Focus();
                        }
                    }
                    else
                    {

                        int trangthai = 0;
                        string sql = "Update DangNhap set trangthai='" + trangthai + "'  where Taikhoan = '" + txtTaiKhoan.Text + "'";

                        //truyền lệnh vào hàm rekey trong kenoidatabase để update trạng thái thành bị khóa (0)
                        KetnoiDataBase.Rekey(sql);
                        MessageBox.Show("Do đăng nhập sai quá nhiều lần , tài khoản bạn đã bị khóa!\n Vui lòng liên lạc với ADMIN để mở tài khoản!!! ", "Thông báo", MessageBoxButtons.OK);

                        sai = 5;
                    }
                }
            }
            catch (Exception ex)
            {
                lblErro.Text = ex.Message;
            }
        
        //this.Dispose();
        //Home home = new Home();
        //home.Size = new System.Drawing.Size(1433,653);

        //home.Show();
    }

        private void designButton2_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn quay lại giao diện bắt đầu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                this.Dispose();
                Start s = new Start();
                //s.Size = new System.Drawing.Size(1433,653);

                s.ShowDialog();
            }
        }

       

        private void ptbAn_Click_1(object sender, EventArgs e)
        {
            if (txtMatKhau.UseSystemPasswordChar == false)
                txtMatKhau.UseSystemPasswordChar = true;
            else
                txtMatKhau.UseSystemPasswordChar = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblQuen_Click(object sender, EventArgs e)
        {
            String tt = "";
            tt += "Phần mềm : Quản lý Khách sạn MIA \n";
            tt += "version : 1.1";
            tt += "\n";
            tt += "              _____________________________________ ";
            tt += "\n\n";
            tt += " Hãy liên hệ với Admin để lấy lại mật khẩu qua link sau:";
            tt += "\n\n         https://www.facebook.com/adminQLKS ";
            tt += "\n\n Chọn [OK] để có thể lập tức truy cập vào link trên!!!! ";

            if (MessageBox.Show(tt, "Quên mật khẩu? ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                System.Diagnostics.Process.Start("https://www.facebook.com/adminQLKS");
            }
            
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
    }
}
