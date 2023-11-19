using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLinkedList
{
    class runTest
    {
        static void Main(string[] args)
        {
            LinkedList L = new LinkedList();
            Input(L, 2);
            Output(L);
        }

        //public static void sapXepSV()
        //{
        //    for (Node p = _f)
        //    {

        //    }
        //}
        public static void Input(LinkedList L, int n)
        {
            for (int i = 0; i < n; i++)
            {
                SinhVien sv = new SinhVien();
                sv.Nhap();
                L.AddLast(sv);
            }
        }

        public static void Output(LinkedList L)
        {
            for (Node p = L.First; p!= null; p = p.Next)
             {
                Console.WriteLine(p.Data.toString());
            }
        }
    }
}
