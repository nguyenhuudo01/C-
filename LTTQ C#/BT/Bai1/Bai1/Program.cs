using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Nhap vao so a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao so b = ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}",a,b, (a + b));
            Console.WriteLine("{0} - {1} = {2}", a, b, (a - b));
            Console.WriteLine("{0} * {1} = {2}", a, b, (a * b));
            Console.WriteLine("{0} / {1} = {2:0.0}", a, b, (double) a / b);
            Console.ReadKey();
        }
    }
}
