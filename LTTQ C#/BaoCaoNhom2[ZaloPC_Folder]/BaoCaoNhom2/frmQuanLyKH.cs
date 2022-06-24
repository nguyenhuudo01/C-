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


namespace BaoCaoNhom2
{
    public partial class frmQuanLyKH : Form
    {
        string connectionString = BaoCaoNhom2.KetnoiDataBase.sqlcon;
        public static string query1 = "Select * from Khachhang";
        public static string state = "";
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;
        public string cv1;
        public frmQuanLyKH()
        {
            InitializeComponent();
            
            getData();
            Namecolumn();
            state = "Reset";
            setControl(state);
        }
        public frmQuanLyKH(string cv) : this()
        {
            cv1 = cv;
        }

        

        private void Namecolumn()
        {
            dgvKH.EnableHeadersVisualStyles = false; //Gets or sets a value indicating whether row and column headers use the visual styles of the user's current theme if visual styles are enabled for the application.
            dgvKH.ColumnHeadersDefaultCellStyle.BackColor = Color.Aquamarine; // gán cột màu header = color
            dgvKH.Columns[0].HeaderText = "Mã khách hàng"; dgvKH.Columns[0].Width = 170;
            dgvKH.Columns[1].HeaderText = "Tên khách hàng"; dgvKH.Columns[1].Width = 300;
            dgvKH.Columns[2].HeaderText = "Ngày sinh"; dgvKH.Columns[2].Width = 150;
            dgvKH.Columns[3].HeaderText = "Giới tính"; dgvKH.Columns[3].Width = 120;
            dgvKH.Columns[4].HeaderText = "Số điện thoại"; dgvKH.Columns[4].Width = 200;
            dgvKH.Columns[5].HeaderText = "Số CMND"; dgvKH.Columns[5].Width = 200;
            dgvKH.Columns[6].HeaderText = "Email"; dgvKH.Columns[6].Width = 300;
            dgvKH.Columns[7].HeaderText = "Địa chỉ"; dgvKH.Columns[7].Width = 370;
            int sc = dgvKH.Rows.Count;
            int index = 0;
            int last = sc - 1;
            //lbl_solg.Text = "Số lượng bản ghi : " + (sc - 1);
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }
        private void setControl(string state)
        {
            switch (state)
            {
                case "Reset":
                    txtMaKH.TextName = "";
                    txtTenKH.TextName = "";
                    txtDiaChi.TextName = "";
                    txtEmail.TextName = "";
                    txtCMND.TextName = "";
                    txtSDT.TextName = "";
                    txtTimKiem.Text = "";
                    dtpNgaySinh.Enabled = false;
                    rdoNam.Enabled = false;
                    rdoNu.Enabled = false;
                    txtMaKH.Enabled = false;
                    txtTenKH.Enabled = false;
                    txtDiaChi.Enabled = false;
                    txtEmail.Enabled = false;
                    txtCMND.Enabled = false;
                    txtSDT.Enabled = false;
                    btnHuy.Enabled = false;
                    btnGhi.Enabled = false;
                    btnXoa.Enabled = false;
                    btnThem.Enabled = true;
                    btnSua.Enabled = false;
                    break;
                case "Add":
                    dtpNgaySinh.Enabled = true;
                    rdoNam.Enabled = true;
                    rdoNu.Enabled = true;
                    txtMaKH.Enabled = true;
                    txtTenKH.Enabled = true;
                    txtDiaChi.Enabled = true;
                    txtEmail.Enabled = true;
                    txtCMND.Enabled = true;
                    txtSDT.Enabled = true;
                    btnHuy.Enabled = true;
                    btnGhi.Enabled = true;
                    btnXoa.Enabled = false;
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    break;
                case "Update":
                    dtpNgaySinh.Enabled = true;
                    rdoNam.Enabled = true;
                    rdoNu.Enabled = true;
                    txtMaKH.Enabled = false;
                    txtTenKH.Enabled = true;
                    txtDiaChi.Enabled = true;
                    txtEmail.Enabled = true;
                    txtCMND.Enabled = true;
                    txtSDT.Enabled = true;
                    btnHuy.Enabled = true;
                    btnGhi.Enabled = true;
                    btnXoa.Enabled = false;
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    break;
            }
        }

        private void getData()
        {
            KetnoiDataBase.Chuoiketnoi(query1, dgvKH);
        }

