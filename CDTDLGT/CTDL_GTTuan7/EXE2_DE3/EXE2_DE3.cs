using System;
using System.IO;

//c.Viết hàm tìm tuần tự theo tên hàng hóa, để tìm và xóa hàng hóa tìm được khỏi danh sách hàng hóa, nếu không tìm thấy thì báo “Khong xoa duoc!”.
//d.Dùng giải thuật Interchange sort sắp xếp danh sách tăng dần theo tháng nhập kho.Xuất lại danh sách sau khi sắp xếp.
//e.Dùng giải thuật Insertion sort sắp xếp danh sách giảm dần theo mã hàng, in kết quả sắp xếp được ra màn hình.

namespace EXE2_DE3
{
    class EXE2_DE3
    {
        static void Main(string[] args)
        {
            string path = @"H:\IT_Language\C#\CDTDLGT\CTDL_GTTuan7\Demoi\input3.txt";

            BachHoaXanh[] bhxs = DocFile(path);
            XuatFile(bhxs);
            //Console.Write("Nhap ten hang: ");
            //string key = Console.ReadLine();
            //timTenHHXXoaHH(ref bhxs, key);

            sapXepTangDanTheoThang(bhxs);
            sapXepGiamDanTheoMaHang(bhxs);
        }
        public static void sapXepGiamDanTheoMaHang(BachHoaXanh[] arr)
        {
            int position;
            BachHoaXanh v; Console.WriteLine($"{"\n",-20}DANH SACH DA SAP XEP");
            for (int i = 0; i < arr.Length; i++)
            {
                v = arr[i];
                position = i - 1;
                while (position >= 0 && String.Compare(v.MaHang,arr[position].MaHang) < 0)
                {
                    arr[position + 1] = arr[position];
                    position--;
                }
                arr[position + 1] = v;
            }
            XuatFile(arr);
        }
        public static void sapXepTangDanTheoThang(BachHoaXanh[] arr)
        {
            // InterchangeSort
            Console.WriteLine($"{"\n",-20}DANH SACH DA SAP XEP");
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i].NgayNK.Month > arr[j].NgayNK.Month)
                    {
                        Swap(ref arr[i],ref arr[j]);
                    }
                }
            }
            XuatFile(arr);
        }
        public static void Swap(ref BachHoaXanh a, ref BachHoaXanh b)
        {
            BachHoaXanh c;
            c = a;
            a = b;
            b = c;
        }
        static void timTenHHXXoaHH(ref BachHoaXanh[] arr, string key)
        {
            int index = timViTriHangHoa(arr, key);
            if (index == -1)
            {
                Console.WriteLine("Khong tim thay");
            }
            else
            {
                Console.WriteLine($"{"\n",-20}DANH SACH DA SAP XEP");
                for (int i = index; i < arr.Length - 1; i++)
                {
                    arr[i] = arr[i + 1];
                   
                }
                Array.Resize(ref arr, arr.Length - 1);
                XuatFile(arr);
            }
        }
        static int timViTriHangHoa(BachHoaXanh[] arr, string key)
        {
            int index = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (String.Compare(arr[i].TenHang, key) == 0)
                {
                    index = i;
                }
            }
            return index;
        }
        public static void XuatFile(BachHoaXanh[] arr)
        {
            Console.WriteLine($"+---------------+---------------+---------------+------------+");
            Console.WriteLine($"|{"",-4}{"Ma Hang",-11}|{"",-4}{"Ten Hang",-11}|{"",-4}{"Ngay DK",-11}|{"",-3}{"Gia Ban",-9}|");
            Console.WriteLine($"+---------------+---------------+---------------+------------+");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].toString());
            }
            Console.WriteLine($"+---------------+---------------+---------------+------------+");
        }
        public static BachHoaXanh[] DocFile(string path)
        {
            BachHoaXanh[] arr = new BachHoaXanh[0];
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    int n = int.Parse(sr.ReadLine());
                    arr = new BachHoaXanh[n];
                    for (int i = 0; i < arr.Length; i++)
                    {
                        string[] str = sr.ReadLine().Split('#');
                        BachHoaXanh bhx = new BachHoaXanh(str[0], str[1], DateTime.ParseExact(str[2],"d/M/yyyy",null),int.Parse(str[3]));
                        arr[i] = bhx;
                    }


                }
            }
            catch (Exception)
            {
                Console.WriteLine("Khong tim thay");
            }
            return arr;
        }
    }
}
