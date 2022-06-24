using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVien
{
    public partial class frmTKNgayHenTra : Form
    {
        string sql, dk = "", sophieu = "";
        private void dgDenHan_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgDenHan.RowCount <= 0) return;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgDenHan.Rows[e.RowIndex];
                sophieu = row.Cells[0].Value.ToString();
                sql = "Select SoPhieu, Sach.MaSach, TenSach, NgayTra,  " +
                    "Case BiHong When 1 then N'Bị hỏng' Else '' End As TinhTrang, GhiChu " +
                    "From CTPhieu inner join Sach on CTPhieu.MaSach = Sach.MaSach " +
                    "Where SoPhieu = '" + sophieu + "'";
                Public.GanNguonDataGridView(dgChiTiet, sql);
            }
        }

        private void dgQuaHan_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgQuaHan.RowCount <= 0) return;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgQuaHan.Rows[e.RowIndex];
                sophieu = row.Cells[0].Value.ToString();
                sql = "Select SoPhieu, Sach.MaSach, TenSach, NgayTra,  " +
                    "Case BiHong When 1 then N'Bị hỏng' Else '' End As TinhTrang, GhiChu " +
                    "From CTPhieu inner join Sach on CTPhieu.MaSach = Sach.MaSach " +
                    "Where SoPhieu = '" + sophieu + "'";
                Public.GanNguonDataGridView(dgChiTiet, sql);
            }
        }

        private void cmdInPhieu_Click(object sender, EventArgs e)
        {
            if (dgChiTiet.RowCount <= 0) return;
            if (sophieu == "") return;
            if (MessageBox.Show("Bạn có muốn in phiếu [ " + sophieu + " ] không?", "Thông Báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Phieu.InPhieu(sophieu);
        }

        private void pnTop_Paint(object sender, PaintEventArgs e)
        {
            dgDenHan.AutoGenerateColumns = false;
            dgQuaHan.AutoGenerateColumns = false;
            dgChiTiet.AutoGenerateColumns = false;
        }

        private void cmdKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdXuat1_Click(object sender, EventArgs e)
        {
            if (dgDenHan.RowCount <= 0) return;
            if (MessageBox.Show("Bạn muốn xuất danh sách phiếu đến hạn trả không?", "Thông Báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Public.XuatFileExcel(dgDenHan, "PhieuDenHanTra.xlsx");
        }

        private void cmdXuat2_Click(object sender, EventArgs e)
        {
            if (dgQuaHan.RowCount <= 0) return;
            if (MessageBox.Show("Bạn muốn xuất danh sách phiếu đã quá hạn không?", "Thông Báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Public.XuatFileExcel(dgQuaHan, "PhieuQuaHan.xlsx");
        }

        public frmTKNgayHenTra()
        {
            InitializeComponent();
        }

        private void cmdThongKe_Click(object sender, EventArgs e)
        {
            sophieu = "";
            DateTime fDate = dtpNgay.Value;
            DateTime aDate = fDate.AddDays(7);
            dgChiTiet.DataSource = null;
            //tìm phiếu gần đến hạn trong vòng 7 ngày
            sql = "Select SoPhieu, NgayLap, NgayHenTra, DocGia.HoDem + ' ' + DocGia.Ten as HoTenDG, " +
                "CanBo.HoDem + ' ' + CanBo.Ten as HoTenCB, Phieu.TheDG, Phieu.MaCB, NgayKetThuc, " +
                "Case DaKetThuc When 1 then N'Đã kết thúc' Else '' End As TinhTrang " +
                "From Phieu inner join CanBo on Phieu.MaCB = CanBo.MaCB " +
                "inner join DocGia on Phieu.TheDG = DocGia.TheDG ";
            dk = " (DaKetThuc = 0) And (NgayHenTra>='" + fDate.ToString("MM/dd/yyyy") + "' and NgayHenTra<='" + aDate.ToString("MM/dd/yyyy") + "') ";
            sql = sql + " Where " + dk;
            sql = sql + " Order by NgayHenTra";
            Public.GanNguonDataGridView(dgDenHan, sql);
            if (dgDenHan.RowCount > 0)
                lblDem1.Text = dgDenHan.RowCount + " phiếu.";
            else
                lblDem1.Text = "";
            //tìm phiếu quá hạn
            sql = "Select SoPhieu, NgayLap, NgayHenTra, DocGia.HoDem + ' ' + DocGia.Ten as HoTenDG, " +
                "CanBo.HoDem + ' ' + CanBo.Ten as HoTenCB, Phieu.TheDG, Phieu.MaCB, NgayKetThuc, " +
                "Case DaKetThuc When 1 then N'Đã kết thúc' Else '' End As TinhTrang " +
                "From Phieu inner join CanBo on Phieu.MaCB = CanBo.MaCB " +
                "inner join DocGia on Phieu.TheDG = DocGia.TheDG ";
            dk = " (DaKetThuc = 0) And (NgayHenTra<'" + fDate.ToString("MM/dd/yyyy") + "') ";
            sql = sql + " Where " + dk;
            sql = sql + " Order by NgayHenTra";
            Public.GanNguonDataGridView(dgQuaHan, sql);
            if (dgQuaHan.RowCount > 0)
                lblDem2.Text = dgQuaHan.RowCount + " phiếu.";
            else
                lblDem2.Text = "";
        }
    }
}
