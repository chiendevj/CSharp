using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Ch5
{
    class runTest
    {
        static void Main(string[] args)
        {
            int a = 0;
            Console.Write("Nhap so nguyen: ");
            int.TryParse(Console.ReadLine(), out a);
            DoiCoSo(a);
        } 

        // Bai 1
        static void DoiCoSo(int n)
        {
            Stack s = new Stack();
            while (n > 0)
            {
                s.Push(n % 2);
                n = n / 2;
            }
            s.Display();
        }
    }
}
