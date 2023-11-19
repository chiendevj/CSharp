using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STACK
{
    class runTest
    {
        static void Main(string[] args)
        {
            ArrayList L = new ArrayList();
            L.Add(12);
            L.Add("Tran Trung Chien");
            L.Add(12.56);
            L.Add(12);
            L.Add("Tran Trung Chien");
            L.Add(12.56);
            //L.RemoveAt(1);
            L.Add(12);
            L.Insert(3,10000);
            L.Add("Tran Trung Chien");
            L.Add(12.56);
            L.Add(12);
            L.Add("Tran Trung Chien");
            L.Add(12.56);
            //L.RemoveAt(1);
            Print(L);
        }

        static void Print(ArrayList L)
        {
            for (int i = 0; i < L.Count; i++)
            {
                Console.WriteLine(L[i]);
            }
        }
    }
}
