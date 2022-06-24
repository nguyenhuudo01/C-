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
    public partial class frmTacGia : Form
    {
        bool ktThem;
        string macu, sql;
        DataGridViewCellMouseEventArgs vt;
        public frmTacGia()
        {
            InitializeComponent();
        }

        private void frmTacGia_Load(object sender, EventArgs e)
        {
            KhoaMo(true);
            LayNguon();
        }
        void LayNguon()
        {
            sql = "Select MaTG, TenTG, ThongTin From TacGia Order By TenTG";
            Public.GanNguonDataGridView(dgDanhSach, sql);
            if (dgDanhSach.RowCount > 0)
                lblThongBao.Text = "Danh sách có " + dgDanhSach.RowCount + " dòng.";
            else
                lblThongBao.Text = "";
        }

        void KhoaMo(bool b)
        {
            dgDanhSach.Enabled = b;
            txtTenTG.ReadOnly = b; txtThongTin.ReadOnly = b;
            cmdInDS.Enabled = b;
            cmdThem.Enabled = b; cmdSua.Enabled = b;
            cmdXoa.Enabled = b; cmdKetThuc.Enabled = b;
            cmdGhi.Enabled = !b; cmdKhong.Enabled = !b;
        }

        void XoaTrang()
        {
            txtMaTG.Text = ""; txtTenTG.Text = ""; txtThongTin.Text = "";
        }
        private void dgDanhSach_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgDanhSach.RowCount <= 0) return;
            if (e.RowIndex >= 0)
            {
                vt = e;
                DataGridViewRow row = dgDanhSach.Rows[e.RowIndex];
                txtMaTG.Text = row.Cells[0].Value.ToString();
                txtTenTG.Text = row.Cells[1].Value.ToString();
                txtThongTin.Text = row.Cells[2].Value.ToString();
            }
        }

        private void cmdThem_Click(object sender, EventArgs e)
        {
            ktThem = true;
            KhoaMo(false);
            XoaTrang();
            txtMaTG.Text = Public.TaoMa("MaTG", "TacGia");
            txtTenTG.Focus();
        }

        private void cmdSua_Click(object sender, EventArgs e)
        {
            if (txtMaTG.Text == "") return;
            ktThem = false;
            macu = txtMaTG.Text;
            KhoaMo(false);
            txtTenTG.Focus();
        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {
            if (txtMaTG.Text == "") return;
            macu = txtMaTG.Text;
            if (MessageBox.Show("Bạn có muốn xóa tác giả đang chọn không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Public.sql = "Delete From TacGia Where MaTG='" + macu + "'";
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
            if (txtTenTG.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên tác giả.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenTG.Focus();
                return;
            }
            /*
            if (Public.ktTrungMa("MaTG", "TacGia", ktThem, txtMaTG.Text, macu) == true)
            {
                MessageBox.Show("Bạn nhập mã tác giả trùng với mã tác giả đã tồn tại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaTG.Focus();
                return;
            }*/
            if ((MessageBox.Show("Bạn có muốn cập nhật tác giả không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                if (ktThem == true)
                    sql = "Insert Into TacGia(MaTG,TenTG,ThongTin) Values(@MaTG,@TenTG,@ThongTin)";
                else
                    sql = "Update TacGia Set TenTG=@TenTG,ThongTin=@ThongTin Where MaTG = @MaTG";
                SqlConnection conn = Public.KetNoi();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@MaTG", SqlDbType.NVarChar).Value = txtMaTG.Text;
                cmd.Parameters.Add("@TenTG", SqlDbType.NVarChar).Value = txtTenTG.Text;
                cmd.Parameters.Add("@ThongTin", SqlDbType.NVarChar).Value = txtThongTin.Text;
                if (conn.State != ConnectionState.Open) conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Bạn cập nhật tác giả thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            Public.XuatFileExcel(dgDanhSach, "TacGia.xls");
        }

        private void cmdKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
