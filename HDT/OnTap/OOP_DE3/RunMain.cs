using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_DE3
{
    internal class RunMain
    {
        static void Main(string[] args)
        {
            LinkedList<Employee> dsNhanVien = new LinkedList<Employee>();
            NhapDanhSach(dsNhanVien);
            XuatDanhSach(dsNhanVien);
        }
        // XUat
        public static void XuatDanhSach(LinkedList<Employee> L)
        {
            for (LinkedListNode<Employee> i = L.First; i != null; i = i.Next)
            {
                Console.WriteLine(i.Value.ToString());
                
            }
            Console.WriteLine();
        }
        // Nhap
        static void NhapDanhSach(LinkedList<Employee> L)
        {
            int n = 0;
            string maNV;
            string ten;
            string maVung;
            DateTime ngaySinh;
            string phone;
            string address;
            DateTime ngayLamViec;
            long luongThang;
            float heSoLuong;
            int choose; 

            Console.Write("Nhap so luong nv: ");
            int.TryParse(Console.ReadLine(), out n);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhan vien thu " + (i+1));
                Console.Write("Nhap ma NV: ");
                maNV = Console.ReadLine();
                Console.Write("Nhap ten: ");
                ten = Console.ReadLine();
                Console.Write("Nhap ngay sinh: ");
                DateTime.TryParse(Console.ReadLine(), out ngaySinh);
                Console.Write("Nhap ma vung: ");
                maVung = Console.ReadLine();

                Console.Write("Nhap so dien thoai: ");
                phone = Console.ReadLine();
                Console.Write("Nhap dia chi: ");
                address = Console.ReadLine();
                PostalDetail postalDetail = new PostalDetail(phone, address);

                Person nv = new Person(ten, maVung, ngaySinh, postalDetail);

                Console.Write("Ngay lam viec: ");
                DateTime.TryParse(Console.ReadLine(), out ngayLamViec);
                Console.WriteLine("LOAI NHAN VIEN");
                Console.WriteLine("1.   STAFF");
                Console.WriteLine("2.   TEACHER");
                Console.Write("Lua chon: ");
                int.TryParse(Console.ReadLine(), out choose);

                switch (choose)
                {
                    case 1:
                        Console.Write("Nhap luong thang: ");
                        long.TryParse(Console.ReadLine(), out luongThang);
                        Console.Write("Nhap he so luong: ");
                        float.TryParse(Console.ReadLine(), out heSoLuong);

                        Staff nvST = new Staff(maNV, nv, ngayLamViec, luongThang, heSoLuong);
                        L.AddLast(nvST);
                        break;
                    case 2:
                        Console.Write("Nhap he so luong: ");
                        float.TryParse(Console.ReadLine(), out heSoLuong);

                        Teacher nvTC = new Teacher(maNV, nv, heSoLuong);
                        L.AddLast(nvTC);

                        break;
                    default:
                        Console.WriteLine("Lua chon sai!");
                        break;
                }


            }

            
        }
    }
}
