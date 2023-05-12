using Author;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4Chuong2_HDT
{
    class Book_test
    {
        static void Main(string[] args)
        {
            // Declare Variable
            string nameAu = null;
            char gender = '\0';
            string gmail = null;
            string nameBook = null;
            double price = 0;
            int qty = 1;
            Author1 au1 = null;
            Book book1 = null;

            // Input + Processing + Output
            Console.Write("Enter name Author: ");
            nameAu = Console.ReadLine();

            GenderList(ref gender);

            Console.Write("Enter your address: ");
            gmail = Console.ReadLine();

            Console.Write("Enter Namebook: ");
            nameBook = Console.ReadLine();

            Console.Write("Enter price it: ");
            double.TryParse(Console.ReadLine(), out price);


            au1 = new Author1(nameAu, ref gender, gmail);


            book1 = new Book(nameBook, au1, price, qty);

            Console.WriteLine(book1.toString());

        }

        // OUT MAIN
        public static string IsEmail(string gmail)
        {
            if(gmail.IndexOf("@") == -1)
            {
                gmail += "@gmail.com";
            }
            return gmail;
        }
        public static void GenderList(ref char gender) 
        {
            char choose = '\0';
            Console.WriteLine("\t\tChoose Gender");
            Console.WriteLine("\t\t1. Male");
            Console.WriteLine("\t\t2. Female");
            Console.WriteLine("\t\t3. Other.");
            Console.Write("Enter the number gender: ");
            char.TryParse(Console.ReadLine(), out choose);
            switch (choose)
            {
                case '1':
                    gender = 'm';
                    break;
                case '2':
                    gender = 'f';
                    break;
                case '3':
                    gender = 'k';
                    break;

                default:
                    gender = '0';
                    break;
            }
        }
    }
}
