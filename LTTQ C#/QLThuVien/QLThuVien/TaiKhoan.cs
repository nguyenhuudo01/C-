using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVien
{
    class TaiKhoan
    {
        public static bool GuiOPTEmail(string emailNhan)
        {
           try
            {
                //nhập tài khoản gmail (lưu ý gmail bật chế độ cho phép truy cập từ ứng dụng kém bảo mật)
                string emailgui = "user@gmail.com";
                string matkhau = "password";
                //tạo mã OTP
                Public.maOTP = TaoMaOTP();
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(emailgui, matkhau);
                MailMessage mail = new MailMessage(emailgui, emailNhan, "QLTV-Lấy lại mật khẩu qua OTP", "Mã OTP của bạn là: " + Public.maOTP + "");
                client.Send(mail);
                MessageBox.Show("Mã OPT đã được gửi đến bạn, vui lòng kiểm tra Email!","Thông Báo",
                    MessageBoxButtons.OK,MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex) {
                MessageBox.Show("Lỗi khi gửi email : " + ex.ToString(), "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
        }

        public static string TaoMaOTP()
        {
            int length = 6;
            string UpperCase = "QWERTYUIOPASDFGHJKLZXCVBNM";
            string LowerCase = "qwertyuiopasdfghjklzxcvbnm";
            string Digits = "123456789";
            string allCharacters = UpperCase + LowerCase + Digits;
            Random r = new Random();
            String otp = "";
            int rand = r.Next(UpperCase.Length);
            otp += UpperCase.ToCharArray()[rand];
            for (int i = 1; i < length; i++)
            {
                rand = r.Next(allCharacters.Length);
                otp += allCharacters.ToCharArray()[rand];
            }
            return otp;
        }

    }
}
