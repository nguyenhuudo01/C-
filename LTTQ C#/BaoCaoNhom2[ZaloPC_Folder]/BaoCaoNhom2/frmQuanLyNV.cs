using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BaoCaoNhom2
{
    public partial class frmQuanLyNV : Form
    {
        string connectionString = BaoCaoNhom2.KetnoiDataBase.sqlcon;
        public static string query1 = "Select * from Nhanvien";
        public static string state = "";
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;
        public string cv1;
        
        public frmQuanLyNV()
        {
            InitializeComponent();
            
            
            getData();
            Namecolumn();
            state = "Reset";
            setControl(state);
        }

        public frmQuanLyNV(string cv) : this()
        {
            cv1 = cv;
        }
        
        private void Namecolumn()
        {
            dgvNV.EnableHeadersVisualStyles = false; //Gets or sets a value indicating whether row and column headers use the visual styles of the user's current theme if visual styles are enabled for the application.
            dgvNV.ColumnHeadersDefaultCellStyle.BackColor = Color.Aquamarine; // gán cột màu header = color
            dgvNV.Columns[0].HeaderText = "Mã nhân viên"; dgvNV.Columns[0].Width = 170;
            dgvNV.Columns[1].HeaderText = "Tên nhân viên"; dgvNV.Columns[1].Width = 300;
            dgvNV.Columns[2].HeaderText = "Ngày sinh"; dgvNV.Columns[2].Width = 150;
            dgvNV.Columns[3].HeaderText = "Giới tính"; dgvNV.Columns[3].Width = 120;
            dgvNV.Columns[4].HeaderText = "Số điện thoại"; dgvNV.Columns[4].Width = 200;
            dgvNV.Columns[5].HeaderText = "Số CMND"; dgvNV.Columns[5].Width = 200;
            dgvNV.Columns[6].HeaderText = "Email"; dgvNV.Columns[6].Width = 300;
            dgvNV.Columns[7].HeaderText = "Địa chỉ"; dgvNV.Columns[7].Width = 370;
            int sc = dgvNV.Rows.Count;
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
                    dtpNgaySinh.Enabled = false;
                    rdoNam.Enabled = false;
                    rdoNu.Enabled = false;
                    txtMaNV.TextName = "";
                    txtTenNV.TextName = "";
                    txtDiaChi.TextName = "";
                    txtEmail.TextName = "";
                    txtCMND.TextName = "";
                    txtSDT.TextName = "";
                    txtTimKiem.Text = "";
                    txtMaNV.Enabled = false;
                    txtTenNV.Enabled = false;
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
                    txtMaNV.Enabled = true;
                    txtTenNV.Enabled = true;
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
                    txtMaNV.Enabled = false;
                    txtTenNV.Enabled = true;
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
            KetnoiDataBase.Chuoiketnoi(query1, dgvNV);
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
            var Result1 = MessageBox.Show("Bạn có muốn xóa thông tin nhân viên này hay không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (Result1 == DialogResult.Yes)
            {
                string queryDelete = "delete Nhanvien where Manv='" + txtMaNV.TextName.Trim() + "'";
                KetnoiDataBase.Chuoiketnoi(queryDelete, dgvNV);
                MessageBox.Show("Xóa thông tin nhân viên thành công!!!", "Thông báo", MessageBoxButtons.OK);
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
            Boolean b ;
            if (state == "Add")
            {
                var Result = MessageBox.Show("Bạn có muốn thêm nhân viên có mã [" + txtMaNV.TextName.Trim() + "] hay không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Result == DialogResult.Yes)
                {
                    string gt = "";
                    if (rdoNam.Checked == true)
                        gt = "Nam";
                    else
                        gt = "Nữ";
                    conn = new SqlConnection(connectionString);
                    string queryCheck = "Select * from Nhanvien where Manv='" + txtMaNV.TextName.Trim() + "'";
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
                        MessageBox.Show("Đã tồn tại mã nhân viên " + txtMaNV.TextName + " trong hệ thống");
                        txtMaNV.Focus();
                        return;
                    }
                    b = check_EmailvaTen();
                    if (b==false)
                    {
                        return;
                    }
                    string query = "Insert into Nhanvien values(N'" + txtMaNV.TextName + "',"
                        + "N'" + txtTenNV.TextName + "','" + Convert.ToDateTime(dtpNgaySinh.Value).ToString("yyyy-MM-dd")
                        + "',N'" + gt.Trim() + "','" + txtSDT.TextName + "','" + txtCMND.TextName
                        + "','" + txtEmail.TextName + "','" + txtDiaChi.TextName + "')";
                    KetnoiDataBase.Chuoiketnoi(query, dgvNV);
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
                    b = check_EmailvaTen();
                    if (b == false)
                    {
                        return;
                    }
                    string query = "Update Nhanvien set Tennv = N'" + txtTenNV.TextName + "',"
                        + "Ngaysinh = N'" + Convert.ToDateTime(dtpNgaySinh.Value).ToString("yyyy-MM-dd") + "'," + "gioitinh = N'" + gt.Trim()
                        + "',sdt = '" + txtSDT.TextName + "',Cmnd='" + txtCMND.TextName + "',Email='" + txtEmail.TextName + "',Diachi ='" + txtDiaChi.TextName + "'"
                        + "where Manv = '" + txtMaNV.TextName + "'";

                    KetnoiDataBase.Chuoiketnoi(query, dgvNV);
                    getData();
                    Namecolumn();
                    setControl("Reset");
                }
            }
        }
        private Boolean check_EmailvaTen()
        {
            conn = new SqlConnection(connectionString);
            string queryCheck = "Select * from Nhanvien where Email = N'" + txtEmail.TextName.Trim()+"'";
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
                MessageBox.Show("Email đã tồn tại trong hệ thống!!!");
                txtEmail.Focus();
                return false;
            }
            return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            state = "Add";
            setControl(state);
        }

        private void dgvNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string gt = "";
            int RowIndex = e.RowIndex;
            DataGridViewRow select = dgvNV.Rows[RowIndex];
            txtMaNV.TextName = select.Cells["Manv"].Value.ToString();
            txtTenNV.TextName = select.Cells["Tennv"].Value.ToString();
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
            txtMaNV.Enabled = false;
            txtTenNV.Enabled = true;
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

            txtMaNV.TextName = dgvNV.Rows[curow].Cells[0].Value.ToString();
            txtTenNV.TextName = dgvNV.Rows[curow].Cells[1].Value.ToString();
            dtpNgaySinh.Text = dgvNV.Rows[curow].Cells[2].Value.ToString();
            gt = dgvNV.Rows[curow].Cells[3].Value.ToString();
            if (String.Compare(gt, "Nam") == 0)
                rdoNam.Checked = true;
            else
                rdoNu.Checked = true;
            txtSDT.TextName = dgvNV.Rows[curow].Cells[4].Value.ToString();
            txtCMND.TextName = dgvNV.Rows[curow].Cells[5].Value.ToString();
            txtEmail.TextName = dgvNV.Rows[curow].Cells[6].Value.ToString();

            txtDiaChi.TextName = dgvNV.Rows[curow].Cells[7].Value.ToString();
            txtMaNV.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

        }

         
        private void designButton7_Click(object sender, EventArgs e)
        {
            int index = dgvNV.CurrentRow.Index;
            index = 0;
            PopulateData(index);
            dgvNV.CurrentCell = dgvNV.Rows[index].Cells[0];
        }

        private void designButton8_Click(object sender, EventArgs e)
        {
            int index = dgvNV.CurrentRow.Index;
            index--;
            index = index < 0 ? 0 : index;
            PopulateData(index);
            dgvNV.CurrentCell = dgvNV.Rows[index].Cells[0];
        }

        private void designButton9_Click(object sender, EventArgs e)
        {
            int index = dgvNV.CurrentRow.Index;
            index = index + 1;
            int sc = dgvNV.Rows.Count;
            int last = sc - 1;
            if (index >= last)
            {
                index = 0;

                PopulateData(index);
                dgvNV.CurrentCell = dgvNV.Rows[index].Cells[0];
            }
            else
            {
                PopulateData(index);
                dgvNV.CurrentCell = dgvNV.Rows[index].Cells[0];
            }
        }

        private void designButton10_Click(object sender, EventArgs e)
        {
            int sc = dgvNV.Rows.Count;
            int last = sc - 1;
            int index = last - 1;
            PopulateData(index);
            dgvNV.CurrentCell = dgvNV.Rows[index].Cells[0];
        }

        private void export2Excel(DataGridView g, string duongDan, string tenTap)
        {
            Microsoft.Office.Interop.Excel.Application obj = new Microsoft.Office.Interop.Excel.Application();
            //tạo trang tính mới
            obj.Application.Workbooks.Add(Type.Missing);
            //cài độ rộng cột
            obj.Columns.ColumnWidth = 25;
            //duyệt tiêu đề datagridview
            for (int i = 1; i < g.Columns.Count + 1; i++)
            {
                //gán các giá trị của datagridview cho các tọa độ của excel[1,1],...
                obj.Cells[1, i] = g.Columns[i - 1].HeaderText;

            }
            //duyệt các giá trị của các tiêu đề trong datagridview
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
            //lưu excel
            obj.ActiveWorkbook.SaveCopyAs(duongDan + tenTap + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            export2Excel(dgvNV, @"D:\", "NhanVien");
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string sqlluachon = "";
            switch (cboLuachon.SelectedItem)
            {
                case "Mã nhân viên":
                    sqlluachon = "Select * from Nhanvien where Manv like N'%" + txtTimKiem.Text.Trim() + "%'";
                    break;
                case "Tên nhân viên":
                    sqlluachon = "Select * from Nhanvien where Tennv like N'%" + txtTimKiem.Text.Trim() + "%'"; 
                    
                    break;
                case "Email":
                    sqlluachon = "Select * from Nhanvien where Email like N'%" + txtTimKiem.Text.Trim() + "%'"; 
                    break;
                case "Số cmnd":
                    sqlluachon = "Select * from Nhanvien where Cmnd like N'%" + txtTimKiem.Text.Trim()+ "%'";
                    break;
                case "Số điện thoại":
                    sqlluachon = "Select * from Nhanvien where sdt like N'%" + txtTimKiem.Text.Trim() + "%'";
                    break;
                case "Giới tính":
                    sqlluachon = "Select * from Nhanvien where gioitinh like N'%" + txtTimKiem.Text.Trim() + "%'";
                    break;
                case "Ngày sinh":
                    sqlluachon = "Select * from Nhanvien where Ngaysinh like N'%" + txtTimKiem.Text.Trim() + "%'";
                    break;
                case "Địa chỉ":
                    sqlluachon = "Select * from Nhanvien where Diachi like N'%" + txtTimKiem.Text.Trim() + "%'";
                    break;
            }

            KetnoiDataBase.Chuoiketnoi(sqlluachon, dgvNV);
            Namecolumn();
        }

        private void cboLuachon_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
