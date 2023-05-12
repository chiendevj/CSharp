using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSLK
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList L = new LinkedList();
            InputFirst(L, 10);
            L.PrintList();
            InputLast(L, 10);
            L.PrintList();

            int y = 20;
            int x = 10;
            Node pre = L.Find(y);
            if (pre != null)
            {
                L.AddAfter(pre,x);
                Console.Write("Ket qua them X sau Y: ");
                L.PrintList();
            }
            else
            {
                Console.WriteLine("Y khong co trong ds.");
            }

        }
        
        static void InputFirst(LinkedList L, int n)
        {
            Random rd = new Random();
            for (int i = 0; i < n; i++)
            {
                L.AddFirst(rd.Next(0,20));
            }
        }

        static void InputLast(LinkedList L, int n)
        {
            Random rd = new Random();
            for (int i = 0; i < n; i++)
            {
                L.AddLast(rd.Next(21, 50));
            }
        }
    }
}
