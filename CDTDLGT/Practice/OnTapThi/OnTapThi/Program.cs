/*
 * TOPIC: ON TAP THI 
 * NAME: LE VIET KHANH
 * CLASS: CD22TT11
 * ID: 22211TT2577
 * DATE: 2023/06/13
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapThi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare variable
            LinkedList dsNhanVien = new LinkedList();
            int soLuong = 0;

            //input
            Console.WriteLine("\t\tNHAP NHAN VIEN");
            Console.Write("Nhap so luong nhan vien: ");
            int.TryParse(Console.ReadLine(), out soLuong);
            NhapDSNhanVien(ref dsNhanVien, soLuong);
            Console.WriteLine();

            //output
            Console.WriteLine("\t\tDANH SACH NHAN VIEN");
            dsNhanVien.Print();

            //tim nhan vien theo ma X
            Console.WriteLine("\t\tTIM NHAN VIEN MA X");
            string x = "";
            Console.Write("Nhap ma nhan vien: ");
            x = Console.ReadLine();
            Node nhanVienTimDuoc = dsNhanVien.Find(x);

            if (nhanVienTimDuoc != null)
            {
                Console.WriteLine("Nhan vien tim duoc: ");
                Console.WriteLine("\t" + nhanVienTimDuoc.Data.toString());
            }
            else
            {
                Console.WriteLine("Khong tim thay");
            }
            Console.WriteLine();


            //tim nhan vien theo ma X va sua ten
            Console.WriteLine("\t\tTIM NHAN VIEN MA X VA SUA TEN");
            Console.Write("Nhap ma nhan vien: ");
            x = Console.ReadLine();
            nhanVienTimDuoc = dsNhanVien.Find(x);

            if (nhanVienTimDuoc != null)
            {
                Console.Write("\tNhap ten moi: ");
                nhanVienTimDuoc.Data.TenNhanVien = Console.ReadLine();

                Console.WriteLine(nhanVienTimDuoc.Data.toString());
            }
            else
            {
                Console.WriteLine("Khong tim thay");
            }
            Console.WriteLine();

            //them nhan vien moi sau nhan vien ma x
            Console.WriteLine("\t\tNHAP NHAN VIEN SAU NHAN VIEN MA X");
            Console.Write("Nhap ma nhan vien x: ");
            x = Console.ReadLine();

            string ma = "";
            do
            {
                Console.Write("\tMa nhan vien: ");
                ma = Console.ReadLine();
            } while (dsNhanVien.Find(ma) != null);

            Console.Write("\tTen nhan vien: ");
            string ten = Console.ReadLine();

            Console.Write("\tTuoi nhan vien: ");
            int tuoi = 0;
            int.TryParse(Console.ReadLine(), out tuoi);

            NhanVien nvThem = new NhanVien(ma, ten, tuoi);

            dsNhanVien.AddAfter(dsNhanVien.Find(x), nvThem);

            //output
            Console.WriteLine("\t\tDANH SACH NHAN VIEN");
            dsNhanVien.Print();
            Console.WriteLine();

            //xoa nhan vien ma X
            Console.WriteLine("\t\tXOA NHAN VIEN MA X");
            x = "";
            Console.Write("Nhap ma nhan vien x: ");
            x = Console.ReadLine();
            nhanVienTimDuoc = dsNhanVien.Find(x);

            if (nhanVienTimDuoc != null)
            {
                dsNhanVien.Remove(nhanVienTimDuoc);

                //output
                Console.WriteLine("\t\tDANH SACH NHAN VIEN SAU KHI XOA");
                dsNhanVien.Print();
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Khong tim thay");
            }
            Console.WriteLine();
        }

        static void NhapDSNhanVien(ref LinkedList dsNhanVien, int soLuongNv)
        {
            string ma = "";
            string ten = "";
            int tuoi = 0;
            for (int i = 1; i <= soLuongNv; i++)
            {
                Console.Write("Nhap ma Nhan Vien: ");
                ma = Console.ReadLine();
                Console.Write("Nhap ten Nhan Vien: ");
                ten = Console.ReadLine();
                Console.Write("Nhap tuoi Nhan Vien: ");
                int.TryParse(Console.ReadLine(), out tuoi);

                NhanVien nvMoi = new NhanVien(ma, ten, tuoi);

                dsNhanVien.AddLast(nvMoi);
            }
        }


    }
}
