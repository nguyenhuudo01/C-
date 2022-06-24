using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace BaoCaoNhom2
{
    class HamHoTro
    {
        public static string sqlcon = KetnoiDataBase.sqlcon;
        private static SqlConnection conn;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;
        public static DataTable dt;
        // DataTable table;
        public static BindingSource code;
        public static SqlCommandBuilder bd;

        public static string load_one_colums(string chuoi, string ten, string colums)
        {
            try
            {
                conn = new SqlConnection(sqlcon);
                da = new SqlDataAdapter(chuoi, sqlcon);

                dt = new DataTable();
                da.Fill(dt);
                code = new BindingSource();

                foreach (DataRow anh in dt.Rows)
                {
                    code.Add(anh);
                }

                DataRow curent = (DataRow)code.Current;
                ten = curent[colums.ToString()].ToString();
                return ten;

            }
            catch (Exception ex)
            {
                return ten;
            }
        }

        public static float load_one_GiaPhong(string chuoi, string colums)
        {
            float number;
            try
            {
                conn = new SqlConnection(sqlcon);
                da = new SqlDataAdapter(chuoi, sqlcon);

                dt = new DataTable();
                da.Fill(dt);
                code = new BindingSource();

                foreach (DataRow anh in dt.Rows)
                {
                    code.Add(anh);
                }

                DataRow curent = (DataRow)code.Current;
                number = Convert.ToInt32(curent[colums.ToString()].ToString());
                return number;

            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public static DateTime load_Date(string chuoi, string colums)
        {
            DateTime NgSinh;
            try
            {
                conn = new SqlConnection(sqlcon);
                da = new SqlDataAdapter(chuoi, sqlcon);

                dt = new DataTable();
                da.Fill(dt);
                code = new BindingSource();

                foreach (DataRow anh in dt.Rows)
                {
                    code.Add(anh);
                }

                DataRow curent = (DataRow)code.Current;
                NgSinh = Convert.ToDateTime(curent[colums.ToString()].ToString());
                return NgSinh;

            }
            catch (Exception ex)
            {
                return DateTime.Now;
            }
        }




        public static string load_soluongkho(string chuoi, string soluong)
        {
            conn = new SqlConnection(sqlcon);
            da = new SqlDataAdapter(chuoi, sqlcon);

            dt = new DataTable();
            da.Fill(dt);
            code = new BindingSource();

            foreach (DataRow anh in dt.Rows)
            {
                code.Add(anh);
            }

            DataRow curent = (DataRow)code.Current;
            soluong = curent["soluong"].ToString();
            return soluong;
        }

        // lấy ra têm sảm phẩm 

        public static string load_tensp(string chuoi, string tensp)
        {
            conn = new SqlConnection(sqlcon);
            da = new SqlDataAdapter(chuoi, sqlcon);

            dt = new DataTable();
            da.Fill(dt);
            code = new BindingSource();

            foreach (DataRow anh in dt.Rows)
            {
                code.Add(anh);
            }

            DataRow curent = (DataRow)code.Current;
            tensp = curent["TenItem"].ToString();
            return tensp;
        }
        public static void update(string sql)
        {

            try
            {
                conn = new SqlConnection(sqlcon);
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);

            }

        }
        //
    }

}

