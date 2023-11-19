using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonDoThiVoHuong
{
    internal class TachFIle
    {
        public static ArrayList docFile() {
            ArrayList arrayList = new ArrayList();

            using (StreamReader sr = new StreamReader("text.txt"))
            {
                String[] str = sr.ReadToEnd().Split(new char[] {'|', '\n', ' ' });
                for (int i =0; i < str.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine("TK: " + str[i]);
                    }
                    else
                    {
                        Console.WriteLine("MK: " + str[i]);
                    }


                }
            }
                return arrayList; 
        }
    }
}
