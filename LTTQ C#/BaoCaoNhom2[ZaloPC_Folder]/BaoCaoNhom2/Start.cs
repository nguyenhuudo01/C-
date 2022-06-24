using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaoCaoNhom2
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void designButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void designButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void designButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            else
                WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn thoát khỏi chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Thả chuột bắt đầu chụp bằng mouse down.
                pictureBox2.Capture = false;

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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            String tt = "";
            tt += "Phần mềm : Quản lý Khách sạn MIA \n";
            tt += "\n ";
            tt += "version : 1.1";
            tt += "\n\n";
            tt += "              _____________Bài tập lớn______________ ";
            tt += "\n\n\n";
            tt += " Trường Đại học Công Nghệ Giao Thông Vận Tải";
            tt += "\n";
            tt += " Lớp: 70DCTT21";
            tt += "\n";
            tt += " Học phần : Lập trình trực quan C#";
            tt += "\n";
            tt += "Nhóm thực hiện: Nhóm số II.";
            tt += "\n\n\nThành viên nhóm: ";
            tt += "\n         - Nhóm trưởng: Nguyễn Quang Bảo. ";
            tt += "\n         - Đội viên:    Phạm Đình Thắng. ";
            tt += "\n         - Đội viên:    Nguyễn Nghĩa Ninh. ";
            tt += "\n         - Đội viên:    Nguyễn Thị Thùy Duyên. ";


            MessageBox.Show("" + tt, "Thông tin phần mềm", MessageBoxButtons.OK);
        }

        
    }
}
