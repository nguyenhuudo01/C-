using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace BaoCaoNhom2
{
    class KetnoiDataBase
    {
        public static string sqlcon = @"Data Source=DESKTOP-63TNGNI\SQLEXPRESS;Initial Catalog=BaoCaoNhom2;Integrated Security=True";
        
        private static SqlConnection mycon;
        public static SqlCommand com;
        public static SqlDataAdapter ad;
        public static DataTable dt;
        // DataTable table;


        public static void Chuoiketnoi1(string query, DataGridView db1)
        {
            try
            {

                SqlCommand cmd = new SqlCommand(query, mycon);
                if (mycon.State == ConnectionState.Closed)
                {
                    mycon.Open();
                }
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    DataColumn cpq = new DataColumn();
                    cpq.ColumnName = "View_phân quyền";
                    ds.Tables[0].Columns.Add(cpq);
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        if (ds.Tables[0].Rows[i]["phanquyen"].ToString() == "1")
                        {
                            ds.Tables[0].Rows[i]["View_phân quyền"] = "Amin";
                        }
                        else if (ds.Tables[0].Rows[i]["phanquyen"].ToString() == "2")
                            ds.Tables[0].Rows[i]["View_phân quyền"] = "Quản lý";
                        else if (ds.Tables[0].Rows[i]["phanquyen"].ToString() == "3")
                            ds.Tables[0].Rows[i]["View_phân quyền"] = "Nhân viên";

                    }
                    DataColumn ctt = new DataColumn();
                    ctt.ColumnName = "View_trạng thái";
                    ds.Tables[0].Columns.Add(ctt);
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        if (ds.Tables[0].Rows[i]["trangthai"].ToString() == "0")
                        {
                            ds.Tables[0].Rows[i]["View_trạng thái"] = "Khóa";
                        }
                        else if (ds.Tables[0].Rows[i]["trangthai"].ToString() == "1")
                        {
                            ds.Tables[0].Rows[i]["View_trạng thái"] = "Hoạt động";
                        }
                        
                    }


                    db1.DataSource = ds.Tables[0];
                    db1.AutoGenerateColumns = false;
                }
                mycon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối " + ex, "Thông báo ! ");

            }
        }

        
        // hàm kết nối
        public static void Chuoiketnoi(string chuoi, DataGridView db1)
        {
            try
            {

                ad = new SqlDataAdapter(chuoi, sqlcon);
                dt = new DataTable();
                bd = new SqlCommandBuilder(ad);
                ad.Fill(dt);
                db1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối " + ex, "Thông báo ! ");

            }
        }
        /// <summary>
        /// Lấy object đầu tiên 
        /// </summary>
        /// <typeparam name="T">Type: kiểu dữ liệu (string, int, Hoocsinh, Object)</typeparam>
        /// <param name="chuoi"></param>
        /// <returns></returns>

        public static T ketnoi<T>(string chuoi)
        {
            T rs = default(T);
            using (mycon = new SqlConnection(sqlcon))
            {
                com = new SqlCommand(chuoi, mycon);
                try
                {
                    mycon.Open();
                    rs = (T)com.ExecuteScalar();
                }
                catch (Exception)
                {

                }

            }

            return rs;
        }


        // Hàm Tìm kiếm
        public static void timkiem(string chuoi, DataGridView db2)
        {
            try
            {
                ad = new SqlDataAdapter(chuoi, sqlcon);
                dt = new DataTable();
                bd = new SqlCommandBuilder(ad);
                ad.Fill(dt);
                db2.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }
        public static SqlCommandBuilder bd;
        public static BindingSource code;
        // hàm xử lý combobox
        public static void xulycbx(string chuoi, ComboBox cbx)
        {
            ad = new SqlDataAdapter(chuoi, sqlcon);
            dt = new DataTable();

            ad.Fill(dt);
            cbx.DataSource = dt;
        }

        // hàm thêm dữ liệu

        public static void them_dl(string sql1, DataGridView dt)
        {
            try
            {
                mycon = new SqlConnection(sqlcon);
                mycon.Open();
                com = new SqlCommand(sql1, mycon);
                ad = new SqlDataAdapter(com);
                DataTable tb = new DataTable();
                ad.Fill(tb);
                dt.DataSource = tb;
                MessageBox.Show("Them Thanh công !", "Thong báo ");
                mycon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "" + ex);
            }

        }

        // hàm xóa dữ liệu
        public static void Xoa(string sql)
        {
            if (MessageBox.Show("Bạn có chắc chăn muốn Xóa không ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    mycon = new SqlConnection(sqlcon);
                    mycon.Open();
                    com = new SqlCommand(sql, mycon);
                    com.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Bạn không thể xóa ! Vui lòng ktra lại ");
                }
            }
        }


        // hàm sửa 
        public static void Sua(string sql)
        {
            if (MessageBox.Show("Bạn có chắc chăn muốn sửa không ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                try
                {
                    mycon = new SqlConnection(sqlcon);
                    mycon.Open();
                    com = new SqlCommand(sql, mycon);
                    com.ExecuteNonQuery();
                    mycon.Close();
                    MessageBox.Show("Bạn sửa thành công ! ", "Thông báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);

                }
            }
        }

        // update số lượng kho
        public static void update_solg(string sql)
        {

            try
            {
                mycon = new SqlConnection(sqlcon);
                mycon.Open();
                com = new SqlCommand(sql, mycon);
                com.ExecuteNonQuery();
                mycon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);

            }

        }
        // lấy ra ho tên đầy đủ
        public static string load(string chuoi, string hoten)
        {
            mycon = new SqlConnection(sqlcon);
            ad = new SqlDataAdapter(chuoi, sqlcon);

            dt = new DataTable("trang");
            ad.Fill(dt);
            code = new BindingSource();

            foreach (DataRow anh in dt.Rows)
            {
                code.Add(anh);
            }

            DataRow curent = (DataRow)code.Current;
            hoten = curent["FullName"].ToString();
            return hoten;
        }
        // lấy ra tên khách
        public static string load_tenkhach(string chuoi, string hoten)
        {
            mycon = new SqlConnection(sqlcon);
            ad = new SqlDataAdapter(chuoi, sqlcon);

            dt = new DataTable("trang");
            ad.Fill(dt);
            code = new BindingSource();

            foreach (DataRow anh in dt.Rows)
            {
                code.Add(anh);
            }

            DataRow curent = (DataRow)code.Current;
            hoten = curent["Tenkh"].ToString();
            return hoten;
        }
        // lấy ra ho tên đầy đủ
        public static string load_Tennv(string chuoi, string hoten)
        {
            mycon = new SqlConnection(sqlcon);
            ad = new SqlDataAdapter(chuoi, sqlcon);

            dt = new DataTable("trang");
            ad.Fill(dt);
            code = new BindingSource();

            foreach (DataRow anh in dt.Rows)
            {
                code.Add(anh);
            }

            DataRow curent = (DataRow)code.Current;
            hoten = curent["Tennv"].ToString();
            return hoten;
        }

        // ham mo khoa tai khoan
        public static void Rekey(string sql)
        {

            try
            {
                mycon = new SqlConnection(sqlcon);
                mycon.Open();
                com = new SqlCommand(sql, mycon);
                com.ExecuteNonQuery();
                mycon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);

            }

        }


        // check tài khoản bị khóa
        public static int check_key(string chuoi, int trangthai)
        {
            mycon = new SqlConnection(sqlcon);
            ad = new SqlDataAdapter(chuoi, sqlcon);

            dt = new DataTable("trang");
            ad.Fill(dt);
            code = new BindingSource();

            foreach (DataRow anh in dt.Rows)
            {
                code.Add(anh);
            }

            DataRow curent = (DataRow)code.Current;
            trangthai = Convert.ToInt32(curent["trangthai"].ToString());
            return trangthai;
        }

        public static void Execute(string sql)
        {
            if (MessageBox.Show("Bạn có chắc chăn muốn xóa không ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                try
                {
                    mycon = new SqlConnection(sqlcon);
                    mycon.Open();
                    com = new SqlCommand(sql, mycon);
                    com.ExecuteNonQuery();
                    mycon.Close();
                    MessageBox.Show("Bạn xóa thành công ! ", "Thông báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);

                }
            }
        }
        // kiem tra trung ID
        public static void them(string select, String sql1, DataGridView dt)
        {
            int i;
            mycon = new SqlConnection(sqlcon);
            mycon.Open();
            string sql = select;
            com = new SqlCommand(sql, mycon);
            i = (int)com.ExecuteScalar();


            if (i != 0)
            {
                MessageBox.Show("Mã đã tồn tại, vui lòng nhập mã mới ! ", "Error", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    them_dl(sql1, dt);
                }
                catch
                {
                    MessageBox.Show("Tài khoản đã tồn tại", "Thông báo");
                }
            }
        }

        public static void luu(string sql)
        {


            try
            {
                mycon = new SqlConnection(sqlcon);
                mycon.Open();
                com = new SqlCommand(sql, mycon);
                com.ExecuteNonQuery();
                mycon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);

            }

        }

        


        // kta ton tai tai khoan
        public static void ktratk(string tk, string newmk, string repass, string sql1)
        {
            int a = 0, b = 0, c = 0;
            mycon = new SqlConnection(sqlcon);
            mycon.Open();
            if (tk == "")
            {
                MessageBox.Show("Bạn chưa nhập tên tài khoản ", "Thông báo", MessageBoxButtons.OK);
            }

            else
            {
                com = new SqlCommand(sql1, mycon);
                a = (int)com.ExecuteScalar();
                // tra ve 0 hoac 1 
                // neu tra ve ten nguoi dung da ton tai va ta co the doi mk
                // tra ve 0 thi tai khoan ko ton tai nen ko doi dc mk
                if (a > 0)
                {
                    if (newmk == repass)
                    {
                        string sql4 = "update DangNhap set Matkhau = '" + newmk + "' where Taikhoan='" + tk + "'";
                        luu(sql4);

                    }
                    else
                    {
                        MessageBox.Show("Phần mật khẩu mới và nhập lại không trùng khớp ! Vui lòng kiểm tra lại", "Thông Báo", MessageBoxButtons.OK);
                    }
                }

                else
                {
                    string t = "Tai khoản này không tồn tại !,Bạn vui lòng kiểm tra lại ";
                    MessageBox.Show((t), "thong báo", MessageBoxButtons.OK);

                }

            }
        }

        public static void update(string sql)
        {

            try
            {
                mycon = new SqlConnection(sqlcon);
                mycon.Open();
                com = new SqlCommand(sql, mycon);
                com.ExecuteNonQuery();
                mycon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);

            }

        }
        //
        public static void them_dl1(string sql1)
        {
            try
            {
                mycon = new SqlConnection(sqlcon);
                mycon.Open();
                com = new SqlCommand(sql1, mycon);
                ad = new SqlDataAdapter(com);
                DataTable tb = new DataTable();
                ad.Fill(tb);

                mycon.Close();
            }
            catch (Exception)
            {
                //MessageBox.Show("");
            }

        }

    }
 }