        private void designButton5_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            state = "Add";
            setControl(state);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            state = "Reset";
            setControl(state);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var Result1 = MessageBox.Show("Bạn có chắc muốn quay về Home không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result1 == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var Result1 = MessageBox.Show("Bạn có muốn xóa thông tin khách hàng này hay không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (Result1 == DialogResult.Yes)
            {
                string queryDelete = "delete Khachhang where MaKH='" + txtMaKH.TextName.Trim() + "'";
                KetnoiDataBase.Chuoiketnoi(queryDelete, dgvKH);
                MessageBox.Show("Xóa thông tin khách hàng thành công!!!", "Thông báo", MessageBoxButtons.OK);
                getData();
                Namecolumn();
                setControl("Reset");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            state = "Update";
            setControl(state);
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            if (state == "Add")
            {
                var Result = MessageBox.Show("Bạn có muốn thêm khách hàng có mã ["+txtMaKH.TextName.Trim()+"] hay không?", "Cảnh báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (Result == DialogResult.Yes)
                {
                    string gt = "";
                    if (rdoNam.Checked == true)
                        gt = "Nam";
                    else
                        gt = "Nữ";
                    conn = new SqlConnection(connectionString);
                    string queryCheck = "Select * from Khachhang where MaKH='" + txtMaKH.TextName.Trim() + "'";
                    SqlCommand cmdCheck = new SqlCommand(queryCheck, conn);
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    da = new SqlDataAdapter(cmdCheck);
                    ds = new DataSet();
                    da.Fill(ds);
                    if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        MessageBox.Show("Đã tồn tại mã nhân viên " + txtMaKH.TextName + " trong hệ thống");
                        txtMaKH.Focus();
                        return;
                    }
                    string query = "Insert into Khachhang values(N'" + txtMaKH.TextName + "',"
                        + "N'" + txtTenKH.TextName + "','" + Convert.ToDateTime(dtpNgaySinh.Value).ToString("yyyy-MM-dd")
                        + "',N'" + gt.Trim() + "','" + txtSDT.TextName + "','" + txtCMND.TextName
                        + "','" + txtEmail.TextName + "','" + txtDiaChi.TextName + "')";
                    KetnoiDataBase.Chuoiketnoi(query, dgvKH);
                    getData();
                    Namecolumn();
                    setControl("Reset");
                }
            }
            else if (state == "Update")
            {

                var Result = MessageBox.Show("Bạn có muốn thay đổi dữ liệu hay không?", "Cảnh báo", MessageBoxButtons.YesNo);
                if (Result == DialogResult.Yes)
                {
                    string gt = "";
                    if (rdoNam.Checked == true)
                        gt = "Nam";
                    else
                        gt = "Nữ";

                    string query = "Update Khachhang set Tenkh = N'" + txtTenKH.TextName + "',"
                        + "Ngaysinh = N'" + Convert.ToDateTime(dtpNgaySinh.Value).ToString("yyyy-MM-dd") + "'," + "gioitinh = N'" + gt.Trim()
                        + "',sdt = '" + txtSDT.TextName + "',Cmnd='" + txtCMND.TextName + "',Email='" + txtEmail.TextName + "',Diachi ='" + txtDiaChi.TextName + "'"
                        + "where MaKH = '" + txtMaKH.TextName + "'";

                    KetnoiDataBase.Chuoiketnoi(query, dgvKH);
                    getData();
                    Namecolumn();
                    setControl("Reset");
                }
            }
        }

        private void dgvKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string gt = "";
            int RowIndex = e.RowIndex;
            DataGridViewRow select = dgvKH.Rows[RowIndex];
            txtMaKH.TextName = select.Cells["MaKH"].Value.ToString();
            txtTenKH.TextName = select.Cells["Tenkh"].Value.ToString();
            dtpNgaySinh.Value = Convert.ToDateTime(select.Cells["Ngaysinh"].Value.ToString());
            gt = select.Cells["gioitinh"].Value.ToString();

            if (gt == "Nam")
                rdoNam.Checked = true;
            else
                rdoNu.Checked = true;
            txtSDT.TextName = select.Cells["sdt"].Value.ToString();
            txtCMND.TextName = select.Cells["Cmnd"].Value.ToString();
            txtEmail.TextName = select.Cells["Email"].Value.ToString();
            txtDiaChi.TextName = select.Cells["Diachi"].Value.ToString();
            dtpNgaySinh.Enabled = true;
            rdoNam.Enabled = true;
            rdoNu.Enabled = true;
            txtMaKH.Enabled = false;
            txtTenKH.Enabled = true;
            txtDiaChi.Enabled = true;
            txtEmail.Enabled = true;
            txtCMND.Enabled = true;
            txtSDT.Enabled = true;
            btnHuy.Enabled = true;
            btnGhi.Enabled = false;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = true;
        }

