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
            InputLast(L, 5);
    
            InputFirst(L, 5);
            L.PrintList();


            //Them mot so x vao sau node y
            //Console.Write("Y = ");
            //int y = int.Parse(Console.ReadLine());
            //Console.Write("X = ");
            //int x = int.Parse(Console.ReadLine());
            //L.Find(x);
            //InputFirst(L, y);
            //L.PrintList();

            // chen so vao so lon nhat sau max
            //Console.Write("X = ");
            //int x = int.Parse(Console.ReadLine());
            //Node pre = Max(L);
            //L.AddAfter(pre,x);
            //Console.Write("Result: ");
            //L.PrintList();
            //Console.ReadKey();

            //chen so vao so lon nhat truoc max
            //Console.Write("X= ");
            //int x = int.Parse(Console.ReadLine());
            ////Node pre = Max(L);
            //L.AddBefore(Max(L), x);
            //Console.Write("Result: ");
            //L.PrintList();

            //// Xoa Node dau
            //L.RemoveFirst();
            //L.PrintList();

            // Xoa Node Cuoi

            //L.RemoveLast();
            //L.PrintList();

            // Xoa sau max
            //L.RemoveAfter(Max(L));
            //L.PrintList();

            // Xoa data
            //L.Remove(Max(L));
            //L.PrintList();

            // Interchange Sort
            //L.InterchangeSort();
            //L.PrintList();

            // Selection Sort
            //L.SelectionSort();
            //L.PrintList();

            //RemoveMin
            //L.Remove(Min(L));
            //L.PrintList();
            Console.WriteLine("Tong = " + Sum(L));
            Console.WriteLine("TBC = " + TrungBinhCong(L));
        }

        static double TrungBinhCong(LinkedList L)
        {
            double tBC = 0;
            int sum = 0;
            int count = 0;
            for (Node p = L.First; p != null; p = p.Next)
            {
                count++;
                sum += p.Data;
            }
            tBC = (double)sum / count;
            return tBC;
        }

        static int Sum(LinkedList L)
        {
            int sum = 0;
            for (Node p = L.First; p != null; p = p.Next)
            {
                sum += p.Data;
            }
            return sum;
        }
        static Node Min(LinkedList L)
        {
            Node min = L.First;
            Node p;
            for (p = min; p != null; p = p.Next)
            {
                if (min.Data > p.Data)
                {
                    min = p;
                }
            }
            return min;
        }
        static Node Max(LinkedList L)
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

        // Them first
        static void InputFirst(LinkedList L, int n)
        {
            Random random = new Random();
            for(int i =0; i< n; i++)
            {
                L.AddFist(random.Next(80, 100));
            }

        }

        // Them last
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
