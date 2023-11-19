/*  Fullname: Trần Trung Chiến
 *  ID: 22211TT3000
 *  Class: CD22TT11
 *  Date: 17/06/2023
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONTAP1
{
    internal class RunMain
    {
        static void Main(string[] args)
        {
            // Khai báo
            LinkedList dsHangHoa = new LinkedList();
            string key = "";

            // Output
            NhapDanhSach(dsHangHoa);
            XuatDSHH(dsHangHoa);
           
            // c. Tìm và cập nhật giá bán cho mặt hàng có mã hàng là Z (Với Z nhập từ bàn phím). Nếu
            //    không tìm thấy thì xuất thông báo: “Khong the cap nhat.”.
            Console.Write("Nhap ma Hang Hoa can tim: ");
            key = Console.ReadLine();
            HangHoa hh = dsHangHoa.FindHH(key);
            if (hh != null)
            {
                Console.WriteLine(hh.toString() + "\n");
            }
            else
            {
                do
                {
                    // Console.WriteLine("Khong tim thay hang hoa!");
                    Console.Write("Nhap ma Hang Hoa can tim: ");
                    key = Console.ReadLine();

                } while (dsHangHoa.Find(key) == null);
                Console.WriteLine((dsHangHoa.Find(key)).Data.toString() + "\n");
            }

            // e
            Console.WriteLine("Them hang hoa sau mot ma hang");
            ThemHangHoa(dsHangHoa);

            // d. Sắp xếp danh sách giảm dần theo giá bán.
            Console.WriteLine("Sap xep danh sach giam dan theo gia ban");
            dsHangHoa.Interchange();
            XuatDSHH(dsHangHoa);

            // f. Xóa
            XoaPhanTuDau(dsHangHoa);
        }

        // f. Xóa k mặt hàng ở đầu danh sách (Với k nhập từ bàn phím, 1<= k <= số lượng hàng có
        //      trong danh sách hiện hành).
        public static void XoaPhanTuDau(LinkedList L)
        {
            int k = 0;
            Console.Write("Nhap so phan tu muon xoa: ");
            int.TryParse(Console.ReadLine(), out k);

            for (int i = 1; i <= k; i++)
            {
                L.RemoveFirst();
            }

            XuatDSHH(L);
        }
        // e. Thêm một mặt hàng mới vào sau mặt hàng có mã hàng là T (Với T được nhập từ bàn
        //      phím). Yêu cầu mặt hàng mới thêm vào có mã hàng không được trùng với mã hàng của
        //      các mặt hàng đã có trong danh sách.
        public static void ThemHangHoa(LinkedList L)
        {
            string ma = "";
            string ten = "";
            int giaBan = 0;
            Console.WriteLine("Nhap ma HH can them sau: ");
            string ma2 = Console.ReadLine();

            do
            {
                Console.Write("Nhap ma Hang Hoa: ");
                ma = Console.ReadLine();
            } while (L.Find(ma) != null);

            Console.Write("Nhap  ten Hang Hoa: ");
            ten = Console.ReadLine();
            Console.Write("Nhap gia Hang Hoa: ");
            int.TryParse(Console.ReadLine(), out giaBan);

            HangHoa newHH = new HangHoa(ma, ten, giaBan);
            L.AddAfter(L.Find(ma2), newHH);

            XuatDSHH(L);
        }

        

        // b. Viết hàm xuất danh sách các mặt hàng đã nhập ra màn hình.
        public static void XuatDSHH(LinkedList L)
        {
            for (Node p = L.First; p != null; p = p.Next)
            {
                Console.WriteLine(p.Data.toString());
            }
            Console.WriteLine();
        }

        // a. Viết hàm nhập danh sách N mặt hàng bằng cách thêm từng mặt hàng vào cuối danh sách.
        public static void NhapDanhSach(LinkedList dsHH) 
        {
            int n = 0;
            do
            {
                Console.Write("Nhap so Hang Hoa: ");
                
            } while (!int.TryParse(Console.ReadLine(), out n) || n < 0);

            for (int i = 1; i <= n; i++)
            {
                string ma = "";
                string ten = "";
                int gia = 0;

                Console.Write("Nhap ma HH: ");
                ma = Console.ReadLine();
                Console.Write("Nhap ten HH: ");
                ten = Console.ReadLine();
                Console.Write("Nhap gia tien: ");
                int.TryParse(Console.ReadLine(), out gia);
 
                HangHoa newHH = new HangHoa(ma, ten, gia);
                dsHH.AddFirst(newHH);
            }
        }
        
    }
}
