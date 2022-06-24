using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCaoNhom2
{
    class Doc_ghi_file
    {
        public static void Ghi_file(string tk, string mahoa)
        {
            string filePath = "D:/matkhau.txt";
            FileStream file = new FileStream(filePath,FileMode.Append);
            file.Close();
            StreamWriter f = File.AppendText(filePath);
            string[] lines = new string[2];
            lines[0] = tk;
            f.WriteLine(lines[0]);
            lines[1] = mahoa;
            f.WriteLine(lines[1]);
            f.Close();
            
            
        }

    public static void Ghi_de_file(string tk, string mahoa)
    {
            string filePath = "D:/matkhau.txt";

            string[] lines = null;

            if (System.IO.File.Exists(filePath))
            {
                lines = System.IO.File.ReadAllLines(filePath);
                
            }
        FileInfo filetodelete = new FileInfo(filePath);
        try
        {
            filetodelete.Delete();
        }
        catch (IOException ex)
        {
        }
        FileStream file = new FileStream(filePath, FileMode.Append);
        file.Close();
        StreamWriter f = File.AppendText(filePath);
            for (int i = 0; i < lines.Length; i++)
        {
            if (String.Compare(tk, lines[i], true) == 0)
            {
                    lines[i + 1] = mahoa;
            }
            f.WriteLine(lines[i]);
        }
            f.Close();
    }



    public static string doc_file(string tk)
        {
            string filePath = "D:/matkhau.txt";

            string[] lines;
            string mahoa = "";

            if (System.IO.File.Exists(filePath))
            {
                lines = System.IO.File.ReadAllLines(filePath);
                for (int i = 0; i < lines.Length; i=i+2)
                {
                    if (String.Compare(tk, lines[i], true) == 0)
                    {
                        mahoa = lines[i + 1];
                        return mahoa;
                    }
                }

            }
            else
            {
                mahoa = "";
            }
            return mahoa;
        }

        public static Boolean kiemtra(string tk)
        {
            string filePath = "D:/matkhau.txt";

            string[] lines;

            if (System.IO.File.Exists(filePath))
            {
                lines = System.IO.File.ReadAllLines(filePath);
                for (int i = 0; i < lines.Length; i = i + 2)
                {
                    if (String.Compare(tk, lines[i], true) == 0)
                    {
                        return true;
                    }
                }

            }
            else
            {
                return false;
            }
            return false;
        }
    }
}
