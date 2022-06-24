using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaoCaoNhom2
{
    public partial class frmQuanLyTK : Form
    {
        string connectionString = BaoCaoNhom2.KetnoiDataBase.sqlcon;
        public static string query1 = "SELECT d.Taikhoan,d.Matkhau,d.FullName,d.Email,d.phanquyen,d.trangthai,n.Cmnd,n.sdt,n.gioitinh,n.Manv " +
            "FROM dbo.DangNhap d  ,dbo.Nhanvien n " +
            "WHERE d.Email = n.Email";
        public static string query2 = "SELECT n.Tennv,n.Email FROM  Nhanvien n  WHERE NOT EXISTS (SELECT * FROM DangNhap " +
            "WHERE n.Tennv = DangNhap.FullName AND n.Email = DangNhap.Email)";
        public static string state = "";
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;
        public frmQuanLyTK()
        {
            InitializeComponent();
            
            getData();
            Namecolumn();
            state = "Reset";
            setControl(state);
        }

        private void Namecolumn()
        {
            dgvNoTK.EnableHeadersVisualStyles = false; //Gets or sets a value indicating whether row and column headers use the visual styles of the user's current theme if visual styles are enabled for the application.
            dgvNoTK.ColumnHeadersDefaultCellStyle.BackColor = Color.Aquamarine; // gán cột màu header = color
            dgvNoTK.Columns[0].HeaderText = "Tên NV";
            dgvNoTK.Columns[0].Width = 200;
            dgvNoTK.Columns[1].HeaderText = "Email";
            dgvNoTK.Columns[1].Width = 200;
            dgvTK.EnableHeadersVisualStyles = false; //Gets or sets a value indicating whether row and column headers use the visual styles of the user's current theme if visual styles are enabled for the application.
            dgvTK.ColumnHeadersDefaultCellStyle.BackColor = Color.Aquamarine; // gán cột màu header = color
            dgvTK.Columns[0].HeaderText = "Tài khoản";
            dgvTK.Columns[0].Width = 200;
            dgvTK.Columns[1].HeaderText = "Mật khẩu";
            dgvTK.Columns[1].Width = 150;
            dgvTK.Columns[2].HeaderText = "Họ và tên";
            dgvTK.Columns[2].Width = 250;
            dgvTK.Columns[3].HeaderText = "Email"; dgvTK.Columns[3].Width = 300;
            dgvTK.Columns[4].HeaderText = "Phân Quyền"; dgvTK.Columns[4].Width = 100;
            dgvTK.Columns[5].HeaderText = "Trạng Thái"; dgvTK.Columns[5].Width = 100;
            dgvTK.Columns[6].HeaderText = "Số Cmnd"; dgvTK.Columns[6].Width = 200;
            dgvTK.Columns[7].HeaderText = "SĐT"; dgvTK.Columns[7].Width = 200;
            dgvTK.Columns[8].HeaderText = "Giới Tính"; dgvTK.Columns[8].Width = 100;
            dgvTK.Columns[9].HeaderText = "Mã nhân viên"; dgvTK.Columns[9].Width = 200;
            dgvTK.Columns[10].HeaderText = "View_Phân Quyền"; dgvTK.Columns[10].Width = 200;
            dgvTK.Columns[11].HeaderText = "View_Trạng Thái"; dgvTK.Columns[11].Width = 200;


            int sc = dgvTK.Rows.Count;
            int index = 0;
            int last = sc - 1;
            dgvTK.Columns[4].Visible = false;
            dgvTK.Columns[5].Visible = false;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }
        private void PopulateData(int curow)
        {
            string quyen = "";
            string trangthai = "";
            txtTK.TextName = dgvTK.Rows[curow].Cells[0].Value.ToString();
            txtMK.TextName = dgvTK.Rows[curow].Cells[1].Value.ToString();
            txtTen.TextName = dgvTK.Rows[curow].Cells[2].Value.ToString();
            txtEmail.TextName = dgvTK.Rows[curow].Cells[3].Value.ToString();
            quyen = dgvTK.Rows[curow].Cells[4].Value.ToString();
            trangthai = dgvTK.Rows[curow].Cells[5].Value.ToString();
            if (quyen == "1") cboPhanQuyen.Text = "Admin";
            if (quyen == "2") cboPhanQuyen.Text = "Quản lý";
            if (quyen == "3") cboPhanQuyen.Text = "Nhân viên";
            if (trangthai == "1")
            {
                cboTrangThai.Text = "Hoạt động";
                btnKhoa.Enabled = true;
                btnMoKhoa.Enabled = false;
            }

            if (trangthai == "0")
            {
                cboTrangThai.Text = "Khóa";

                btnKhoa.Enabled = false;
                btnMoKhoa.Enabled = true;

            }
            txtTK.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = true;
            btnGhi.Enabled = false;
        }
        private void setControl(string state)
        {
            switch (state)
            {
                case "Reset":
                    txtTK.TextName = "";
                    txtTen.TextName = "";
                    txtMK.TextName = "";
                    txtEmail.TextName = "";
                    cboPhanQuyen.Text = "Lựa chọn quyền tài khoản";
                    cboTrangThai.Text = "Lựa chọn trạng thái tài khoản";
                    txtTK.Enabled = false;
                    txtTen.Enabled = false;
                    txtMK.Enabled = false;
                    txtEmail.Enabled = false;
                    cboPhanQuyen.Enabled = false;
                    cboTrangThai.Enabled = false;
                    btnHuy.Enabled = false;
                    btnGhi.Enabled = false;
                    btnKhoa.Enabled = false;
                    btnMoKhoa.Enabled = false;
                    btnXoa.Enabled = false;
                    btnThem.Enabled = true;
                    btnSua.Enabled = false;
                    break;
                case "Add":
                    txtTK.Enabled = true;
                    txtTen.Enabled = true;
                    txtMK.Enabled = true;
                    txtEmail.Enabled = true;
                    cboPhanQuyen.Enabled = true;
                    cboTrangThai.Enabled = true;
                    btnKhoa.Enabled = false;
                    btnMoKhoa.Enabled = false;
                    btnHuy.Enabled = true;
                    btnGhi.Enabled = true;
                    btnXoa.Enabled = false;
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    break;
                case "Update":
                    txtTK.Enabled = false;
                    txtTen.Enabled = true;
                    txtMK.Enabled = true;
                    txtEmail.Enabled = true;
                    cboPhanQuyen.Enabled = true;
                    cboTrangThai.Enabled = true;
                    btnKhoa.Enabled = false;
                    btnMoKhoa.Enabled = false;
                    btnHuy.Enabled = true;
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
            KetnoiDataBase.Chuoiketnoi1(query1, dgvTK);
            KetnoiDataBase.Chuoiketnoi(query2, dgvNoTK);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            state = "Add";
            setControl(state);
        }

        private void dgvTK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int RowIndex = e.RowIndex;
            
            PopulateData(RowIndex);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            state = "Update";
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
            var Result1 = MessageBox.Show("Bạn có muốn xóa thông tin tài khoản này hay không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (Result1 == DialogResult.Yes)
            {
                string queryDelete = "delete DangNhap where Taikhoan='" + txtTK.TextName.Trim() + "'";
                KetnoiDataBase.Chuoiketnoi(queryDelete, dgvTK);
                MessageBox.Show("Xóa tài khoản thành công!!!", "Thông báo", MessageBoxButtons.OK);
                getData();
                Namecolumn();
                setControl("Reset");
            }
        }
        //Hàm check email
        public static bool isEmail(string inputEmail)
        {
            inputEmail = inputEmail ?? string.Empty;
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }

        // hàm trả về quyền sử dung admin, quản lý, người dùng.
        int check_quyen(string quyen)
        {
            int quyenq = 0;
            if (quyen.ToString().Equals("Admin")==true) quyenq = 1;
            if (quyen.ToString().Equals("Quản lý")==true) quyenq = 2;
            if (quyen.ToString().Equals("Nhân viên")==true || quyen.ToString().Equals("")==true) quyenq = 3;
            return quyenq;
        }
        // hàm trả về trạng thái sử dụng
        int check_trangthai(string quyen1)
        {
            int tt = 0;
            if (quyen1.ToString().Equals("Hoạt động")==true) tt = 1;
            if (quyen1.ToString().Equals("Khóa")==true) tt = 0;
            return tt;
        }
        private Boolean check_EmailvaTen()
        {
            conn = new SqlConnection(connectionString);
            string queryCheck = "Select * from Nhanvien where Tennv = N'"+txtTen.TextName.Trim()+"'And Email = N'" + txtEmail.TextName.Trim() + "'";
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
                return true;
            }
            else
            {
                MessageBox.Show("Không tồn tại nhân viên có email và tên này trong hệ thống!!!");
                txtEmail.Focus();
                return false;
            }
        }
        private Boolean check_EmailLap()
        {
            conn = new SqlConnection(connectionString);
            string queryCheck = "Select * from DangNhap where Email = N'" + txtEmail.TextName.Trim() + "'";
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
                MessageBox.Show("Email của nhân viên đã được dùng cho 1 tài khoản khác trong hệ thống!!!");
                txtEmail.Focus();
                return false;
            }
            return true;
        }
        private void btnGhi_Click(object sender, EventArgs e)
        {
            Boolean b;
            if (state == "Add")
            {
                var Result = MessageBox.Show("Bạn có muốn thêm tài khoản không?", "Cảnh báo", MessageBoxButtons.YesNo);
                if (Result == DialogResult.Yes)
                {
                    if (txtMK.TextName == "" || txtTK.TextName == "" || txtEmail.TextName == "" || txtTen.TextName == "")
                    {
                        MessageBox.Show("Ban chưa nhập đầy đủ thông Tin !", "Error", MessageBoxButtons.OK);
                    }
                    else
                    {
                        conn = new SqlConnection(connectionString);
                        string queryCheck = "Select * from DangNhap where Taikhoan='" + txtTK.TextName.Trim() + "'";
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
                            MessageBox.Show("Đã tồn tại tài khoản " + txtTK.TextName + " trong hệ thống");
                            txtTK.Focus();
                            return;
                        }
                        string username = txtTK.TextName.Trim();
                        string password = txtMK.TextName.Trim();
                        string fullname = txtTen.TextName.Trim();
                        string mail = txtEmail.TextName.Trim(); ;
                        string quyen = cboPhanQuyen.Text;
                        string trangthai = cboTrangThai.Text;
                        int q1 = check_quyen(quyen);
                        int t1 = check_trangthai(trangthai);
                        if (username.Length > 20)
                        {
                            MessageBox.Show("tên tài khoản quá dài ! chỉ nhập nhiều nhất 15 ký tự", "Error", MessageBoxButtons.OK);
                            txtTK.TextName = "";
                            txtTK.Focus();

                        }
                        else if (isEmail(txtEmail.TextName) == false)
                        {
                            MessageBox.Show("Định dạng mail sai vui lòng kiểm tra lại ", "Error", MessageBoxButtons.OK);
                            txtEmail.TextName = "";
                            txtEmail.Focus();
                        }
                        else
                        {

                            b = check_EmailvaTen();
                            if (b == false)
                            {
                                return;
                            }
                            b = check_EmailLap();
                            if (b == false)
                            {
                                return;
                            }
                            string sql1 = "Insert into DangNhap values(N'" + username + "',N'" + password + "',"
                                        + "N'" + fullname + "','" + mail + "','" + q1 + "','" + t1 + "')";
                            KetnoiDataBase.Chuoiketnoi(sql1, dgvTK);
                            getData();
                            Namecolumn();
                            setControl("Reset");
                        }
                    }

                }
            }
            else if (state == "Update")
            {

                var Result = MessageBox.Show("Bạn có muốn thay đổi dữ liệu hay không?", "Cảnh báo", MessageBoxButtons.YesNo);
                if (Result == DialogResult.Yes)
                {
                    if (isEmail(txtEmail.TextName) == false)
                    {
                        MessageBox.Show("Định dạng mail sai vui lòng kiểm tra lại ", "Error", MessageBoxButtons.OK);
                        txtEmail.TextName = "";
                        txtEmail.Focus();
                    }
                    else
                    {
                        string username = txtTK.TextName.Trim();
                        string password = txtMK.TextName.Trim();
                        string fullname = txtTen.TextName.Trim();
                        string mail = txtEmail.TextName.Trim();
                        string quyen = cboPhanQuyen.Text;
                        string trangthai = cboTrangThai.Text;
                        int q1 = check_quyen(quyen);
                        int t1 = check_trangthai(trangthai);
                        b = check_EmailvaTen();
                        if (b == false)
                        {
                            return;
                        }
                        b = check_EmailLap();
                        if (b == false)
                        {
                            return;
                        }
                        string sql = "Update DangNhap set Matkhau = N'" + password + "',"
                            + "FullName = N'" + fullname + "',Email = '" + mail + "',"
                            + "phanquyen = '" + q1 + "', trangthai='" + t1 + "'  where Taikhoan = '" + username + "'";

                        KetnoiDataBase.Chuoiketnoi(sql, dgvTK);
                        getData();
                        Namecolumn();
                        setControl("Reset");

                    }
                }
            }
        }

        private void designButton7_Click(object sender, EventArgs e)
        {
            int index = dgvTK.CurrentRow.Index;
            index = 0;
            PopulateData(index);
            dgvTK.CurrentCell = dgvTK.Rows[index].Cells[0];
        }

        private void designButton8_Click(object sender, EventArgs e)
        {
            int index = dgvTK.CurrentRow.Index;
            index--;
            index = index < 0 ? 0 : index;
            PopulateData(index);
            dgvTK.CurrentCell = dgvTK.Rows[index].Cells[0];
        }

        private void designButton9_Click(object sender, EventArgs e)
        {
            int index = dgvTK.CurrentRow.Index;
            index = index + 1;
            int sc = dgvTK.Rows.Count;
            int last = sc - 1;
            if (index >= last)
            {
                index = 0;

                PopulateData(index);
                dgvTK.CurrentCell = dgvTK.Rows[index].Cells[0];
            }
            else
            {
                PopulateData(index);
                dgvTK.CurrentCell = dgvTK.Rows[index].Cells[0];
            }
        }

        private void designButton10_Click(object sender, EventArgs e)
        {
            int sc = dgvTK.Rows.Count;
            int last = sc - 1;
            int index = last - 1;
            PopulateData(index);
            dgvTK.CurrentCell = dgvTK.Rows[index].Cells[0];
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            
            string sqlluachon = "";
            switch (cboLuachon.SelectedItem)
            {
                case "Tài Khoản":
                    sqlluachon = "Select * from DangNhap where Taikhoan like '%" + txtTimKiem.Text.Trim() + "%'";
                    break;
                case "Email":
                    sqlluachon = "Select * from DangNhap where Email like '%" + txtTimKiem.Text.Trim() + "%'";

                    break;
                case "Họ và tên":
                    sqlluachon = "Select * from DangNhap where FullName like '%" + txtTimKiem.Text.Trim() + "%'";
                    break;
                case "Phân quyền":
                    int quyen = 0;
                    string quyen1 = txtTimKiem.Text.Trim();
                    string quyen2 = "admin";
                    string quyen4 = "nhân viên";
                    string quyen3 = "quản lý";
                    if (quyen2.Contains(quyen1) == true )
                        quyen = 1;
                    if (quyen3.Contains(quyen1) == true)
                        quyen = 2;
                    if (quyen4.Contains(quyen1) == true)
                        quyen = 3;
                    sqlluachon = "Select * from DangNhap where phanquyen =" + quyen ;
                    break;
                case "Trạng thái":
                    int t = 0;
                    string tt = txtTimKiem.Text.Trim();
                    string tt1 = "khóa";
                    string tt2 = "hoạt động";
                    if (tt1.Contains(tt) == true)
                        t = 0;
                    if (tt2.Contains(tt) == true)
                        t = 1;
                            sqlluachon = "Select * from DangNhap where trangthai like " + t ;
                    break;
                
            }

            KetnoiDataBase.Chuoiketnoi(sqlluachon, dgvTK);
            Namecolumn();
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            int trangthai = 0;
            string sql = "Update DangNhap set trangthai='" + trangthai + "'  where Taikhoan = '" + txtTK.TextName + "'";
            if (MessageBox.Show("Bạn có chắc chăn muốn khóa tài khoản này ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                KetnoiDataBase.Rekey(sql);
                MessageBox.Show("Bạn khóa thành công ! tài khoản sẽ không thế đăng nhập được ", "Thông báo", MessageBoxButtons.OK);
                KetnoiDataBase.Chuoiketnoi(query1, dgvTK);
                getData();
                Namecolumn();
                setControl("Reset");
            }
        }

        private void btnMoKhoa_Click(object sender, EventArgs e)
        {
            int trangthai = 1;
            if (MessageBox.Show("Bạn có chắc chăn muốn mở khóa tài khoản này ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string sql = "Update DangNhap set trangthai='" + trangthai + "'  where Taikhoan = '" + txtTK.TextName + "'";
                KetnoiDataBase.Rekey(sql);
                MessageBox.Show("Bạn mở khóa thành công ! tài khoản hoạt động bình thường ", "Thông báo", MessageBoxButtons.OK);
                KetnoiDataBase.Chuoiketnoi(query1, dgvTK);
                getData();
                Namecolumn();
                setControl("Reset");
            }
        }
        private void PopulateData1(int curow)
        {
            
            txtTen.TextName = dgvNoTK.Rows[curow].Cells[0].Value.ToString();
            txtEmail.TextName = dgvNoTK.Rows[curow].Cells[1].Value.ToString();
            
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = e.RowIndex;

            PopulateData1(RowIndex);
        }
    }
}
