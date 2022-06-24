using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, P, S;
            Console.Write("Nhap canh thu nhat: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap canh thu hai: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap canh thu ba: ");
            c = Convert.ToInt32(Console.ReadLine());
            if ((a * a < b * b + c * c) && (b * b < a * a + c * c) && (c * c < b * b + a * a))
            {
                Console.WriteLine("Day la ba canh cua tam giac");
                P = (a + b + c) / 2;
                S= Math.Sqrt(P * (P - a) * (P - b) * (P - c));
                Console.WriteLine("Chu vi tam giac la = {0}", P);
                Console.WriteLine("Dien tich tam giac la = {0}", S);
            }
            else
            {
                Console.Write("Day khong phai la ba canh cua tam giac");
            }
            Console.ReadKey();
        }
    }
}
