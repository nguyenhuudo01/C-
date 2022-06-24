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
            int chisomoi, chisocu, sodien, tg;
            int m1 = 0, m2 = 0, m3 = 0, m4 = 0, m5 = 0, m6 = 0;
            double t1 = 1678, t2 = 1734, t3 = 2014, t4 = 2536, t5 = 2834, t6 = 2927;
            double tt1 = 0, tt2 = 0, tt3 = 0, tt4 = 0, tt5 = 0, tt6 = 0;
            do
            {
                Console.Write("Nhap chi so cu: ");
                chisocu = Int32.Parse(Console.ReadLine());

            } while (chisocu < 0);
            do
            {
                Console.Write("Nhap chi so moi: ");
                chisomoi = Int32.Parse(Console.ReadLine());

            } while (chisomoi < chisocu);
            sodien = chisomoi - chisocu;
            tg = sodien;
            if(tg > 400) { m6 = tg - 400; tg = 400; };
            if (tg > 300) { m5 = tg - 300; tg = 300; };
            if (tg > 200) { m4 = tg - 200; tg = 200; };
            if (tg > 100) { m3 = tg - 100; tg = 100; };
            if (tg > 50) { m2 = tg - 50; tg = 50; };
            m1 = tg;
            tt1 = m1 * t1;
            tt2 = m2 * t2;
            tt3 = m3 * t3;
            tt4 = m4 * t4;
            tt5 = m5 * t5;
            tt6 = m6 * t6;
            double tong = tt1 + tt2 + tt3 + tt4 + tt5 + tt6;
            Console.WriteLine("Muc 1 co {0} so,  Don gia {1} vnd, Thanh Tien {2}", m1, t1, tt1);
            Console.WriteLine("Muc 2 co {0} so,  Don gia {1} vnd, Thanh Tien {2}", m2, t2, tt2);
            Console.WriteLine("Muc 3 co {0} so,  Don gia {1} vnd, Thanh Tien {2}", m3, t3, tt3);
            Console.WriteLine("Muc 4 co {0} so,  Don gia {1} vnd, Thanh Tien {2}", m4, t4, tt4);
            Console.WriteLine("Muc 5 co {0} so,  Don gia {1} vnd, Thanh Tien {2}", m5, t5, tt5);
            Console.WriteLine("Muc 6 co {0} so,  Don gia {1} vnd, Thanh Tien {2}", m6, t6, tt6);
            Console.WriteLine("So dien tieu thu {0} so, Tong thanh toan {1} vnd", sodien, tong);
            Console.ReadKey();
        }
    }
}
