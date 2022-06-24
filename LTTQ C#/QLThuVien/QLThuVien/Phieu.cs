using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVien
{
    class Phieu
    {
        public static void InPhieu(string sophieu)
        {
            //database
            System.Data.DataTable dt;
            string sql;
            //ms office
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;

            try
            {
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = true;
                excel.DisplayAlerts = false;

                workbook = excel.Workbooks.Open(Application.StartupPath + "\\PhieuMuonTra.xlsx");
                worksheet = null;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                //đọc dữ liệu phần phiếu và in ra
                sql = "Select SoPhieu, NgayLap, NgayHenTra, DocGia.HoDem + ' ' + DocGia.Ten as HoTenDG, " +
                    "CanBo.HoDem + ' ' + CanBo.Ten as HoTenCB, Phieu.TheDG, Lop " +
                    "From Phieu inner join CanBo on Phieu.MaCB = CanBo.MaCB " +
                    "inner join DocGia on Phieu.TheDG = DocGia.TheDG " + 
                    "where SoPhieu = '"+ sophieu +"'";
                dt = Public.LayDuLieu(sql);
                worksheet.Range["B3"].Value2 = ("'" + dt.Rows[0]["SoPhieu"].ToString());
                worksheet.Range["E3"].Value2 = "'" + DateTime.Parse(dt.Rows[0]["NgayLap"].ToString()).ToString("dd/MM/yyyy");
                worksheet.Range["E4"].Value2 = "'" + DateTime.Parse(dt.Rows[0]["NgayHenTra"].ToString()).ToString("dd/MM/yyyy");
                worksheet.Range["B5"].Value2 = "'" + dt.Rows[0]["TheDG"].ToString();
                worksheet.Range["B6"].Value2 = "'" + dt.Rows[0]["HoTenDG"].ToString();
                worksheet.Range["E6"].Value2 = "'" + dt.Rows[0]["Lop"].ToString();
                worksheet.Range["D20"].Value2 = "'Ngày " + DateTime.Now.ToString("dd / MM / yyyy");
                worksheet.Range["D25"].Value2 = "'" + dt.Rows[0]["HoTenCB"].ToString();
                //đọc dữ liệu phần chi tiết và in ra
                sql = "Select SoPhieu, Sach.MaSach, TenSach, NgayTra,  " +
                    "Case BiHong When 1 then N'Bị hỏng' Else '' End As TinhTrang " +
                    "From CTPhieu inner join Sach on CTPhieu.MaSach = Sach.MaSach " +
                    "Where SoPhieu = '" + sophieu + "'";
                dt = Public.LayDuLieu(sql);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    worksheet.Range["B" + (9+i)].Value2 = "'" + dt.Rows[i]["MaSach"].ToString();
                    worksheet.Range["C" + (9 + i)].Value2 = "'" + dt.Rows[i]["TenSach"].ToString();
                    if (dt.Rows[i]["NgayTra"].ToString()!="")
                        worksheet.Range["D" + (9 + i)].Value2 = "'" + DateTime.Parse(dt.Rows[i]["NgayTra"].ToString()).ToString("dd/MM/yyyy");
                    worksheet.Range["E" + (9 + i)].Value2 = "'" + dt.Rows[i]["TinhTrang"].ToString();
                }
                workbook.SaveAs(Application.StartupPath + "\\Export\\" + DateTime.Now.ToString("yyyyMMdd_HHmmss_") + "PhieuMuonTra.xlsx");//lưu tập tin
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
        public static void checkMauPhieu()
        {
            string fName = Application.StartupPath + "\\PhieuMuonTra.xlsx";
            if (File.Exists(fName)==true)
                return;
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            Microsoft.Office.Interop.Excel.Range range;
            try
            {
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = true;
                excel.DisplayAlerts = false;

                workbook = excel.Workbooks.Add(Type.Missing);//tạo mới một Workbooks bằng phương thức add()
                worksheet = null;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;

                worksheet.Range["A1"].ColumnWidth = 9.29;
                worksheet.Range["B1"].ColumnWidth = 12.29;
                worksheet.Range["C1"].ColumnWidth = 41.71;
                worksheet.Range["D1"].ColumnWidth = 12.14;
                worksheet.Range["E1"].ColumnWidth = 10.86;

                range = worksheet.Range["A2", "E2"];
                range.Merge();
                range.Value2 = "PHIẾU MƯỢN SÁCH"; range.Font.Color = System.Drawing.Color.DarkBlue;
                range.Font.Name = "Times New Roman"; range.Font.Size = 14;range.Font.Bold = true;
                range.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                range = worksheet.Range["A3"];
                range.Value2 = "Số phiếu :"; range.Font.Color = System.Drawing.Color.DarkBlue;
                range.Font.Name = "Times New Roman"; range.Font.Size = 12;range.Font.Bold = true;

                range = worksheet.Range["B3", "C3"];
                range.Merge(); range.Font.Color = System.Drawing.Color.DarkBlue;
                range.Font.Name = "Times New Roman"; range.Font.Size = 12; range.Font.Bold = true;

                range = worksheet.Range["D3"];
                range.Value2 = "Ngày mượn :"; range.Font.Color = System.Drawing.Color.DarkBlue;
                range.Font.Name = "Times New Roman"; range.Font.Size = 12; 
                range = worksheet.Range["E3"];
                range.Font.Color = System.Drawing.Color.DarkBlue;
                range.Font.Name = "Times New Roman"; range.Font.Size = 12; range.Font.Bold = true;

                range = worksheet.Range["D4"];
                range.Value2 = "Ngày hẹn trả :"; range.Font.Color = System.Drawing.Color.DarkBlue;
                range.Font.Name = "Times New Roman"; range.Font.Size = 12;
                range = worksheet.Range["E4"];
                range.Font.Color = System.Drawing.Color.DarkBlue;
                range.Font.Name = "Times New Roman"; range.Font.Size = 12; range.Font.Bold = true;

                range = worksheet.Range["A5"];
                range.Value2 = "Mã thẻ :"; range.Font.Color = System.Drawing.Color.DarkBlue;
                range.Font.Name = "Times New Roman"; range.Font.Size = 12; range.Font.Bold = true;
                range = worksheet.Range["B5", "C5"];range.Merge();
                range.Font.Color = System.Drawing.Color.DarkBlue;
                range.Font.Name = "Times New Roman"; range.Font.Size = 12;

                range = worksheet.Range["A6"];
                range.Value2 = "Họ tên :"; range.Font.Color = System.Drawing.Color.DarkBlue;
                range.Font.Name = "Times New Roman"; range.Font.Size = 12; range.Font.Bold = true;
                range = worksheet.Range["B6", "C6"];range.Merge();
                range.Font.Color = System.Drawing.Color.DarkBlue;
                range.Font.Name = "Times New Roman"; range.Font.Size = 12;

                range = worksheet.Range["D6"];
                range.Value2 = "Lớp :"; range.Font.Color = System.Drawing.Color.DarkBlue;
                range.Font.Name = "Times New Roman"; range.Font.Size = 12; range.Font.Bold = true;
                range = worksheet.Range["E6"];
                range.Font.Color = System.Drawing.Color.DarkBlue;
                range.Font.Name = "Times New Roman"; range.Font.Size = 12;

                range = worksheet.Range["D20", "E20"];
                range.Merge(); range.Font.Color = System.Drawing.Color.DarkBlue;
                range.Font.Name = "Times New Roman"; range.Font.Size = 12;
                range.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                range = worksheet.Range["D21", "E21"];
                range.Merge();
                range.Value2 = "Cán bộ lập phiếu"; range.Font.Color = System.Drawing.Color.DarkBlue;
                range.Font.Name = "Times New Roman"; range.Font.Size = 12;
                range.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                range = worksheet.Range["D25", "E25"];
                range.Merge(); range.Font.Color = System.Drawing.Color.DarkBlue;
                range.Font.Name = "Times New Roman"; range.Font.Size = 12;
                range.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                range = worksheet.Range["A8"];range.Value2 = "STT";
                range = worksheet.Range["B8"]; range.Value2 = "Mã sách";
                range = worksheet.Range["C8"]; range.Value2 = "Tên sách";
                range = worksheet.Range["D8"]; range.Value2 = "Ngày trả";
                range = worksheet.Range["E8"]; range.Value2 = "Tình trạng";
                range = worksheet.Range["A8","E8"];
                range.Font.Name = "Times New Roman"; range.Font.Size = 12;
                range.Font.Bold = true;range.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                for (int i = 1; i <= 10; i++)
                {
                    range = worksheet.Range["A" + (8+i)];
                    range.Value2 = "'" + i;
                }
                range = worksheet.Range["A9", "E18"];
                range.Font.Name = "Times New Roman"; range.Font.Size = 10;
                range.Font.Bold = false; range.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                range= worksheet.Range["C9", "C18"];
                range.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

                range = worksheet.Range["A8", "E18"];
                Microsoft.Office.Interop.Excel.Borders border = range.Borders;
                border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                border.Weight = 2d; border.Color = System.Drawing.Color.DarkBlue;

                workbook.SaveAs(Application.StartupPath + "\\PhieuMuonTra.xlsx");
                workbook.Close();//đóng tập tin
                excel.Quit();//thoát khỏi excel
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
