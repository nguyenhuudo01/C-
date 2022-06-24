using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAi4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.Write("Nhap canh thu nhat: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap canh thu hai: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap canh thu ba: ");
            c = Convert.ToInt32(Console.ReadLine());
            if (a < b + c && b < a + c && c < a + b)
            {
                if (a * a == b * b + c * c || b * b == a * a + c * c || c * c == a * a + b * b)
                {
                    Console.WriteLine("Day la tam giac vuong");                    
                }
                else if (a == b && b == c)
                {
                    Console.WriteLine("Day la tam giac deu");
                }
                else if (a == b || a == c || b == c)
                {
                    Console.WriteLine("Day la tam giac can");
                }
                else if (a * a > b * b + c * c || b * b > a * a + c * c || c * c > a * a + b * b)
                {
                    Console.WriteLine("Day la tam giac tu");
                }
                else
                    Console.WriteLine("Day la tam giac nhon");
            }
            else
                Console.WriteLine("Ba canh a, b, c khong phai la ba canh cua mot tam giac");
            Console.ReadKey();
        }
    }
}
