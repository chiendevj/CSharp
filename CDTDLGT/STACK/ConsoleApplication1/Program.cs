using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> L = new LinkedList<int>();
            L.AddFirst(10);
            L.AddFirst(12);
            L.AddFirst(8);
            L.AddBefore(L.Find(12), 110);
            L.AddAfter(L.Find(8), 102);
            L.AddFirst(1000);
            Print(L);
            
            
        }

        static void Print(LinkedList<int> L)
        {
            for (LinkedListNode<int> p = L.First; p != null; p=p.Next)
            {
                Console.WriteLine(p.Value);
            }
            Console.WriteLine();
        }
    }
}
