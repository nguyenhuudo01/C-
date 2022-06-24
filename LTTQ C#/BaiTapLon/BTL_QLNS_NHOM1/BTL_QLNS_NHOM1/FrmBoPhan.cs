using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BTL_QLNS_NHOM1
{
    public partial class FrmBoPhan : Form
    {
        public FrmBoPhan()
        {
            InitializeComponent();
        }
        DataBase dtb = new DataBase();
        public static SqlConnection Con;
        DataSet ds1 = new DataSet();
        DataSet ds2 = new DataSet();
        DataSet ds3 = new DataSet();
        DataSet ds4 = new DataSet();
        DataSet ds5 = new DataSet();
        private void FrmBoPhan_Load(object sender, EventArgs e)
        {
            Con = new SqlConnection();
            Con.ConnectionString = @"Data Source=DESKTOP-63TNGNI\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            dtb.loaddatagridview1(dgvBoPhan, ds1, "select * from TblBoPhan");
        }
        public static void FillCombo(string sql, ComboBox cbo, string ma, string ten)
        {

            SqlDataAdapter Mydata = new SqlDataAdapter(sql, Con);
            DataTable table = new DataTable();
            Mydata.Fill(table);
            cbo.DataSource = table;
            cbo.ValueMember = ma; //Trường giá trị
            cbo.DisplayMember = ten; //Trường hiển thị

        }

        private void dgvBoPhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtMaBoPhan.Text = dgvBoPhan.Rows[i].Cells[0].Value.ToString();
            txtTenBoPhan.Text = dgvBoPhan.Rows[i].Cells[1].Value.ToString();
            txtGhiChu.Text = dgvBoPhan.Rows[i].Cells[3].Value.ToString();
            dtNgayThanhLap.Text = dgvBoPhan.Rows[i].Cells[2].Value.ToString();
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox4.Controls)
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
                if (!dtb.kttrungkhoa(txtMaBoPhan.Text, "select MaBoPhan from TblBoPhan"))
                {
                    string insert = "insert into TblBoPhan values(N'" + txtMaBoPhan.Text + "',N'" + txtTenBoPhan.Text + "',N'" + dtNgayThanhLap.Text + "',N'" + txtGhiChu.Text + "')";
                    dtb.thucthiketnoi(insert);
                    dtb.loaddatagridview(dgvBoPhan, "select * from TblBoPhan");
                }
                else
                {
                    MessageBox.Show("Bộ phận này đã tòn tại ", "Trùng bộ phân", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                string update = "update TblBoPhan set TenBoPhan=N'" + txtTenBoPhan.Text + "',NgayThanhLap=N'" + dtNgayThanhLap.Text + "',GhiChu=N'" + txtGhiChu.Text + "' where MaBoPhan='" + txtMaBoPhan.Text + "'";
                dtb.thucthiketnoi(update);
                dtb.loaddatagridview(dgvBoPhan, "select * from TblBoPhan");
                MessageBox.Show("Sửa thành công");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string del = "delete from TblBoPhan where MaBoPhan='" + txtMaBoPhan.Text + "'";
            string del1 = "delete from TblPhongBan where MaBoPhan='" + txtMaBoPhan.Text + "'";
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                dtb.thucthiketnoi(del1);
                dtb.thucthiketnoi(del);
                dtb.loaddatagridview(dgvBoPhan, "select * from TblBoPhan");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmBoPhan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn kết thúc không?", "Kết Thúc",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
       
        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (dgvBoPhan.RowCount <= 0) return;
            if (MessageBox.Show("Bạn có muốn xuất danh sách ra excel không?", "Thông Báo",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            DataBase.XuatFileExcel(dgvBoPhan, "BoPhan.xls");
        }
    }
}
