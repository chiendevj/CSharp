using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_On
{
    class runTest
    {
        static void Main(string[] args)
        {
            LinkedList L = new LinkedList();
            Nhap(L, 5);
            L.PrintList();

            //string key = "8";
            //TimThongTinMonHoc(L, key);

            //SapXepTheoSTC(L);

            XoaMonHoc(L);

        }

        // Xoa Mon Hoc
        public static void XoaMonHoc(LinkedList L)
        {
            Node monHoc = L.FindMaMH("z");
            if (monHoc == null)
            {
                Console.WriteLine($"Khong tim thay ma mon hoc Z nay!");
            }
            else
            { 
                L.RemoveAfter(monHoc);
                Console.WriteLine("Danh sach sau khi xoa");
                L.PrintList();
            }

        }

        // Tim Thong Tin Mon Hoc
        public static void TimThongTinMonHoc(LinkedList L, string maMH)
        {
            Console.WriteLine();
            Node monHoc = L.FindMaMH(maMH);

            if (monHoc == null)
            {
                Console.WriteLine($"Khong tim thay ma mon hoc {maMH} nay!");
            }
            else
            {
                for (Node p = L.First; p != null; p = p.Next)
                {
                    if (monHoc.mh.MaMonHoc.Equals(p.mh.MaMonHoc))
                    {
                        Console.WriteLine(p.mh.toString());
                    }
                }
            }
            
        }

        // Sap xep danh sach tang dan theo so tin chi
        public static void SapXepTheoSTC(LinkedList L)
        {
            for (Node p = L.First; p != null; p = p.Next)
            {
                L.InterchangeSor();
            }
        }
        // Nhap
        public static void Nhap(LinkedList L, int n)
        {
            for (int i = 0; i < n; i++)
            {
                MonHoc mh = new MonHoc();
                mh.Nhap();
                L.AddFirst(mh);
            }
        }
    }
}
