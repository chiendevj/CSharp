/*
 * FULLNAME: TRẦN TRUNG CHIẾN
 * ID: 22211TT3000
 * CLASS: CD22TT11
 * DATE: 20/06/2023
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapChung
{
    internal class RunMain
    {
        static void Main(string[] args)
        {
            LinkedList L = new LinkedList();
            NhanVien nv =  new NhanVien("1","1",1);
            NhanVien nv2 = new NhanVien("2", "444", 2);
            NhanVien nv3 = new NhanVien("3", "3", 3);
            NhanVien nv4 = new NhanVien("4", "4", 4);
            L.AddFirst(nv);
            L.AddFirst(nv2);
            L.AddFirst(nv4);
            // L.RemoveLast();
            L.AddBefore(L.Find("4"), nv3);
            // L.Remove(nv3);
            L.PrintList();
            L.SelectionSort();
            L.PrintList();
            XoaSau(L);
            AddAfterMax(L);
        }

        static void AddAfterMax(LinkedList L)
        {
            Node max = L.First;
            for (Node i = L.First; i != null; i = i.Next)
            {
                if (i.Data.TuoiNV > max.Data.TuoiNV)
                {
                    max = i;
                }
            }
            NhanVien nv = new NhanVien("22211TT3000", "Chien", 19);
            L.AddAfter(max, nv);
            L.PrintList();
        }

        static void XoaSau(LinkedList L)
        {

            int k = 0;
            do
            {
                Console.Write("Nhap so k: ");
                int.TryParse(Console.ReadLine(), out k);
            } while (k <= 0 || k > (L.Size + 1));
            if (k == (L.Size + 1))
            {
                Console.WriteLine("Danh sach rong!");
                return;
            }
            else
            {
                for (int i = 1; i <= k; i++)
                {
                    L.RemoveFirst();
                }
            }
            L.PrintList();
        }
    }
}
