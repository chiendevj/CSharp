using System;
using System.IO;

namespace BT5
{
    class BT5
    {
        static void Main(string[] args)
        {
            string path = @"H:\IT_Language\C#\CDTDLGT\BT5_GTTK\InputBai5Chuong2.txt";
            //string path2 = @"H:\IT_Language\C#\CDTDLGT\BT5_GTTK\OutputBai5Chuong2.txt";
            Sach[] arr = new Sach[0];
            DocDSach(ref arr, path);
            XuatDSach(arr);
            GhiChung(ref arr);
            GhiRieng(ref arr);
        }
        static void GhiChung(ref Sach[] arr)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter($@"H:\IT_Language\C#\CDTDLGT\BT5_GTTK\OutputBai5Chuong2.txt"))
                {
                    sw.WriteLine($@"||---------------||---------------||---------------||---------------||");
                    sw.WriteLine($@"||{"Ma Sach",-15}||{"Ten Sach",-15}||{"Nam XB",-15}||{"Gia Ban",-15}||");
                    for (int i = 0; i < arr.Length; i++)
                    {
                        sw.WriteLine($@"||{arr[i].MaSach,-15}||{arr[i].TenSach,-15}||{arr[i].NamXB,-15}||{arr[i].GiaBan,-15}||");
                    }
                    sw.WriteLine($@"||---------------||---------------||---------------||---------------||");
                    sw.Close();
                }
            }
            catch (IOException)
            {
                Console.WriteLine("File not found!");
            }
        }
        static void GhiRieng(ref Sach[] arr)
        {
            try
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    using (StreamWriter sw = new StreamWriter($@"H:\IT_Language\C#\CDTDLGT\BT5_GTTK\{arr[i].TenSach}.txt"))
                    {

                        sw.WriteLine(arr[i].MaSach);
                        sw.WriteLine(arr[i].TenSach);
                        sw.WriteLine(arr[i].NamXB);
                        sw.WriteLine(arr[i].GiaBan);
                        sw.Close();
                    }

                }

            }
            catch (IOException)
            {
                Console.WriteLine("File not found!");
            }
        }
        static void XuatDSach(Sach[] arr)
        {
            Console.WriteLine($"{"MaSach",-10}{"TenSach",-10}{"NamXB",-10}{"GiaBan",-10}");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].Xuat();
            }
        }
        static void DocDSach(ref Sach[] arr, string path)
        {
            int soPt = 0; // line 1 của file đọc
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    int.TryParse(sr.ReadLine(), out soPt);
                    arr = new Sach[soPt];
                    for (int i = 0; i < arr.Length; i++)
                    {
                        Sach s = new Sach();
                        s.Doc(sr);
                        arr[i] = s;
                    }
                    sr.Close();
                }

            }
            catch (IOException)
            {

                Console.WriteLine("File not found!");
            }
        }
        
    }
}
