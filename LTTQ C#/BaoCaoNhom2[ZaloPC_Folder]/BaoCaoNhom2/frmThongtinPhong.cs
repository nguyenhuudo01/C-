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
    public partial class frmThongtinPhong : Form
    {
        public static string str = "Select  * From PHONG";
        int index = 0;
        int last = 0;

        public frmThongtinPhong()
        {
            InitializeComponent();
            KetnoiDataBase.Chuoiketnoi(str, dtgTTPhong);
            Namecolumn();
            AddCombox();
            load_Lphong();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

        }
        public void AddCombox()
        {
            cboLuaChon.Items.Add("Mã phòng");
            cboLuaChon.Items.Add("Tên phòng");
            cboLuaChon.Items.Add("Loại phòng");
            cboLuaChon.Items.Add("Mô tả phòng");
            cboLuaChon.Items.Add("Số người tối đa");
            cboLuaChon.Items.Add("Trạng thái");
        }

        private void Namecolumn()
        {
            // dtgTTPhong.Columns[0].Visible = false;
            dtgTTPhong.Columns[1].HeaderText = "Tên phòng"; dtgTTPhong.Columns[1].Width = 170;
            dtgTTPhong.Columns[2].HeaderText = "Loại phòng"; dtgTTPhong.Columns[2].Width = 200;
            dtgTTPhong.Columns[3].HeaderText = "Thông tin phòng"; dtgTTPhong.Columns[3].Width = 800;
            dtgTTPhong.Columns[4].HeaderText = "Số người tối đa"; dtgTTPhong.Columns[4].Width = 100;
            dtgTTPhong.Columns[5].HeaderText = "Trạng Thái"; dtgTTPhong.Columns[5].Width = 150;
            dtgTTPhong.AutoGenerateColumns = false;
            int sc = dtgTTPhong.Rows.Count;
            index = 0;
            last = sc - 1;
            txtTongso.Text = (sc - 1) + "";
            btnXoa.Enabled = true;
            btnReset.Enabled = true;
        }
        private void load_Lphong()
        {

            string load_loaiphong = "Select loaiphong from LPhong";
            KetnoiDataBase.xulycbx(load_loaiphong, cboLoaiPhong);
            cboLoaiPhong.DisplayMember = "loaiphong";
            cboLoaiPhong.ValueMember = "loaiphong";
        }
        private void LoawData(int curow)
        {

            string trangthai = "";

            dtgTTPhong.Rows[0].Cells[0].Value = false;
            txtTenPhong.Text = dtgTTPhong.Rows[curow].Cells[1].Value.ToString();
            cboLoaiPhong.Text = dtgTTPhong.Rows[curow].Cells[2].Value.ToString();
            rtxtMoTa.Text = dtgTTPhong.Rows[curow].Cells[3].Value.ToString();
            txtMaxNg.Value = Convert.ToInt32(dtgTTPhong.Rows[curow].Cells[4].Value.ToString());

            cboTrangThai.Text = dtgTTPhong.Rows[curow].Cells[5].Value.ToString();

            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            int sc = dtgTTPhong.Rows.Count;
            index = 0;
            last = sc - 1;
            txtTongso.Text = (sc - 1) + "";

        }
        public void Clear()
        {

            txtMaxNg.Text = "";
            txtTenPhong.Text = "";
            txt_search.Text = "";
            rtxtMoTa.Text = "";
            cboTrangThai.Text = "";
            cboLoaiPhong.Text = "";
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtTongso.Enabled = false;
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenPhong.Text == "" || txtMaxNg.Text == "" || rtxtMoTa.Text == "")
            {
                MessageBox.Show("Ban chưa nhập đầy đủ thông Tin !", "Error", MessageBoxButtons.OK);
            }
            else
            {
                int count;
                count = dtgTTPhong.Rows.Count;// đếm tất cả dòng trong datagridview
                string chuoi = "";
                string maphong = "";
                int chuoi2 = 0;

                chuoi = Convert.ToString(dtgTTPhong.Rows[count - 2].Cells[0].Value);
                chuoi2 = Convert.ToInt32(chuoi.Remove(0, 2));// loại bỏ 2 kí tự đầu

                if (chuoi2 + 1 < 10)
                {
                    maphong = "ph0" + (chuoi2 + 1).ToString();
                }
                else if (chuoi2 + 1 < 100)
                {
                    maphong = "ph" + (chuoi2 + 1).ToString();
                }
                string sql = "Select count(*) from Phong where MaPhong ='" + maphong + "'";
                string sql1 = "Insert into PHONG values(N'" + maphong + "','" + txtTenPhong.Text + "','" + cboLoaiPhong.Text + "',N'" + rtxtMoTa.Text.Trim() + "','" + Convert.ToInt32(txtMaxNg.Value.ToString()) + "',N'" + cboTrangThai.Text + "' )";
                KetnoiDataBase.them(sql, sql1, dtgTTPhong);
                KetnoiDataBase.Chuoiketnoi(str, dtgTTPhong);
                Namecolumn();
                Clear();


            }
        }

        private void dtgTTPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            index = dtgTTPhong.CurrentRow.Index;
            LoawData(index);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chăn muốn thoát không ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from PHONG where MaPhong = N'" + dtgTTPhong.CurrentRow.Cells["MaPhong"].Value + "'";
            KetnoiDataBase.Xoa(sql);
            KetnoiDataBase.Chuoiketnoi(str, dtgTTPhong);
            Namecolumn();
            Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "Update PHONG set TenPhong = N'" + txtTenPhong.Text.Trim() + "',";
            sql += "loaiphong = N'" + cboLoaiPhong.Text.Trim() + "',";
            sql += "Mota = N'" + rtxtMoTa.Text + "',songtoida = '" + Convert.ToInt32(txtMaxNg.Value.ToString()) + "',trangthai = N'" + cboTrangThai.Text.Trim() + "'";
            sql += "where MaPhong = '" + dtgTTPhong.CurrentRow.Cells["MaPhong"].Value + "'";
            KetnoiDataBase.Sua(sql);
            KetnoiDataBase.Chuoiketnoi(str, dtgTTPhong);
            Namecolumn();
            Clear();
        }
        private void PopulateData(int curow)
        {


            txtTenPhong.Text = dtgTTPhong.Rows[curow].Cells[1].Value.ToString();
            cboLoaiPhong.Text = dtgTTPhong.Rows[curow].Cells[2].Value.ToString();
            rtxtMoTa.Text = dtgTTPhong.Rows[curow].Cells[3].Value.ToString();
            txtMaxNg.Value = Convert.ToInt32(dtgTTPhong.Rows[curow].Cells[4].Value.ToString());

            cboTrangThai.Text = dtgTTPhong.Rows[curow].Cells[5].Value.ToString();
            btnThem.Enabled = false;

            btnXoa.Enabled = true;
            btnSua.Enabled = true;


        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            index--;
            index = index < 0 ? 0 : index;
            PopulateData(index);
            dtgTTPhong.CurrentCell = dtgTTPhong.Rows[index].Cells[0];
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            index = index + 1;
            if (index >= last)
            {
                index = 0;

                PopulateData(index);
                dtgTTPhong.CurrentCell = dtgTTPhong.Rows[index].Cells[0];
            }
            else
            {
                PopulateData(index);
                dtgTTPhong.CurrentCell = dtgTTPhong.Rows[index].Cells[0];
            }
        }

        private void btnDau_Click(object sender, EventArgs e)
        {
            index = 0;
            PopulateData(index);
            dtgTTPhong.CurrentCell = dtgTTPhong.Rows[index].Cells[0];
        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            index = last - 1;
            PopulateData(index);
            dtgTTPhong.CurrentCell = dtgTTPhong.Rows[index].Cells[0];
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string tukhoa = txt_search.Text;
            String chuoi1 = "";
            if (String.Compare(cboLuaChon.Text, "Mã phòng", true) == 0 || cboLuaChon.SelectedItem == null)
            {
                chuoi1 = "Select * from Phong where MaPhong like N'%" + tukhoa + "%'";
            }
            else if (String.Compare(cboLuaChon.Text, "Tên phòng", true) == 0)
            {
                chuoi1 = "Select * from Phong where TenPhong like N'%" + tukhoa + "%'";
            }
            else if (String.Compare(cboLuaChon.Text, "Loại phòng", true) == 0)
            {
                chuoi1 = "Select * from Phong where loaiphong like N'%" + tukhoa + "%'";
            }
            else if (String.Compare(cboLuaChon.Text, "Mô tả phòng", true) == 0)
            {
                chuoi1 = "Select * from Phong where Mota like N'%" + tukhoa + "%'";
            }
            else if (String.Compare(cboLuaChon.Text, "Số người tối đa", true) == 0)
            {
                chuoi1 = "Select * from Phong where songtoida like N'%" + tukhoa + "%'";
            }

            else
            {
                chuoi1 = "Select * from Phong where trangthai like N'%" + tukhoa + "%'";
            }
            KetnoiDataBase.timkiem(chuoi1, dtgTTPhong);
            Namecolumn();
        }
    }
}
