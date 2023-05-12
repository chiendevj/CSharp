using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1_Chuong3HDT
{
    class Circletest
    {
        static void Main(string[] args)
        {
            // Declare variable
            double radius = 0;
            double height = 0;
            string color = "";

            // Input
            Console.Write("Enter radius: ");
            double.TryParse(Console.ReadLine(), out radius);
            Console.Write("Enter height: ");
            double.TryParse(Console.ReadLine(), out height);
            ChooseColor(ref color);

            Cylinder cylinder1 = new Cylinder(height,radius,color);

            Circle circle1 = new Circle(radius,color);

            Console.WriteLine(circle1.toString());
            Console.WriteLine(cylinder1.toString());
        }
        static void ChooseColor(ref string color)
        {
            Console.WriteLine("=========================");
            Console.WriteLine("|\tCHOOSE COLOR\t|");
            Console.WriteLine("|\t1. RED\t\t|");
            Console.WriteLine("|\t2. BLUE\t\t|");
            Console.WriteLine("|\t3. GREEN\t|");
            Console.WriteLine("|\t4. YELLOW\t|");
            Console.WriteLine("|\t5. PINK\t\t|");
            Console.WriteLine("=========================");
            char choose = '\0';
            Console.Write("Enter the number: ");
            char.TryParse(Console.ReadLine(), out choose);
            switch (choose)
            {
                case '1':
                    color = "RED";
                    break;
                case '2':
                    color = "BLUE";
                    break;
                case '3':
                    color = "GREEN";
                    break;
                case '4':
                    color = "YELLOW";
                    break;
                case '5':
                    color = "PINK";
                    break;
                default:
                    Console.WriteLine("404");
                    break;
            }
        }
    }
}
