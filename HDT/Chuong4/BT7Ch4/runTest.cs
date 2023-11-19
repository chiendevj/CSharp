using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_OnTap
{
    class runTest
    {
        static void Main(string[] args)
        {
            //Console.Write("Nhap so phan tu mang: ");
            //int n = int.Parse(Console.ReadLine());
            int[] arr = new int[4] {1, 2, 3, 4};
            //MyArray.Nhap(arr);
            MyArray myArray = new MyArray(arr);
            MyArray myArray2 = new MyArray(arr);
            Console.Write("Cau A: ");
            Console.WriteLine(myArray.toString());

            myArray++;
            Console.Write("Cau B: ");
            Console.WriteLine(myArray.toString());

            myArray--;
            Console.Write("Cau C: ");
            Console.WriteLine(myArray.toString());

            myArray = myArray + 5;
            Console.Write("Cau D: ");
            Console.WriteLine(myArray.toString());

            MyArray myArray3 = myArray + myArray2;
            Console.WriteLine("Cau E: ");
            Console.WriteLine(myArray.toString());
            Console.WriteLine(myArray2.toString());
            Console.WriteLine(myArray3.toString());

            int[,] myArray4 = myArray * myArray2;
            for (int i = 0; i < myArray4.GetLength(0); i++)
            {
                for (int j = 0; j < myArray4.GetLength(1); j++)
                {
                    Console.Write(myArray4[i,j] + "   ");
                }
            Console.WriteLine();
            }

        }

        
    }
}
