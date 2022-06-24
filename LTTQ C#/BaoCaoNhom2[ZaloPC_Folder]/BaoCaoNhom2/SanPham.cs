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
using app = Microsoft.Office.Interop.Excel.Application;

namespace BaoCaoNhom2
{
    public partial class SanPham : Form
    {
        string connectionString = KetnoiDataBase.sqlcon;
        public static string query1 = "Select * from Khohang";
        public static string state = "";
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet dsCheck;
        public SanPham()
        {
            InitializeComponent();
            state = "Reset";
            setControl(state);
            getData();
        }

        private void setControl(string state)
        {
            switch (state)
            {
                case "Reset":
                    txtMaSP.Text = "";
                    txtGiaBan.Text = "";
                    txtGiaNhap.Text = "";
                    txtSL.Text = "";
                    txtTenSP.Text = "";
                    txtTuKhoa.Text = "Nhập từ khóa....";
                    txtMaSP.Enabled = false;
                    txtGiaBan.Enabled = false;
                    txtGiaNhap.Enabled = false;
                    txtTenSP.Enabled = false;
                    txtSL.Enabled = false;
                    btnGhi.Enabled = false;
                    btnNhapLai.Enabled = false;
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    break;
                case "Add":
                    txtMaSP.Enabled = true;
                    txtGiaBan.Enabled = true;
                    txtGiaNhap.Enabled = true;
                    txtTenSP.Enabled = true;
                    txtSL.Enabled = true;
                    btnGhi.Enabled = true;
                    btnNhapLai.Enabled = true;
                    btnSua.Enabled = false;
                    btnThem.Enabled = false;
                    btnXoa.Enabled = false;
                    break;
                case "Update":
                    txtMaSP.Enabled = false;
                    txtGiaBan.Enabled = true;
                    txtGiaNhap.Enabled = true;
                    txtTenSP.Enabled = true;
                    txtSL.Enabled = true;
                    btnGhi.Enabled = true;
                    btnNhapLai.Enabled = true;
                    btnSua.Enabled = false;
                    btnThem.Enabled = false;
                    btnXoa.Enabled = false;
                    break;
            }
        }

        private void getData()
        {
            
            KetnoiDataBase.Chuoiketnoi(query1, dgvSanPham);
            dgvSanPham.EnableHeadersVisualStyles = false; //Gets or sets a value indicating whether row and column headers use the visual styles of the user's current theme if visual styles are enabled for the application.
            dgvSanPham.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue; // gán cột màu header = color
            dgvSanPham.Columns["Maitem"].HeaderText = "Mã item"; dgvSanPham.Columns["TenItem"].Width = 100;
            dgvSanPham.Columns["TenItem"].HeaderText = "Tên sản phẩm"; dgvSanPham.Columns["TenItem"].Width = 150;
            dgvSanPham.Columns["gianhap"].HeaderText = "Giá nhập"; dgvSanPham.Columns["gianhap"].Width = 200;
            dgvSanPham.Columns["soluong"].HeaderText = "Số lượng"; dgvSanPham.Columns["soluong"].Width = 200;
            dgvSanPham.Columns["giaban"].HeaderText = "Giá bán"; dgvSanPham.Columns["giaban"].Width = 600;
            
        }




