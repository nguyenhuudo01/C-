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
    public partial class frmQLPhieu : Form
    {
        string sql, dk, sophieu="";
        public frmQLPhieu()
        {
            InitializeComponent();
        }

        private void cmdTraCuu_Click(object sender, EventArgs e)
        {
            dgPhieu.DataSource = null;
            sophieu = "";
            if (dtpTuNgay.Value>dtpDenNgay.Value)
            {
                MessageBox.Show("Bạn phải chọn từ ngày nhỏ hơn đến ngày", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpTuNgay.Focus();
                return;
            }
            sql = "Select SoPhieu, NgayLap, NgayHenTra, DocGia.HoDem + ' ' + DocGia.Ten as HoTenDG, " +
                "CanBo.HoDem + ' ' + CanBo.Ten as HoTenCB, Phieu.TheDG, Phieu.MaCB, NgayKetThuc, " +
                "Case DaKetThuc When 1 then N'Đã kết thúc' Else '' End As TinhTrang " +  
                "From Phieu inner join CanBo on Phieu.MaCB = CanBo.MaCB " +
                "inner join DocGia on Phieu.TheDG = DocGia.TheDG ";
            dk = "";
            if (chkPhieuKetThuc.Checked == true) dk = " (DaKetThuc = 0) ";
            if (optNgayLapPhieu.Checked == true)
                dk = dk + (dk.Equals("")==false ? " And " : "") + 
                    " (NgayLap>='"+ dtpTuNgay.Value.ToString("MM/dd/yyyy") +"' and NgayLap<='"+ dtpDenNgay.Value.ToString("MM/dd/yyyy") + "') ";
            if (optNgayHenTra.Checked == true)
                dk = dk + (dk.Equals("") == false ? " And " : "") +
                    " (NgayHenTra>='" + dtpTuNgay.Value.ToString("MM/dd/yyyy") + "' and NgayHenTra<='" + dtpDenNgay.Value.ToString("MM/dd/yyyy") + "') ";
            if (optPhieuQuaHan.Checked == true)
                dk = dk + (dk.Equals("") == false ? " And " : "") + " (NgayHenTra<='" + DateTime.Now.ToString("MM/dd/yyyy") + "') ";
            if (optTimSoPhieu.Checked == true && txtTimKiem.Text!="")
            {
                if (Public.IsNumber(txtTimKiem.Text) == true)
                {
                    long num = long.Parse(txtTimKiem.Text);
                    dk = dk + (dk.Equals("") == false ? " And " : "") + " (SoPhieu = '" + num.ToString("0000000000") + "') ";
                }
            }
            if (optTimDocGia.Checked == true && txtTimKiem.Text != "")
                dk = dk + (dk.Equals("") == false ? " And " : "") + " (DocGia.Ten Like N'%" + txtTimKiem.Text + "%' or Phieu.TheDG Like N'%" + txtTimKiem.Text + "%') ";
            if (optTimCanBo.Checked == true && txtTimKiem.Text != "") 
                dk = dk + (dk.Equals("") == false ? " And " : "") + " (CanBo.Ten Like N'%" + txtTimKiem.Text + "%' or Phieu.MaCB Like N'%" + txtTimKiem.Text + "%') ";
            if (dk != "") sql = sql + " Where " + dk;
            Public.GanNguonDataGridView(dgPhieu,sql);            
            dgChiTiet.DataSource = null;
            if (dgPhieu.RowCount > 0)
                lblThongBao.Text = "Tìm thấy " + dgPhieu.RowCount + " phiếu mượn.";
            else
                lblThongBao.Text = "Không tìm thấy phiếu nào theo yêu cầu.";
        }

        private void cmdKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdInPhieu_Click(object sender, EventArgs e)
        {
            if (dgPhieu.RowCount <= 0) return;
            if (sophieu == "") return;
            if (MessageBox.Show("Bạn có muốn in phiếu [ " + sophieu + " ] không?", "Thông Báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Phieu.InPhieu(sophieu);
        }

        private void dgPhieu_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgPhieu.RowCount <= 0) return;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgPhieu.Rows[e.RowIndex];
                sophieu = row.Cells[0].Value.ToString();
                sql = "Select SoPhieu, Sach.MaSach, TenSach, NgayTra,  " +
                    "Case BiHong When 1 then N'Bị hỏng' Else '' End As TinhTrang, GhiChu " +
                    "From CTPhieu inner join Sach on CTPhieu.MaSach = Sach.MaSach " +
                    "Where SoPhieu = '" + sophieu + "'";
                Public.GanNguonDataGridView(dgChiTiet, sql);
            }
        }

        private void frmQLPhieu_Load(object sender, EventArgs e)
        {
            dgPhieu.AutoGenerateColumns = false;
            dgChiTiet.AutoGenerateColumns = false;
            dtpTuNgay.Value = DateTime.Now.AddDays(-15);
            dtpDenNgay.Value = DateTime.Now;
        }
    }
}
