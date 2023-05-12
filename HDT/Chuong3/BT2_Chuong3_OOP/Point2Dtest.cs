using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2_Chuong3_OOP
{
    internal class Point2Dtest
    {
        static void Main(string[] args)
        {
            Point2D point2d1 = new Point2D(3,4);
            Point3D point3d1 = new Point3D(3,4,5);

            Console.WriteLine(point2d1.toString());
            Console.WriteLine(point3d1.toString());
        }
    }
}
