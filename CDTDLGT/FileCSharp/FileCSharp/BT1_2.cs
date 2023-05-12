using System;
using System.IO;

namespace FileCSharp
{
    public class BT1_2
    {
        static void Main(string[] args)
        {
            string path = "H:\\IT_Language\\C#\\CDTDLGT\\FileCSharp\\MangNguyen.txt";
            int a = 0;
            int b = 0;
            int soPt = 0;
            int tong = 0;
            Console.Write("Nhap so nguyen thu nhat: ");
            int.TryParse(Console.ReadLine(), out a);
            Console.Write("Nhap so nguyen thu hai: ");
            int.TryParse(Console.ReadLine(), out b);
            Console.Write("Nhap so phan tu mang: ");
            int.TryParse(Console.ReadLine(), out soPt);
            int[] arr = new int[soPt];
            for (int i = 0; i < arr.Length; i++)
            {
                int.TryParse(Console.ReadLine(), out arr[i]);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    tong += arr[i];
                }
            }
            try
            {
                StreamWriter sw = new StreamWriter(path);
                
                sw.WriteLine(a);
                sw.WriteLine(b);
                sw.WriteLine(a + b);
                sw.WriteLine(soPt);
                for (int i = 0; i < arr.Length; i++)
                {
                    sw.WriteLine(arr[i]);
                }
                sw.WriteLine(tong);
                sw.Close();
            }
            catch (IOException)
            {

                Console.WriteLine("File not found!!");
            }
        }
    }
}
