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
            double tiengui, laisuat, sotien, tienlai;
            int i, sothang;
            do
            {
                Console.Write("So tien lai la: ");
                tiengui = Double.Parse(Console.ReadLine());
            } while (tiengui <=100000);
            Console.Write("So thang gui la: ");
            sothang = Int32.Parse(Console.ReadLine());
            Console.Write("Lai suat (%): ");
            laisuat = Double.Parse(Console.ReadLine());
            laisuat = (laisuat / 100) / 12;
            Console.WriteLine("Lai suat thang la :" + laisuat);
            Console.WriteLine(" Bang ke thonng tin tien gui");
            sotien = tiengui;
            for(i = 1; i <= sothang; i++)
            {
                Console.Write("Thang {0} : Tien ban dau = {1}", i, sotien);
                tienlai = sotien + laisuat;
                sotien = sotien + laisuat;
                Console.WriteLine(", Tien lai = {0}, So tien cuoi cunng = {1}", tienlai, sotien);
            }
            Console.WriteLine("Tong so tien nhan duoc la: " + sotien);
            Console.ReadKey();
        }
    }
}
