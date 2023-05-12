using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT5_Chuong3_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
           
            TTSinhVien[] ttsv = NhapTTSinhVien();
            XuatTTSinhVien(ttsv);
        }
        public static void XuatTTSinhVien(TTSinhVien[] arrs)
        {
            for (int i = 0; i < arrs.Length; i++)
            {
                Console.WriteLine(arrs[i].toString());
            }
        }
        public static TTSinhVien[] NhapTTSinhVien()
        {
            int n = 0;
            Console.Write("So luong Sinh Vien: ");
            int.TryParse(Console.ReadLine(), out n);
            TTSinhVien[] arrs = new TTSinhVien[n];
            for (int i = 0; i < arrs.Length; i++)
            {
                Console.Write("Ma Lop: ");
                string maLop = Console.ReadLine();
                Console.Write("Khoa: ");
                string khoa = Console.ReadLine();
                Console.Write("Ma Sinh Vien: ");
                string maSV = Console.ReadLine();
                Console.Write("Ho va Ten: ");
                string hoTen = Console.ReadLine();
                TTMonHoc[] t = NhapTTMonHoc();
                arrs[i] = new TTSinhVien(maLop,khoa,maSV,hoTen,t);
            }
            return arrs;
        }
        public static void XuatTTMonHoc(TTMonHoc[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].toString());
            }
        }
        public static TTMonHoc[] NhapTTMonHoc()
        {
            int soMonHoc = 0;
            int soTinChi = 0;
            double diemMH = 0;
            Console.Write("Nhap so mon hoc: ");
            int.TryParse(Console.ReadLine(), out soMonHoc);

            TTMonHoc[] arr = new TTMonHoc[soMonHoc];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Ten Mon: ");
                string tenMonHoc = Console.ReadLine();
                Console.Write("So Tin Chi: ");
                int.TryParse(Console.ReadLine(), out soTinChi);
                Console.Write("Diem: ");
                double.TryParse(Console.ReadLine(), out diemMH);
                arr[i] = new TTMonHoc(tenMonHoc, soTinChi, diemMH);
            }
        return arr;
        }
    }
}
