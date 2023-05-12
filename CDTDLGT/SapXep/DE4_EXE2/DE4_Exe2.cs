using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DE4_EXE2
{
    internal class DE4_Exe2
    {
        static void Main(string[] args)
        {
            string key;
            string path = "H:\\IT_Language\\C#\\CDTDLGT\\SapXep\\DE4_EXE2\\input_De4- 2020.txt";

            MonHoc[] monHocs = DocFile(path);
            XuatFile(monHocs);

            sapXepTangDanTheoMaMH(monHocs);

            Console.Write("Nhap ma mon hoc can sua: ");
            key = Console.ReadLine();
            timMaMH(ref monHocs, key);

            sapXepGiamDanTheoSoTC(monHocs);
        }

        static void sapXepGiamDanTheoSoTC(MonHoc[] arr)
        {
            // Dùng selection sort
            int min;
            MonHoc monHoc;
            Console.WriteLine($"{"\n",-20}DANH SACH DUOC SAP XEP");

            for (int i = 0; i < arr.Length - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j].SoTC > arr[min].SoTC)
                        min = j;
                }
                monHoc = arr[i];
                arr[i] = arr[min];
                arr[min] = monHoc;
            }
            XuatFile(arr);
        }
        static void timMaMH(ref MonHoc[] arr, string key)
        {
            int index = timVTMH(arr, key);
            if (index == -1)
            {
                Console.WriteLine("Khong tim thay");
            }
            else
            {
                Console.WriteLine($"{"\n",-20}DANH SACH DUOC SAP XEP");

                for (int i = 0; i < arr.Length; i++)
                {
                    if (String.Compare(arr[i].MaMH, key) == 0)
                    {
                        Console.Write("Nhap so tin chi moi: ");
                        arr[i].SoTC = int.Parse(Console.ReadLine());
                        XuatFile(arr);
                    }
                }
            }
        }
        static int timVTMH(MonHoc[] arr, string key)
        {
            int index = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (String.Compare(key, arr[i].MaMH) == 0)
                {
                    index = i;
                    break;
                }

            }
            return index;
        }
        static void sapXepTangDanTheoMaMH(MonHoc[] arr)
        {
            Console.WriteLine($"{"\n",-20}DANH SACH DUOC SAP XEP");

            MonHoc mh;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = arr.Length - 1; j > i; j--)
                {
                    if (String.Compare(arr[j - 1].MaMH, arr[j].MaMH) > 0)
                    {
                        mh = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = mh;
                    }
                }

            }
            XuatFile(arr);
        }
        static void XuatFile(MonHoc[] arr)
        {
            Console.WriteLine($"{"Ma MH",-15}{"Ten MH",-15}{"Ngay DKi",-15}{"So Tin Chi",-15}");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].toString());
            }
        }
        static MonHoc[] DocFile(string path)
        {
            int n;
            MonHoc[] mh = new MonHoc[0];

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    n = int.Parse(sr.ReadLine());
                    mh = new MonHoc[n];
                    for (int i = 0; i < n; i++)
                    {
                        string[] t = sr.ReadLine().Split('#');
                        MonHoc monhoc = new MonHoc(t[0], t[1], DateTime.Parse(t[2]), int.Parse(t[3]));
                        mh[i] = monhoc;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("File not found.");
            }

            return mh;
        }
    }
}
