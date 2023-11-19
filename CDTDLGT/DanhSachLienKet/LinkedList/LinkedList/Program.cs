using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_C4
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList L = new LinkedList();
            //L.PrintList();
            InputFirst(L, 10);
            L.PrintList();
            InputLast(L, 5);
            L.PrintList();

            //Them mot so x vao sau node y
            Console.Write("Y = ");
            int y = int.Parse(Console.ReadLine());
            InputFirst(L, y);
            L.PrintList();
            // chen so vao so lon nhat
            //Console.Write("X = ");
            //int x = int.Parse(Console.ReadLine());
            //Node pre = TimPhanTuLonNhat(L);
            //L.AddAfter(pre,x);
            //Console.Write("Result: ");
            //L.PrintList();
            //Console.ReadKey();

        }

        //
        static Node TimPhanTuLonNhat(LinkedList L)
        {
            Node max = L.First;
            Node p;
            for(p = L.First; p != null; p = p.Next)
            {
                if(max.Data < p.Data)
                {
                    max = p;
                }
            }
            return max;

        }

        static void InputFirst(LinkedList L, int n)
        {
            Random random = new Random();
            for(int i =0; i< n; i++)
            {
                L.AddFist(random.Next(0, 100));
            }

        }

        static void InputLast(LinkedList L, int n)
        {
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                L.AddFist(random.Next(0, 10));
            }

        }
    }
}
