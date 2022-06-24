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
            int a, b, c;
            double denta,x, x1, x2;
            Console.Write("Nhap gia tri cua a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap gia tri cua b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap gia tri cua c: ");
            c = Convert.ToInt32(Console.ReadLine());
            denta = b * b - 4 * a * c;
            if (denta == 0)
            {
                Console.Write("Phuong trinh co mot nghiem duy nhat.");
                x1 = -b / (2.0 * a);
                x2 = x1;
                Console.Write("Nghiem duy nhat cua phuong trinh la = {0}", x1);
            }
            else if (denta > 0)
            {
                Console.WriteLine("Phuong trinh co hai nghiem thuc phan biet");

                x1 = (-b + Math.Sqrt(denta)) / (2 * a);
                x2 = (-b - Math.Sqrt(denta)) / (2 * a);

                Console.WriteLine("Nghiem thu nhat: x1 = {0}", x1);
                Console.Write("Nghiem thu nhat: x2 = {0}", x2);
            }
            else
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Phuong trinh vo so nghiem");
                }
                else
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
            }
            else
            {
                x = -c / (float)b;
                Console.WriteLine("Phuong trinh co nghiem x = " + x);
            }
            Console.ReadKey();
        }
    }
    }
