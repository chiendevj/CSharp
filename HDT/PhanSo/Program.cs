using System;

namespace Program
{
    class PhanSo_Test
    {
        public static void Main()
        {
            // Variable
            int tuSo = 0;
            int mauSo = 0;
            // Input
            System.Console.Write("Nhap tu so: ");
            int.TryParse(Console.ReadLine(), out tuSo);
            System.Console.Write("Nhap mau so: ");
            int.TryParse(Console.ReadLine(), out mauSo);
            PhanSo ps1 = new PhanSo(tuSo,mauSo);
            PhanSo ps2 = new PhanSo(tuSo,mauSo);

            // Output
            System.Console.WriteLine($"Phan so goc: {ps1.toString()}");
            System.Console.WriteLine($"Cong 2 phan so: {ps1.CongPS(ps2).toString()}");
            System.Console.WriteLine($"Tru 2 phan so: {ps1.TruPS(ps2).toString()}");
            System.Console.WriteLine($"Nhan 2 phan so: {ps1.NhanPS(ps2).toString()}");
            System.Console.WriteLine($"Thuong 2 phan so: {ps1.ThuongPS(ps2).toString()}");
        }
    }
}