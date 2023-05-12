using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRR_BTChuong4
{
    class BT_Chuong4
    {
        static void Main(string[] args)
        {
            int row = 0;
            int column = 0;
            int[,] arrs;
            int[,] arrs2;
            // Input
            Console.Write("Enter row: ");
            int.TryParse(Console.ReadLine(), out row);
            Console.Write("Enter column: ");
            int.TryParse(Console.ReadLine(), out column);
            arrs = new int[row, column];

            Console.Write("Enter rows matrix 2: ");
            int row2 = int.Parse(Console.ReadLine());
            Console.Write("Enter columns matrix 2: ");
            int column2 = int.Parse(Console.ReadLine());
            arrs2 = new int[row2, column2];
            // Output
            NhapMang2Chieu(arrs);
            InMang2Chieu(arrs);
            NhapArrs2(arrs2);
            InArrs2(arrs2);
            // KiemTraChuyenVi
            if (isMaTranChuyenVi(arrs, MaTranChuyenVi(arrs)))
            {
                Console.WriteLine("Ham tren chuyen vi");
            }
            else
            {
                Console.WriteLine("Ham tren khong chuyen vi");
            }
            // Cộng 2 ma trận có cùng kích thước
            CongHaiMaTranCoCungKT(row, column, arrs, arrs2);
            // Nhân Ma Trận với một số nguyên
            NhanHaiMaTranVoiMotSo(row, column, arrs);
            // Ma Trận Dòng
            MaTranDong(arrs);
            // Ma Trận Cột
            MaTranCot(arrs);
            // Chuyển vị
            MaTranChuyenVi(arrs);
            // Chéo
            MaTranCheo(arrs);
            // Zero
            MaTraZero(arrs);


        }
        // Ngoài Main
        static bool isMaTranChuyenVi(int[,] a, int[,] b)
        {
            if (a == b)
            {
                return true;
            }
            return false;

        }
        static int[,] NhanHaiMaTranVoiMotSo(int row, int col, int[,] arrs)
        {
            int number = 0;
            int[,] arr4 = new int[row, col];
            Console.WriteLine("\n\tNHAN MA TRAN VOI MOT SO");
            Console.Write("Enter the number: ");
            int.TryParse(Console.ReadLine(), out number);
            Console.WriteLine("\t");
            for (int i = 0; i < arr4.GetLength(0); i++)
            {
                for (int j = 0; j < arr4.GetLength(1); j++)
                {
                    arr4[i, j] = arrs[i, j] * number;
                    Console.Write(arr4[i, j] + "\t");
                }
                Console.WriteLine();
            }
            return arr4;
        }
        static int[,] CongHaiMaTranCoCungKT(int row, int column, int[,] arr, int[,] arr2)
        {
            int[,] arr3 = new int[row, column];
            Console.WriteLine("\n\tTONG HAI MA TRAN 1 VA 2");
            for (int i = 0; i < arr3.GetLength(0); i++)
            {
                for (int j = 0; j < arr3.GetLength(1); j++)
                {
                    arr3[i, j] = arr[i, j] + arr2[i, j];
                    Console.Write(arr3[i, j] + "\t");
                }
                Console.WriteLine();
            }

            return arr3;
        }
        static int[,] MaTranCot(int[,] arr)
        {
            Console.WriteLine("\tMA TRAN COT");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine(arr[i, j] + "\t");
                }
            }
            return arr;
        }
        static int[,] MaTranDong(int[,] arr)
        {
            Console.WriteLine("\tMA TRAN DONG");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
            }
            Console.WriteLine();
            return arr;
        }
        static int[,] MaTranCheo(int[,] arr)
        {
            Console.WriteLine("MA TRAN CHEO");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i != j)
                    {
                        arr[i, j] = 0;
                    }
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            return arr;
        }
        static int[,] MaTranChuyenVi(int[,] arr)
        {
            Console.WriteLine("\tMA TRAN CHUYEN VI");
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    Console.Write(arr[j, i] + "\t");
                }
                Console.WriteLine();
            }
            return arr;
        }
        static int[,] MaTraZero(int[,] arr)
        {
            Console.WriteLine("\tMA TRAN ZERO");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = 0;
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            return arr;
        }
        static int[,] NhapMang2Chieu(int[,] arrs)
        {
            // Nhập mảng
            for (int i = 0; i < arrs.GetLength(0); i++)
            {
                for (int j = 0; j < arrs.GetLength(1); j++)
                {
                    Console.Write($"A[{i},{j}]= ");
                    int.TryParse(Console.ReadLine(), out arrs[i, j]);
                }
                Console.WriteLine();
            }

            return arrs;
        }
        static int[,] InMang2Chieu(int[,] arr)
        {
            // In mảng
            Console.WriteLine("========================================\n\tMA TRAN SO 1");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            return arr;
        }
        static int[,] NhapArrs2(int[,] arrs2)
        {
            Random rand = new Random();
            for (int i = 0; i < arrs2.GetLength(0); i++)
            {
                for (int j = 0; j < arrs2.GetLength(1); j++)
                {
                    arrs2[i, j] = rand.Next(1, 10);
                }
            }
            return arrs2;
        }
        static int[,] InArrs2(int[,] arrs2)
        {
            Console.WriteLine("\n\tMA TRAN SO 2");
            for (int i = 0; i < arrs2.GetLength(0); i++)
            {
                for (int j = 0; j < arrs2.GetLength(1); j++)
                {
                    Console.Write(arrs2[i, j] + "\t");
                }
                Console.WriteLine();
            }
            return arrs2;
        }
    }
}
