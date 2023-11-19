using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3_Ch5
{
    class RunMain
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            ResizableCircle rc = new ResizableCircle(7);
            ResizableCircle rc1 = new ResizableCircle(5);
            rc1.resize(50);

            Console.WriteLine(circle.toString());
            Console.WriteLine(rc1.toString());
        }
    }
}
