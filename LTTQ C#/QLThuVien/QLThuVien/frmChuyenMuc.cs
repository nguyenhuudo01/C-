using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVien
{
    public partial class frmChuyenMuc : Form
    {
        bool ktThem;
        string macu, sql;
        DataGridViewCellMouseEventArgs vt;
        public frmChuyenMuc()
        {
            InitializeComponent();
        }

        private void frmChuyenMuc_Load(object sender, EventArgs e)
        {
            KhoaMo(true);
            LayNguon();
        }
        void LayNguon()
        {
            sql = "Select MaMuc, TenMuc From ChuyenMuc Order By MaMuc";
            Public.GanNguonDataGridView(dgDanhSach, sql);
            if (dgDanhSach.RowCount > 0)
                lblThongBao.Text = "Danh sách có " + dgDanhSach.RowCount + " dòng.";
            else
                lblThongBao.Text = "";
        }

        void KhoaMo(bool b)
        {
            dgDanhSach.Enabled = b;
            txtTenMuc.ReadOnly = b;
            cmdInDS.Enabled = b;
            cmdThem.Enabled = b; cmdSua.Enabled = b;
            cmdXoa.Enabled = b; cmdKetThuc.Enabled = b;
            cmdGhi.Enabled = !b; cmdKhong.Enabled = !b;
        }

        void XoaTrang()
        {
            txtMaMuc.Text = ""; txtTenMuc.Text = "";
        }
        private void dgDanhSach_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgDanhSach.RowCount <= 0) return;
            if (e.RowIndex >= 0)
            {
                vt = e;
                DataGridViewRow row = dgDanhSach.Rows[e.RowIndex];
                txtMaMuc.Text = row.Cells[0].Value.ToString();
                txtTenMuc.Text = row.Cells[1].Value.ToString();
            }
        }

        private void cmdThem_Click(object sender, EventArgs e)
        {
            ktThem = true;
            KhoaMo(false);
            XoaTrang();
            txtMaMuc.Text = Public.TaoMa("MaMuc", "ChuyenMuc");
            txtTenMuc.Focus();
        }

        private void cmdSua_Click(object sender, EventArgs e)
        {
            if (txtMaMuc.Text == "") return;
            ktThem = false;
            macu = txtMaMuc.Text;
            KhoaMo(false);
            txtTenMuc.Focus();
        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {
            if (txtMaMuc.Text == "") return;
            macu = txtMaMuc.Text;
            if (MessageBox.Show("Bạn có muốn xóa chuyên mục đang chọn không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Public.sql = "Delete From ChuyenMuc Where MaMuc='" + macu + "'";
                if (Public.ThucHienSQL(Public.sql) == true)
                {
                    MessageBox.Show("Bạn thực hiện xóa thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    XoaTrang();
                    LayNguon();
                }
            }
        }

        private void cmdGhi_Click(object sender, EventArgs e)
        {
            if (txtTenMuc.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên chuyên mục.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenMuc.Focus();
                return;
            }
            /*
            if (Public.ktTrungMa("MaMuc", "ChuyenMuc", ktThem, txtMaMuc.Text, macu) == true)
            {
                MessageBox.Show("Bạn nhập mã chuyên mục trùng với mã chuyên mục đã tồn tại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaMuc.Focus();
                return;
            }*/
            if ((MessageBox.Show("Bạn có muốn cập nhật chuyên mục sách không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                if (ktThem == true)
                    sql = "Insert Into ChuyenMuc(MaMuc,TenMuc) Values(@MaMuc,@TenMuc)";
                else
                    sql = "Update ChuyenMuc Set TenMuc=@TenMuc Where MaMuc = @MaMuc";
                SqlConnection conn = Public.KetNoi();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@MaMuc", SqlDbType.NVarChar).Value = txtMaMuc.Text;
                cmd.Parameters.Add("@TenMuc", SqlDbType.NVarChar).Value = txtTenMuc.Text;
                if (conn.State != ConnectionState.Open) conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Bạn cập nhật chuyên mục sách thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                XoaTrang();
                KhoaMo(true);
                LayNguon();
                try
                {
                    dgDanhSach_CellMouseClick(sender, vt);
                }
                catch (Exception ex) { Console.WriteLine("Error : " + ex.Message.ToString()); }
            }
        }

        private void cmdKhong_Click(object sender, EventArgs e)
        {
            try
            {
                XoaTrang();
                KhoaMo(true);
                dgDanhSach_CellMouseClick(sender, vt);
            }
            catch (Exception ex) { Console.WriteLine("Error : " + ex.Message.ToString()); }
        }

        private void cmdInDS_Click(object sender, EventArgs e)
        {
            if (dgDanhSach.RowCount <= 0) return;
            if (MessageBox.Show("Bạn có muốn xuất danh sách ra excel không?", "Thông Báo",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            Public.XuatFileExcel(dgDanhSach, "ChuyenMuc.xls");
        }

        private void cmdKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
