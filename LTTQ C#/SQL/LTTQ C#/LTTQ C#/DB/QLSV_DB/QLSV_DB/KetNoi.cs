using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QLSV_DB
{
    class KetNoi
    {
        public static SqlConnection connectDB()
        {
            string connString = @"Data Source=DESKTOP-63TNGNI\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
        public static DataTable getData(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, connectDB());
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
