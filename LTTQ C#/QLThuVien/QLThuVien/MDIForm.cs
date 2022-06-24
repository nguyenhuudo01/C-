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
    public partial class MDIForm : Form
    {
        bool ktDangXuat = false;
        public MDIForm()
        {
            InitializeComponent();
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            ktDangXuat = true;
            frmDangNhap frm = new frmDangNhap();
            frm.Show();
            this.Close();
        }

        private void mnuDoiMatKhau_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frm = new frmDoiMatKhau();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MDIForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ktDangXuat == false) Application.Exit();
        }

        private void MDIForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ktDangXuat == false)
            {
                if (MessageBox.Show("Bạn có muốn kết thúc không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    e.Cancel = true;
            }
        }

        private void mnuQLCanBo_Click(object sender, EventArgs e)
        {
            frmCanBo frm = new frmCanBo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuQLDocGia_Click(object sender, EventArgs e)
        {
            frmDocGia frm = new frmDocGia();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuChuyenMuc_Click(object sender, EventArgs e)
        {
            frmChuyenMuc frm = new frmChuyenMuc();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuTacGia_Click(object sender, EventArgs e)
        {
            frmTacGia frm = new frmTacGia();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuNXB_Click(object sender, EventArgs e)
        {
            frmNhaXB frm = new frmNhaXB();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuSach_Click(object sender, EventArgs e)
        {
            frmSach frm = new frmSach();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuLapPhieuMuon_Click(object sender, EventArgs e)
        {
            frmPhieuMuon frm = new frmPhieuMuon();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuQuanLyPhieu_Click(object sender, EventArgs e)
        {
            frmQLPhieu frm = new frmQLPhieu();
            frm.MdiParent = this;
            frm.Show();
        }

        private void MDIForm_Load(object sender, EventArgs e)
        {
            Public.checkFolder();
            Phieu.checkMauPhieu();
        }

        private void mnuTKNgayHenTra_Click(object sender, EventArgs e)
        {
            frmTKNgayHenTra frm = new frmTKNgayHenTra();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuTKDocGia_Click(object sender, EventArgs e)
        {
            frmTKDocGia frm = new frmTKDocGia();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
