using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] nv = new Employee[2];
            Nhap(nv);
            Xuat(nv);
        }

        static void Xuat(Employee[] arr)
        {
            //Console.WriteLine($"{"Ma NV",-15}{"Ho NV",-15}{"Ten NV",-15}{"Luong",-15}");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].toString());
            }
        }
        static void Nhap(Employee[] NhanVien)
        {
           
            for (int i = 0; i < NhanVien.Length; i++)
            {
                Console.WriteLine($"{"",-20} DANH SACH LOAI NHAN VIEN");
                Console.WriteLine("1.   Nhan Vien Thoi Vu");
                Console.WriteLine("2.   Nhan Vien Kinh Doanh");
                int choose = 0;
                do
                {
                    Console.Write("Nhap loai Nhan Vien: ");
                    int.TryParse(Console.ReadLine(), out choose);
                } while (choose >1 && choose <2);
                switch (choose)
                {
                    case 1: // HourlyEMlpoyee
                        Console.Write("Nhap empCode: ");
                        int empCode = int.Parse(Console.ReadLine());
                        Console.Write("Nhap firstName: ");
                        string firstName = Console.ReadLine();
                        Console.Write("Nhap lastName: ");
                        string lastName = Console.ReadLine();
                        Console.Write("Nhap rate: ");
                        double rate = double.Parse(Console.ReadLine());
                        Console.Write("Nhap gio: ");
                        double gio = double.Parse(Console.ReadLine());
                        NhanVien[i] = new HourlyEMployee(empCode, firstName, lastName, rate, gio);
                        break;
                    case 2:
                        Console.Write("Nhap empCode: ");
                        int empCode2 = int.Parse(Console.ReadLine());
                        Console.Write("Nhap firstName: ");
                        string firstName2 = Console.ReadLine();
                        Console.Write("Nhap lastName: ");
                        string lastName2 = Console.ReadLine();
                        Console.Write("Nhap hoa hong: ");
                        double commis = double.Parse(Console.ReadLine());
                        Console.Write("Nhap grossSale: ");
                        double gross = double.Parse(Console.ReadLine());
                        Console.Write("Nhap luong CB: ");
                        double basic = double.Parse(Console.ReadLine());
                        NhanVien[i] = new SalariedEmpoyee(empCode2, firstName2, lastName2, commis, gross, basic);
                        break;
                 
                }
            }
            
            

        }
    }
}
