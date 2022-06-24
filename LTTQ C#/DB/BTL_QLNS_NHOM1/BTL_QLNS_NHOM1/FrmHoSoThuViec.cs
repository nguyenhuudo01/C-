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
    public partial class FrmHoSoThuViec : Form
    {
        public FrmHoSoThuViec()
        {
            InitializeComponent();
        }
        DataBase dataBase = new DataBase();
        private void FrmHoSoThuViec_Load(object sender, EventArgs e)
        {
            dtdNgaySinh.CustomFormat = " MM / dd / yyyy ";
            dtdNgayTV.CustomFormat = " MM / dd / yyyy ";
            dataBase.loaddatagridview(dataGridView1, "select * from TblHoSoThuViec");
            dataBase.loadcombobox(cbMaPhong, "select * from Tblphongban", 1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            cbMaPhong.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtMaNV.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtHoTen.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            dtdNgaySinh.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtGioiTinh.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txtDiaChi.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            txtTrinhDo.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            txtHocHam.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            txtViTriTV.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
            dtdNgayTV.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();
            txtThangTV.Text = dataGridView1.Rows[i].Cells[10].Value.ToString();
            txtGhiChu.Text = dataGridView1.Rows[i].Cells[11].Value.ToString();

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

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!dataBase.kttrungkhoa(txtMaNV.Text, "select MaNVTV from TblHoSoThuViec"))
            {
                string insert = "insert into TblHoSoThuViec values('" + cbMaPhong.Text + "',N'" + txtMaNV.Text + "',N'" + txtHoTen.Text + "',N'" + dtdNgaySinh.Text + "',N'" + txtGioiTinh.Text + "',N'" + txtDiaChi.Text + "',N'" + txtTrinhDo.Text + "',N'" + txtHocHam.Text + "',N'" + txtViTriTV.Text + "',N'" + dtdNgayTV.Text + "',N'" + txtThangTV.Text + "',N'" + txtGhiChu.Text + "')";
                dataBase.thucthiketnoi(insert);
                dataBase.loaddatagridview(dataGridView1, "select * from TblHoSoThuViec");
            }
            else
            {
                MessageBox.Show("Mã nhân viên này đã tòn tại bạn có thể thử mã nhân viên khác", "Trùng mã nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "update TblHoSoThuViec set MaPhong=N'" + cbMaPhong.Text + "',HoTen=N'" + txtHoTen.Text + "',NgaySinh=N'" + dtdNgaySinh.Text + "',GioiTinh=N'" + txtGioiTinh.Text + "',DiaChi=N'" + txtDiaChi.Text + "',TDHocVan=N'" + txtTrinhDo.Text + "',HocHam=N'" + txtHocHam.Text + "',ViTriThuViec=N'" + txtViTriTV.Text + "',NgayTV=N'" + dtdNgayTV.Text + "',ThangTV=N'" + txtThangTV.Text + "',GhiChu=N'" + txtGhiChu.Text + "' where MaNVTV='" + txtMaNV.Text + "'";
                dataBase.thucthiketnoi(update);
                dataBase.loaddatagridview(dataGridView1, "select * from TblHoSoThuViec");
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
                string del = "delete from TblHoSoThuViec where MaNVTV='" + txtMaNV.Text + "'";
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    dataBase.thucthiketnoi(del);
                    dataBase.loaddatagridview(dataGridView1, "select * from TblHoSoThuViec");
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
    }
}
