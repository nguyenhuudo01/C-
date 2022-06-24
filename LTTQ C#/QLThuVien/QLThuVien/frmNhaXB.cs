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
    public partial class frmNhaXB : Form
    {
        bool ktThem;
        string macu, sql;
        DataGridViewCellMouseEventArgs vt;
        public frmNhaXB()
        {
            InitializeComponent();
        }
        private void frmNhaXB_Load(object sender, EventArgs e)
        {
            KhoaMo(true);
            LayNguon();
        }
        void LayNguon()
        {
            sql = "Select MaNXB, TenNXB, SDT, DiaChi From NhaXB Order By TenNXB";
            Public.GanNguonDataGridView(dgDanhSach, sql);
            if (dgDanhSach.RowCount > 0)
                lblThongBao.Text = "Danh sách có " + dgDanhSach.RowCount + " dòng.";
            else
                lblThongBao.Text = "";
        }

        void KhoaMo(bool b)
        {
            dgDanhSach.Enabled = b;
            txtTenNXB.ReadOnly = b;txtSDT.ReadOnly = b;txtDiaChi.ReadOnly = b;
            cmdInDS.Enabled = b;
            cmdThem.Enabled = b; cmdSua.Enabled = b;
            cmdXoa.Enabled = b; cmdKetThuc.Enabled = b;
            cmdGhi.Enabled = !b; cmdKhong.Enabled = !b;
        }

        void XoaTrang()
        {
            txtMaNXB.Text = ""; txtTenNXB.Text = "";txtSDT.Text = "";txtDiaChi.Text = "";
        }
        private void dgDanhSach_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgDanhSach.RowCount <= 0) return;
            if (e.RowIndex >= 0)
            {
                vt = e;
                DataGridViewRow row = dgDanhSach.Rows[e.RowIndex];
                txtMaNXB.Text = row.Cells[0].Value.ToString();
                txtTenNXB.Text = row.Cells[1].Value.ToString();
                txtSDT.Text = row.Cells[2].Value.ToString();
                txtDiaChi.Text = row.Cells[3].Value.ToString();
            }
        }

        private void cmdThem_Click(object sender, EventArgs e)
        {
            ktThem = true;
            KhoaMo(false);
            XoaTrang();
            txtMaNXB.Text = Public.TaoMa("MaNXB", "NhaXB");
            txtTenNXB.Focus();
        }

        private void cmdSua_Click(object sender, EventArgs e)
        {
            if (txtMaNXB.Text == "") return;
            ktThem = false;
            macu = txtMaNXB.Text;
            KhoaMo(false);
            txtTenNXB.Focus();
        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNXB.Text == "") return;
            macu = txtMaNXB.Text;
            if (MessageBox.Show("Bạn có muốn xóa nhà xuất bản đang chọn không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Public.sql = "Delete From NhaXB Where MaNXB='" + macu + "'";
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
            if (txtTenNXB.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên nhà xuất bản.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNXB.Focus();
                return;
            }
            /*
            if (Public.ktTrungMa("MaNXB", "NhaXB", ktThem, txtMaNXB.Text, macu) == true)
            {
                MessageBox.Show("Bạn nhập mã nhà xuất bản trùng với mã nhà xuất bản đã tồn tại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaNXB.Focus();
                return;
            }*/
            if ((MessageBox.Show("Bạn có muốn cập nhật nhà xuất bản không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                if (ktThem == true)
                    sql = "Insert Into NhaXB(MaNXB,TenNXB,SDT,DiaChi) Values(@MaNXB,@TenNXB,@SDT,@DiaChi)";
                else
                    sql = "Update NhaXB Set TenNXB=@TenNXB,SDT=@SDT,DiaChi=@DiaChi Where MaNXB = @MaNXB";
                SqlConnection conn = Public.KetNoi();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@MaNXB", SqlDbType.NVarChar).Value = txtMaNXB.Text;
                cmd.Parameters.Add("@TenNXB", SqlDbType.NVarChar).Value = txtTenNXB.Text;
                cmd.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = txtSDT.Text;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = txtDiaChi.Text;
                if (conn.State != ConnectionState.Open) conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Bạn cập nhật nhà xuất bản thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }

        private void cmdInDS_Click(object sender, EventArgs e)
        {
            if (dgDanhSach.RowCount <= 0) return;
            if (MessageBox.Show("Bạn có muốn xuất danh sách ra excel không?", "Thông Báo",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            Public.XuatFileExcel(dgDanhSach, "NXB.xls");
        }

        private void cmdKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