        private void PopulateData(int curow)
        {
            string gt = "";

            txtMaKH.TextName = dgvKH.Rows[curow].Cells[0].Value.ToString();
            txtTenKH.TextName = dgvKH.Rows[curow].Cells[1].Value.ToString();
            dtpNgaySinh.Text = dgvKH.Rows[curow].Cells[2].Value.ToString();
            gt = dgvKH.Rows[curow].Cells[3].Value.ToString();
            if (String.Compare(gt, "Nam") == 0)
                rdoNam.Checked = true;
            else
                rdoNu.Checked = true;
            txtSDT.TextName = dgvKH.Rows[curow].Cells[4].Value.ToString();
            txtCMND.TextName = dgvKH.Rows[curow].Cells[5].Value.ToString();
            txtEmail.TextName = dgvKH.Rows[curow].Cells[6].Value.ToString();
            txtDiaChi.TextName = dgvKH.Rows[curow].Cells[7].Value.ToString();

            txtMaKH.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = true;

        }

        private void designButton7_Click(object sender, EventArgs e)
        {
            int index = dgvKH.CurrentRow.Index;
            index = 0;
            PopulateData(index);
            dgvKH.CurrentCell = dgvKH.Rows[index].Cells[0];
        }

        private void designButton8_Click(object sender, EventArgs e)
        {
            int index = dgvKH.CurrentRow.Index;
            index--;
            index = index < 0 ? 0 : index;
            PopulateData(index);
            dgvKH.CurrentCell = dgvKH.Rows[index].Cells[0];
        }

        private void designButton9_Click(object sender, EventArgs e)
        {
            int index = dgvKH.CurrentRow.Index;
            index = index + 1;
            int sc = dgvKH.Rows.Count;
            int last = sc - 1;
            if (index >= last)
            {
                index = 0;

                PopulateData(index);
                dgvKH.CurrentCell = dgvKH.Rows[index].Cells[0];
            }
            else
            {
                PopulateData(index);
                dgvKH.CurrentCell = dgvKH.Rows[index].Cells[0];
            }
        }

        private void designButton10_Click(object sender, EventArgs e)
        {
            int sc = dgvKH.Rows.Count;
            int last = sc - 1;
            int index = last - 1;
            PopulateData(index);
            dgvKH.CurrentCell = dgvKH.Rows[index].Cells[0];
        }

        private void export2Excel(DataGridView g, string duongDan, string tenTap)
        {
            Microsoft.Office.Interop.Excel.Application obj = new Microsoft.Office.Interop.Excel.Application(); 
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

        private void btnExcel_Click(object sender, EventArgs e)
        {
            export2Excel(dgvKH, @"D:\", "KhachHang");
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string sqlluachon = "";
            switch (cboLuachon.SelectedItem)
            {
                case "Mã khách hàng":
                    sqlluachon = "Select * from Khachhang where MaKH like N'%" + txtTimKiem.Text.Trim() + "%'";
                    break;
                case "Tên khách hang":
                    sqlluachon = "Select * from Khachhang where Tenkh like N'%" + txtTimKiem.Text.Trim() + "%'";

                    break;
                case "Email":
                    sqlluachon = "Select * from Khachhang where Email like N'%" + txtTimKiem.Text.Trim() + "%'";
                    break;
                case "Số CMND":
                    sqlluachon = "Select * from Khachhang where Cmnd like N'%" + txtTimKiem.Text.Trim() + "%'";
                    break;
                case "Số điện thoại":
                    sqlluachon = "Select * from Khachhang where sdt like N'%" + txtTimKiem.Text.Trim() + "%'";
                    break;
                case "Giới tính":
                    sqlluachon = "Select * from Khachhang where gioitinh like N'%" + txtTimKiem.Text.Trim() + "%'";
                    break;
                case "Ngày sinh":
                    sqlluachon = "Select * from Khachhang where Ngaysinh like N'%" + txtTimKiem.Text.Trim() + "%'";
                    break;
                case "Địa chỉ":
                    sqlluachon = "Select * from Khachhang where Diachi like N'%" + txtTimKiem.Text.Trim() + "%'";
                    break;
            }

            KetnoiDataBase.Chuoiketnoi(sqlluachon, dgvKH);
            
            Namecolumn();
        }
    }
}
         