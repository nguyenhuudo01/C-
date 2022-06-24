using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAi3
{
    class Program
    {
        static void Main(string[] args)
        {
            float r, cv, dt;
            float PI = 3.14f;
            Console.Write("Ban kinh duong tron: ");
            r = float.Parse(Console.ReadLine());
            cv = 2 * PI * r;
            dt = PI * r * r;
            Console.WriteLine("Chu vi hinh tron la: " + cv);
            Console.WriteLine("Dien tich hinh tron la: " + dt);
            Console.ReadKey();

        }
    }
}
