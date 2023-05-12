using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT7_Chuong3_OOP
{
    internal class BT7_main
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.Write("Nhap so luong tai lieu: ");
            int.TryParse(Console.ReadLine(), out n);
            TaiLieu[] listData = new TaiLieu[n];
            nhapData(listData);
            string path = @"H:\IT_Language\CSharp\HDT\Chuong3\BT7_Chuong3_OOP\DanhSachTaiLieu.txt";
            ghiFile(listData, path);

            TaiLieu[] arr = docFile(path);
            XuatFile(arr);
            XuatFileNguoc(arr);

            Console.Write("Nhap ma DOC: ");
            string key = Console.ReadLine();
            RemoveData(listData, key);

        }

        static void RemoveData(TaiLieu[] arr, string key)
        {
            int index = timPhanTu(arr, key);

            if (index == -1)
            {
                Console.WriteLine("Khong tim thay ma DOC nay!");
            }
            else
            {
                for (int i = index; i < arr.Length - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                Array.Resize(ref arr, arr.Length - 1);
            }
                XuatFile(arr);
        }

        static int timPhanTu(TaiLieu[] arr, string key)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].MaTaiLieu.CompareTo(key)  == 0)
                {
                    return i;
                }
            }
            return -1;
        }
        static void XuatFileNguoc(TaiLieu[] arr)
        {
            Console.WriteLine($"{"",-20} DANH SACH TAI LIEU GHI NGUOC");
            Console.WriteLine($"+----------+---------------+--------------------+--------------------+---------------+----------+");
            Console.WriteLine($"|{"Ma TL",-10}|{"Loai TL",-15}|{"Ten TL",-20}|{"Tac Gia",-20}|{"Nha XB",-15}|{"Ghi Chu",-10}|");
            Console.WriteLine($"+----------+---------------+--------------------+--------------------+---------------+----------+");
            for (int i = arr.Length -1; i >= 0; i--)
            {
                Console.WriteLine(arr[i].toString());
            }
            Console.WriteLine($"+----------+---------------+--------------------+--------------------+---------------+----------+");

        }
        static void XuatFile(TaiLieu[] arr)
        {
            Console.WriteLine($"{"",-20} DANH SACH TAI LIEU GHI XUOI");
            Console.WriteLine($"+----------+---------------+--------------------+--------------------+---------------+----------+");
            Console.WriteLine($"|{"Ma TL",-10}|{"Loai TL",-15}|{"Ten TL",-20}|{"Tac Gia",-20}|{"Nha XB",-15}|{"Ghi Chu",-10}|");
            Console.WriteLine($"+----------+---------------+--------------------+--------------------+---------------+----------+");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].toString());
            }
            Console.WriteLine($"+----------+---------------+--------------------+--------------------+---------------+----------+");

        }
        static TaiLieu[] docFile(string path)
        {
            TaiLieu[] arr = new TaiLieu[0];

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    int n = int.Parse(sr.ReadLine());
                    arr = new TaiLieu[n];
                    for (int i = 0; i < arr.Length; i++)
                    {
                        string[] t = sr.ReadLine().Split('#');
                        TaiLieu tl = new TaiLieu(t[0], t[1], t[2], t[3], t[4], t[5]);
                        arr[i] = tl;
                    }
                    sr.Close();
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e);
            }
            return arr;
        }
        static void ghiFile(TaiLieu[] arr, string path)
        {
            try
            {
                using ( StreamWriter sw = new StreamWriter (path))
                {
                    sw.WriteLine(arr.Length);
                    for (int i = 0; i < arr.Length; i++)
                    {
                        sw.WriteLine(arr[i].MaTaiLieu+"#"+ arr[i].LoaiTaiLieu + "#" + arr[i].TenTaiLieu + "#" + arr[i].TacGia + "#" + arr[i].NhaXB + "#" + arr[i].GhiChu);
                    }
                    sw.Close();
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e);
            }
        }

        static void nhapData(TaiLieu[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new TaiLieu();
                Console.Write($"Nhap ma DOC thu {i + 1} :");
                arr[i].MaTaiLieu = Console.ReadLine();
                Console.Write($"Nhap loai DOC thu {i + 1} :");
                arr[i].LoaiTaiLieu = Console.ReadLine();
                Console.Write($"Nhap ten DOC thu {i + 1} :");
                arr[i].TenTaiLieu = Console.ReadLine();
                Console.Write($"Nhap tac gia thu {i + 1} :");
                arr[i].TacGia = Console.ReadLine();
                Console.Write($"Nhap nha XB thu {i + 1} :");
                arr[i].NhaXB = Console.ReadLine();
                Console.Write($"Nhap ghi chu thu {i + 1} :");
                arr[i].GhiChu = Console.ReadLine();
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            }

        }
    }
}
