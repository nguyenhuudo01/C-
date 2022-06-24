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
    public partial class frmTKDocGia : Form
    {
        string sql,the,sophieu;
        public frmTKDocGia()
        {
            InitializeComponent();
        }

        private void txtTheDG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8) || e.KeyChar == (char)Keys.Enter)
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    cmdTimDG_Click(sender, e);
                }
                else
                    e.Handled = true;
            }
        }

        private void cmdTimDG_Click(object sender, EventArgs e)
        {
            if (txtTheDG.Text == "") return;
            long num = long.Parse(txtTheDG.Text);
            txtHoTenDG.Text = "";txtLop.Text = "";the = "";sophieu = ""; dgChiTiet.DataSource = null;
            dgPhieuMuon.DataSource = null;dgPhieuTra.DataSource = null;
            sql = "select TheDG, HoDem + ' ' + Ten as HoTen, Lop, NgayMuaThe, NgayHetHan from docgia where thedg = '" + num.ToString("0000000000") + "'";
            DataTable dg = Public.LayDuLieu(sql);
            if (dg.Rows.Count > 0)
            {
                the= dg.Rows[0]["TheDG"].ToString();
                txtTheDG.Text = the;
                txtHoTenDG.Text = dg.Rows[0]["HoTen"].ToString();
                txtLop.Text = dg.Rows[0]["Lop"].ToString();
                             
            }            
        }

        private void pnTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmTKDocGia_Load(object sender, EventArgs e)
        {
            dgPhieuMuon.AutoGenerateColumns = false;
            dgPhieuTra.AutoGenerateColumns = false;
            dgChiTiet.AutoGenerateColumns = false;
        }

        private void cmdThongKe_Click(object sender, EventArgs e)
        {
            if (the == "") return;
            dgChiTiet.DataSource = null;
            //tìm phiếu độc giả đã trả
            sql = "Select SoPhieu, NgayLap, NgayHenTra, DocGia.HoDem + ' ' + DocGia.Ten as HoTenDG, " +
                "CanBo.HoDem + ' ' + CanBo.Ten as HoTenCB, Phieu.TheDG, Phieu.MaCB, NgayKetThuc, " +
                "Case DaKetThuc When 1 then N'Đã kết thúc' Else '' End As TinhTrang " +
                "From Phieu inner join CanBo on Phieu.MaCB = CanBo.MaCB " +
                "inner join DocGia on Phieu.TheDG = DocGia.TheDG " +
                "Where (DaKetThuc=1) And (Phieu.TheDG = '"+ the + "') " +
                "Order by NgayHenTra";
            
            Public.GanNguonDataGridView(dgPhieuTra, sql);
            if (dgPhieuTra.RowCount > 0)
                lblDem1.Text = dgPhieuTra.RowCount + " phiếu.";
            else
                lblDem1.Text = "";
            //tìm phiếu độc giả đang mượn
            sql = "Select SoPhieu, NgayLap, NgayHenTra, DocGia.HoDem + ' ' + DocGia.Ten as HoTenDG, " +
                "CanBo.HoDem + ' ' + CanBo.Ten as HoTenCB, Phieu.TheDG, Phieu.MaCB, NgayKetThuc, " +
                "Case DaKetThuc When 1 then N'Đã kết thúc' Else '' End As TinhTrang " +
                "From Phieu inner join CanBo on Phieu.MaCB = CanBo.MaCB " +
                "inner join DocGia on Phieu.TheDG = DocGia.TheDG " +
                "Where (DaKetThuc=0) And (Phieu.TheDG = '" + the + "') " +
                "Order by NgayHenTra";
            Public.GanNguonDataGridView(dgPhieuMuon, sql);
            if (dgPhieuMuon.RowCount > 0)
                lblDem2.Text = dgPhieuMuon.RowCount + " phiếu.";
            else
                lblDem2.Text = "";
        }

        private void cmdInPhieu_Click(object sender, EventArgs e)
        {
            if (dgChiTiet.RowCount <= 0) return;
            if (sophieu == "") return;
            if (MessageBox.Show("Bạn có muốn in phiếu [ " + sophieu + " ] không?", "Thông Báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Phieu.InPhieu(sophieu);
        }

        private void dgPhieuTra_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgPhieuTra.RowCount <= 0) return;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgPhieuTra.Rows[e.RowIndex];
                sophieu = row.Cells[0].Value.ToString();
                sql = "Select SoPhieu, Sach.MaSach, TenSach, NgayTra,  " +
                    "Case BiHong When 1 then N'Bị hỏng' Else '' End As TinhTrang, GhiChu " +
                    "From CTPhieu inner join Sach on CTPhieu.MaSach = Sach.MaSach " +
                    "Where SoPhieu = '" + sophieu + "'";
                Public.GanNguonDataGridView(dgChiTiet, sql);
            }
        }

        private void dgPhieuMuon_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgPhieuMuon.RowCount <= 0) return;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgPhieuMuon.Rows[e.RowIndex];
                sophieu = row.Cells[0].Value.ToString();
                sql = "Select SoPhieu, Sach.MaSach, TenSach, NgayTra,  " +
                    "Case BiHong When 1 then N'Bị hỏng' Else '' End As TinhTrang, GhiChu " +
                    "From CTPhieu inner join Sach on CTPhieu.MaSach = Sach.MaSach " +
                    "Where SoPhieu = '" + sophieu + "'";
                Public.GanNguonDataGridView(dgChiTiet, sql);
            }
        }

        private void cmdKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
