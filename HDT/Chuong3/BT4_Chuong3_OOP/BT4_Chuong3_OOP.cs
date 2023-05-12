using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4_Chuong3_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            BienLai[] bienlai = danhSachBL();
            
            Xuat(bienlai);
        }
        public static void Xuat(BienLai[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].toString());
            }
        }
        public static BienLai[] danhSachBL()
        {
            Console.Write("Danh Sach Bien Lai gom: ");
            int n = int.Parse(Console.ReadLine());

            BienLai[] arr = new BienLai[n];
            for (int i = 0; i < arr.Length; i++)
            {
                
                Console.WriteLine($"Bien Lai thu: {i+1}");
                Console.Write("Ho va ten: ");
                string hoTen = Console.ReadLine();
                Console.Write("Dia Chi: ");
                string diaChi = Console.ReadLine();
                Console.Write("Ma so CT: ");
                string maSoCT = Console.ReadLine();
                Console.WriteLine("Chi so moi: ");
                int csm = int.Parse(Console.ReadLine());
                Console.WriteLine("Chi so cu: ");
                int csc = int.Parse(Console.ReadLine());
                arr[i] = new BienLai(hoTen,diaChi, maSoCT, csm, csc);
            }
            return arr;
        }
    }
}
