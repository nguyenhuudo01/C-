using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BaoCaoNhom2
{
    class MD5
    {
        private string key;
        //Mã hóa chuoi bằng md5 - mã hóa 1 chiều
        public static string MaHoa(string key)
        {
            string result = "";
            //Encoding.UTF8.GetBytes(key) trả về 1 mảng byte chứa kết quả mã hóa của key (mã hóa key thành chuỗi các byte)
            byte[] buffer = Encoding.UTF8.GetBytes(key);
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            // trả về mã băm bằng md5
            buffer = md5.ComputeHash(buffer);
            for (int i = 0; i < buffer.Length; i++)
            {
                //x2 là chữ thường ; X2 là chữ in hoa
                result += buffer[i].ToString("x2");
            }
            return result;
        }

    }
}
