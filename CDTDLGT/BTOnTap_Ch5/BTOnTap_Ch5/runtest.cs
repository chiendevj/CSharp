using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTOnTap_Ch5
{
    class runtest
    {
        static void Main(string[] args)
        {
            LinkedList L = new LinkedList();
        }
        static void NhapTTNV()
        {
            NhanVien nv = new NhanVien();
            Console.WriteLine("Nhap hotEN: ");
            string hoten = Console.ReadLine();
        }
        static void NhapDS(LinkedList L)
        {
            for (Node p = L.First; p!= null; p = p.Next)
            {
                
            }
        }
    }
}
