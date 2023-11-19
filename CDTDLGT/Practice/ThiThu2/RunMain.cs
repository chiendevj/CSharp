using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiThu2
{
    internal class RunMain
    {
        static void Main(string[] args)
        {
            LinkedList linked = new LinkedList();
            GiayDep g1 = new GiayDep("1", "1", 1);
            GiayDep g2 = new GiayDep("2", "2", 2);
            GiayDep g3 = new GiayDep("3", "3", 3);
            GiayDep g4 = new GiayDep("4", "4", 4);
            GiayDep g5 = new GiayDep("5", "5", 5);
            linked.AddLast(g1);
            linked.AddLast(g2);
            linked.AddLast(g3);
            linked.AddLast(g4);
            linked.AddLast(g5);

            linked.AddFirst(g1);
            linked.AddFirst(g2);
            linked.AddFirst(g3);
            linked.AddFirst(g4);
            linked.AddFirst(g5);
            Xuat(linked);
           
            


        }
        static void Xuat(LinkedList linked)
        {
            for (Node i = linked.First; i != null; i = i.Next)
            {
                Console.WriteLine(i.Data.toString());
            }
            Console.WriteLine();
        }

    }
}
