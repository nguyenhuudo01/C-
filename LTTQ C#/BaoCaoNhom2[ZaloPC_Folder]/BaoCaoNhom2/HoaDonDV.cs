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
    public partial class HoaDonDV : Form
    {
        string connectionString = KetnoiDataBase.sqlcon;
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;
        public static string State = "";
        public HoaDonDV()
        {
            InitializeComponent();
            getUI();
            State = "Reset";
            setControl(State);
            txtPhiDV.Enabled = false;
            txtMaHDDV.Enabled = false;
        }

        private void getUI()
        {
            string query = "SELECT dbo.HoaDonDV.maHDDV,dbo.Khachhang.Makh, dbo.DichVu.tenDV,dbo.Khachhang.Tenkh,dbo.Khachhang.Ngaysinh,dbo.DichVu.phiDV FROM dbo.HoaDonDV,dbo.DichVu,dbo.Khachhang WHERE dbo.HoaDonDV.maDV=dbo.DichVu.maDV AND dbo.HoaDonDV.maKH=dbo.Khachhang.MaKh";
            KetnoiDataBase.Chuoiketnoi(query, dgvHoaDonDV);
            tinhTien();
        }
        public void tinhTien()
        {
            int sc = dgvHoaDonDV.Rows.Count;
            double thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
            {

                thanhtien += float.Parse(dgvHoaDonDV.Rows[i].Cells[5].Value.ToString());
            }

            lblTongTien.Text = string.Format("{0:#,##0}", double.Parse(thanhtien.ToString()));
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string query;
            if (cboTimKiem.Text == "Mã hóa đơn")
            {
                query = "SELECT dbo.HoaDonDV.maHDDV, dbo.DichVu.tenDV,dbo.Khachhang.Makh,dbo.Khachhang.Tenkh,dbo.Khachhang.Ngaysinh,dbo.DichVu.phiDV FROM dbo.HoaDonDV,dbo.DichVu,dbo.Khachhang" +
                   " WHERE dbo.HoaDonDV.maDV=dbo.DichVu.maDV AND dbo.HoaDonDV.maKH=dbo.Khachhang.MaKh and dbo.HoaDonDV.maHDDV like'%" + txtTimKiem.Text + "%'";
                KetnoiDataBase.Chuoiketnoi(query, dgvHoaDonDV);
            }
            else if (cboTimKiem.Text == "Dịch vụ")
            {
                query = "SELECT dbo.HoaDonDV.maHDDV, dbo.DichVu.tenDV,dbo.Khachhang.Makh,dbo.Khachhang.Tenkh,dbo.Khachhang.Ngaysinh,dbo.DichVu.phiDV FROM dbo.HoaDonDV,dbo.DichVu,dbo.Khachhang" +
                    " WHERE dbo.HoaDonDV.maDV=dbo.DichVu.maDV AND dbo.HoaDonDV.maKH=dbo.Khachhang.MaKh and dbo.DichVu.tenDV like '%" + txtTimKiem.Text + "%'";
                KetnoiDataBase.Chuoiketnoi(query, dgvHoaDonDV);
            }
            else if (cboTimKiem.Text == "Khách hàng")
            {
                query = "SELECT dbo.HoaDonDV.maHDDV, dbo.DichVu.tenDV,dbo.Khachhang.Makh,dbo.Khachhang.Tenkh,dbo.Khachhang.Ngaysinh,dbo.DichVu.phiDV FROM dbo.HoaDonDV,dbo.DichVu,dbo.Khachhang" +
                    " WHERE dbo.HoaDonDV.maDV=dbo.DichVu.maDV AND dbo.HoaDonDV.maKH=dbo.Khachhang.MaKh and dbo.Khachhang.Tenkh like '%" + txtTimKiem.Text + "%'";
                KetnoiDataBase.Chuoiketnoi(query, dgvHoaDonDV);
            }
            else if (cboTimKiem.Text == "Ngày sinh")
            {
                query = "SELECT dbo.HoaDonDV.maHDDV, dbo.DichVu.tenDV,dbo.Khachhang.Makh,dbo.Khachhang.Tenkh,dbo.Khachhang.Ngaysinh,dbo.DichVu.phiDV FROM dbo.HoaDonDV,dbo.DichVu,dbo.Khachhang" +
                       " WHERE dbo.HoaDonDV.maDV=dbo.DichVu.maDV AND dbo.HoaDonDV.maKH=dbo.Khachhang.MaKh and dbo.Khachhang.Ngaysinh like '%" + Convert.ToDateTime(txtTimKiem.Text).ToString("yyyy-MM-dd") + "%'";
                KetnoiDataBase.Chuoiketnoi(query, dgvHoaDonDV);

            }
            tinhTien();
        }
        private void setControl(string State)
        {
            switch (State)
            {
                case "Reset":
                    btnThem.Enabled = true;
                    btnXoa.Enabled = true;
                    btnGhi.Enabled = false;
                    btnNhapLai.Enabled = false;
                    txtMaHDDV.Enabled = false;
                    cboKH.Enabled = false;
                    cboTenDV.Enabled = false;
                    txtMaHDDV.Text = "";
                    cboTenDV.Text = "-Chọn tên dịch vụ-";
                    cboKH.Text = "-Chọn mã khách hàng-";
                    lblTenKH.Text = "";

                    break;
                case "Insert":
                    btnThem.Enabled = false;
                    btnXoa.Enabled = false;
                    btnGhi.Enabled = true;
                    btnNhapLai.Enabled = true;
                    cboKH.Enabled = true;
                    cboTenDV.Enabled = true;
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
            r["MaKh"] = "-Chọn mã khách hàng-";
            tb.Rows.InsertAt(r, 0);
            cboKH.DataSource = tb;
            cboKH.DisplayMember = "MaKh";
            cboKH.ValueMember = "Tenkh";

            //string query = "SELECT * FROM Khachhang";
            //QLKS.KetnoiDataBase.xulycbo(query, cboMaKhach);
            //cboMaKhach.DisplayMember = "MaKh";
            //cboMaKhach.ValueMember = "Tenkh";
        }
        private void LoadDV()
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM DichVu", con);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da1.Fill(tb);
            DataRow r = tb.NewRow();
            r["tenDV"] = "-Chọn tên dịch vụ-";
            tb.Rows.InsertAt(r, 0);
            cboTenDV.DataSource = tb;
            cboTenDV.DisplayMember = "tenDV";
            cboTenDV.ValueMember = "maDV";

            //string query = "SELECT * FROM Khachhang";
            //QLKS.KetnoiDataBase.xulycbo(query, cboMaKhach);
            //cboMaKhach.DisplayMember = "MaKh";
            //cboMaKhach.ValueMember = "Tenkh";
        }
        private void lblTongTien_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            State = "Insert";
            setControl(State);
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            State = "Reset";
            setControl(State);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadKH();
            LoadDV();
        }

        private void cboKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "Select * from Khachhang where Makh='" + cboKH.Text + "'";
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

        private void dgvHoaDonDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = e.RowIndex;
            DataGridViewRow select = dgvHoaDonDV.Rows[RowIndex];
            txtMaHDDV.Text = select.Cells["maHDDV"].Value.ToString();
            cboKH.Text = select.Cells["Makh"].Value.ToString();
            cboTenDV.Text = select.Cells["tenDV"].Value.ToString();
            txtPhiDV.Text = select.Cells["phiDV"].Value.ToString();
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            if (State == "Insert")
            {
                int count;
                count = dgvHoaDonDV.Rows.Count;// đếm tất cả dòng trong datagridview
                string chuoi = "";
                int chuoi2 = 0;
                chuoi = Convert.ToString(dgvHoaDonDV.Rows[count - 2].Cells[0].Value);
                chuoi2 = Convert.ToInt32(chuoi.Remove(0, 2));// loại bỏ 2 kí tự đầu
                if (chuoi2 + 1 < 10)
                {
                    txtMaHDDV.Text = "hd0" + (chuoi2 + 1).ToString();
                }
                else if (chuoi2 + 1 < 100)
                {
                    txtMaHDDV.Text = "hd" + (chuoi2 + 1).ToString();
                }

                if (cboKH.Text == "-Chọn mã khách hàng-")
                {
                    MessageBox.Show("Chưa chọn mã khách", "Cảnh báo");
                    cboKH.Focus();
                    return;
                }
                else if (cboTenDV.Text == "-Chọn tên dịch vụ-")
                {
                    MessageBox.Show("Chưa nhập số lượng bán", "Cảnh báo");
                    cboTenDV.Focus();
                    return;
                }
                conn = new SqlConnection(connectionString);
                string query = "insert into HoaDonDV values('" + txtMaHDDV.Text + "','" + cboTenDV.SelectedValue + "','" + cboKH.Text + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                var result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Bạn đã thêm hóa đơn thành công!");
                    getUI();
                    State = "Reset";
                    setControl(State);
                }
            }
        }

        private void cboTenDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "Select * from DichVu where maDV='" + cboTenDV.SelectedValue + "'";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtPhiDV.Text = dr["phiDV"].ToString();
            }
            conn.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            var kq = MessageBox.Show("Bạn có thực sự muốn xóa ", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.Yes)
            {
                string query1 = "delete HoaDonDV where maHDDV='" + txtMaHDDV.Text.Trim() + "'";
                SqlCommand cmd1 = new SqlCommand(query1, conn);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                var result1 = cmd1.ExecuteNonQuery();
                if (result1 > 0)
                {
                    MessageBox.Show("Xóa hóa đơn thành công!");
                    getUI();
                    State = "Reset";
                    setControl(State);
                }
                else
                {
                    MessageBox.Show("Xóa hóa đơn thất bại!");
                }
            }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            try
            {
                export2Excel(dgvHoaDonDV, @"D:\", "HoaDonDichVu");
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
        private void designButton2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cboTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtPhiDV_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTenKH_Click(object sender, EventArgs e)
        {

        }

        private void txtMaHDDV_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
