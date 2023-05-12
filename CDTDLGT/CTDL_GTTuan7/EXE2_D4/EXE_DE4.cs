using System;
using System.IO;
using System.Security.Cryptography;

namespace EXE2_D4
{
    class EXE_DE4
    {
        static void Main(string[] args)
        {
            //  Declare Path
            string path = @"H:\IT_Language\C#\CDTDLGT\CTDL_GTTuan7\Demoi\input4.txt";

            //  Processing + Ouput
            QuanLiNhanVien[] qlnv = DocFile(path);

            XuatFile(qlnv);

            //  SapXepGiamDanTheoMaNV(qlnv);

            Console.Write("Nhap Ma NV: ");
            string key = Console.ReadLine();
            SuaLuongNVTheoViTriTimDuoc(key, qlnv);
            XoaNhanVien(key, qlnv);

              

            //  SapXepTangDanTheoNamSinh(qlnv);

            //  SapXepTangDanTheoHoTen(qlnv);

            //  SapXepTangDanTheoLuong(qlnv);
        }
        //      Ngoài Main
        //g.	Dùng giải thuật Selection Sort sắp xếp danh sách tăng dần theo lương của nhân viên.
        //      Xuất lại danh sách sau khi sắp xếp.
        static void SapXepTangDanTheoLuong(QuanLiNhanVien[] arr)
        {
            int pos;
            QuanLiNhanVien v; // lưu giá trị arr[i] tránh bị ghi đè
            for (int i = 1; i < arr.Length; i++)
            {
                v = arr[i];
                pos = i - 1; // tìm vị trí chèn v
                while (pos >= 0 && v.Luong < arr[pos].Luong)
                {
                    arr[pos + 1] = arr[pos];
                    pos--;
                }
                arr[pos + 1] = v;
            }
            XuatFile(arr);
        }

        //f.	Dùng giải thuật Selection Sort sắp xếp danh sách tăng dần theo năm sinh của nhân viên.
        //      Xuất lại danh sách sau khi sắp xếp.
        static void SapXepTangDanTheoHoTen(QuanLiNhanVien[] arr)
        {
            int min = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j].NgaySinh.Year < arr[min].NgaySinh.Year)
                    {
                        min = j;
                    }
                }
                Swap(ref arr[i], ref arr[min]);
            }
            XuatFile(arr);
        }

        //e.	Dùng giải thuật Selection Sort sắp xếp danh sách tăng dần theo năm sinh của nhân viên.
        //      Xuất lại danh sách sau khi sắp xếp.
        static void SapXepTangDanTheoNamSinh(QuanLiNhanVien[] arr)
        {
            int min;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j].NgaySinh.Year < arr[min].NgaySinh.Year)
                    {
                        min = j;
                    }
                }
                Swap(ref arr[i], ref arr[min]);
            }
            XuatFile(arr);
        }

        //d.	Viết hàm tìm nhị phân theo mã nhân viên, để tìm, sửa  và xóa lương của nhân viên có mã được nhập từ bàn phím.
        //      Nếu tìm không được thì xuất thông báo không sửa được. Xuất lại danh sách sau khi sửa.
        static void XoaNhanVien(string key, QuanLiNhanVien[] arr)
        {
            int index = SequenceSearch(arr,key);

            for (int i = index; i < arr.Length -1; i++)
            {
                for (int j = arr.Length - 1; j > index; j--)
                {
                    arr[i] = arr[i + 1];
                }
            }
            Array.Resize(ref arr,  arr.Length -1);
            XuatFile(arr);
        }

        static void SuaLuongNVTheoViTriTimDuoc(string key, QuanLiNhanVien[] arr)
        {
            int index = SequenceSearch(arr, key);
            double luong = 0;
            if (index == -1)
            {
                Console.WriteLine("Khong tim thay ma Nhan Vien!");
            }
            else
            {
                Console.Write("Nhap muc Luong can sua doi: ");
                double.TryParse(Console.ReadLine(), out luong);
                arr[index].Luong = luong;
            }
            Console.WriteLine($"{"",-20}DANH SACH DA DUOC CAP NHAT");
            XuatFile(arr);
        }

        //      Tìm vị trí nhân viên dùng BinarySearch
        static int BinarySearch(QuanLiNhanVien[] arrInt, string key)
        {
            int left = 0; int right = arrInt.Length - 1;
            int mid;
            while (left <= right)
            {
                mid = (left + right) / 2;
                if (arrInt[mid].MaNV == key)
                    return mid;
                else if (String.Compare(arrInt[mid].MaNV,key)  < 0)
                    left = mid + 1;
                else right = mid - 1;
            }
            return -1;
        }

        //      Tìm vị trí nhân viên dùng SequenceSearch
        static int SequenceSearch(QuanLiNhanVien[] arr, string key)
        {
            int index = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (String.Compare(arr[i].MaNV, key) == 0)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        //c:    Dùng giải thuật Bubble sort sắp xếp danh sách giảm dần theo MaNV. Xuất lại danh sách sau khi sắp xếp.
        static void SapXepGiamDanTheoMaNV(QuanLiNhanVien[] arr)
        {
            Console.WriteLine($"{"",-20}DANH SACH SAP XEP");
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = arr.Length - 1; j > i; j--)
                {
                    if (String.Compare(arr[i].MaNV, arr[j].MaNV) < 0)
                    {
                        Swap(ref arr[i], ref arr[j]);
                    }
                }
            }
            XuatFile(arr);
        }

        //      Swap phần tử 
        static void Swap(ref QuanLiNhanVien a, ref QuanLiNhanVien b)
        {
            QuanLiNhanVien c;
            c = a;
            a = b;
            b = c;
        }

        //      Đọc + Xuất File
        static void XuatFile(QuanLiNhanVien[] arr)
        {
            Console.WriteLine($"+---------------+---------------+---------------+------------+");
            Console.WriteLine($"|{"Ma NV",-15}|{"Ho va Ten",-15}|{"Ngay Sinh",-15}|{"Luong",-12}|");
            Console.WriteLine($"+---------------+---------------+---------------+------------+");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].toString());
            }
            Console.WriteLine($"+---------------+---------------+---------------+------------+");
        }

        static QuanLiNhanVien[] DocFile(string path)
        {
            QuanLiNhanVien[] arr = new QuanLiNhanVien[0];
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    int n = int.Parse(sr.ReadLine());
                    arr = new QuanLiNhanVien[n];

                    for (int i = 0; i < arr.Length; i++)
                    {
                        string[] t = sr.ReadLine().Split('#');
                        arr[i] = new QuanLiNhanVien(t[0], t[1], DateTime.ParseExact(t[2], "MM/dd/yyyy", null), double.Parse(t[3]));
                    }
                }
            }
            catch (IOException)
            {
                Console.WriteLine("File not found!");
            }
            return arr;
        }
    }
}
