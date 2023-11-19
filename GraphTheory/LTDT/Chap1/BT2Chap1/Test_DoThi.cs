using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2Chap1
{
    internal class Test_DoThi
    {
        static void Main(string[] args)
        {
            TienIch_DoThi.GhiFile();
            int[][] matrix = TienIch_DoThi.TaoManTran();
            int[] arr = TienIch_DoThi.TimBacCuaDinh();

            // In bac ma tran ke
            TienIch_DoThi.InMaTran(matrix);
            //TienIch_DoThi.InbacCuaDinh(arr);

            // in bac ma tran trong so
            int[] arrTrongSo = TienIch_DoThi.DemBacCuaDinh(matrix);
            TienIch_DoThi.InBacMaTranTrongSo(arrTrongSo);

            // In danh sach ke
            List<LinkedList<int>> danhSachKe = TienIch_DoThi.docFile();
            TienIch_DoThi.InDanhSachKe(danhSachKe);

            // In Ma Tran ke
            int[][] matrixV2 = TienIch_DoThi.maTranSauKhiChuyen(danhSachKe);
            TienIch_DoThi.InMaTranKeSauKhiChuyen(matrixV2);
            //TienIch_DoThi.maTranSauKhiChuyen(danhSachKe);
            // Kiem tra tính lien thong
            ketQuaTinhLienThong(danhSachKe);

        }

        public static void ketQuaTinhLienThong(List<LinkedList<int>> danhSachKe)
        {
            bool ketQua = TienIch_DoThi.kiemTraLienThong(danhSachKe);
            if (ketQua) 
            {
                Console.WriteLine("Do thi co tinh lien thong");
            }
            else
            {
                Console.WriteLine("Do thi khong co tinh lien thong");
            }
        }
    }
}
