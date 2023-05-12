using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1_Chuong4
{
    class BT1_C4
    {
        static void Main(string[] args)
        {
            LinkedList L = new LinkedList();
            Console.Write("Nhap so phan tu: ");
            int soPt = int.Parse(Console.ReadLine());

            Input(L, soPt);
            L.PrintList();

            LietKeSoNguyenTo(L);

            Console.WriteLine("d. Trung Binh Cong: " + Math.Round(tinhTrungBinhCong(L),3));

            Console.Write("Nhap key: ");
            int key = int.Parse(Console.ReadLine());
            Console.WriteLine("e. So lan xuat hien {key} trong DS la: " + DemSoLanXuatHienCuaMotSoNguyen(L,key));

            Console.WriteLine($"f. So Chinh Phuong Cuoi Cung trong DS: {timSoChinhPhuongCuoiCung(L).Data}");

            Console.WriteLine("h. Gia tri Min: " + TimMinTrongDS(L));
        }
        // i) Them mot phan tu vao sau phan tu nho nhat trong danh sach
        static void ThemPhanTuSauGiaTriMin(LinkedList L)
        {
            
        }
        // h) Tim phan tu co gia tri nho nhat
        static int TimMinTrongDS(LinkedList L)
        {
            Node min = L.First;
            for (Node p = L.First; p != null; p = p.Next)
            {
                if (min.Data > p.Data)
                {
                    min = p;
                }
            }
            return min.Data;
        }

        // g) Tim va tra ve phan tu thu k trong danh sach tinh tu dau danh sach
        //static int timVaTraVePhanTuThukTrongDS(LinkedList L, int soPt, int viTri)
        //{
        //    for (int i = 0; i < soPt; i++)
        //    {
        //        if (viTri == i)
        //        {
        //            Console.WriteLine();
        //        }
        //    }
        //}


        // f) Tim so chinh phuong cuoi cung
        static Node timSoChinhPhuongCuoiCung(LinkedList L)
        {
            Node result = null;
            for (Node p = L.First; p != null; p = p.Next)
            {
                if (KiemTraSoChinhPhuong(p.Data))
                {
                    result =  p;
                }
            }
            return result;  
        }
        static bool KiemTraSoChinhPhuong(int num)
        {
            for (int i = 1; i <= num/2; i++)
            {
                if (i * i == num)
                {
                    return true;
                }
            }
            return false;
        }
        //e) Dem so lan xuat hien cua mot so nguyen
        static int DemSoLanXuatHienCuaMotSoNguyen(LinkedList L, int key)
        {
            int count = 0;
            for (Node p = L.First; p != null; p = p.Next)
            {
                if (p.Data == key)
                {
                    count++;
                }
            }
            return count;
        }
        
        // d) Tính trung bình cộng
        static double tinhTrungBinhCong(LinkedList L)
        {
            double tBC = 0;
            double sum = 0;
            int count = 0;
            for (Node p = L.First; p != null; p = p.Next)
            {
                sum += p.Data;
                count++;
            }

            tBC = sum / count;
            return tBC;
        }
        
        // c) Liệt kê các số nguyên tố
        static void LietKeSoNguyenTo(LinkedList L)
        {
            Console.Write("c. So Nguyen To Trong Danh Sach: ");
            for (Node p = L.First; p != null; p = p.Next)
            {
                if (KiemTraSoNguyenTo(p.Data))
                {
                    Console.Write(p.Data + "   ");
                }
                
            }
            Console.WriteLine();
        }
        static bool KiemTraSoNguyenTo(int num)
        {
            int dem = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    dem++;
                }
            }
            if (dem == 2)
            {
                return true;
            }
            return false;
        }
        
        // Input a,b
        static void Input(LinkedList L, int soPt)
        {
            Random rand = new Random();
            for (int i = 0; i < soPt; i++)
            {
                L.AddLast(rand.Next(1,20));
            }
        }
    }
}
