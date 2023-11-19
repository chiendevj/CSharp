using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIST
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> L = new List<int>();
            L.Add(12);
            L.Add(13);
            L.Add(14);
            L.Add(15);
            L.Add(15);
            L.Add(112);
            L.Add(1);

            Print(L);
        }

        static void Print(List<int> L)
        {
            for (int i = 0; i < L.Count; i++)
            {
                Console.WriteLine(L[i]);
            }
        }
    }
}
