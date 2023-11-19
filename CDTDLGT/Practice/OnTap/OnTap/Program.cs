using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList dsHangHoa = new LinkedList();
            Menu(ref dsHangHoa);
        }

        static void Menu(ref LinkedList dsHangHoa)
        {
            Console.Clear();

            Console.WriteLine("\tQ U A N L Y H A N G H O A");

            Console.WriteLine("1. Nhap danh sach hang hoa");
            Console.WriteLine("2. Xuat danh sach hang hoa");
            Console.WriteLine("3. Cap nhat gia tien");
            Console.WriteLine("4. Sap xep danh sach giam dan theo gia ban");
            Console.WriteLine("5. Them hang hoa sau hang ma 'T'");
            Console.WriteLine("6. Xoa k hang hoa dau danh sach");
            Console.WriteLine("7. Dung chuong trinh");

            Console.WriteLine();
            Console.Write("Nhap vao lua chon cua ban: ");

            switch (Console.ReadKey().Key) 
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    int n = 0;

                    Console.Write("Nhap vao so luong Hang nhap: ");
                    int.TryParse(Console.ReadLine(), out n);

                    AddLastList(ref dsHangHoa, n);

                    Console.Write("Nhap thanh cong! Bam phim bat ki de quay lai ");

                    Console.ReadKey();
                    Menu(ref dsHangHoa);
                    break;

                case ConsoleKey.D2:
                    Console.Clear();

                    Console.WriteLine("DANH SACH HANG HOA");
                    PrintList(dsHangHoa);

                    Console.Write("Bam phim bat ki de quay lai ");

                    Console.ReadKey();
                    Menu(ref dsHangHoa);
                    break;

                case ConsoleKey.D3:
                    Console.Clear();

                    string Z = "";

                    Console.Write("Nhap vao ma cua hang can thay doi so luong: ");
                    Z = Console.ReadLine();

                    UpdatePriceList(ref dsHangHoa, Z);

                    Console.ReadKey();
                    Menu(ref dsHangHoa);
                    break;

                case ConsoleKey.D4:
                    Console.Clear();

                    LinkedList dsHangHoaSapXep = dsHangHoa.InterchangeSort();

                    Console.WriteLine("DANH SACH GIAM DAN THEO GIA TIEN");

                    PrintList(dsHangHoaSapXep);

                    Console.Write("Bam phim bat ki de quay lai ");

                    Console.ReadKey();
                    Menu(ref dsHangHoa);
                    break;

                case ConsoleKey.D5:
                    Console.Clear();

                    string T = "";

                    Console.Write("Nhap vao ma cua hang can them hang vao sau: ");
                    T = Console.ReadLine();

                    AddAfterToList(ref dsHangHoa, T);

                    Console.ReadKey();
                    Menu(ref dsHangHoa);
                    break;

                case ConsoleKey.D6:
                    Console.Clear();

                    int k =0 ;

                    Console.Write("Nhap so luong can xoa: ");
                    int.TryParse(Console.ReadLine(), out k);

                    if (dsHangHoa.Size == 0)
                    {
                        Console.WriteLine("Danh sach hang hoa dang trong!!");
                    }
                    else
                    {
                        while (k <= 0 || k > dsHangHoa.Size)
                        {
                            Console.WriteLine("---> So luong xoa khong dung!!");
                            Console.Write("Nhap so luong can xoa: ");
                            int.TryParse(Console.ReadLine(), out k);
                        }

                        RemoveKFirstList(ref dsHangHoa, k);

                        Console.WriteLine("Xoa thanh cong !");
                    }

                    Console.ReadKey();
                    Menu(ref dsHangHoa);
                    break;

                case ConsoleKey.D7:
                    Console.Clear();

                    Console.WriteLine("Hen gap lai <3");
                    Console.ReadKey();
                    break;

                default:
                   Menu(ref dsHangHoa); ;
                    break;
            }
        }

        //them tung mat hang cuoi danh sach
        static void AddLastList(ref LinkedList dsHangHoa, int size)
        {
            string ma = "";
            string ten = "";
            int gia = 0;

            for (int i = 1; i <= size; i++)
            {
                Console.WriteLine($"NHAP HANG HOA THU {i}");

                Console.Write("\tNhap ma: ");
                ma = Console.ReadLine();
                Console.Write("\tNhap ten: ");
                ten = Console.ReadLine();
                Console.Write("\tNhap gia: ");
                int.TryParse( Console.ReadLine(), out gia );

                HangHoa hangHoa = new HangHoa(ma, ten, gia);

                dsHangHoa.AddLast(hangHoa);
            }

        }

        static void PrintList(LinkedList dsHangHoa)
        {
            Console.WriteLine($"{"Ma hang", -15}{"Ten hang", -15}{"Gia    ", 15}");
            for (Node i = dsHangHoa.First; i != null; i = i.Next)
            {
                Console.WriteLine(i.Data.ToPrint());
            }
            Console.WriteLine();
        }

        static void UpdatePriceList(ref LinkedList dsHangHoa, string ma)
        {
            Node isFound = dsHangHoa.Find(ma);
            
            if (isFound != null)
            {
                Console.Write("Nhap gia ban moi: ");
                int giaMoi = 0;
                int.TryParse(Console.ReadLine(), out giaMoi);

                isFound.Data.GiaBan = giaMoi;

                Console.Write("Cap nhat thanh cong! Bam phim bat ky de tro lai ");
            }
            else
            {
                Console.WriteLine("Khong tim thay!!");   
            }
        }

        static void AddAfterToList(ref LinkedList dsHangHoa, string maT)
        {
            Node isFound = dsHangHoa.Find(maT);
            string ma = "";
            string ten = "";
            int gia = 0;

            if (isFound != null)
            {
                Console.WriteLine($"NHAP HANG HOA SAU '{maT}'");

                
                Console.Write("\tNhap ma: ");
                ma = Console.ReadLine();

                while (dsHangHoa.Find(ma) != null)
                {
                    Console.WriteLine("---> Ma hang nay da ton tai !!");
                    Console.Write("\tNhap ma: ");
                    ma = Console.ReadLine();
                }

                Console.Write("\tNhap ten: ");
                ten = Console.ReadLine();
                Console.Write("\tNhap gia: ");
                int.TryParse(Console.ReadLine(), out gia);

                HangHoa hangHoa = new HangHoa(ma, ten, gia);

                dsHangHoa.AddAfter(isFound, hangHoa);

                Console.WriteLine("Them thanh cong ! Bam phim bat ky de tro lai ");
            }
            else
            {
                Console.WriteLine("Khong tim thay");
            }
        }

        static void RemoveKFirstList(ref LinkedList dsHangHoa, int k)
        {
            for (int i = 0; i < k; i++)
            {
                dsHangHoa.RemoveFirst();
            }
        }
    }
}
