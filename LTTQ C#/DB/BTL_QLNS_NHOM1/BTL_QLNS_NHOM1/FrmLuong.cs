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
    public partial class FrmLuong : Form
    {
        public FrmLuong()
        {
            InitializeComponent();
        }
        DataBase dataBase = new DataBase();
        DataSet ds1 = new DataSet();
        
        private void FrmLuong_Load(object sender, EventArgs e)
        {
            dtNgayTang.CustomFormat = " MM / dd / yyyy ";
            dtNgayNhap.CustomFormat = " MM / dd / yyyy ";
            dtNgaySua.CustomFormat = " MM / dd / yyyy ";
            dtNgaySuaPhuCap.CustomFormat = " MM / dd / yyyy ";
            DataSet ds1 = new DataSet();
            dataBase.loaddatagridview(dataGridView1, "select * from TblBangLuongCTy");
            dataBase.loaddatagridview1(dataGridView2, ds1, "select * from TblTangLuong");
            dataBase.loadcombobox(cbMaNV, "select * from TblTTNVCoBan", 2);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtMaLuong.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtLCB.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtPhuCapChucVu.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            dtNgayNhap.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtLCBMoi.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            dtNgaySua.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            txtLyDo.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            txtPhuCapChucVuMoi.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            dtNgaySuaPhuCap.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
            txtGhiChu.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();
        }
        private void btnMoi1_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if ((ctr is TextBox) || (ctr is DateTimePicker) || (ctr is ComboBox))
                {
                    ctr.Text = "";
                }
            }
        }

        private void dg2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            cbMaNV.Text = dataGridView2.Rows[i].Cells[0].Value.ToString();
            txtHoTen.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
            txtGioiTinh.Text = dataGridView2.Rows[i].Cells[2].Value.ToString();
            txtChucVu.Text = dataGridView2.Rows[i].Cells[3].Value.ToString();
            txtMLCu.Text = dataGridView2.Rows[i].Cells[4].Value.ToString();
            txtMLMoi.Text = dataGridView2.Rows[i].Cells[5].Value.ToString();
            dtNgayTang.Text = dataGridView2.Rows[i].Cells[6].Value.ToString();
            txtLiDo.Text = dataGridView2.Rows[i].Cells[7].Value.ToString();
        }

        private void btnThem1_Click(object sender, EventArgs e)
        {
            try
            {

                string insert = "insert into TblBangLuongCTy values(N'" + txtMaLuong.Text + "',N'" + txtLCB.Text + "',N'" + txtPhuCapChucVu.Text + "',N'" + dtNgayNhap.Text + "',N'" + txtLCBMoi.Text + "',N'" + dtNgaySua.Text + "',N'" + txtLyDo.Text + "',N'" + txtPhuCapChucVuMoi.Text + "',N'" + dtNgaySuaPhuCap.Text + "',N'" + txtGhiChu.Text + "')";
                if (!dataBase.kttrungkhoa(txtMaLuong.Text, "select MaLuong from TblBangLuongCTy"))
                {
                    if (txtMaLuong.Text != "")
                    {
                        dataBase.thucthiketnoi(insert);
                        dataGridView1.Refresh();
                        dataBase.loaddatagridview(dataGridView1, "select * from TblBangLuongCTy");
                        MessageBox.Show("Thêm thành công");
                    }
                    else MessageBox.Show("Bạn chưa nhập Mã Lương");
                }
                else
                    MessageBox.Show("Mã Lương này đã tồn tại", "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void btnSua1_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "update TblBangLuongCTy set LCB=N'" + txtLCB.Text + "',PCChucVu=N'" + txtPhuCapChucVu.Text + "',NgayNhap='" + dtNgayNhap.Text + "',LCBMoi=N'" + txtLCBMoi.Text + "',NgaySua=N'" + dtNgaySua.Text + "',LyDo=N'" + txtLyDo.Text + "',PCCVuMoi='" + txtPhuCapChucVuMoi.Text + "',NgaySuaPC=N'" + dtNgaySuaPhuCap.Text + "',GhiChu=N'" + txtGhiChu.Text + "' where MaLuong=N'" + txtMaLuong.Text + "'";
                dataBase.thucthiketnoi(update);
                dataBase.loaddatagridview(dataGridView1, "select * from TblBangLuongCTy");
                MessageBox.Show("Sửa thành công");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void btnXoa1_Click(object sender, EventArgs e)
        {
            string delete = "delete from TblBangLuongCTy where MaLuong=N'" + txtMaLuong.Text + "'";
            string delete1 = "delete from TblSoBH where MaLuong=N'" + txtMaLuong.Text + "'";
            if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                dataBase.thucthiketnoi(delete1);
                dataBase.thucthiketnoi(delete);
                dataBase.loaddatagridview(dataGridView1, "select * from TblBangLuongCTy");
            }
        }

        private void btnThoat1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataBase.loadtextbox(txtHoTen, "select HoTen from TblTTNVCoBan where MaNV='" + cbMaNV.Text + "'");
            dataBase.loadtextbox(txtGioiTinh, "select GioiTinh from TblTTNVCoBan where MaNV='" + cbMaNV.Text + "'");
            dataBase.loadtextbox(txtChucVu, "select ChucVu from TblTTNVCoBan where MaNV='" + cbMaNV.Text + "'");
            dataBase.loadtextbox(txtMLCu, "select MaLuong from TblCongKhoiDieuHanh where MaNV='" + cbMaNV.Text + "'");
            dataBase.loadtextbox(txtMLMoi, "select MaLuongMoi from TblTangLuong where MaNV='" + cbMaNV.Text + "'");
            dataBase.loadtextbox(txtLiDo, "select LyDo from TblTangLuong where MaNV='" + cbMaNV.Text + "'");
            dataBase.loaddatetime(dtNgayTang, "select NgayTang from TblTangLuong where MaNV='" + cbMaNV.Text + "'", 0);
        }

        private void btnMoi2_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox4.Controls)
            {
                if ((ctr is TextBox) || (ctr is DateTimePicker) || (ctr is ComboBox))
                {
                    ctr.Text = "";
                }
            }
        }

        private void btnThem2_Click(object sender, EventArgs e)
        {
            try
            {

                string insert = "insert into TblTangLuong values(N'" + cbMaNV.Text + "',N'" + txtHoTen.Text + "',N'" + txtGioiTinh.Text + "',N'" + txtChucVu.Text + "',N'" + txtMLCu.Text + "',N'" + txtMLMoi.Text + "',N'" + dtNgayTang.Text + "',N'" + txtLiDo.Text + "')";
                if (!dataBase.kttrungkhoa(cbMaNV.Text, "select MaNV from TblTangLuong"))
                {
                    if (cbMaNV.Text != "")
                    {
                        dataBase.thucthiketnoi(insert);
                        dataGridView1.Refresh();
                        dataBase.loaddatagridview(dataGridView2, "select * from TblTangLuong");
                        MessageBox.Show("Thêm thành công");
                    }
                    else MessageBox.Show("Bạn chưa chọn mà nhân viên");
                }
                else
                    MessageBox.Show("Nhân viên này bạn đã nhập dữ liêu rồi", "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
            string up = "update TblTTNVCoBan set MaLuong=N'" + txtMLMoi.Text + "' where MaNV='" + cbMaNV.Text + "'";
            dataBase.thucthiketnoi(up);
            dataBase.loaddatagridview1(dataGridView2, ds1, "select * from TblTangLuong");
        }

        private void btnSua2_Click(object sender, EventArgs e)
        {
            try
            {

                string update = "update TblTangLuong set HoTen=N'" + txtHoTen.Text + "',GioiTinh=N'" + txtGioiTinh.Text + "',ChucVu=N'" + txtChucVu.Text + "',MaLuongCu='" + txtMLCu.Text + "',MaLuongMoi=N'" + txtMLMoi.Text + "',NgayTang='" + dtNgayTang.Text + "',LyDo=N'" + txtLiDo.Text + "' where MaNV=N'" + cbMaNV.Text + "'";
                dataBase.thucthiketnoi(update);
                dataBase.loaddatagridview1(dataGridView2, ds1, "select * from TblTangLuong");
                MessageBox.Show("Sửa thành công");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
            string up = "update TblTTNVCoBan set MaLuong=N'" + txtMLMoi.Text + "' where MaNV='" + cbMaNV.Text + "'";
            dataBase.thucthiketnoi(up);
            dataBase.loaddatagridview1(dataGridView2, ds1, "select * from TblTangLuong");
        }

        private void btnXoa2_Click(object sender, EventArgs e)
        {
            DataSet ds1 = new DataSet();
            string delete = "delete from TblTangLuong where MaNV=N'" + cbMaNV.Text + "'";
            if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                dataBase.thucthiketnoi(delete);
                dataBase.loaddatagridview1(dataGridView2, ds1, "select * from TblTangLuong");
            }
        }

        private void btnThoat2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void btnXuatExcel1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount <= 0) return;
            if (MessageBox.Show("Bạn có muốn xuất danh sách ra excel không?", "Thông Báo",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            DataBase.XuatFileExcel(dataGridView1, "LuongCty.xls");
        }

        private void btnXuatExcel2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.RowCount <= 0) return;
            if (MessageBox.Show("Bạn có muốn xuất danh sách ra excel không?", "Thông Báo",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            DataBase.XuatFileExcel(dataGridView2, "TangLuong.xls");
        }

        private void FrmLuong_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void txtLCB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtLCBMoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
