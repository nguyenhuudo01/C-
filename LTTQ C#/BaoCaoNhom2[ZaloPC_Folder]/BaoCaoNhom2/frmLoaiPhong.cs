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
    public partial class frmLoaiPhong : Form
    {
        public static string str = "Select  * From LPhong";
        int index = 0;
        int last = 0;

        public frmLoaiPhong()
        {
            InitializeComponent();
            KetnoiDataBase.Chuoiketnoi(str, dtgLoaiPhong);
            Namecolumn();
            AddCombox();
        }
        public void AddCombox()
        {
            cboLuaChon.Items.Add("Loại phòng");
            cboLuaChon.Items.Add("Mô tả phòng");
            cboLuaChon.Items.Add("Giá phòng");
        }

        private void LoawData(int curow)
        {

            txtLoaiPhong.Text = dtgLoaiPhong.Rows[curow].Cells[0].Value.ToString();
            rtxtMoTa.Text = dtgLoaiPhong.Rows[curow].Cells[1].Value.ToString();
            txtGiaphong.Value = Convert.ToInt32(dtgLoaiPhong.Rows[curow].Cells[2].Value.ToString());

            txtLoaiPhong.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnHuy.Enabled = true;

        }
        public void Clear()
        {
            txtLoaiPhong.Enabled = true;
            rtxtMoTa.Text = "";
            txtGiaphong.Value = 0;
            txtLoaiPhong.Text = "";
            btnHuy.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = true;
            txtLoaiPhong.Focus();
            txtTongsoLP.Enabled = false;

        }
        private void Namecolumn()
        {

            dtgLoaiPhong.Columns[0].HeaderText = "Loại phòng"; dtgLoaiPhong.Columns[0].Width = 300;
            dtgLoaiPhong.Columns[2].HeaderText = "Giá phòng"; dtgLoaiPhong.Columns[2].Width = 230;
            dtgLoaiPhong.Columns[1].HeaderText = "Mô tả"; dtgLoaiPhong.Columns[1].Width = 500;



            int sc = dtgLoaiPhong.Rows.Count;
            index = 0;
            last = sc - 1;
            txtTongsoLP.Text = (sc - 1) + "";
            btnHuy.Enabled = false;
            btnSua.Enabled = false;
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtLoaiPhong.Text == "" || rtxtMoTa.Text == "" || txtGiaphong.Text == "")
            {
                MessageBox.Show("Ban chưa nhập đầy đủ thông Tin !", "Error", MessageBoxButtons.OK);
            }
            else
            {
                string map = txtLoaiPhong.Text.Trim();
                string sql = "Select count(*) from LPhong where loaiphong ='" + map.Trim() + "'";
                string sql1 = "Insert into LPhong values(N'" + map + "',N'" + rtxtMoTa.Text + "','" + Convert.ToInt32(txtGiaphong.Value.ToString()) + "' )";
                KetnoiDataBase.them(sql, sql1, dtgLoaiPhong);
                KetnoiDataBase.Chuoiketnoi(str, dtgLoaiPhong);
                Namecolumn();
                Clear();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //loaiphong,mota,giaphong
            string sql = "Update LPhong set mota = N'" + rtxtMoTa.Text + "',giaphong='" + Convert.ToInt32(txtGiaphong.Value.ToString()) + "'where loaiphong = '" + txtLoaiPhong.Text + "'";
            KetnoiDataBase.Sua(sql);
            KetnoiDataBase.Chuoiketnoi(str, dtgLoaiPhong);
            Namecolumn();
            Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chăn muốn thoát không ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void dtgLoaiPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = dtgLoaiPhong.CurrentRow.Index;
            LoawData(index);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            string sql = "Delete from LPhong where loaiphong = N'" + txtLoaiPhong.Text + "'";
            KetnoiDataBase.Xoa(sql);
            KetnoiDataBase.Chuoiketnoi(str, dtgLoaiPhong);
            Namecolumn();
            Clear();
        }

        private void PopulateData(int curow)
        {

            txtLoaiPhong.Text = dtgLoaiPhong.Rows[curow].Cells[0].Value.ToString();
            rtxtMoTa.Text = dtgLoaiPhong.Rows[curow].Cells[1].Value.ToString();
            txtGiaphong.Value = Convert.ToInt32(dtgLoaiPhong.Rows[curow].Cells[2].Value.ToString());
            txtLoaiPhong.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnHuy.Enabled = true;

        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            index--;
            index = index < 0 ? 0 : index;
            PopulateData(index);
            dtgLoaiPhong.CurrentCell = dtgLoaiPhong.Rows[index].Cells[0];
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            index = index + 1;
            if (index >= last)
            {
                index = 0;

                PopulateData(index);
                dtgLoaiPhong.CurrentCell = dtgLoaiPhong.Rows[index].Cells[0];
            }
            else
            {
                PopulateData(index);
                dtgLoaiPhong.CurrentCell = dtgLoaiPhong.Rows[index].Cells[0];
            }
        }

        private void btnDau_Click(object sender, EventArgs e)
        {
            index = 0;
            PopulateData(index);
            dtgLoaiPhong.CurrentCell = dtgLoaiPhong.Rows[index].Cells[0];
        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            index = last - 1;
            PopulateData(index);
            dtgLoaiPhong.CurrentCell = dtgLoaiPhong.Rows[index].Cells[0];
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string tukhoa = txt_search.Text;
            String chuoi1 = "";
            if (String.Compare(cboLuaChon.Text, "Loại phòng", true) == 0)
            {
                chuoi1 = "Select * from LPhong where loaiphong like N'%" + tukhoa + "%'";
            }
            else if (String.Compare(cboLuaChon.Text, "Giá phòng", true) == 0)
            {
                chuoi1 = "Select * from LPhong where giaphong like N'%" + tukhoa + "%'";
            }
            else
            {
                chuoi1 = "Select * from LPhong where Mota like N'%" + tukhoa + "%'";
            }
            KetnoiDataBase.timkiem(chuoi1, dtgLoaiPhong);
            Namecolumn();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
