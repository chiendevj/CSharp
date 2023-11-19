/*
 * FULLNAME: TRẦN TRUNG CHIẾN
 * ID: 22211TT3000
 * CLASS: CD22TT11
 * DATE: 22/06/2023
 * MON THI: OOP
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OnTap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Khai bao
            LinkedList<XeHoi> dsXe = new LinkedList<XeHoi>();

            // Output
            // cau a
            NhapDSXe(ref dsXe);
            // cau b
            XuatDSXe(dsXe);
            // cau c
            Console.WriteLine($"{"LOAI XE",-30}{"XE KHACH",-30}{"XE TAI",-30}{"XE TAXI",-30}");
            Console.WriteLine($"{"TONG TIEN",-30}{TinhTongTienXeKhach(dsXe),-30}{TinhTongTienXeTai(dsXe),-30}{TinhTongTienXeTaxi(dsXe),-30}");
            
        }

        // OUT MAIN
        // tinh tong tien
        static double TinhTongTienXeTaxi(LinkedList<XeHoi> L)
        {
            double tongTienXeTaxi = 0d;
            for (LinkedListNode<XeHoi> i = L.First; i != null; i = i.Next)
            {
                if (i.Value.GetType().Equals(new XeTaxi().GetType()))
                {
                    tongTienXeTaxi += i.Value.TongTien();
                }

            }
            return tongTienXeTaxi;
        }
        static double TinhTongTienXeTai(LinkedList<XeHoi> L)
        {
            double tongTienXeTai = 0d;
            for (LinkedListNode<XeHoi> i = L.First; i != null; i = i.Next)
            {
                if (i.Value.GetType().Equals(new XeTai().GetType()))
                {
                    tongTienXeTai += i.Value.TongTien();
                }

            }
            return tongTienXeTai;
        }
        static double TinhTongTienXeKhach(LinkedList<XeHoi> L)
        {
            double tongTienXeKhach = 0d;
            for (LinkedListNode<XeHoi> i = L.First; i != null; i = i.Next)
            {
                if (i.Value.GetType().Equals(new XeKhach().GetType()))
                {
                    tongTienXeKhach += i.Value.TongTien();
                }
               
            }
            return tongTienXeKhach;
        }                                               
        // Xuat
        public static void XuatDSXe(LinkedList<XeHoi> L)
        {
            for (LinkedListNode<XeHoi> i = L.First; i != null; i = i.Next)
            {
                Console.WriteLine(i.Value.ThongTin());
            }
        }

        // Nhap
        public static void NhapDSXe(ref LinkedList<XeHoi> L)
        {
            // khai bao
            int n = 0;
            string mauXe = "";
            Date namSX = new Date();
            string nuocSX ="";
            string hieuXe = "";
            int ngay = 0;
            int thang = 0;
            int nam = 0;
            int choose = 0;
            int soGhe = 0;
            double giaVe = 0d;
            int trongTai = 0;
            int soKm = 0;
            double donGia = 0d;
            int soCho = 0;
            double giaKM = 0d;

            Console.Write("Nhap so luong xe Hoi: ");
            int.TryParse(Console.ReadLine(), out n);
            for (int i = 1; i <= n; i++) 
            {
                Console.WriteLine($"\tNhap xe thu {i}");

                Console.Write("\tNhap mau xe: ");
                mauXe = Console.ReadLine();

                Console.WriteLine("\tNhap nam SX: ");
                Console.Write("\tNgay: ");
                int.TryParse(Console.ReadLine(), out ngay);
                Console.Write("\tThang: ");
                int.TryParse(Console.ReadLine(), out thang);
                Console.Write("\tNam: ");
                int.TryParse(Console.ReadLine(), out nam);
                namSX = new Date(ngay, thang, nam);

                Console.Write("\tNhap nuoc SX : ");
                nuocSX = Console.ReadLine();

                Console.Write("\tNhap hieu xe: ");
                hieuXe = Console.ReadLine();

                Console.WriteLine("\t DANH SACH XE HOI");
                Console.WriteLine("\t1. Xe khach");
                Console.WriteLine("\t2. Xe tai");
                Console.WriteLine("\t3. Xe taxi");

                Console.Write("Nhap lua chon: ");
                int.TryParse(Console.ReadLine(), out choose);

                switch (choose)
                {
                    case 1:
                        Console.Write("Nhap so ghe: ");
                        int.TryParse(Console.ReadLine(), out soGhe);
                        Console.Write("Nhap gia ve: ");
                        double.TryParse(Console.ReadLine(), out giaVe);
                        XeKhach xeKhach = new XeKhach(mauXe, namSX, nuocSX, hieuXe, soGhe, giaVe);

                        L.AddLast(xeKhach);
                        break;
                    case 2:
                        Console.Write("Nhap trong tai: ");
                        int.TryParse(Console.ReadLine(), out trongTai);
                        Console.Write("Nhap so Km: ");
                        int.TryParse(Console.ReadLine(), out soKm);
                        Console.Write("Nhap don gia: ");
                        double.TryParse(Console.ReadLine(), out donGia);
                        XeTai xeTai = new XeTai(mauXe, namSX, nuocSX, hieuXe, trongTai, soKm, donGia);

                        L.AddLast(xeTai);
                        break;
                    case 3:
                        Console.Write("Nhap so cho: ");
                        int.TryParse(Console.ReadLine(), out soCho);
                        Console.Write("Nhap gia KM: ");
                        double.TryParse(Console.ReadLine(), out giaKM);
                        XeTaxi xeTaxi = new XeTaxi(mauXe, namSX, nuocSX, hieuXe, soCho, giaKM);

                        L.AddLast(xeTaxi);
                        break;
                    default:
                        Console.WriteLine("Lua chon sai!!");
                        break;
                }
            }
        }
    }
}
