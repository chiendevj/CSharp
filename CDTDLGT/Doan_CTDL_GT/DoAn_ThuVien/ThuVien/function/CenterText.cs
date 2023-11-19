using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThuVien
{
    public class CenterText
    {
        public CenterText(string text)
        {
            int widthConsole = Console.WindowWidth;
            int padding = 0;
            if (text.Equals("User     : ") || text.Equals("Password : "))
            {
                padding = (widthConsole / 2) + (text.Length / 2) - 10;
                Console.Write("{0," + padding + "}", text);
            }
            else if (text.Equals("--> Nhap lua chon : "))
            {
                padding = (widthConsole / 2) + (text.Length / 2) - 3;
                Console.Write("{0," + padding + "}", text);
            }
            else if (text == "          D A N G  N H A P        ")
            {
                Console.Write(text);
            }
            else
            {
                padding = (widthConsole / 2) + (text.Length / 2);
                Console.WriteLine($"{text.PadLeft(padding)}");
            }
        }
    }
}