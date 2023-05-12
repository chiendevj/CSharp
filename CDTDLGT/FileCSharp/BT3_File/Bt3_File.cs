using System;
using System.IO;

namespace BT3_File
{
    public class Bt3_File
    {
        static void Main(string[] args)
        {
            int soPt;
            string[] arr;
            string path = "";
            path = "H:\\IT_Language\\C#\\CDTDLGT\\FileCSharp\\BT3_File\\HangHoa.txt";
            Console.Write("Nhap so luong phan tu mang: ");
            int.TryParse(Console.ReadLine(), out soPt);
            arr = new string[soPt];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Console.ReadLine();
            }

            StreamWriter sw = new StreamWriter(path);
            for (int i = 0;i < arr.Length; i++) 
            {
                sw.WriteLine(arr[i]);
            }
            sw.Close();
        }
    }
}
