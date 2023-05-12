using System;
using System.IO;
namespace Program
{
    class BT_File
    {
        public static void Main()
        {
            // Declare Variable
            int soPt = 0;
            int[] arr;
            System.Console.Write("Nhap so phan tu mang: ");
            int.TryParse(Console.Readline(), out soPt);
            arr = new int[soPt];
            for (int i = 0; i < arr.Length; i++)
            {
                System.Console.Write($"arr[{i + 1}]");
                int.TryParse(Console.Readline(), out arr[i]);
            }
            // Ghi file
            try
            {
                StreamWriter sw = new StreamWriter(@"H:\IT Language\File_C#\MangNguyen.txt");
                for (int i = 0; i < arr.Length; i++)
                {
                    sw.WriteLine(arr[i]);
                }
            }
            catch (IOException)
            {
                
                System.Console.WriteLine("Duong dan sai!!!");
            }

        }
    }
}