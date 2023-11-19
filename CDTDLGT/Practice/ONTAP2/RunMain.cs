/*
 * FULLNAME: TRẦN TRUNG CHIẾN
 * ID: 22211TT3000
 * CLASS: CD22TT11
 * DATE: 18/ 06/ 2023
 * SUBJECT: CTDL&GT
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONTAP2
{
    internal class RunMain
    {
        static void Main(string[] args)
        {
            // Khai báo
            LinkedList dsMonHoc = new LinkedList();

            // Output
            NhapDanhSachMonHoc(dsMonHoc);
            XuatDanhSachMonHoc(dsMonHoc);
            TimMonHoc(dsMonHoc);
            Console.WriteLine($"{"", -20}DANH SACH SAU KHI SAP XEP");
            dsMonHoc.InterchangeSort();
            XuatDanhSachMonHoc(dsMonHoc);
            ThemMonHoc(dsMonHoc);
            ThemMonHocTruocMonHocKhac(dsMonHoc);
        }

        // NGOÀI MAIN   
        public static void ThemMonHocTruocMonHocKhac(LinkedList dsMonHoc)
        {
            string maMH = "";
            string tenMH = "";
            int soTC = 0;
            string maID = "";
            do
            {
                Console.Write("Nhap ID: ");
                maMH = Console.ReadLine();

            } while (dsMonHoc.FindNode(maMH) != null);

            Console.Write("Nhap Ten MH: ");
            tenMH = Console.ReadLine();
            Console.Write("Nhap so TC: ");
            int.TryParse(Console.ReadLine(), out soTC);

            MonHoc monHoc = new MonHoc(maMH, tenMH, soTC);

            do
            {
                Console.Write("Nhap ID ban muon them truoc: ");
                maID = Console.ReadLine();
            } while (dsMonHoc.FindNode(maID) == null);
            Console.WriteLine();
            //Tim phan tu lon nhat trong danh sach
            //Node max = dsMonHoc.First;
            //for(Node p = dsMonHoc.First; p != null; p = p.Next)
            //{
            //    if(p.Data.SoTC < max.Data.SoTC)
            //        max = p;
            //}

            dsMonHoc.AddBefore(monHoc, dsMonHoc.Find(maID));
            XuatDanhSachMonHoc(dsMonHoc);
        }
        // e. Thêm một môn học mới vào sau môn học có mã môn học là Y (Với Y được nhập từ
        // bàn phím). Yêu cầu môn học mới thêm vào có maMH không được trùng với mã các
        // môn học đã có trong danh sách.
        public static void ThemMonHoc(LinkedList L)
        {
            string id;
            string ma;
            string ten;
            int soTC;
            
            // Kiểm tra xem người dùng nhập vào có đúng mã id có trong danh sách không
            do
            {
                Console.Write("Nhap ID them sau: ");
                id = Console.ReadLine();
            } while (L.FindNode(id) == null);
            
            // Kiểm tra mã id mới có trùng với mã trong linkedlist không
            do
            {
                Console.Write("Nhap ma ID: ");
                ma = Console.ReadLine();
            } while (L.Find(ma) != null);
            Console.Write("Nhap ten: ");
            ten = Console.ReadLine();
            Console.Write("Nhap so TC: ");
            int.TryParse(Console.ReadLine(), out soTC);

            MonHoc newMH = new MonHoc(ma, ten, soTC);

            L.AddAfter(L.FindNode(id), newMH);
            XuatDanhSachMonHoc(L);
        }

        public static void TimMonHoc(LinkedList L)
        {
            string maMH = "";
            Console.Write("Nhap ma MH can tim: ");
            maMH = Console.ReadLine();

            MonHoc result = L.Find(maMH);
            if (result != null)
            {
                Console.WriteLine(result.toString());
            }
            else
            {
                Console.WriteLine("Khong tim thay");
            }
        }

        public static void XuatDanhSachMonHoc(LinkedList L)
        {
            for (Node i = L.First; i != null; i = i.Next)
            {
                Console.WriteLine(i.Data.toString());
            }
            Console.WriteLine();
        }

        public static void NhapDanhSachMonHoc(LinkedList L)
        {
            int n = 0;
            string ma = "";
            string ten = "";
            int soTC = 0;

            do
            {
                Console.Write("Nhap so luong mon hoc: ");
            } while (!int.TryParse(Console.ReadLine(), out n));

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap ID Mon hoc: ");
                ma = Console.ReadLine();
                Console.Write("Nhap ten Mon hoc: ");
                ten = Console.ReadLine();
                Console.Write("Nhap so Tin chi: ");
                int.TryParse(Console.ReadLine(), out soTC);

                MonHoc newMh = new MonHoc(ma, ten, soTC);
                L.AddLast(newMh);
            }
        }

    }
}
