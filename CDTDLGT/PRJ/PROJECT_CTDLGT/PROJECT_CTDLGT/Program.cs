using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace PROJECT_CTDLGT
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khai báo biến
            string user = "";
            string password = "";
            Sach[] arr = new Sach[5];
            string pathAdmin = "H:\\IT_Language\\C#\\CDTDLGT\\PRJ\\FIleTXT\\Admin.txt";
            HeThong();
            DangNhapTaiKhoan(user, password, pathAdmin);
            QuanLiSach(arr);
        }
        // Ngoài main
        static void QuanLiSach(Sach[] arr)
        {
            Console.WriteLine($"|{"Ma Sach",-5}||{"Ten Sach",-20}||{"Tac Gia",-10}||{"Nha XB",-8}||{"Gia Ban",-8}||{"Nam PH",-5}||{"So Trang",-5}||{"Ngay NK",-7}||Tinh Trang Sach|");
        }
        static void DangNhapTaiKhoan(string user, string pass, string pathAdmin)
        {
            string[] arr;
            int n = 0;
            int count = 0; // đếm số lần đăng nhập fail, count = 3, thoát chương trình
            Console.WriteLine("\n\t********DANG NHAP TAI KHOAN********");
            //Console.Write("\tNhap user: ");
            //user = Console.ReadLine();
            //Console.Write("\tNhap password: ");
            //pass = Console.ReadLine();
            try
            {
                using (StreamReader sr = new StreamReader(pathAdmin))
                {
                    n = int.Parse(sr.ReadLine());
                    arr = new string[n];
                    
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr = sr.ReadLine().Split('#');
                        Console.WriteLine(arr[i]);
                        //if (String.Compare(user, arr[0], true) == 0 && String.Compare(pass, arr[1], true) == 0)
                        //{
                        //    Console.WriteLine("Dang nhap thanh cong!!");
                        //    break;
                        //}
                        //else
                        //{
                        //    Console.WriteLine("Dang nhap that bai!!");

                        //}

                    }
                }
            }
            catch (IOException)
            {
                Console.WriteLine("File not found, 404!!");
            }


        }
        static void HeThong()
        {
            // MENU CHỌN TRANG CHỦ
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t***********************************");

            Console.Write("\t*       ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("TRANG CHU HE THONG        ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*");

            Console.WriteLine("\t***********************************");
            Console.ForegroundColor = ConsoleColor.Magenta;


        }
    }
}
