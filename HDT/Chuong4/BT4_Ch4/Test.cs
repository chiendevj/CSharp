using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4_Ch4
{
    class Test
    {
        static void Main(string[] args)
        {
            //HourlyEmployee HE1 = new HourlyEmployee(111, "Tran TRung", "Chien", 3, 8);
            //Console.WriteLine(HE1.toString());
            //HourlyEmployee HE2 = new HourlyEmployee(222, "Nguyen Van", "A", 4, 6);
            //Console.WriteLine(HE2.toString());
            //SalariedEmployee SE1 = new SalariedEmployee(111, "Tran TRung", "Chien", 3, 1000, 5000000);
            //Console.WriteLine(SE1.toString());
            //SalariedEmployee SE2 = new SalariedEmployee(222, "Nguyen Van", "A", 3, 1000, 123456);
            //Console.WriteLine(SE2.toString());

            Console.Write("Nhap so nhan vien: ");
            int n = int.Parse(Console.ReadLine());
            Employee[] NhanVien = new Employee[n];
            Nhap(NhanVien);
            Xuat(NhanVien);
            
        }

        static void Xuat(Employee[] arr)
        {
            Console.WriteLine($"{"Ma NV",-15}{"Ho NV",-15}{"Ten NV",-15}{"Luong",-15}");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].toString());
            }
        }
        static void Nhap(Employee[] NhanVien)
        {
            
            for (int i = 0; i < NhanVien.Length; i++)
            {
                Console.WriteLine($"{"",-20}LOAI NHAN VIEN");
                Console.WriteLine("1. Nhan Vien Thoi Vu");
                Console.WriteLine("2. Nhan Vien Kinh Doanh");
                int choose = 0;
                do
                {
                    int.TryParse(Console.ReadLine(), out choose);
                } while (choose < 1 && choose >2);
                switch (choose)
                {
                    case 1:
                        Console.Write("Nhap Ma Nhan Vien: ");
                        int maMV = int.Parse(Console.ReadLine());
                        Console.Write("Nhap Ho Nhan Vien: ");
                        string hoNV = Console.ReadLine();
                        Console.Write("Nhap Ten Nhan Vien: ");
                        string tenNV = Console.ReadLine();
                        Console.Write("Nhap ti le: ");
                        double rate = double.Parse(Console.ReadLine());
                        Console.Write("Nhap So Gio: ");
                        double soLuongGio = double.Parse(Console.ReadLine());
                        NhanVien[i] = new HourlyEmployee(maMV, hoNV, tenNV, rate, soLuongGio);
                        break;
                    case 2:
                        Console.Write("Nhap Ma Nhan Vien: ");
                        int maMVien = int.Parse(Console.ReadLine());
                        Console.Write("Nhap Ho Nhan Vien: ");
                        string hoNVien = Console.ReadLine();
                        Console.Write("Nhap Ten Nhan Vien: ");
                        string tenNVien = Console.ReadLine();
                        Console.Write("Nhap hoa hong: ");
                        double cmRate = double.Parse(Console.ReadLine());
                        Console.Write("Nhap Doanh Thu SPham: ");
                        double doanhthuSP = double.Parse(Console.ReadLine());
                        Console.Write("Nhap Luong CB: ");
                        double luongCB = double.Parse(Console.ReadLine());
                        NhanVien[i] = new SalariedEmployee(maMVien, hoNVien, tenNVien, cmRate, doanhthuSP, luongCB);
                        break;

                }
            }
        }
    }
}
