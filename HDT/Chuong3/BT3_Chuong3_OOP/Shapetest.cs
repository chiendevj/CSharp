using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3_Chuong3_OOP
{
    internal class Shapetest
    {
        static void Main(string[] args)
        {
            Shape shape1 = new Shape("blue", true);
            Circle circle1 = new Circle(5);
            Rectangle rtg1 = new Rectangle(3,4);
            Square square1 = new Square(10);

            Console.WriteLine(shape1.toString());
            Console.WriteLine(circle1.toString());
            Console.WriteLine(rtg1.toString());
            Console.WriteLine(square1.toString());
        }
    }
}
