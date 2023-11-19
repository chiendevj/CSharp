/*
 * FULLNAME: TRẦN TRUNG CHIẾN
 * ID: 22211TT3000
 * CLASS: CD22TT11
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap2
{
    internal class RunMain
    {
        static void Main(string[] args)
        {
            // Khai báo
            LinkedList<Nguoi> dsNhanVien = new LinkedList<Nguoi>();
            NhapDanhSach(dsNhanVien);
            XuatDanhSach(dsNhanVien);

            Console.WriteLine($"{"LOAI NV",-30}|{"NV QL",-30}|{"NV BC",-30}|{"NV HD",-30}");
            Console.WriteLine($"{"TT",-30}|{TinhLuongNhanVienQuanLi(dsNhanVien),-30}|{TinhLuongNhanVienBienChe(dsNhanVien),-30}|{TinhLuongNhanVienHopDong(dsNhanVien),-30}");
        }

        // OUT MAIN
        public static double TinhLuongNhanVienQuanLi(LinkedList<Nguoi> L)
        {
            double tongLuongNVQL = 0d;
            for (LinkedListNode<Nguoi> i = L.First; i != null; i = i.Next)
            {
                if (i.Value.GetType().Equals(new NhanVienQL().GetType()))
                {
                    tongLuongNVQL += i.Value.TinhLuong();
                }
            }
            return tongLuongNVQL;
        }

        public static double TinhLuongNhanVienHopDong(LinkedList<Nguoi> L)
        {
            double tongLuongNVHD = 0d;
            for (LinkedListNode<Nguoi> i = L.First; i != null; i = i.Next)
            {
                if (i.Value.GetType().Equals(new NhanVienHD().GetType()))
                {
                    tongLuongNVHD += i.Value.TinhLuong();
                }
            }
            return tongLuongNVHD;
        }

        public static double TinhLuongNhanVienBienChe(LinkedList<Nguoi> L)
        {
            double tongLuongNVBC = 0d;
            for (LinkedListNode<Nguoi> i = L.First; i != null; i = i.Next)
            {
                if (i.Value.GetType().Equals(new NhanVienBC().GetType()))
                {
                    tongLuongNVBC += i.Value.TinhLuong();
                }
            }
            return tongLuongNVBC;
        }
        // Xuat
        public static void XuatDanhSach(LinkedList<Nguoi> L)
        {
            for (LinkedListNode<Nguoi> i = L.First; i != null; i = i.Next)
            {
                Console.WriteLine(i.Value.ThongTin());
            }
            Console.WriteLine();
        }
        // Nhap
        public static void NhapDanhSach(LinkedList<Nguoi> L)
        {
            // khai bao
            int n = 0; // luu so luong nhan vien
            string ten = "";
            int ngay = 0;
            int thang = 0;
            int nam = 0;
            string soDT = "";
            string diaChi = "";
            int choose = 0;

            string maQL = "";
            double luongCB = 0d;
            double heSoLuong = 0d;
            double heSoQuanLi = 0d;
            string maBC = "";
            string maHD = "";
            double phuCap = 0d;
            double soNgayLamViec = 0d;
            double luongNgay = 0d;
            // Processing
            Console.Write("Nhap so luong nhan vien: ");
            int.TryParse(Console.ReadLine(), out n);

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\tNhap nhan vien thu {i}");

                Console.Write("Nhap ten NV: ");
                ten = Console.ReadLine();

                Console.WriteLine("Nhap Ngay Sinh");
                Console.Write("Nhap ngay sinh: ");
                int.TryParse(Console.ReadLine(), out ngay);
                Console.Write("Nhap thang sinh: ");
                int.TryParse(Console.ReadLine(), out thang);
                Console.Write("Nhap nam sinh: ");
                int.TryParse(Console.ReadLine(), out nam);
                Date ngaySinh = new Date(ngay, thang, nam);

                Console.Write("Nhap SDT NV: ");
                soDT = Console.ReadLine();

                Console.Write("Nhap dia chi NV: ");
                diaChi = Console.ReadLine();

                Console.WriteLine("DANH SACH NHAN VIEN");
                Console.WriteLine("\t1. NHAN VIEN QUAN LI");
                Console.WriteLine("\t2. NHAN VIEN BIEN CHE");
                Console.WriteLine("\t3. NHAN VIEN HOP DONG");

                Console.Write("Nhap Lua Chon: ");
                int.TryParse(Console.ReadLine(), out choose);
                switch (choose)
                {
                    case 1:
                        Console.Write("Nhap ma QL: ");
                        maQL = Console.ReadLine();
                        Console.Write("Nhap luong co ban: ");
                        double.TryParse(Console.ReadLine(), out luongCB);
                        Console.Write("Nhap he so luong: ");
                        double.TryParse(Console.ReadLine(), out heSoLuong);
                        Console.Write("Nhap he so Quan Li: ");
                        double.TryParse(Console.ReadLine(), out heSoQuanLi);

                        NhanVienQL newNVQL = new NhanVienQL(ten, ngaySinh, soDT, diaChi, maQL, luongCB, heSoLuong, heSoQuanLi);
                        L.AddLast(newNVQL);
                        break;
                    case 2:
                        Console.Write("Nhap ma BC: ");
                        maBC = Console.ReadLine();
                        Console.Write("Nhap luong CB: ");
                        double.TryParse(Console.ReadLine(), out luongCB);
                        Console.Write("Nhap he so luong: ");
                        double.TryParse(Console.ReadLine(), out heSoLuong);
                        Console.Write("Nhap tien phu cap: ");
                        double.TryParse(Console.ReadLine(), out phuCap);

                        NhanVienBC newNVBC = new NhanVienBC(ten, ngaySinh, soDT, diaChi, maBC, luongCB, heSoLuong, phuCap);
                        L.AddLast(newNVBC);
                        break;
                    case 3:
                        Console.Write("Nhap ma HD: ");
                        maHD = Console.ReadLine();
                        Console.Write("Nhap luong ngay: ");
                        double.TryParse(Console.ReadLine(), out luongNgay);
                        Console.Write("Nhap so ngay lam viec: ");
                        double.TryParse(Console.ReadLine(), out soNgayLamViec);
                        Console.Write("Nhap tien phu cap: ");
                        double.TryParse(Console.ReadLine(), out phuCap);

                        NhanVienHD newNVHD = new NhanVienHD(ten, ngaySinh, soDT, diaChi, maHD, luongNgay, soNgayLamViec, phuCap);
                        L.AddLast(newNVHD);
                        break;
                    default:
                        Console.WriteLine("Lua chon sai!");
                        break;
                }
            }
        }
    }
}
