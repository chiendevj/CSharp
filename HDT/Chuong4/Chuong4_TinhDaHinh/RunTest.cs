using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong4_TinhDaHinh
{
    class RunTest
    {
        static void Main(string[] args)
        {
            PhanSo ps1 = new PhanSo(8,2);
            PhanSo ps2 = new PhanSo(8,4);
            
            Console.WriteLine($"Phan so {ps1.toString()} duoc RG: "+ ps1.RutGon().toString());
            PhanSo ps3 = -ps1;
            PhanSo ps4 = -ps2;
            Console.WriteLine($"Doi dau phan so: {ps3.toString()}\nDoi dau phan so: {ps4.toString()}"); 
            PhanSo TongHaiPS = ps1 + ps2;
            Console.WriteLine($"{ps1.toString()} + {ps2.toString()} = {TongHaiPS.RutGon().toString()}");
            PhanSo HieuHaiPS = ps1 - ps2;
            Console.WriteLine($"{ps1.toString()} - {ps2.toString()} = {HieuHaiPS.RutGon().toString()}");
            PhanSo TichHaiPS = ps1 * ps2;
            Console.WriteLine($"{ps1.toString()} * {ps2.toString()} = {TichHaiPS.RutGon().toString()}");
            PhanSo ThuongHaiPS = ps1 / ps2;
            Console.WriteLine($"{ps1.toString()} / {ps2.toString()} = {ThuongHaiPS.RutGon().toString()}");

            Console.WriteLine($"{ps1.RutGon().toString()} = {ps2.RutGon().toString()} : {ps1 == ps2}");
            Console.WriteLine($"{ps1.RutGon().toString()} >= {ps2.RutGon().toString()} : {ps1 >= ps2}");
            Console.WriteLine($"{ps1.RutGon().toString()} > {ps2.RutGon().toString()} : {ps1 > ps2}");
        }
    }
}
