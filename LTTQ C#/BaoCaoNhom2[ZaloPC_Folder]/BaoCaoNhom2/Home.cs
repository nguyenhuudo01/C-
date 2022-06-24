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
    public partial class Home : Form
    {
        private string chucvu;
        private string ten;
        private string tk;
        public Home()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            pnTK.Visible = false;
            pnQuanLy.Visible = false;
            pnPhong.Visible = false;
            pnBaoCao.Visible = false;
        }

        
        

        //Hàm tạo truyền thông điệp là tên chức vụ và full name từ form login
        //truyền dữ liệu bằng contructor
        public Home(string Message,string Message2,string Message3) : this()
        {
            pnTK.Visible = false;
            pnQuanLy.Visible = false;
            pnPhong.Visible = false;
            pnBaoCao.Visible = false;
            chucvu = Message;
            lblChucVu.Text = chucvu;
            ten = Message2;
            lblTenUser.Text = ten;
            PhanQuyen(lblChucVu.Text.Trim());
            tk = Message3;
        }
        private void resetPhanQuyen()
        {
            btnTK.Enabled = true;
            btnQuanLyTK.Enabled = true;
            btnDoiMK.Enabled = true;
            btnDangXuat.Enabled = true;

            btnQuanLy.Enabled = true;
            btnQuanLyNV.Enabled = true;
            btnQuanLyKH.Enabled = true;
            btnQuanLyPhuThu.Enabled = true;
            btnQuanLyPhong.Enabled = true;
            btnQuanLySP.Enabled = true;
            btnQuanLyLoaiPhong.Enabled = true;
            btnQuanLyNhapKho.Enabled = true;
            btnQuanLyDV.Enabled = true;

            btnPhong.Visible = true;
            btnDatPhong.Enabled = true;
            btnThuePhong.Enabled = true;
            btnTraPhong.Enabled = true;

            BtnBaoCao.Visible = true;
            btnThongKeThuNhap.Enabled = true;
            btnThongKeNhapKho.Enabled = true;

            btnTT.Enabled = true;

            //Xóa icon
            btnQuanLyTK.Image = null;
            

            
            btnQuanLyNV.Image = null;
            btnQuanLyKH.Image = null;
            btnQuanLyPhuThu.Image = null;
            btnQuanLyPhong.Image = null;
            btnQuanLySP.Image = null;
            btnQuanLyLoaiPhong.Image = null;
            btnQuanLyNhapKho.Image = null;
            btnQuanLyDV.Image = null;

            
        }

        //Phân quyền
        private void PhanQuyen(String pq)
        {
            resetPhanQuyen();
            switch (pq)
            {
                case "[Admin]":
                    btnTK.Enabled = true;
                    btnQuanLyTK.Enabled = true;
                    btnDoiMK.Enabled = true;
                    btnDangXuat.Enabled = true;

                    btnQuanLy.Enabled = true;
                    btnQuanLyNV.Enabled = true;
                    btnQuanLyKH.Enabled = true;
                    btnQuanLyPhuThu.Enabled = false;
                    btnQuanLyPhuThu.Image = BaoCaoNhom2.Properties.Resources.baseline_lock_black_36dp;
                    btnQuanLyPhuThu.ImageAlign = ContentAlignment.MiddleRight;
                    btnQuanLyPhong.Enabled = true;
                    btnQuanLySP.Enabled = true;
                    btnQuanLyLoaiPhong.Enabled = true;
                    btnQuanLyNhapKho.Enabled = false;
                    btnQuanLyNhapKho.Image = BaoCaoNhom2.Properties.Resources.baseline_lock_black_36dp;
                    btnQuanLyNhapKho.ImageAlign = ContentAlignment.MiddleRight;
                    btnQuanLyDV.Enabled = true;

                    btnPhong.Visible = false;
                    btnDatPhong.Enabled = false;
                    btnThuePhong.Enabled = false;
                    btnTraPhong.Enabled = false;

                    BtnBaoCao.Visible = false;
                    btnThongKeThuNhap.Enabled = false;
                    btnThongKeNhapKho.Enabled = false;

                    btnTT.Enabled = true;
                    break;
                case "[Manager]":
                    btnTK.Enabled = true;
                    btnQuanLyTK.Enabled = false;
                    btnQuanLyTK.Image = BaoCaoNhom2.Properties.Resources.baseline_lock_black_36dp;
                    btnQuanLyTK.ImageAlign = ContentAlignment.MiddleRight;
                    btnDoiMK.Enabled = true;
                    btnDangXuat.Enabled = true;

                    btnQuanLy.Enabled = true;
                    btnQuanLyNV.Enabled = true;
                    btnQuanLyKH.Enabled = true;
                    btnQuanLyPhuThu.Enabled = false;
                    btnQuanLyPhuThu.Image = BaoCaoNhom2.Properties.Resources.baseline_lock_black_36dp;
                    btnQuanLyPhuThu.ImageAlign = ContentAlignment.MiddleRight;
                    btnQuanLyPhong.Enabled = false;
                    btnQuanLyPhong.Image = BaoCaoNhom2.Properties.Resources.baseline_lock_black_36dp;
                    btnQuanLyPhong.ImageAlign = ContentAlignment.MiddleRight;
                    btnQuanLySP.Enabled = false;
                    btnQuanLySP.Image = BaoCaoNhom2.Properties.Resources.baseline_lock_black_36dp;
                    btnQuanLySP.ImageAlign = ContentAlignment.MiddleRight;
                    btnQuanLyLoaiPhong.Enabled = false;
                    btnQuanLyLoaiPhong.Image = BaoCaoNhom2.Properties.Resources.baseline_lock_black_36dp;
                    btnQuanLyLoaiPhong.ImageAlign = ContentAlignment.MiddleRight;
                    btnQuanLyNhapKho.Enabled = true;
                    btnQuanLyDV.Enabled = false;
                    btnQuanLyDV.Image = BaoCaoNhom2.Properties.Resources.baseline_lock_black_36dp;
                    btnQuanLyDV.ImageAlign = ContentAlignment.MiddleRight;

                    btnPhong.Visible = false;
                    btnDatPhong.Enabled = false;
                    btnThuePhong.Enabled = false;
                    btnTraPhong.Enabled = false;

                    BtnBaoCao.Enabled = true;
                    btnThongKeThuNhap.Enabled = true;
                    btnThongKeNhapKho.Enabled = true;

                    btnTT.Enabled = true;
                    break;
                case "[Nhân Viên]":
                    btnTK.Enabled = true;
                    btnQuanLyTK.Enabled = false;
                    btnQuanLyTK.Image = BaoCaoNhom2.Properties.Resources.baseline_lock_black_36dp;
                    btnQuanLyTK.ImageAlign = ContentAlignment.MiddleRight;
                    btnDoiMK.Enabled = true;
                    btnDangXuat.Enabled = true;

                    btnQuanLy.Enabled = true;
                    btnQuanLyNV.Enabled = false;
                    btnQuanLyNV.Image = BaoCaoNhom2.Properties.Resources.baseline_lock_black_36dp;
                    btnQuanLyNV.ImageAlign = ContentAlignment.MiddleRight;
                    btnQuanLyKH.Enabled = true;
                    btnQuanLyPhuThu.Enabled = true;
                    btnQuanLyPhong.Enabled = false;
                    btnQuanLyPhong.Image = BaoCaoNhom2.Properties.Resources.baseline_lock_black_36dp;
                    btnQuanLyPhong.ImageAlign = ContentAlignment.MiddleRight;
                    btnQuanLySP.Enabled = false;
                    btnQuanLySP.Image = BaoCaoNhom2.Properties.Resources.baseline_lock_black_36dp;
                    btnQuanLySP.ImageAlign = ContentAlignment.MiddleRight;
                    btnQuanLyLoaiPhong.Enabled = false;
                    btnQuanLyLoaiPhong.Image = BaoCaoNhom2.Properties.Resources.baseline_lock_black_36dp;
                    btnQuanLyLoaiPhong.ImageAlign = ContentAlignment.MiddleRight;
                    btnQuanLyNhapKho.Enabled = false;
                    btnQuanLyNhapKho.Image = BaoCaoNhom2.Properties.Resources.baseline_lock_black_36dp;
                    btnQuanLyNhapKho.ImageAlign = ContentAlignment.MiddleRight;
                    btnQuanLyDV.Enabled = true;

                    btnPhong.Enabled = true;
                    btnDatPhong.Enabled = true;
                    btnThuePhong.Enabled = true;
                    btnTraPhong.Enabled = true;

                    BtnBaoCao.Visible = false;
                    btnThongKeThuNhap.Enabled = false;
                    btnThongKeNhapKho.Enabled = false;

                    btnTT.Enabled = true;
                    break;
            }
        }
        public void ShowMenu(Panel pn)
        {
            if (pn.Visible == false)
            {
                HideMenu();
                pn.Visible = true;
            }
            else
                pn.Visible = false;
        }
        public void HideMenu()
        {
            if (pnTK.Visible == true)
                pnTK.Visible = false;
            if (pnQuanLy.Visible == true)
                pnQuanLy.Visible = false;
            if (pnPhong.Visible == true)
                pnPhong.Visible = false;
            if (pnBaoCao.Visible == true)
                pnBaoCao.Visible = false;
        }
        

        private void btnTK_Click(object sender, EventArgs e)
        {
            ShowMenu(pnTK);
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            ShowMenu(pnQuanLy);
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            ShowMenu(pnPhong);
        }

        private void BtnBaoCao_Click(object sender, EventArgs e)
        {
            ShowMenu(pnBaoCao);
        }

        

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            
            colorButtonStart();
            btnDangXuat.BackColor = Color.FromArgb(0, 206, 209);
            this.Dispose();
            Login lg = new Login();
            lg.Show();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Thả chuột bắt đầu chụp bằng mouse down.
                pictureBox1.Capture = false;

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

        private Form actionForm = null;
        private void openChildForm(Form childForm)
        {
            if(actionForm != null)
            {
                actionForm.Close();
            }
            actionForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnChild.Controls.Add(childForm);
            pnChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        
        private void colorButtonStart()
        {
            btnQuanLyTK.BackColor = Color.FromArgb(0, 191, 255);
            btnDoiMK.BackColor = Color.FromArgb(0, 191, 255);
            btnDangXuat.BackColor = Color.FromArgb(0, 191, 255);
            btnQuanLyNV.BackColor = Color.FromArgb(0, 191, 255);
            btnQuanLyKH.BackColor = Color.FromArgb(0, 191, 255);
            btnQuanLyPhuThu.BackColor = Color.FromArgb(0, 191, 255);
            btnQuanLyPhong.BackColor = Color.FromArgb(0, 191, 255);
            btnQuanLySP.BackColor = Color.FromArgb(0, 191, 255);
            btnQuanLyLoaiPhong.BackColor = Color.FromArgb(0, 191, 255);
            btnQuanLyNhapKho.BackColor = Color.FromArgb(0, 191, 255);
            btnQuanLyDV.BackColor = Color.FromArgb(0, 191, 255);
            btnDatPhong.BackColor = Color.FromArgb(0, 191, 255);
            btnThuePhong.BackColor = Color.FromArgb(0, 191, 255);
            btnTraPhong.BackColor = Color.FromArgb(0, 191, 255);
            btnThongKeThuNhap.BackColor = Color.FromArgb(0, 191, 255);
            btnThongKeNhapKho.BackColor = Color.FromArgb(0, 191, 255);
        }
        private void btnQuanLyNV_Click(object sender, EventArgs e)
        {
            colorButtonStart();
            btnQuanLyNV.BackColor = Color.FromArgb(0,206,209);
            string cv = lblChucVu.Text;
            openChildForm(new frmQuanLyNV(cv));
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            else
                WindowState = FormWindowState.Maximized;
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            if (actionForm != null)
            {
                actionForm.Close();
            }
            colorButtonStart();
            btnDoiMK.BackColor = Color.FromArgb(0, 206, 209);
            frmRepass rp = new frmRepass(tk);
            rp.StartPosition = FormStartPosition.CenterScreen;
            rp.Show();
        }

        private void btnQuanLyKH_Click(object sender, EventArgs e)
        {
            colorButtonStart();
            btnQuanLyKH.BackColor = Color.FromArgb(0, 206, 209);
            openChildForm(new frmQuanLyKH(lblChucVu.Text));
        }

        private void btnQuanLyPhuThu_Click(object sender, EventArgs e)
        {
            colorButtonStart();
            btnQuanLyPhuThu.BackColor = Color.FromArgb(0, 206, 209);
            openChildForm(new PhuThu());
        }

        private void btnQuanLyPhong_Click(object sender, EventArgs e)
        {
            colorButtonStart();
            btnQuanLyPhong.BackColor = Color.FromArgb(0, 206, 209);
            openChildForm(new frmThongtinPhong());
        }

        private void btnQuanLySP_Click(object sender, EventArgs e)
        {
            colorButtonStart();
            btnQuanLySP.BackColor = Color.FromArgb(0, 206, 209);
            openChildForm(new SanPham());
        }

        private void btnQuanLyLoaiPhong_Click(object sender, EventArgs e)
        {
            colorButtonStart();
            btnQuanLyLoaiPhong.BackColor = Color.FromArgb(0, 206, 209);
            openChildForm(new frmLoaiPhong());
        }

        private void btnQuanLyNhapKho_Click(object sender, EventArgs e)
        {
            colorButtonStart();
            btnQuanLyNhapKho.BackColor = Color.FromArgb(0, 206, 209);
            openChildForm(new NhapKho());
        }

        private void btnQuanLyDV_Click(object sender, EventArgs e)
        {
            colorButtonStart();
            btnQuanLyDV.BackColor = Color.FromArgb(0, 206, 209);
            openChildForm(new frmDichVu());
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            colorButtonStart();
            btnDatPhong.BackColor = Color.FromArgb(0, 206, 209);
            openChildForm(new frmDatPhong());
        }

        private void btnThuePhong_Click(object sender, EventArgs e)
        {
            colorButtonStart();
            btnThuePhong.BackColor = Color.FromArgb(0, 206, 209);
            openChildForm(new frmThuePhong());
        }

        private void btnTraPhong_Click(object sender, EventArgs e)
        {
            colorButtonStart();
            btnTraPhong.BackColor = Color.FromArgb(0, 206, 209);
            openChildForm(new frmTraPhong());
        }

        private void btnThongKeThuNhap_Click(object sender, EventArgs e)
        {
            colorButtonStart();
            btnThongKeThuNhap.BackColor = Color.FromArgb(0, 206, 209);
            openChildForm(new DoanhThu());
        }

        private void btnThongKeNhapKho_Click(object sender, EventArgs e)
        {
            colorButtonStart();
            btnThongKeNhapKho.BackColor = Color.FromArgb(0, 206, 209);
            openChildForm(new ThongKeNhapKho());
        }

        private void btnQuanLyTK_Click(object sender, EventArgs e)
        {
            colorButtonStart();
            btnQuanLyTK.BackColor = Color.FromArgb(0, 206, 209);
            openChildForm(new frmQuanLyTK());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnTT_Click(object sender, EventArgs e)
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
