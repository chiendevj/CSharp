using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI5HDT
{
    class BookAuthorTest
    {
        static void Main(string[] args)
        {
            string nameBook = null;
            Console.Write("Nhap ten sach: ");
            nameBook = Console.ReadLine();
            BookAuthor book1 = new BookAuthor(nameBook, author(), 12000);
            Console.WriteLine("____________________________________________________" +
                "");
            Console.WriteLine(book1.toString());
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
        public static Author[] author()
        {
            Author[] author;

            int n = 0;
            string name = "";
            char gender = '\0';
            string email = "";
            Console.Write("Nhap luong tac gia: ");
            int.TryParse(Console.ReadLine(), out n);
            author = new Author[n];
            for (int i = 0; i < author.Length; i++)
            {
                Console.WriteLine($"\tThu {i + 1}");
                Console.Write("Ho va ten: ");

                name = Console.ReadLine();

                GenderList(ref gender);

                Console.Write("Email: ");
                email = Console.ReadLine();
                author[i] = new Author(name,ref gender, email);

            }
            return author;
        }
    }
}