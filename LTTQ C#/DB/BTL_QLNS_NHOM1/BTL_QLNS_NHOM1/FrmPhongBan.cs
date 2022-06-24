using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app = Microsoft.Office.Interop.Excel.Application;

namespace BTL_QLNS_NHOM1
{
    public partial class FrmPhongBan : Form
    {
        public FrmPhongBan()
        {
            InitializeComponent();
        }
        DataBase dataBase = new DataBase();
        private void FrmPB_Load(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = " MM / dd / yyyy ";
            dataBase.loaddatagridview(dataGridView1, "select * from TblPhongBan");
            dataBase.loadcombobox(cbMaBoPhan, "select * from TblBoPhan", 0);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            cbMaBoPhan.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtMaPhong.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtTenPhong.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtGhiChu.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            cbMaBoPhan.Text = "";
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if ((ctr is TextBox) || (ctr is DateTimePicker) || (ctr is ComboBox))
                {
                    ctr.Text = "";
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!dataBase.kttrungkhoa(txtMaPhong.Text, "select MaPhong from TblPhongBan"))
                {
                    string insert = "insert into TblPhongBan values('" + cbMaBoPhan.Text + "',N'" + txtMaPhong.Text + "',N'" + txtTenPhong.Text + "',N'" + dateTimePicker1.Text + "',N'" + txtGhiChu.Text + "')";
                    dataBase.thucthiketnoi(insert);
                    dataBase.loaddatagridview(dataGridView1, "select * from TblPhongBan");
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Mã phòng này đã tòn tại bạn có thể thử mã phòng khác", "Trùng mã phòng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "update TblPhongBan set MaBoPhan=N'" + cbMaBoPhan.Text + "',TenPhong=N'" + txtTenPhong.Text + "',NgayThanhLap=N'" + dateTimePicker1.Text + "',GhiChu=N'" + txtGhiChu.Text + "' where MaPhong=N'" + txtMaPhong.Text + "'";
                dataBase.thucthiketnoi(update);
                dataBase.loaddatagridview(dataGridView1, "select * from TblPhongBan");
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
                string del = "delete from TblPhongBan where MaPhong=N'" + txtMaPhong.Text + "'";
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    dataBase.thucthiketnoi(del);
                    dataBase.loaddatagridview(dataGridView1, "select * from TblPhongBan");
                    MessageBox.Show("Xóa thành công");
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount <= 0) return;
            if (MessageBox.Show("Bạn có muốn xuất danh sách ra excel không?", "Thông Báo",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            DataBase.XuatFileExcel(dataGridView1, "PhongBan.xls");
        }

        private void FrmPhongBan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void cbMaBoPhan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
