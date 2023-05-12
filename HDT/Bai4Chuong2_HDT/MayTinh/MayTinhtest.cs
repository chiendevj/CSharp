using System;
namespace Bai8_QLMayTinh
{
    class MainMayTinh
{
    static void Main(string[] args)
    {
        int soPt;
        int count = 0;
        Console.Write("Nhap so luong may tinh can co trong he thong: ");
        int.TryParse(Console.ReadLine(), out soPt);
        MayTinh[] arr = new MayTinh[soPt];
        for (int i = 0; i < arr.Length; i++)
        {
            MayTinh mt1 = new MayTinh();
            Console.Write("Nhap loai may :");
            mt1.LoaiMay = Console.ReadLine();
            Console.Write("Nhap Noi SX:");
            mt1.NoiSX = Console.ReadLine();
            Console.Write("Nhap thoi gian bao hanh (thang):");
            mt1.ThoiGianBH = int.Parse(Console.ReadLine());
            arr[i] = mt1;
        }
        Console.WriteLine($"| {"Loai",-25} | {"Noi SX",-15} | {"Thoi Gian Bao Hanh",-15} |");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i].toString());
            if (arr[i].ThoiGianBH > 12)
            {
                count++;
            }
        }
        
        Console.WriteLine($"Co {count} san pham tren 1 nam bao hanh!\n====================================================");
        Console.WriteLine("\t\t---CAC LOAI MAY SAN XUAT TAI MY---");
        Console.WriteLine($"{"Loai",-15} | {"NoiSX",-15} | {"Thoi Gian Bao Hanh",-15}");
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].NoiSX == "My" || arr[i].NoiSX == "MY" || arr[i].NoiSX == "my")
            {
                Console.WriteLine($"{arr[i].LoaiMay,-25} | {arr[i].NoiSX,-15} | {arr[i].ThoiGianBH,-15}");
            }
        }
        Console.WriteLine($"CO {MayTinh.Qty} MAY TINH TREN HE THONG");
    }
}
}