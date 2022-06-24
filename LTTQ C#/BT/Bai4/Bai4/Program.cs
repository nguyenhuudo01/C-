using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            int ngay_cong, bac_tho;
            double luong, luong_ngay;
            Console.Write("Nhap so ngay cong = ");
            ngay_cong = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap bac tho = ");
            bac_tho = Convert.ToInt32(Console.ReadLine());
            luong_ngay = (bac_tho == 1) ? 150000 : 300000 ;
            luong = luong_ngay * bac_tho;
            Console.Write("Luong cua cong nhan la: {0}", luong);
            Console.ReadKey();

        }
    }
}
