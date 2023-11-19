using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_LinkedListBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList L =  new LinkedList();
            NhapDS(L,10);
            L.Print();
        }

        public static void InDS(LinkedList L)
        {
            for (Node p = L.First; p != null; p = p.Next)
            {
                Console.Write(p.Data +"   ");
            }
        }
        public static void NhapDS(LinkedList L, int n)
        {
            for (int i = 1; i <= n; i++)
            {
                L.addLast(i);
            }
        }
    }
}
