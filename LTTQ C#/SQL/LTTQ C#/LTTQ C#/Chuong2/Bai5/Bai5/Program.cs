using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            int thang, nam;
            int songay = 0;
            Console.Write("Nhap thang: ");
            thang = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap nam: ");
            nam = Convert.ToInt32(Console.ReadLine());            
            if (thang >= 1 && thang <= 12)
            {
                switch (thang)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12: songay = 31;
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11: songay = 30;
                        break;

                    case 2:
                        if (nam % 400 == 0 || (nam % 4 == 0 && nam % 100 != 0))    // nam nhuan
                            songay = 29;
                        else
                            songay = 28;
                        break;
                }

                Console.Write("=> Thang " + thang + "/" + nam + " co " + songay + " ngay ");
            }
            else
                Console.Write("=> Thang khong hop le! ");
            Console.ReadKey();
        }
    }
    }
