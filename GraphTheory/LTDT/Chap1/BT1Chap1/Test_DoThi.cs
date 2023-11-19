using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonDoThiVoHuong
{
    class Test_DoThi
    {
        static void Main(string[] args)
        {
            //TienIch_DoThi.GhiFile();
            ////int[][] maTran = TienIch_DoThi.TaoMaTran();
            ////int[] bacCuaDinh = TienIch_DoThi.TimBacCuaDinh();
            //////TienIch_DoThi.InMaTran(maTran);
            ////TienIch_DoThi.InBacCuaDinh(bacCuaDinh);

            //// Danh sach ke
            ////List<LinkedList<int>> matrix = TienIch_DoThi.docFile();
            ////TienIch_DoThi.InMaTran(matrix);
            ////TienIch_DoThi.DanhSachKe(matrix);

            //// chuyen ve ma tran ke
            //List<LinkedList<int>> matrix = TienIch_DoThi.docFile();
            //TienIch_DoThi.InMaTran(matrix);
            //int[][] maTran = TienIch_DoThi.maTranKeSauKhiChuyen(matrix);

            //Console.WriteLine("MA TRAN KE DUOC CHUYEN TU DANH SACH KE");
            //for (int i = 0; i < maTran.GetLength(0); i++)
            //{
            //    for (int j = 0; j < maTran.GetLength(0); j++)
            //    {
            //        Console.Write(maTran[i][j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //bool ketQua = TienIch_DoThi.kiemTraTinhLienThongCuaDoThi(matrix);
            //if (ketQua == true)
            //{
            //    Console.WriteLine("Do thi co tinh lien thong!");
            //}
            //else
            //{
            //    Console.WriteLine("Do thi khong co tinh lien thong!");
            //}

            //Console.WriteLine(TienIch_DoThi.kiemTraChuTrinhEuler(matrix));

            //// chu trinh Euler
            //List<int> chuTrinhE = TienIch_DoThi.TimChuTrinhEuler(0, matrix);
            //Console.WriteLine("CHU TRINH EULER");
            //foreach (var item in chuTrinhE)
            //{
            //    Console.Write(item + "   ");
            //}

            // Phu cay

            TachFIle.docFile();
        }
    }
}