        private void export2Excel(DataGridView g, string duongDan, string tenTap)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for (int i = 1; i < g.Columns.Count + 1; i++)
            {

                obj.Cells[1, i] = g.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null)
                    {

                        obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(duongDan + tenTap + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }









        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            state = "Reset";
            setControl(state);
        }













        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTuKhoa.Text.Trim() == "Nhập từ khóa....")
            {
                MessageBox.Show("Bạn chưa nhập từ khóa");
            }
            else if (cboTimKiem.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn trường tìm kiếm");
            }
            else
            {
                if (cboTimKiem.SelectedItem == "Mã sản phẩm")
                {
                    string timKiem = "Select * from Khohang where Maitem like '%" + txtTuKhoa.Text.Trim() + "%'";
                    KetnoiDataBase.Chuoiketnoi(timKiem, dgvSanPham);
                }
                else if (cboTimKiem.SelectedItem == "Tên sản phẩm")
                {
                    string timKiem = "Select * from Khohang where TenItem like '%" + txtTuKhoa.Text.Trim() + "%'";
                    KetnoiDataBase.Chuoiketnoi(timKiem, dgvSanPham);
                }
                else if (cboTimKiem.SelectedItem == "Giá nhập")
                {
                    string timKiem = "Select * from Khohang where gianhap like '%" + txtTuKhoa.Text.Trim() + "%'";
                    KetnoiDataBase.Chuoiketnoi(timKiem, dgvSanPham);
                }
                else if (cboTimKiem.SelectedItem == "Số lượng")
                {
                    string timKiem = "Select * from Khohang where soluong like '%" + txtTuKhoa.Text.Trim() + "%'";
                    KetnoiDataBase.Chuoiketnoi(timKiem, dgvSanPham);
                }
                else if (cboTimKiem.SelectedItem == "Giá bán")
                {
                    string timKiem = "Select * from Khohang where giaban like '%" + txtTuKhoa.Text.Trim() + "%'";
                    KetnoiDataBase.Chuoiketnoi(timKiem, dgvSanPham);
                }
            }
        }

        private void btnXuatExcel_Click_1(object sender, EventArgs e)
        {
            export2Excel(dgvSanPham, @"D:\", "SanPham");
        }

        private void btnGhi_Click_1(object sender, EventArgs e)
        {
            if (state == "Add")
            {
                conn = new SqlConnection(connectionString);
                string queryCheck = "Select * from Khohang where Maitem='" + txtMaSP.Text.Trim() + "'";
                SqlCommand cmdCheck = new SqlCommand(queryCheck, conn);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                da = new SqlDataAdapter(cmdCheck);
                dsCheck = new DataSet();
                da.Fill(dsCheck);
                if (dsCheck != null && dsCheck.Tables.Count > 0 && dsCheck.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("Đã tồn tại mã sản phẩm " + txtMaSP.Text + " trong hệ thống");
                    txtMaSP.Focus();
                    return;
                }
                string query = "insert into Khohang values('" + txtMaSP.Text.Trim() + "',N'" + txtTenSP.Text.Trim() + "', '" + Convert.ToInt32(txtGiaNhap.Text.Trim()) + "', '" + txtSL.Text.Trim() + "', '" + Convert.ToInt32(txtGiaBan.Text.Trim()) + "')";
                KetnoiDataBase.Chuoiketnoi(query, dgvSanPham);
                getData();
                setControl("Reset");
            }
            else if (state == "Update")
            {
                var Result = MessageBox.Show("Bạn có muốn thay đổi dữ liệu hay không?", "Cảnh báo", MessageBoxButtons.YesNo);
                if (Result == DialogResult.Yes)
                {
                    string query = "update Khohang set TenItem=N'" + txtTenSP.Text.Trim() +
                        "', gianhap='" + Convert.ToInt32(txtGiaNhap.Text.Trim()) + "', giaban='" + Convert.ToInt32(txtGiaBan.Text.Trim()) +
                        "',soluong='" + Convert.ToInt32(txtSL.Text.Trim()) + "' WHERE Maitem='" + txtMaSP.Text.Trim() + "'";

                    KetnoiDataBase.Chuoiketnoi(query, dgvSanPham);
                    getData();
                    setControl("Reset");
                }
            }
        }

        private void btnNhapLai_Click_2(object sender, EventArgs e)
        {
            state = "Reset";
            setControl(state);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            state = "Add";
            setControl(state);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            state = "Update";
            setControl(state);
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            var Result1 = MessageBox.Show("Bạn có thực sự muốn xóa dữ liệu hay không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (Result1 == DialogResult.Yes)
            {
                string queryDelete = "delete Khohang where Maitem='" + txtMaSP.Text.Trim() + "'";
                KetnoiDataBase.Chuoiketnoi(queryDelete, dgvSanPham);
                getData();
                setControl("Reset");
            }
        }

        private void btnThoat_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvSanPham_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = e.RowIndex;
            DataGridViewRow select = dgvSanPham.Rows[RowIndex];
            txtMaSP.Text = select.Cells["Maitem"].Value.ToString();
            txtTenSP.Text = select.Cells["TenItem"].Value.ToString();
            txtGiaNhap.Text = select.Cells["gianhap"].Value.ToString();
            txtSL.Text = select.Cells["soluong"].Value.ToString();
            txtGiaBan.Text = select.Cells["giaban"].Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTuKhoa_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtGiaBan_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGiaNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenSP_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SanPham_Fill_Panel_PaintClient(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
