using System;
using System.IO;

namespace BT5
{
    class BT5
    {
        static void Main(string[] args)
        {
            Sach[] arr = new Sach[0];
            DocDSach(ref arr, @"D:\GT2\BT5\InputBai2Chuong3.txt");
            XuatDSach(arr);
        }
        static void XuatDSach(Sach[]arr)
        {
            Console.WriteLine($"{"MaSach",-10}{"TenSach",-10}{"NamXB",-10}{"GiaBan",-10}");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].Xuat();
            }
        }
        static void DocDSach(ref Sach[]arr, string path)
        {
            int n = 0;
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    int.TryParse(sr.ReadLine(), out n);
                    arr = new Sach[n];
                    for (int i = 0; i < arr.Length; i++)
                    {
                        Sach s = new Sach();
                        s.Doc(sr);
                        arr[i] = s;
                    }
                }
            }
            catch (IOException)
            {   

                Console.WriteLine("File not found!");
            }
        }
    }
}
