using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE2_TranTrungChien
{
    class runtest
    {
        static void Main(string[] args)
        {
            Nguoi[] thongTincoBan = new Nguoi[2];
            GiangVien[] dsnv = nhapTTGiangVien(thongTincoBan);
            Xuat(dsnv);
            Console.WriteLine($"Danh Sach gom: {Nguoi.SoNguoi} nguoi.");
        }

        public static void Xuat(GiangVien[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].toString());
            }
        }

        public static GiangVien[] nhapTTGiangVien(Nguoi[] ttcb)
        {
            GiangVien[] dsnv = new GiangVien[ttcb.Length];
            for (int i = 0; i < ttcb.Length; i++)
            {
                
                Console.WriteLine("DANH SACH GIANG VIEN");
                Console.WriteLine("1. Giang Vien Bien Che");
                Console.WriteLine("2. Giang Vien Hop Dong");
                int choose = 0;
                Console.Write($"{"", -5}Lua Chon: ");
                do
                {
                    int.TryParse(Console.ReadLine(), out choose);
                } while (choose < 1 || choose > 2);
                switch (choose)
                {
                    case 1:
                        Console.WriteLine("Nhap Ho Ten: ");
                        string hoTen = Console.ReadLine();
                        Console.WriteLine("Nhap dia chi: ");
                        string dc = Console.ReadLine();
                        ttcb[i] = new Nguoi(hoTen, dc);
                        Console.WriteLine("Nhap he so Luong: ");
                        double heSoLuong = double.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap luong co ban: ");
                        double luongCb = double.Parse(Console.ReadLine());
                        dsnv[i] = new GiangVienBienChe(ttcb[i], heSoLuong, luongCb);
                        break;
                    case 2:
                        Console.WriteLine("Nhap Ho Ten: ");
                        string hoTen2 = Console.ReadLine();
                        Console.WriteLine("Nhap dia chi: ");
                        string dc2 = Console.ReadLine();
                        ttcb[i] = new Nguoi(hoTen2, dc2);
                        Console.WriteLine("Nhap gia tien 1Tiet: ");
                        double giaTien1Tiet = double.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap so tiet giang: ");
                        int soTietGiang = int.Parse(Console.ReadLine());
                        dsnv[i] = new GiangVienHopDong(ttcb[i], giaTien1Tiet, soTietGiang);
                        break;
                    default:
                        break;
                }
            }
                return dsnv;
        }
    }
}
