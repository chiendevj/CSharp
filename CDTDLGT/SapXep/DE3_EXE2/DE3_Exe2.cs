using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DE3_EXE2
{
    class DE3_Exe2
    {
        static void Main(string[] args)
        {
            string key = "";
            string path = "H:\\IT_Language\\C#\\CDTDLGT\\SapXep\\DE3_EXE2\\input_De3 - 2020.txt";
            HoaDon[] hh = DocFile(path);
            Xuat(hh);

            Console.Write("Nhap ma hoa don: ");
            key = Console.ReadLine();
            xoaHoaDon(ref hh, key);

            sapXepTheoThangGiamDan(hh);
            Xuat(hh);

            sapXepTheoMHDTangDan(hh);
            Xuat(hh);

        }
        static void sapXepTheoMHDTangDan(HoaDon[] arr)
        {
            int pos;
            HoaDon hd;
            Console.WriteLine($"{"",-20}DANH SACH DUOC SAP XEP");
            for (int i = 0; i < arr.Length; i++)
            {
                
                hd = arr[i];
                pos = i - 1;
                while (pos >= 0 && (String.Compare(hd.MaHoaDon, arr[pos].MaHoaDon)  < 0))
                {
                    arr[pos + 1] = arr[pos];
                    pos--;
                }
                arr[pos + 1] = hd;
            }
        }
        static void sapXepTheoThangGiamDan(HoaDon[] arr)
        {
            Console.WriteLine($"{"",-20}DANH SACH DUOC SAP XEP");
            HoaDon item;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i].NgayThanhToan.Month < arr[j].NgayThanhToan.Month)
                    {
                        item = arr[i];
                        arr[i] = arr[j];
                        arr[j] = item;
                    }
                }
            }
        }
        static void xoaHoaDon(ref HoaDon[] arr,string key)
        {
            int index =  timHoaDon(arr,key);
            if (index ==  -1)
            {
                Console.WriteLine("Khong tim thay!!");
            }
            else
            {
                for (int i = index; i < arr.Length - 1; i++)
                {
                        arr[i] = arr[i + 1];
                    
                }
                Array.Resize(ref arr, arr.Length - 1);
                Xuat(arr);
            }
        }
        static int timHoaDon(HoaDon[] arr, string key)
        {
            int index = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (String.Compare(key, arr[i].MaHoaDon) == 0)
                {
                    index = i;
                    break;
                }
                
            }
            return index;
        }
        static void Xuat(HoaDon[] arr)
        {
            Console.WriteLine($"{"Ma Hoa Don",-15}{"Ten KH",-15}{"Ngay TT",-15}{"Tien TT",-15}");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].Display());

            }
        }
        static HoaDon[] DocFile(string path)
        {                                       
            HoaDon[] arr = new HoaDon[0];       
            int n = 0;                          
            try
            {                                   
                using (StreamReader sr = new StreamReader(path))
                {
                    n = int.Parse(sr.ReadLine());
                    arr = new HoaDon[n];
                    for (int i = 0; i < n; i++)
                    {
                        string[] t = sr.ReadLine().Split('#');
                        HoaDon hd = new HoaDon(t[0], t[1], DateTime.Parse(t[2]), int.Parse(t[3]));
                        arr[i] = hd;
                    }
                }
            }
            catch (IOException)
            {
                Console.WriteLine("File not found");
            }
            return arr;
        }
    }
}
