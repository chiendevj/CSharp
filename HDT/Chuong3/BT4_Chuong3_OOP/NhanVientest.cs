using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4_Chuong3_OOP
{
    class NhanVientest
    {
        static void Main(string[] args)
        {
            //DateTime ngaySinh;
            //string fullname = "";
            //Console.Write("Nhap ho ten cua ban: ");
            //fullname = Console.ReadLine();

            //Console.Write("Nhap ngay sinh cua ban: ");
            //DateTime.TryParse(Console.ReadLine(), out ngaySinh);

            //DiaChi dc1 = new DiaChi("53", "Vo Van Ngan", "TP.Thu Duc", "TP.Ho Chi Minh");
            //NhanVien nv1 = new NhanVien(fullname, ngaySinh, dc1);

            //NVSanXuat nvsx1 = new NVSanXuat(7500000, 50, fullname, ngaySinh, dc1);
            //Console.WriteLine(nvsx1.toString());
            Console.Write("Nhap so luong sinh vien: ");
            int n = int.Parse(Console.ReadLine());

            NhanVien[] danhSachNhanVien = new NhanVien[n]; // Khởi tạo mảng danh sách nhân viên
            NhapDSNV(danhSachNhanVien);
            Xuat(danhSachNhanVien);
           
        }


        public static void Xuat(NhanVien[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].toString());
            }
        }
        public static void NhapDiaChi(NhanVien[] arr)
        {
            DiaChi[] dc = new DiaChi[arr.Length];

            for (int i = 0; i < dc.Length; i++)
            {
                Console.Write("Nhap so nha: ");
                dc[i].SoNha = Console.ReadLine();

                Console.Write("Nap ten duong: ");
                dc[i].TenDuong = Console.ReadLine();

                Console.Write("Nhap ten quan: ");
                dc[i].TenQuan = Console.ReadLine();

                Console.Write("Nhap ten tinh(Thanh pho): ");
                dc[i].TenThanhPho = Console.ReadLine();

                DiaChi diachi = new DiaChi(dc[i].SoNha, dc[i].TenDuong, dc[i].TenQuan, dc[i].TenThanhPho);
            }
        } 
        public static void NhapDSNV(NhanVien[] danhSachNhanVien)
        {
            // Nhập danh sách nhân viên từ bàn phím
            

            for (int i = 0; i < danhSachNhanVien.Length; i++)
            {
                danhSachNhanVien[i] = new NhanVien(); // Khởi tạo đối tượng nhân viên mới

                Console.Write("Nhap ho ten NV thu {0}: ", i + 1);
                danhSachNhanVien[i].HoTen = Console.ReadLine();

                Console.Write("Nhap nam sinh NV thu {0}: ", i + 1);
                danhSachNhanVien[i].NgaySinh = DateTime.Parse(Console.ReadLine());

                NhapDiaChi(danhSachNhanVien);

            }

        }
    }
}
