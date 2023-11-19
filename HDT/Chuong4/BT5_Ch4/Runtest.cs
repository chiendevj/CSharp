using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT5_Ch4
{
    class Runtest
    {
        static void Main(string[] args)
        {
            Money mn1 = new Money(5,5000);
            Money mn2 = new Money(100, 5000);
            Money total = mn1 + mn2;
            Console.WriteLine(total.toString());
            Money result = mn1 - mn2;
            Console.WriteLine(result.toString());
        }
    }
}
