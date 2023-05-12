using System;
using System.IO;

namespace BT6_Chuong3_OOP
{
    class BT6_Chuong3_OOP
    {
        static void Main(string[] args)
        {
            SinhVien[] dssv = DSSinhVien.DanhSachSinhVien();
            DSSinhVien.XuatFile(dssv);
        }
        
    }
}
