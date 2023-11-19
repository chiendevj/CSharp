/*
 * FULLNAME: TRAN TRUNG CHIEN
 * ID: 22211TT3000
 * CLASS: CD22TT11
 * DATE: 21 - 06 - 2023
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiThu1
{
    internal class RunMain
    {
        static void Main(string[] args)
        {
            LinkedList L = new LinkedList();
            NhapDanhSach(L);
            XuatDanhSach(L);

            TimMonHoc(L);

            
            ThemMHSauMH(L);

            XoaMonHoc(L);

            //Console.WriteLine("DAH SACH SAU KHI SAP XEP");
            //L.InterchangeSort();
            //XuatDanhSach(L);

        }

        // f. Xóa k mặt hàng ở đầu danh sách (Với k nhập từ bàn phím, 1<= k <= số lượng hàng có
        // trong danh sách hiện hành).
        static void XoaMonHoc(LinkedList L)
        {

            Console.Write("Nhap ID de xoa sau no: ");
            string k = Console.ReadLine();
            if (L.Find(k) == null)
            {
                Console.WriteLine("Khong tim thay, khong the xoa");
            }
            else
            {
                L.RemoveAfter(L.Find(k));
                XuatDanhSach(L);
            }
        }
        // e. Thêm một mặt hàng mới vào sau mặt hàng có mã hàng là T (Với T được nhập từ bàn
        // phím). Yêu cầu mặt hàng mới thêm vào có mã hàng không được trùng với mã hàng của
        // các mặt hàng đã có trong danh sách.
        static void ThemMHSauMH(LinkedList L)
        {
            string maMHMoi;
            string tenMHMoi;
            int soTCMoi;

            Console.Write("Nhap id ban muon them vao sau: ");
            string id = Console.ReadLine();
            do
            {
                Console.Write("Nhap ma Mon Hoc moi: ");
                maMHMoi = Console.ReadLine();
            } while (L.Find(maMHMoi) != null);

            Console.Write("Nhap ten MH: ");
            tenMHMoi = Console.ReadLine();
            Console.Write("Nhap so TC: ");
            int.TryParse(Console.ReadLine(), out soTCMoi);
            MonHoc mh = new MonHoc(maMHMoi, tenMHMoi, soTCMoi);
            if (L.Find(id) == null)
            {
                Console.WriteLine("Khong the them.");
            }
            else
            {
                L.AddBefore(L.Find(id), mh);
                XuatDanhSach(L);
            }

        }


        // Tìm và cập nhật giá bán cho mặt hàng có mã hàng là Z (Với Z nhập từ bàn phím). Nếu
        // không tìm thấy thì xuất thông báo: “Khong the cap nhat.”.
        static void TimMonHoc(LinkedList L)
        {
            string key = "";
            Console.Write("Nhap key: ");
            key = Console.ReadLine();

            Node monHoc = L.Find(key);
            if (monHoc == null)
            {
                Console.WriteLine("Khong the cap nhat!");
            }
            else
            {
                int soTC = 0;
                Console.Write("Nhap lai so Tinh chi moi: ");
                int.TryParse(Console.ReadLine(), out soTC);
                monHoc.Data.SoTC = soTC;
                XuatDanhSach(L);
            }
        }
        // Xuất dnah sach
        static void XuatDanhSach(LinkedList L)
        {
            for (Node i = L.First; i != null; i = i.Next)
            {
                Console.WriteLine(i.Data.toString());
            }
            Console.WriteLine();
        }
        // Nhập danh sách
        static void NhapDanhSach(LinkedList L)
        {
            int n = 0;
            do
            {
                Console.Write("Nhap so luong mon hoc: ");
            } while (!int.TryParse(Console.ReadLine(), out n));

            for (int i = 0; i < n; i++)
            {
                string ma = "";
                string ten = "";
                int soTC = 0;

                Console.Write("Nhap ma MH: ");
                ma = Console.ReadLine();
                Console.Write("Nhap ten MH: ");
                ten = Console.ReadLine();
                Console.Write("Nhap so TC: ");
                int.TryParse(Console.ReadLine(), out soTC);
                MonHoc mh =  new MonHoc(ma, ten, soTC);
                L.AddLast(mh);
            }
        }
    }
}
