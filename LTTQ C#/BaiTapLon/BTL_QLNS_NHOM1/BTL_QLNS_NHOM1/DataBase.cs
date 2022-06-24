using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Deployment.Application;

namespace BTL_QLNS_NHOM1
{
    internal class DataBase
    {
        string connString = @"Data Source=DESKTOP-63TNGNI\SQLEXPRESS;Initial Catalog=QLNS;Integrated Security=True";
        SqlConnection sqlcon;
        SqlCommand sqlcom;
        SqlDataAdapter sqlda;
        SqlDataReader sqldr;
        DataSet ds = new DataSet();


        void ketnoi()
        {
            sqlcon = new SqlConnection(connString);
            sqlcon.Open();
        }

        void ngatketnoi()
        {
            sqlcon.Close();
        }

        public void thucthiketnoi(string strsql)
        {
            ketnoi();
            sqlcom = new SqlCommand(strsql, sqlcon);
            sqlcom.ExecuteNonQuery();
            ngatketnoi();

        }

        public void loaddatagridview(DataGridView dg, string strselect, string visibleColumn = null)
        {
            ds.Clear();
            sqlda = new SqlDataAdapter(strselect, connString);
            sqlda.Fill(ds, "tenbang");
            dg.DataSource = ds.Tables[0];
            if (visibleColumn != null)
            {
                dg.Columns[visibleColumn].Visible = false;
            }
        }
        public void loaddatagridview1(DataGridView dg, DataSet ds1, string strselect, string visibleColumn = null)
        {
            ds1.Clear();
            sqlda = new SqlDataAdapter(strselect, connString);
            sqlda.Fill(ds1, "tenbang");
            dg.DataSource = ds1.Tables[0];
            if (visibleColumn != null)
            {
                dg.Columns[visibleColumn].Visible = false;
            }
        }
        public void loadcombobox(ComboBox cb, string strselect, byte chiso)
        {
            ketnoi();
            sqlcom = new SqlCommand(strselect, sqlcon);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                cb.Items.Add(sqldr[chiso].ToString());
            }
            ngatketnoi();
        }
        public void loadcomboboxchiso(ComboBox cb, string strselect, byte chiso)
        {
            ketnoi();
            sqlcom = new SqlCommand(strselect, sqlcon);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                cb.Text = sqldr[chiso].ToString();
            }
            ngatketnoi();
        }
        public void loadtextbox(TextBox cb, string strselect)
        {
            ketnoi();
            sqlcom = new SqlCommand(strselect, sqlcon);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                cb.Text = sqldr[0].ToString();
            }
            ngatketnoi();
        }

        public void loaddatetime(DateTimePicker cb, string strselect, byte chiso)
        {
            ketnoi();
            sqlcom = new SqlCommand(strselect, sqlcon);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                cb.Text = sqldr[chiso].ToString();
            }
            ngatketnoi();
        }

        public void loadtextboxchiso(TextBox cb, string strselect, byte chiso)
        {
            ketnoi();
            sqlcom = new SqlCommand(strselect, sqlcon);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                cb.Text = sqldr[chiso].ToString();
            }
            ngatketnoi();
        }

        public string getdata(string dauvao, string strsql)
        {
            string strketqua = "";
            ketnoi();
            sqlcom = new SqlCommand(strsql, sqlcon);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                if (sqldr[0].ToString().ToLower() == dauvao.ToLower())
                    strketqua = sqldr[1].ToString();
            }
            ngatketnoi();
            return strketqua;
        }

        public bool kt(string dauvao, string strsql, byte chiso)
        {
            bool ok = false;
            ketnoi();
            sqlcom = new SqlCommand(strsql, sqlcon);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                if (sqldr[chiso].ToString().ToLower() == dauvao.ToLower())
                    ok = true;
            }
            ngatketnoi();
            return ok;
        }

        public string thu(string dauvao, string strsql)
        {
            string strketqua = "";
            ketnoi();
            sqlcom = new SqlCommand(strsql, sqlcon);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                if (sqldr[0].ToString().ToLower() == dauvao.ToLower())
                    strketqua = sqldr[0].ToString();
            }
            ngatketnoi();
            return strketqua;
        }

        public bool kttrungkhoa(string dauvao, string strsql)
        {
            bool ok = false;
            ketnoi();
            sqlcom = new SqlCommand(strsql, sqlcon);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                if (sqldr[0].ToString().ToLower() == dauvao.ToLower())
                    ok = true;
            }
            ngatketnoi();
            return ok;
        }

        public void loatextbox(TextBox tb, string strselect, byte chiso)
        {
            ketnoi();
            sqlcom = new SqlCommand(strselect, sqlcon);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                tb.Lines[0] = (sqldr[chiso].ToString());
            }
            ngatketnoi();
        }

        public static void XuatFileExcel(DataGridView dataGridView1, string fileName)
        {
            /*khai báo thư viện hỗ trợ Microsoft.Office.Interop.Excel
                - vào menu Project / chọn add reference..
                - chọn mục COM
                - tìm và tích chọn Microsoft Excel [xx.x] Object Library
                - nếu trước cài bản office cao hơn và bị báo lỗi Unable to cast COM object of type 'Microsoft.Office.Interop.Excel.ApplicationClass' to interface type 'Microsoft.Office.Interop.Excel._Application'. This operation failed because the QueryInterface call on the COM component for the interface with IID '{000208D5-0000-0000-C000-000000000046}
                    + vào run, gõ regedit để mở thanh ghi
                    + Computer\HKEY_CLASSES_ROOT\TypeLib\{00020813-0000-0000-C000-000000000046} xóa thư mục 1.9 giữ lại mục có nội dung Microsoft Excel [xx.x] Object Library
                    + Computer\HKEY_CLASSES_ROOT\TypeLib\{00020905-0000-0000-C000-000000000046} giữ lại mục có nội dung Microsoft Word xx.x Object Library
            */
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            Microsoft.Office.Interop.Excel.Range excelCellrange;
            try
            {
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = true;
                excel.DisplayAlerts = false;

                workbook = excel.Workbooks.Add(Type.Missing);//tạo mới một Workbooks bằng phương thức add()
                worksheet = null;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                //xuất danh sách tiêu đề cột
                for (int i = 0; i < dataGridView1.ColumnCount; i++)//tạo dòng tiêu đề từ cột trong DataGridView
                {
                    worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                }
                //xuất danh sách nội dung dòng
                for (int i = 0; i < dataGridView1.RowCount; i++)//xuất nội dung các dòng tiếp theo
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = "'" + dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }

                //thay đổi độ rộng cột theo dữ liệu - tạo đường khung viền cho bảng
                excelCellrange = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[dataGridView1.RowCount + 1, dataGridView1.ColumnCount]];
                excelCellrange.EntireColumn.AutoFit();
                Microsoft.Office.Interop.Excel.Borders border = excelCellrange.Borders;
                border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                border.Weight = 2d;
                //tô màu chữ, màu nền cho dòng đầu tiên
                excelCellrange = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, dataGridView1.ColumnCount]];
                excelCellrange.Interior.Color = System.Drawing.Color.Blue;
                excelCellrange.Font.Color = System.Drawing.Color.White;

                workbook.SaveAs(Application.StartupPath + "\\" + DateTime.Now.ToString("yyyyMMdd_HHmmss_") + fileName);//lưu tập tin
                //workbook.Close();//đóng tập tin
                //excel.Quit();//thoát khỏi excel
                //Process.Start("Explorer.exe", fileName);//mở tập tin trên máy qua đường dẫn
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            finally
            {
                worksheet = null;
                workbook = null;
            }
            
        }
    }
}
