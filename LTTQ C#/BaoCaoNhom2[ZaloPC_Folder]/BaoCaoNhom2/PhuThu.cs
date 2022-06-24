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
    public partial class PhuThu : Form
    {
        string connectionString = KetnoiDataBase.sqlcon;
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;
        public static string State = "";
        public PhuThu()
        {
            InitializeComponent();
            State = "Reset";
            setControl(State);
            lblSlKho.Text = "";
            lblTenKH.Text = "";
            getDataSP();
            getDataPhuThu();
        }

        private void getDataPhuThu()
        {
            string query = "Select Phuthu.MaPhu,Phuthu.MaKh,Phuthu.Maitem,Phuthu.tensp,Phuthu.soLuongPhuThu,Phuthu.gia,Phuthu.thanhtien, Khachhang.Tenkh from Phuthu,Khachhang where Phuthu.MaKh=Khachhang.MaKh";
            KetnoiDataBase.Chuoiketnoi(query, dgvPhuThu);
            dgvPhuThu.EnableHeadersVisualStyles = false; //Gets or sets a value indicating whether row and column headers use the visual styles of the user's current theme if visual styles are enabled for the application.
            dgvPhuThu.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue; // gán cột màu header = color
            dgvPhuThu.Columns["MaPhu"].Visible = false;
            dgvPhuThu.Columns["Maitem"].Visible = false;
            //dgvPhuThu.Columns["trangthai"].Visible = false;
        }
        int SLBan = 0;
        public void dieuKien()
        {
            if (lblSlKho.Text != "")
            {
                try
                {
                    SLBan = Convert.ToInt32(txtSLBan.Text);
                }catch(Exception ex)
                {
                    txtSLBan.Text = "";
                }
                int SLKho = Convert.ToInt32(lblSlKho.Text.Trim());
                if (SLBan > SLKho)
                {
                    MessageBox.Show("Số lượng bán không thể lớn hơn số lượng kho!", "Nhập lại");
                    txtSLBan.Text = "0";
                    txtSLBan.Focus();
                }
            }

        }
        private void getDataSP()
        {
            string query = "Select * from Khohang";
            KetnoiDataBase.Chuoiketnoi(query, dgvSanPham);
            dgvSanPham.EnableHeadersVisualStyles = false; //Gets or sets a value indicating whether row and column headers use the visual styles of the user's current theme if visual styles are enabled for the application.
            dgvSanPham.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue; // gán cột màu header = color
        }

        private void setControl(string State)
        {
            switch (State)
            {
                case "Reset":
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnGhi.Enabled = false;
                    btnNhapLai.Enabled = false;
                    txtGia.Enabled = false;
                    txtMaPhuThu.Enabled = false;
                    txtMaSP.Enabled = false;
                    txtSLBan.Enabled = false;
                    txtTenSP.Enabled = false;
                    txtThanhTien.Enabled = false;

                    txtGia.Text = "";
                    txtMaPhuThu.Text = "";
                    txtMaSP.Text = "";
                    txtSLBan.Text = "";
                    txtTenSP.Text = "";
                    txtThanhTien.Text = "";


                    break;
                case "Insert":
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnGhi.Enabled = true;
                    btnNhapLai.Enabled = true;
                    txtMaPhuThu.Enabled = false;
                    txtSLBan.Enabled = true;
                    txtTenSP.Enabled = false;
                    txtThanhTien.Enabled = false;


                    txtGia.Enabled = true;
                    break;
                case "Update":
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnGhi.Enabled = true;
                    btnNhapLai.Enabled = true;
                    txtMaPhuThu.Enabled = false;
                    txtSLBan.Enabled = true;
                    txtTenSP.Enabled = false;
                    txtThanhTien.Enabled = false;
                    txtGia.Enabled = true;
                    break;
                default:
                    break;
            }
        }


        private void LoadKH()
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Khachhang", con);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da1.Fill(tb);
            DataRow r = tb.NewRow();
            r["MaKh"] = "Chọn khách hàng";
            tb.Rows.InsertAt(r, 0);
            cboMaKhach.DataSource = tb;
            cboMaKhach.DisplayMember = "MaKh";
            cboMaKhach.ValueMember = "Tenkh";

            //string query = "SELECT * FROM Khachhang";
            //QLKS.KetnoiDataBase.xulycbo(query, cboMaKhach);
            //cboMaKhach.DisplayMember = "MaKh";
            //cboMaKhach.ValueMember = "Tenkh";
        }

        private void PhuThu_Load(object sender, EventArgs e)
        {
            LoadKH();
        }



        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void btnXuatExel_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {

        }

        private void txtTuKhoa_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void dgvSanPham_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = e.RowIndex;
            DataGridViewRow select = dgvSanPham.Rows[RowIndex];
            txtMaSP.Text = select.Cells["Maitem"].Value.ToString();
            txtTenSP.Text = select.Cells["TenItem"].Value.ToString();
            txtGia.Text = select.Cells["giaban"].Value.ToString();
            lblSlKho.Text = "" + select.Cells["soluong"].Value.ToString();
        }

        private void PhuThu_Fill_Panel_PaintClient(object sender, PaintEventArgs e)
        {

        }

        private void cboMaKhach_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            State = "Insert";
            setControl(State);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            State = "Update";
            setControl(State);
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            var kq = MessageBox.Show("Bạn có thực sự muốn xóa ", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.Yes)
            {
                int b = (int)dgvPhuThu.CurrentRow.Cells[4].Value;
                string queryUpdate2 = "update Khohang set soluong = soluong +'" + b + "' where Maitem='" + txtMaSP.Text.Trim() + "'";
                conn = new SqlConnection(connectionString);
                string query1 = "delete Phuthu where MaPhu='" + txtMaPhuThu.Text.Trim() + "'";
                SqlCommand cmd1 = new SqlCommand(query1, conn);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                var result1 = cmd1.ExecuteNonQuery();
                if (result1 > 0)
                {
                    KetnoiDataBase.Chuoiketnoi(queryUpdate2, dgvSanPham);
                    getDataSP();
                    getDataPhuThu();
                    State = "Reset";
                    setControl(State);
                }
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            State = "Reset";
            setControl(State);
        }

        private void dgvPhuThu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = e.RowIndex;
            DataGridViewRow select = dgvPhuThu.Rows[RowIndex];
            txtMaPhuThu.Text = select.Cells["MaPhu"].Value.ToString();
            cboMaKhach.Text = select.Cells["Makh"].Value.ToString();
            txtTenSP.Text = select.Cells["tensp"].Value.ToString();
            txtMaSP.Text = select.Cells["Maitem"].Value.ToString();
            txtSLBan.Text = select.Cells["soLuongPhuThu"].Value.ToString();
            txtGia.Text = select.Cells["gia"].Value.ToString();
            txtThanhTien.Text = select.Cells["thanhtien"].Value.ToString();
        }

        private void txtSLBan_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnGhi_Click_1(object sender, EventArgs e)
        {
            if (State == "Insert")
            {
                string queryUpdate = "update Khohang set soluong='" + (Convert.ToInt32(lblSlKho.Text.Trim()) - Convert.ToInt32(txtSLBan.Text.Trim())) + "' where Maitem='" + txtMaSP.Text.Trim() + "'";
                int count;
                count = dgvPhuThu.Rows.Count;// đếm tất cả dòng trong datagridview
                string chuoi = "";
                int chuoi2 = 0;
                chuoi = Convert.ToString(dgvPhuThu.Rows[count - 2].Cells[0].Value);
                chuoi2 = Convert.ToInt32(chuoi.Remove(0, 2));// loại bỏ 2 kí tự đầu
                if (chuoi2 + 1 < 10)
                {
                    txtMaPhuThu.Text = "ph0" + (chuoi2 + 1).ToString();
                }
                else if (chuoi2 + 1 < 100)
                {
                    txtMaPhuThu.Text = "ph" + (chuoi2 + 1).ToString();
                }
                if (txtMaPhuThu.Text == "" || txtMaPhuThu.Text.Trim() == "")
                {
                    MessageBox.Show("Chưa nhập mã phụ thu", "Cảnh báo");
                    txtMaPhuThu.Focus();
                    return;
                }
                else if (cboMaKhach.Text == "Chọn mã Khách hàng")
                {
                    MessageBox.Show("Chưa nhập mã khách", "Cảnh báo");
                    cboMaKhach.Focus();
                    return;
                }
                else if (txtSLBan.Text == "" || txtSLBan.Text.Trim() == "")
                {
                    MessageBox.Show("Chưa nhập số lượng bán", "Cảnh báo");
                    txtSLBan.Focus();
                    return;
                }


                conn = new SqlConnection(connectionString);
                string queryCheck = "Select * from Phuthu where MaPhu='" + txtMaPhuThu.Text.Trim() + "'";
                SqlCommand cmdCheck = new SqlCommand(queryCheck, conn);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                da = new SqlDataAdapter(cmdCheck);
                DataSet dsCheck = new DataSet();
                da.Fill(dsCheck);
                if (dsCheck != null && dsCheck.Tables.Count > 0 && dsCheck.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("Đã tồn tại mã phụ thu " + txtMaPhuThu.Text + " trong hệ thống");
                    txtMaPhuThu.Focus();
                    return;
                }




                conn = new SqlConnection(connectionString);
                string query = "insert into Phuthu values('" + txtMaPhuThu.Text.Trim() + "',N'" + cboMaKhach.Text + "','" + txtMaSP.Text.Trim() + "',N'" + txtTenSP.Text.Trim() + "','" + txtSLBan.Text.Trim() +
                    "','" + txtGia.Text.Trim() + "','0','" + txtThanhTien.Text.Trim() + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                var result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    getDataPhuThu();
                    KetnoiDataBase.Chuoiketnoi(queryUpdate, dgvSanPham);
                    getDataSP();
                    State = "Reset";
                    setControl(State);
                }
            }
            else if (State == "Update")
            {
                conn = new SqlConnection(connectionString);
                string query2 = "update Phuthu set MaKH='" + cboMaKhach.Text + "',Maitem='" + txtMaSP.Text.Trim() + "',tensp=N'" + txtTenSP.Text.Trim() + "',soLuongPhuThu='" + txtSLBan.Text.Trim() + "',gia='" + txtGia.Text.Trim() + "',trangthai='0',thanhtien='" + txtThanhTien.Text.Trim() + "'where MaPhu='" + txtMaPhuThu.Text.Trim() + "'";
                SqlCommand cmd2 = new SqlCommand(query2, conn);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                var result2 = cmd2.ExecuteNonQuery();
                if (result2 > 0)
                {
                    // QLKS.KetnoiDataBase.Chuoiketnoi(queryUpdate1, dgvSanPham);
                    getDataSP();
                    getDataPhuThu();
                    State = "Reset";
                    setControl(State);
                }
            }
        }

        private void btnXuatEx_Click(object sender, EventArgs e)
        {
            try
            {
                export2Excel(dgvPhuThu, @"D:\", "PhuThu");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            };
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

        private void cboTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click_2(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void lblTenKH_Click(object sender, EventArgs e)
        {

        }

        private void txtTenSP_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblSlKho_Click(object sender, EventArgs e)
        {

        }

        private void txtThanhTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaPhuThu_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void txtTuKhoa_TextChanged(object sender, EventArgs e)
        {
            if (cboTimKiem.Text == "Sản phẩm")
            {
                conn = new SqlConnection(connectionString);
                string query = "Select * from Khohang where TenItem like '%" + txtTuKhoa.Text + "%'";
                SqlCommand cmd = new SqlCommand(query, conn);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dgvSanPham.DataSource = ds.Tables[0];
                    dgvSanPham.AutoGenerateColumns = false;
                }
                conn.Close();
            }
            else if (cboTimKiem.Text == "Trường tìm kiếm")
            {
                MessageBox.Show("Yêu cầu chọn trường tìm kiếm", "Cảnh báo", MessageBoxButtons.OK);
            }
            else
            {
                string query1 = "Select * from Phuthu where MaKh like '%" + txtTuKhoa.Text + "%'";
                KetnoiDataBase.Chuoiketnoi(query1, dgvPhuThu);
            }
        }

        private void PhuThu_Fill_Panel_PaintClient_1(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void PhuThu_Load_1(object sender, EventArgs e)
        {
            LoadKH();
        }

        private void cboMaKhach_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "Select * from Khachhang where Makh='" + cboMaKhach.Text + "'";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                lblTenKH.Text = dr["Tenkh"].ToString();
            }
            conn.Close();
        }

        private void txtSLBan_TextChanged_1(object sender, EventArgs e)
        {
            dieuKien();
            try
            {
                int Tong = Convert.ToInt32(txtGia.Text) * Convert.ToInt32(txtSLBan.Text);
                txtThanhTien.Text = Convert.ToString(Tong);
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}
