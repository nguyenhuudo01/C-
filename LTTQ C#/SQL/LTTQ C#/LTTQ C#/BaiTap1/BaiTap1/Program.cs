using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
             Console.Write("Nhap so nguyen a ");
             a = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("So nguyen a vua nhap la: " + a);
            //nhap so thuc, dung lop bao de chuyen doi du lieu, dung doi so de in ket qua
            double b;
            Console.Write("Nhap so thuc b ");
            b = Double.Parse(Console.ReadLine());
            Console.WriteLine("So thuc = {0:0.0}", b);
            Console.ReadKey();
        }
    }
}
