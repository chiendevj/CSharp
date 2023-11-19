using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT6_Chuong4
{
    class Runtest
    {
        static void Main(string[] args)
        {

            DonThuc dt1 = new DonThuc(7,3);
            DonThuc dt2 = new DonThuc(7,8);
            DonThuc dt3 = new DonThuc(1,3);

            Console.WriteLine(dt1.ToString());
            Console.Write("Nhap gia tri X = ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine($"Gia tri don thuc: {dt1.ToString()} khi x = {x} la: {dt1.getGiaTri(x)}");

            Console.WriteLine($"{dt1.ToString()} + {dt3.ToString()} = {(dt1 + dt3).ToString()}");
            Console.WriteLine($"{dt1.ToString()} - {dt3.ToString()} = {(dt1 - dt3).ToString()}");
            Console.WriteLine($"{dt1.ToString()} * {dt2.ToString()} = {(dt1 * dt2).ToString()}");
            Console.WriteLine($"{dt1.ToString()} / {dt2.ToString()} = {(dt1 / dt2).ToString()}");



        }
    }
}
