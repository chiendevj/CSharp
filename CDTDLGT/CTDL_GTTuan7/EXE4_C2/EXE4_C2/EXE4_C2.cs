using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE4_C2
{
    class EXE4_C2
    {
        static void Main(string[] args)
        {
            string path = "D:\\CTDL_GTTuan7\\input_De4- 2020.txt";
            MonHoc[] monhocs = NhapFile(path);
            XuatFile(monhocs);

            // c.	Dùng giải thuật BubbleSort sắp xếp danh sách tăng dần theo maMH.
            sapXepTangDanTheoMaMH(monhocs);

            // d. 	Dùng giải thuật tìm nhị phân tìm theo maMH: sửa số tín chỉ của môn học tìm được 
            //      (Mã môn học cần tìm và số tín chỉ mới được nhập từ bàn phím). Xuất lại danh sách sau khi sửa tín chỉ.

            Console.Write("Nhap ma MH: ");
            string key = Console.ReadLine();
            //Console.WriteLine(timVTMH(monhocs,key));
            timMHSuaSoTC(monhocs,key);


        }
        public static void timMHSuaSoTC(MonHoc[] arr, string key)
        {
            int viTri = timVTMH(arr, key);
            Console.Write("Nhap so TC can sua: ");
            int stc = int.Parse(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == viTri)
                {
                    arr[i].SoTC = stc;
                }
                else
                {
                    Console.WriteLine("Khong tim thay ma MH nay");
                }
            }
            XuatFile(arr);
        }
        public static int timVTMH(MonHoc[] arr, string key)
        {
            int index = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (String.Compare(arr[i].MaMH, key) == 0)
                {
                    index = i;
                }
            }
            return index;
        }
        public static void sapXepTangDanTheoMaMH(MonHoc[] arr)
        {
            Console.WriteLine($"{"\n",-20} DANH SACH DA SAP XEP");
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = arr.Length -1; j > i ; j--)
                {
                    if (String.Compare(arr[j - 1].MaMH,arr[j].MaMH) > 0)
                    {
                        Swap(ref arr[j],ref arr[j-1]);
                    }
                }
            }
            XuatFile(arr);
        }

        public static void Swap(ref MonHoc a, ref MonHoc b)
        {
            MonHoc c;
            c = a;
            a = b;
            b = c;


        }
        public static void XuatFile(MonHoc[] arr)
        {
            Console.WriteLine($"{"Ma MH",-15}{"Ten MH",-15}{"Ngay DK",-15}{"So TC",-15}");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].toString());
            }
        }

        public static MonHoc[] NhapFile(string path)
        {
            MonHoc[] arr = new MonHoc[0];
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    int n = int.Parse(sr.ReadLine());
                    arr = new MonHoc[n];
                    for (int i = 0; i < arr.Length; i++)
                    {
                        string[] t = sr.ReadLine().Split('#');
                        MonHoc mh = new MonHoc(t[0], t[1], DateTime.ParseExact(t[2], "d/M/yyyy", null), int.Parse(t[3]));
                        arr[i] = mh;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return arr;
        }


    }
}
