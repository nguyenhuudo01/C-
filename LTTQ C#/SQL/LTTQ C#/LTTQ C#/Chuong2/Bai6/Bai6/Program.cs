using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            String can = " ";
            String chi =" ";
            Console.Write("Nhap nam duong lich: ");
            year = Convert.ToInt32(Console.ReadLine());
            // Xác định Can
            switch (year % 10)
            {
                case 0:
                    can = "Canh";
                    break;
                case 1:
                    can = "Tan";
                    break;
                case 2:
                    can = "Nham";
                    break;
                case 3:
                    can = "Quy";
                    break;
                case 4:
                    can = "Giap";
                    break;
                case 5:
                    can = "At";
                    break;
                case 6:
                    can = "Binh";
                    break;
                case 7:
                    can = "Dinh";
                    break;
                case 8:
                    can = "Mau";
                    break;
                case 9:
                    can = "Ky";
                    break;
            }

            // Xác định Chi
            switch (year % 12)
            {
                case 0:
                    chi = "Than";
                    break;
                case 1:
                    chi = "Dau";
                    break;
                case 2:
                    chi = "Tuat";
                    break;
                case 3:
                    chi = "Hoi";
                    break;
                case 4:
                    chi = "Ty";
                    break;
                case 5:
                    chi = "Suu";
                    break;
                case 6:
                    chi = "Dan";
                    break;
                case 7:
                    chi = "Meo";
                    break;
                case 8:
                    chi = "Thin";
                    break;
                case 9:
                    chi = "Ty.";
                    break;
                case 10:
                    chi = "Ngo";
                    break;
                case 11:
                    chi = "Mui";
                    break;
            }
            Console.Write("Nam duong lich tuong duong am lich "+year +" la " + (can + " " + chi));
            Console.ReadKey();
        }
    }
}
