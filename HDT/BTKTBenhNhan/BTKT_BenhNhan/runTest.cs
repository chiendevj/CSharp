using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace BTKT_BenhNhan
{
    class runTest
    {
        static void Main(string[] args)
        {
            //BenhNhanNoiTru bnnt = new BenhNhanNoiTru("BN1", "Nguyen Van A", DateTime.ParseExact("27/03/2002", "dd/MM/yyyy", null), "Co", DateTime.ParseExact("12/05/2023", "dd/MM/yyyy", null), DateTime.ParseExact("12/05/2023", "dd/MM/yyyy", null), DateTime.ParseExact("19/05/2023", "dd/MM/yyyy", null), "TN", 12);
            //Console.WriteLine(bnnt.toString());
            //BenhNhanNoiTru bnnt2 = new BenhNhanNoiTru("BN1", "Nguyen Van A", DateTime.ParseExact("27/03/2002", "dd/MM/yyyy", null), "Co", DateTime.ParseExact("12/05/2023", "dd/MM/yyyy", null), DateTime.ParseExact("12/05/2023", "dd/MM/yyyy", null), DateTime.ParseExact("19/05/2023", "dd/MM/yyyy", null), "TN", 12);
            //Console.WriteLine(bnnt2.toString());

            BenhNhan[] dssbnnoitru = new BenhNhan[2];
            NhapBN(dssbnnoitru);
            Xuat(dssbnnoitru);
            Console.WriteLine(demSoLuongBenhNhan(dssbnnoitru,new DateTime(2222,11,11)));
            //List<BenhNhanNoiTru> danhSachBenhNhan = new List<BenhNhanNoiTru>();

            //// Thêm bệnh nhân vào danh sách
            //danhSachBenhNhan.Add(new BenhNhanNoiTru("BN001", "Nguyen Van A", DateTime.ParseExact("27/03/2002", "dd/MM/yyyy", null), "abc", DateTime.ParseExact("27/03/2002", "dd/MM/yyyy", null), DateTime.ParseExact("27/03/2002", "dd/MM/yyyy", null), DateTime.ParseExact("27/03/2002", "dd/MM/yyyy", null), "Khoa 1", 1));
            //danhSachBenhNhan.Add(new BenhNhanNoiTru("BN001", "Nguyen Van A", DateTime.ParseExact("27/03/2002", "dd/MM/yyyy", null), "abc", DateTime.ParseExact("27/03/2002", "dd/MM/yyyy", null), DateTime.ParseExact("27/03/2002", "dd/MM/yyyy", null), DateTime.ParseExact("27/03/2002", "dd/MM/yyyy", null), "Khoa 1", 1));

            ////// Xuất thông tin các bệnh nhân trong danh sách
            //foreach (BenhNhanNoiTru benhNhan in danhSachBenhNhan)
            //{
            //    Console.WriteLine(benhNhan.toString());
            //}
        }

        

    public static void Xuat(BenhNhan[] dsbn)
        {
            for (int i = 0; i < dsbn.Length; i++) 
            {
                Console.WriteLine(dsbn[i].toString() +"\n++++++++++++++++++++++++++++++++++++++++++++++");
            }
        }

        public static int demSoLuongBenhNhan(BenhNhan[] arr, DateTime NK)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (NK.Equals(arr[i].NgayLapHoSo)) { 
                    count++;
                }
            }
            return count;
        }
        public static void NhapBN(BenhNhan[] dsbn)
        {
            for (int i = 0; i < dsbn.Length; i++)
            {
                Console.WriteLine("DANH SACH BENH NHAN");
                Console.WriteLine("1. Benh nhan noi tru");
                Console.WriteLine("2. Benh nhan ngoai tru");
                int choose = 0;
                do
                {
                    Console.Write("Lua chon: ");
                    int.TryParse(Console.ReadLine(), out choose);

                } while (choose < 1 && choose > 2);
                
                // Nhập thông tin bệnh nhân
                switch (choose)
                {
                    case 1:
                        Console.Write("Nhap ma ho so: ");
                        string maHs = Console.ReadLine();
                        Console.Write("Nhap ho ten: ");
                        string hoTen = Console.ReadLine();
                        Console.Write("Nhap ngay Sinh: ");
                        DateTime ngaySinh;
                        DateTime.TryParse(Console.ReadLine(), out ngaySinh);
                        Console.Write("Chuan doan: ");
                        string chuanDBN = Console.ReadLine();
                        Console.Write("Nhap ngay lap Ho So: ");
                        DateTime ngayLHS;
                        DateTime.TryParse(Console.ReadLine(), out ngayLHS);
                        Console.Write("Nhap ngay Nhap Vien: ");
                        DateTime ngayNhapVien;
                        DateTime.TryParse(Console.ReadLine(), out ngayNhapVien);
                        Console.Write("Nhap ngay ra Vien: ");
                        DateTime ngayRaVien;
                        DateTime.TryParse(Console.ReadLine(), out ngayRaVien);
                        Console.Write("Ten Khoa Benh: ");
                        string tenKhoa = Console.ReadLine();
                        Console.Write("Nam tai giuong: ");
                        int soGiuong = int.Parse(Console.ReadLine());
                        dsbn[i] = new BenhNhanNoiTru(maHs, hoTen, ngaySinh, chuanDBN, ngayLHS, ngayNhapVien, ngayRaVien, tenKhoa, soGiuong);
                        break;

                    case 2:
                        Console.Write("Nhap ma ho so: ");
                        string maHs2 = Console.ReadLine();
                        Console.Write("Nhap ho ten: ");
                        string hoTen2 = Console.ReadLine();
                        Console.Write("Nhap ngay Sinh: ");
                        DateTime ngaySinh2;
                        DateTime.TryParse(Console.ReadLine(), out ngaySinh2);
                        Console.Write("Chuan doan: ");
                        string chuanDBN2 = Console.ReadLine();
                        Console.Write("Nhap ngay lap Ho So: ");
                        DateTime ngayLHS2;
                        DateTime.TryParse(Console.ReadLine(), out ngayLHS2);
                        Console.Write("Nhap ngay kham: ");
                        DateTime ngayKham;
                        DateTime.TryParse(Console.ReadLine(), out ngayKham);
                        Console.Write("Nhap ma so Bao Hiem: ");
                        string maBH = Console.ReadLine();
                        Console.Write("Ma Toa Thuoc: ");
                        string maTH = Console.ReadLine();
                        dsbn[i] = new BenhNhanNgoaiTru(maHs2, hoTen2, ngaySinh2, chuanDBN2, ngayLHS2, ngayKham, maBH, maTH);
                        
                        break;
                }
                
              
            }
        }

       

    }
}
