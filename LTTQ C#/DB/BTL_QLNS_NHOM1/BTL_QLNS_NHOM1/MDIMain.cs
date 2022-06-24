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
    public partial class MDIMain : Form
    {
        public MDIMain()
        {
            InitializeComponent();
        }

        private void mnuPhongBan_Click(object sender, EventArgs e)
        {
            FrmPhongBan fpb = new FrmPhongBan();
           // panel_show.Show();
            //panel_show.Controls.Clear();
            //fpb.TopLevel = false;
            //fpb.Dock = DockStyle.Fill;
            //panel_show.Controls.Add(fpb);
            fpb.Show();
        }

        private void mnuLuong_Click(object sender, EventArgs e)
        {
            FrmLuong fluong = new FrmLuong();
            //panel_show.Show();
           // panel_show.Controls.Clear();
           // fluong.TopLevel = false;
           // fluong.Dock = DockStyle.Fill;
            //panel_show.Controls.Add(fluong);
            fluong.Show();
        }

        private void mnuThongTinCaNhan_Click(object sender, EventArgs e)
        {
            FrmThongTinCaNhan fThongTinCaNhan = new FrmThongTinCaNhan();
            //panel_show.Show();
           // panel_show.Controls.Clear();
           // fThongTinCaNhan.TopLevel = false;
          //  fThongTinCaNhan.Dock = DockStyle.Fill;
          //  panel_show.Controls.Add(fThongTinCaNhan);
            fThongTinCaNhan.Show();
        }

        private void mnuTroGiup_Click(object sender, EventArgs e)
        {
            FrmTroGiup fTroGiup = new FrmTroGiup();
            //panel_show.Show();
          //  panel_show.Controls.Clear();
            //fTroGiup.TopLevel = false;
            //fTroGiup.Dock = DockStyle.Fill;
            //panel_show.Controls.Add(fTroGiup);
            fTroGiup.Show();
        }
        private void mnuTimKiem_Click(object sender, EventArgs e)
        {
            FrmTimKiem fTimkiem = new FrmTimKiem();
           // panel_show.Show();
           // panel_show.Controls.Clear();
           // fTimkiem.TopLevel = false;
           // fTimkiem.Dock = DockStyle.Fill;
           // panel_show.Controls.Add(fTimkiem);
            fTimkiem.Show();
        }
        private void mnuCheDo_Click(object sender, EventArgs e)
        {
            FrmCheDo fCheDo = new FrmCheDo();
           // panel_show.Show();
           // panel_show.Controls.Clear();
           // fCheDo.TopLevel = false;
            //fCheDo.Dock = DockStyle.Fill;
            //panel_show.Controls.Add(fCheDo);
            fCheDo.Show();
        }
        private void mnuThongTinCoBan_Click(object sender, EventArgs e)
        {
            FrmThongTinCoBan fTTCoBan = new FrmThongTinCoBan();
            //panel_show.Show();
            //panel_show.Controls.Clear();
          //  fTTCoBan.TopLevel = false;
           // fTTCoBan.Dock = DockStyle.Fill;
          //  panel_show.Controls.Add(fTTCoBan);
            fTTCoBan.Show();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void mnuQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            FrmQLTaiKhoan fQLyTaiKhoan = new FrmQLTaiKhoan();
            //panel_show.Show();
           // panel_show.Controls.Clear();
          //  fQLyTaiKhoan.TopLevel = false;
           // fQLyTaiKhoan.Dock = DockStyle.Fill;
           // panel_show.Controls.Add(fQLyTaiKhoan);
            fQLyTaiKhoan.Show();
        }
        private void mnuDoiMatKhau_Click(object sender, EventArgs e)
        {
            FrmDoiMatKhau fDoiMatKhau = new FrmDoiMatKhau();
          //  panel_show.Show();
          //  panel_show.Controls.Clear();
          //  fDoiMatKhau.TopLevel = false;
          //  fDoiMatKhau.Dock = DockStyle.Fill;
          //  panel_show.Controls.Add(fDoiMatKhau);
            fDoiMatKhau.Show();
        }
        private void mnuDangNhap_Click(object sender, EventArgs e)
        {
            FrmDangNhap fDangNhap = new FrmDangNhap();
            fDangNhap.Show();
        }
        public static string quyen;

        private void MDIMain_Load(object sender, EventArgs e)
        {
            
            if (quyen == "Admin")
            {
                menuItemQuanLy.Enabled = true;
                menuItemDanhMuc.Enabled = true;
                menuItemTaiKhoan.Enabled = true;
                mnuCheDo.Enabled = true;
                mnuTimKiem.Enabled = true;
                mnuTroGiup.Enabled = true;
                mnuThoat.Enabled = true;
            }
            else if (quyen == "user")
            {
                menuItemQuanLy.Enabled = true;
                menuItemDanhMuc.Enabled = true;
                menuItemTaiKhoan.Enabled = false;
                mnuCheDo.Enabled = true;
                mnuTimKiem.Enabled = true;
                mnuTroGiup.Enabled = true;
                mnuThoat.Enabled = true;
            }
           
            }

        private void mnuBoPhan_Click(object sender, EventArgs e)
        {
            FrmBoPhan fBoPhan = new FrmBoPhan();
            fBoPhan.Show();
        }

        private void mnuHoSoThuViec_Click(object sender, EventArgs e)
        {
            FrmHoSoThuViec fHoSoThuViec = new FrmHoSoThuViec();
            fHoSoThuViec.Show();
        }

        private void mnuBangLuong_Click(object sender, EventArgs e)
        {
            FrmBangCong fBangCong = new FrmBangCong();
            fBangCong.Show();
        }


        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmDangNhap fDangNhap = new FrmDangNhap();
            fDangNhap.Show();
        }

        private void MDIMain_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
   }
