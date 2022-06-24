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
    public partial class FrmCheDo : Form
    {
        public FrmCheDo()
        {
            InitializeComponent();
        }
        DataBase dataBase = new DataBase();
        DataSet ds1 = new DataSet();
        DataSet ds2 = new DataSet();
        private void FrmCheDo_Load(object sender, EventArgs e)
        {
            dt1.CustomFormat = " MM / dd / yyyy ";
            dt2.CustomFormat = " MM / dd / yyyy ";
            dt3.CustomFormat = " MM / dd / yyyy ";
            dt4.CustomFormat = " MM / dd / yyyy ";
            dt5.CustomFormat = " MM / dd / yyyy ";
            dataBase.loadcombobox(cbMaNVBH, "select * from TblTTNVCoBan", 2);
            dataBase.loadcombobox(cbMaNVTS, "select * from TblTTNVCoBan", 2);
            dataBase.loaddatagridview1(dataGVBH, ds1, "select * from TblSoBH");
            dataBase.loaddatagridview1(dataGVTS, ds2, "select * from TblThaiSan");
        }

        private void dataGVTS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtMaBoPhan.Text = dataGVTS.Rows[i].Cells[0].Value.ToString();
            txtMaPhong.Text = dataGVTS.Rows[i].Cells[1].Value.ToString();
            cbMaNVTS.Text = dataGVTS.Rows[i].Cells[2].Value.ToString();
            txtHoTen.Text = dataGVTS.Rows[i].Cells[3].Value.ToString();
            dt2.Text = dataGVTS.Rows[i].Cells[4].Value.ToString();
            dt3.Text = dataGVTS.Rows[i].Cells[5].Value.ToString();
            dt4.Text = dataGVTS.Rows[i].Cells[6].Value.ToString();
            dt5.Text = dataGVTS.Rows[i].Cells[7].Value.ToString();
            txtTroCapCTy.Text = dataGVTS.Rows[i].Cells[8].Value.ToString();
            txtGhiChuTS.Text = dataGVTS.Rows[i].Cells[9].Value.ToString();
        }

        private void btnMoiBH_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if ((ctr is TextBox) || (ctr is DateTimePicker) || (ctr is ComboBox))
                {
                    ctr.Text = "";
                }
            }
        }

        private void btnThemBH_Click(object sender, EventArgs e)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            try
            {

                string insert = "insert into TblSoBH values(N'" + cbMaNVBH.Text + "',N'" + txtMaLuong.Text + "',N'" + txtMaBH.Text + "',N'" + dt1.Text + "',N'" + txtNoiCapSo.Text + "',N'" + txtGhiChuBH.Text + "')";
                if (!dataBase.kttrungkhoa(txtMaLuong.Text, "select MaSoBH from TblSoBH"))
                {
                    if (txtMaLuong.Text != "")
                    {
                        dataBase.thucthiketnoi(insert);
                        dataGVBH.Refresh();
                        dataBase.loaddatagridview1(dataGVBH, ds1, "select * from TblSoBH");
                        MessageBox.Show("Thêm thành công");
                    }
                    else MessageBox.Show("Bạn chưa nhập Mã số bảo hiểm");
                }
                else
                    MessageBox.Show("Mã số bảo hiểm này đã tồn tại", "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void btnSuaBH_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "update TblSoBH set NgayCapSo=N'" + dt1.Text + "',NoiCapSo=N'" + txtNoiCapSo.Text + "',MaLuong=N'" + txtMaLuong.Text + "',GhiChu=N'" + txtGhiChuBH.Text + "' where MaNV=N'" + cbMaNVBH.Text + "'";
                dataBase.thucthiketnoi(update);
                dataBase.loaddatagridview1(dataGVBH, ds1, "select * from TblSoBH");
                MessageBox.Show("Sửa thành công");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void btnXoaBH_Click(object sender, EventArgs e)
        {
            string delete = "delete from TblSoBH where MaNV=N'" + cbMaNVBH.Text + "'";
            if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                dataBase.thucthiketnoi(delete);
                dataBase.loaddatagridview1(dataGVBH, ds1, "select * from TblSoBH");
            }
            
        }

        private void btnThoatBH_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMoiTS_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if ((ctr is TextBox) || (ctr is DateTimePicker) || (ctr is ComboBox))
                {
                    ctr.Text = "";
                }
            }
        }

        private void btnThemTS_Click(object sender, EventArgs e)
        {
            string insert = "insert into TblThaiSan values(N'" + txtMaBoPhan.Text + "',N'" + txtMaPhong.Text + "',N'" + cbMaNVTS.Text + "',N'" + txtHoTen.Text + "',N'" + dt2.Text + "',N'" + dt3.Text + "',N'" + dt4.Text + "',N'" + dt5.Text + "',N'" + txtTroCapCTy.Text + "',N'" + txtGhiChuTS.Text + "')";
            if (!dataBase.kttrungkhoa(cbMaNVTS.Text, "select MaNV from TblThaiSan"))
            {
                if (cbMaNVTS.Text != "")
                {
                    dataBase.thucthiketnoi(insert);
                    dataGVTS.Refresh();
                    dataBase.loaddatagridview1(dataGVTS, ds2, "select * from TblThaiSan");
                    MessageBox.Show("Thêm thành công");
                }
                else MessageBox.Show("Bạn chưa nhập Mã  nhân vien");
            }
            else
                MessageBox.Show("Mã nhân viên này đã tồn tại", "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnSuaTS_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "update TblThaiSan set HoTen=N'" + txtHoTen.Text + "',NgaySinh=N'" + dt2.Text + "',NgayVeSom=N'" + dt3.Text + "',NgayNghiSinh=N'" + dt4.Text + "',NgayLamTroLai='" + dt5.Text + "',TroCapCTy=N'" + txtTroCapCTy.Text + "',GhiChu=N'" + txtGhiChuTS.Text + "' where MaNV=N'" + cbMaNVTS.Text + "'";
                dataBase.thucthiketnoi(update);
                dataBase.loaddatagridview1(dataGVTS, ds2, "select * from TblThaiSan");
                MessageBox.Show("Sửa thành công");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void btnXoaTS_Click(object sender, EventArgs e)
        {
            string delete = "delete from TblThaiSan where MaNV=N'" + cbMaNVTS.Text + "'";
            if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                dataBase.thucthiketnoi(delete);
                dataBase.loaddatagridview1(dataGVTS, ds2, "select * from TblThaiSan");
            }
        }

        private void btnThoatTS_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCheDo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void dataGVBH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            cbMaNVBH.Text = dataGVBH.Rows[i].Cells[0].Value.ToString();
            txtMaLuong.Text = dataGVBH.Rows[i].Cells[1].Value.ToString();
            txtMaBH.Text = dataGVBH.Rows[i].Cells[2].Value.ToString();
            dt1.Text = dataGVBH.Rows[i].Cells[3].Value.ToString();
            txtNoiCapSo.Text = dataGVBH.Rows[i].Cells[4].Value.ToString();
           // txtGhiChuBH.Text = dataGVBH.Rows[i].Cells[5].Value.ToString();
        }

        private void btnXuatExcelBH_Click(object sender, EventArgs e)
        {
            if (dataGVBH.RowCount <= 0) return;
            if (MessageBox.Show("Bạn có muốn xuất danh sách ra excel không?", "Thông Báo",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            DataBase.XuatFileExcel(dataGVBH, "BaoHiem.xls");
        }

        private void btnXuatExcelTS_Click(object sender, EventArgs e)
        {
            if (dataGVTS.RowCount <= 0) return;
            if (MessageBox.Show("Bạn có muốn xuất danh sách ra excel không?", "Thông Báo",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            DataBase.XuatFileExcel(dataGVTS, "ThaiSan.xls");
        }

        private void cbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataBase.loadtextboxchiso(txtMaLuong, "select * from TblTTNVCoBan where MaNV=N'" + cbMaNVBH.Text + "'", 4);
            dataBase.loadtextboxchiso(txtMaBH, "select * from TblSoBH where MaNV=N'" + cbMaNVBH.Text + "'", 2);
            dataBase.loaddatetime(dt1, "select * from TblSoBH where MaNV=N'" + cbMaNVBH.Text + "'", 3);
            dataBase.loadtextboxchiso(txtNoiCapSo, "select * from TblSoBH where MaNV=N'" + cbMaNVBH.Text + "'", 4);
            dataBase.loadtextboxchiso(txtGhiChuBH, "select * from TblSoBH where MaNV=N'" + cbMaNVBH.Text + "'", 5);
        }

        private void cbMaNVTS_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataBase.loadtextboxchiso(txtMaBoPhan, "select * from TblTTNVCoBan where MaNV=N'" + cbMaNVTS.Text + "'", 0);
            dataBase.loadtextboxchiso(txtMaPhong, "select * from TblTTNVCoBan where MaNV=N'" + cbMaNVTS.Text + "'", 1);
            dataBase.loadtextboxchiso(txtHoTen, "select * from TblTTNVCoBan where MaNV=N'" + cbMaNVTS.Text + "'", 3);
            dataBase.loadtextboxchiso(txtTroCapCTy, "select * from TblThaiSan where MaNV=N'" + cbMaNVTS.Text + "'", 8);
            dataBase.loadtextboxchiso(txtGhiChuTS, "select * from TblThaiSan where MaNV=N'" + cbMaNVTS.Text + "'", 9);
            dataBase.loaddatetime(dt2, "select * from TblThaiSan where MaNV=N'" + cbMaNVTS.Text + "'", 4);
            dataBase.loaddatetime(dt3, "select * from TblThaiSan where MaNV=N'" + cbMaNVTS.Text + "'", 5);
            dataBase.loaddatetime(dt4, "select * from TblThaiSan where MaNV=N'" + cbMaNVTS.Text + "'", 6);
            dataBase.loaddatetime(dt5, "select * from TblThaiSan where MaNV=N'" + cbMaNVTS.Text + "'", 7);
        }

        private void dataGVBH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
