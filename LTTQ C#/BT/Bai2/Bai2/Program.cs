using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, P;
            Console.Write("Nhap vao chieu dai a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap vao chieu rong b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Chu vi hinh chu nhat la: "+(a +b) * 2);
            Console.Write("Dien tich hinh chu nhat la: " + (a * b));
            Console.ReadKey();
        }
    }
}
