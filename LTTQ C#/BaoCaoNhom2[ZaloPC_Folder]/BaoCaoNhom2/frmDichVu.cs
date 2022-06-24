using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaoCaoNhom2
{
    public partial class frmDichVu : Form
    {
        public static string str = "Select  * From DichVu";
        int index = 0;
        int last = 0;
        public frmDichVu()
        {
            InitializeComponent();
            KetnoiDataBase.Chuoiketnoi(str, dtgDichVu);
            Namecolumn();
            AddCombox();
            txtMaDV.Enabled = false;
        }
        public void AddCombox()
        {
            cboLuaChon.Items.Add("Dịch vụ");
            cboLuaChon.Items.Add("Mô tả dịch vụ");
            cboLuaChon.Items.Add("Giá dịch vụ");
        }
        private void Namecolumn()
        {
            dtgDichVu.Columns[0].HeaderText = "Mã Dịch Vụ"; dtgDichVu.Columns[0].Width = 150;
            dtgDichVu.Columns[1].HeaderText = "Dịch Vụ"; dtgDichVu.Columns[1].Width = 150;
            dtgDichVu.Columns[2].HeaderText = "Mô tả"; dtgDichVu.Columns[2].Width = 1070;
            dtgDichVu.Columns[3].HeaderText = "Giá phòng"; dtgDichVu.Columns[3].Width = 150;

            int sc = dtgDichVu.Rows.Count;
            index = 0;
            last = sc - 1;
            txtTongso.Text = (sc - 1) + "";
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            txtTongso.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chăn muốn thoát không ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenDV.Text == "" || rtxtMoTa.Text == "" || txtPhiDV.Text == "")
            {
                MessageBox.Show("Ban chưa nhập đầy đủ thông Tin !", "Error", MessageBoxButtons.OK);
            }
            else
            {
                int count;
                count = dtgDichVu.Rows.Count;// đếm tất cả dòng trong datagridview
                string chuoi = "";
                string maDV = "";
                int chuoi2 = 0;

                chuoi = Convert.ToString(dtgDichVu.Rows[count - 2].Cells[0].Value);
                chuoi2 = Convert.ToInt32(chuoi.Remove(0, 2));// loại bỏ 2 kí tự đầu

                if (chuoi2 + 1 < 10)
                {
                    maDV = "DV0" + (chuoi2 + 1).ToString();
                }
                else if (chuoi2 + 1 < 100)
                {
                    maDV = "DV" + (chuoi2 + 1).ToString();
                }
                string sql = "Select count(*) from DichVu where MaDV = '" + maDV + "'";

                string sql2 = "Insert into DichVu values ('" + maDV + "','" + txtTenDV.Text + "','" + rtxtMoTa.Text.Trim() + "', N'" + Convert.ToInt32(txtPhiDV.Value) + "')";
                KetnoiDataBase.them(sql, sql2, dtgDichVu);
                KetnoiDataBase.Chuoiketnoi(str, dtgDichVu);
                Namecolumn();
                Clear();
            }
        }
        public void Clear()
        {
            txtMaDV.Text = "";
            txtTenDV.Enabled = true;
            txtTenDV.Text = "";
            rtxtMoTa.Text = "";

            txtPhiDV.Value = 0;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = true;
            txtMaDV.Focus();

        }
        private void btnSua_Click(object sender, EventArgs e)
        {

            string sql = "Update DichVu set TenDV = N'" + txtTenDV.Text.Trim() + "',";
            sql += " moTa = N'" + rtxtMoTa.Text.Trim() + "',";
            sql += " phiDV = N'" + Convert.ToInt32(txtPhiDV.Value) + "where MaPhong = '" + dtgDichVu.CurrentRow.Cells["MaDV"].Value + "'";
            KetnoiDataBase.Sua(sql);
            KetnoiDataBase.Chuoiketnoi(str, dtgDichVu);
            Namecolumn();
            Clear();
        }
        private void LoawData(int curow)
        {

            txtMaDV.Text = dtgDichVu.Rows[curow].Cells[0].Value.ToString();
            txtTenDV.Text = dtgDichVu.Rows[curow].Cells[1].Value.ToString();
            rtxtMoTa.Text = dtgDichVu.Rows[curow].Cells[2].Value.ToString();
            txtPhiDV.Value = Convert.ToInt32(dtgDichVu.Rows[curow].Cells[3].Value.ToString());

            txtMaDV.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

        }
        private void dtgDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = dtgDichVu.CurrentRow.Index;
            LoawData(index);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void PopulateData(int curow)
        {

            txtMaDV.Text = dtgDichVu.Rows[curow].Cells[0].Value.ToString();
            txtTenDV.Text = dtgDichVu.Rows[curow].Cells[1].Value.ToString();
            rtxtMoTa.Text = dtgDichVu.Rows[curow].Cells[2].Value.ToString();
            txtPhiDV.Value = Convert.ToInt32(dtgDichVu.Rows[curow].Cells[3].Value.ToString());
            txtMaDV.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

        }
        private void btnTruoc_Click(object sender, EventArgs e)
        {
            index--;
            index = index < 0 ? 0 : index;
            PopulateData(index);
            dtgDichVu.CurrentCell = dtgDichVu.Rows[index].Cells[0];
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            index = index + 1;
            if (index >= last)
            {
                index = 0;

                PopulateData(index);
                dtgDichVu.CurrentCell = dtgDichVu.Rows[index].Cells[0];
            }
            else
            {
                PopulateData(index);
                dtgDichVu.CurrentCell = dtgDichVu.Rows[index].Cells[0];
            }
        }

        private void btnDau_Click(object sender, EventArgs e)
        {
            index = 0;
            PopulateData(index);
            dtgDichVu.CurrentCell = dtgDichVu.Rows[index].Cells[0];
        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            index = last - 1;
            PopulateData(index);
            dtgDichVu.CurrentCell = dtgDichVu.Rows[index].Cells[0];
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string tukhoa = txt_search.Text;
            String chuoi1 = "";
            if (String.Compare(cboLuaChon.Text, "Dịch vụ", true) == 0)
            {
                chuoi1 = "Select * from DichVu where TenDV like N'%" + tukhoa + "%'";
            }
            else if (String.Compare(cboLuaChon.Text, "Giá dịch vụ", true) == 0)
            {
                chuoi1 = "Select * from DichVu where phiDV like N'%" + tukhoa + "%'";
            }
            else
            {
                chuoi1 = "Select * from DichVu where Mota like N'%" + tukhoa + "%'";
            }
            KetnoiDataBase.timkiem(chuoi1, dtgDichVu);
            Namecolumn();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from DichVu where loaiphong = N'" + txtMaDV.Text + "'";
            KetnoiDataBase.Xoa(sql);
            KetnoiDataBase.Chuoiketnoi(str, dtgDichVu);
            Namecolumn();
            Clear();
        }

        private void btnXuatHD_Click(object sender, EventArgs e)
        {
            HoaDonDV hd = new HoaDonDV();
            hd.Show();
        }
    }
}
