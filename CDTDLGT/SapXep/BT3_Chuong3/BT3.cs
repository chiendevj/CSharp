using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3_Chuong3
{
    class BT3
    {
        static void Main(string[] args)
        {
            int soPt = 0;
            Console.Write("Nhap so luong SV: ");
            int.TryParse(Console.ReadLine(), out soPt);
            QuanLiSinhVien[] arr = new QuanLiSinhVien[soPt];
            NhapDSSV(arr);
            XuatDSSV(arr);
        }
        public static void XuatDSSV(QuanLiSinhVien[] arrSV)
        {
            for (int i = 0; i < arrSV.Length; i++)
            {
                arrSV[i].XuatSV();
            }
        }
        public static void NhapDSSV(QuanLiSinhVien[] arrSV)
        {
            for (int i = 0; i < arrSV.Length; i++)
            {
                QuanLiSinhVien qlsv = new QuanLiSinhVien();
                qlsv.NhapSV();
                arrSV[i] = qlsv;
            }
        }
    }
}
