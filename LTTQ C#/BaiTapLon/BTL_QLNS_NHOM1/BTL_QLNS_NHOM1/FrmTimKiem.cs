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
    public partial class FrmTimKiem : Form
    {
        public FrmTimKiem()
        {
            InitializeComponent();
        }
        DataBase dataBase = new DataBase();
        private void FrmTimKiem_Load(object sender, EventArgs e)
        {
            rdMaNV.Checked = true;
            dataBase.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan");
            thongBao();
        }
        int i = 0;
       
        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtNhap.Text == "") || (txtNhap.Text == "Nhập vào từ khóa tìm kiếm"))
                {
                    MessageBox.Show("bạn chưa nhập tù khóa", "Nhập từ khóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    if (i == 1)
                    {
                        dataBase.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan where MaNV=N'" + txtNhap.Text + "'");
                    }
                    if (i == 2)
                    {
                        dataBase.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan where HoTen=N'" + txtNhap.Text + "'");
                    }
                    if (i == 3)
                    {
                        dataBase.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan where CMTND=N'" + txtNhap.Text + "'");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Tìm kiếm sai");
            }
            thongBao();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void thongBao()
        {
            if (dataGridView1.RowCount > 0)
                lblThongBao.Text = "Danh sách có " + dataGridView1.RowCount + " dòng.";
            else
                lblThongBao.Text = "";
        }
        private void txtNhap_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if ((txtNhap.Text == "") || (txtNhap.Text == "Nhập vào từ khóa tìm kiếm"))
                {
                    dataBase.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan");
                }
                else
                {

                    if (i == 1)
                    {
                        dataBase.loatextbox(txtNhap, "select * from TblTTNVCoBan where MaNV like N'" + txtNhap.Text + "%'", 2);
                        dataBase.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan where MaNV like N'" + txtNhap.Text + "%'");
                    }
                    if (i == 2)
                    {
                        dataBase.loatextbox(txtNhap, "select * from TblTTNVCoBan where MaNV like N'" + txtNhap.Text + "%'", 3);
                        dataBase.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan where HoTen like N'" + txtNhap.Text + "%'");
                    }
                    if (i == 3)
                    {
                        dataBase.loatextbox(txtNhap, "select * from TblTTNVCoBan where MaNV like N'" + txtNhap.Text + "%'", 8);
                        dataBase.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan where CMTND like N'" + txtNhap.Text + "%'");
                    }
                }
            }
            catch
            {
                MessageBox.Show("tìm kiếm sai");
            }
            thongBao();
        }

        private void rdMaNV_CheckedChanged(object sender, EventArgs e)
        {
            i = 1;
            thongBao();
        }

        private void rdHoTen_CheckedChanged(object sender, EventArgs e)
        {
            i = 2;
            thongBao();
        }

        private void rdCMTND_CheckedChanged(object sender, EventArgs e)
        {
            i = 3;
            thongBao();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount <= 0) return;
            if (MessageBox.Show("Bạn có muốn xuất danh sách ra excel không?", "Thông Báo",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            DataBase.XuatFileExcel(dataGridView1, "TimKiem.xls");
        }
    }
}
