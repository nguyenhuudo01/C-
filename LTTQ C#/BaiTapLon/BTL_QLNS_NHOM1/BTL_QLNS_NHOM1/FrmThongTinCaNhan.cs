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
    public partial class FrmThongTinCaNhan : Form
    {
        public FrmThongTinCaNhan()
        {
            InitializeComponent();
        }
        DataBase dataBase = new DataBase();

        private void FrmThongTinCaNhan_Load(object sender, EventArgs e)
        {
            dataBase.loaddatagridview(dataGridView1, "select * from TblTTCaNhan");
            dataBase.loadcombobox(cbMaNV, "select * from TblTTCaNhan", 0);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hang = e.RowIndex;
                cbMaNV.Text = dataGridView1.Rows[hang].Cells[0].Value.ToString();
                txtHoTen.Text = dataGridView1.Rows[hang].Cells[1].Value.ToString();
                txtNoiSinh.Text = dataGridView1.Rows[hang].Cells[2].Value.ToString();
                txtNguyenQuan.Text = dataGridView1.Rows[hang].Cells[3].Value.ToString();
                txtDCThuongTru.Text = dataGridView1.Rows[hang].Cells[4].Value.ToString();
                txtDCTamTru.Text = dataGridView1.Rows[hang].Cells[5].Value.ToString();
                txtSDT.Text = dataGridView1.Rows[hang].Cells[6].Value.ToString();
                txtDanToc.Text = dataGridView1.Rows[hang].Cells[7].Value.ToString();
                txtTonGiao.Text = dataGridView1.Rows[hang].Cells[8].Value.ToString();
                txtQuocTich.Text = dataGridView1.Rows[hang].Cells[9].Value.ToString();
                txtHocVan.Text = dataGridView1.Rows[hang].Cells[10].Value.ToString();
                txtGhiChu.Text = dataGridView1.Rows[hang].Cells[11].Value.ToString();
                //

            }
            catch (Exception)
            { }
        }

        private void cbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataBase.loadtextboxchiso(txtHoTen, "select * from TblTTCaNhan where MaNV='" + cbMaNV.Text + "'", 1);
            dataBase.loadtextboxchiso(txtNoiSinh, "select * from TblTTCaNhan where MaNV='" + cbMaNV.Text + "'", 2);
            dataBase.loadtextboxchiso(txtNguyenQuan, "select * from TblTTCaNhan where MaNV='" + cbMaNV.Text + "'", 3);
            dataBase.loadtextboxchiso(txtDCThuongTru, "select * from TblTTCaNhan where MaNV='" + cbMaNV.Text + "'", 4);
            dataBase.loadtextboxchiso(txtDCTamTru, "select * from TblTTCaNhan where MaNV='" + cbMaNV.Text + "'", 5);
            dataBase.loadtextboxchiso(txtSDT, "select * from TblTTCaNhan where MaNV='" + cbMaNV.Text + "'", 6);
            dataBase.loadtextboxchiso(txtDanToc, "select * from TblTTCaNhan where MaNV='" + cbMaNV.Text + "'", 7);
            dataBase.loadtextboxchiso(txtTonGiao, "select * from TblTTCaNhan where MaNV='" + cbMaNV.Text + "'", 8);
            dataBase.loadtextboxchiso(txtQuocTich, "select * from TblTTCaNhan where MaNV='" + cbMaNV.Text + "'", 9);
            dataBase.loadtextboxchiso(txtHocVan, "select * from TblTTCaNhan where MaNV='" + cbMaNV.Text + "'", 10);
            dataBase.loadtextboxchiso(txtGhiChu, "select * from TblTTCaNhan where MaNV='" + cbMaNV.Text + "'", 11);
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if ((ctr is TextBox) || (ctr is DateTimePicker) || (ctr is ComboBox))
                {
                    ctr.Text = "";
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "update TblTTCaNhan set Manv=N'" + cbMaNV.Text + "',Noisinh=N'" + txtNoiSinh.Text + "',NguyenQuan=N'" + txtNguyenQuan.Text + "',DCThuongChu=N'" + txtDCThuongTru.Text + "',DCTamChu=N'" + txtDCTamTru.Text + "',SDT=N'" + txtSDT.Text + "',DanToc=N'" + txtDanToc.Text + "',TonGiao=N'" + txtTonGiao.Text + "',QuocTich=N'" + txtQuocTich.Text + "',HocVan=N'" + txtHocVan.Text + "',GhiChu=N'" + txtGhiChu.Text + "' where MaNV=N'" + cbMaNV.Text + "'";
                dataBase.thucthiketnoi(update);
                dataBase.loaddatagridview(dataGridView1, "select * from TblTTCaNhan");
                MessageBox.Show("Sửa thành công");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string delete = "delete from TblTTCaNhan where MaNV=N'" + cbMaNV.Text + "'";
                if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    dataBase.thucthiketnoi(delete);
                    dataBase.loaddatagridview(dataGridView1, "select * from TblTTCaNhan");
                }
            }
            catch
            {
                MessageBox.Show("không xóa được");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnXuatExcel1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount <= 0) return;
            if (MessageBox.Show("Bạn có muốn xuất danh sách ra excel không?", "Thông Báo",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            DataBase.XuatFileExcel(dataGridView1, "TTCN.xls");
        }

        
    }
}
