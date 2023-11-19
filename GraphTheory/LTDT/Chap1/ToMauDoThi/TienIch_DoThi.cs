using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToMauDoThi
{
    internal class TienIch_DoThi
    {
        // Thuc hien to mau do thi da chuan bi
        public void chonMauTo (List<int> mauTo)
        {
            for (int i = 0; i < mauTo.Count; i++)
            {

            }
        }

        // chuan bi
        public static void chuanBi()
        {
            List<int> danhSachBac = new List<int>();
            danhSachBac.Add(0);
        }

        public static int timBacCuaDinhLonNhat(int[][] matran)
        {
            int max = 0;
            for (int i = 0; i <  matran.GetLength(0); i++)
            {
                for (int j = 0; j < matran.GetLength(0); j++)
                {
                    if (matran[i][j] > max)
                    {
                        max = matran[i][j];
                    }
                }
            }

            return max;
        }

        public static void InMaTran(int[][] matran)
        {
            for (int i = 0; i < matran.GetLength(0); i++)
            {
                for (int j = 0; j < matran.GetLength(0); j++)
                {
                    Console.Write(matran[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public static int[][] TaoMaTran()
        {
            int[][] maTran = new int[0][];


            using (StreamReader sr = new StreamReader("ma_tran_to_mau_do_thi.txt"))
            {
                int soDinh = int.Parse(sr.ReadLine());
                maTran = new int[soDinh][];

                for (int i = 0; i < soDinh; i++)
                {
                    maTran[i] = new int[soDinh];
                    string line = sr.ReadLine();

                    string[] str = line.Split(',');
                    for (int j = 0; j < soDinh; j++)
                    {
                        int x = int.Parse(str[j]);
                        maTran[i][j] = x;

                    }
                }
            }
            return maTran;
        }
        public static void GhiFile()
        {
            int soDinh = 5;
            string line1 = "0,1,1,1,0";
            string line2 = "1,0,1,0,0";
            string line3 = "1,1,0,1,1";
            string line4 = "1,0,1,0,1";
            string line5 = "0,0,1,1,0";

            try
            {
                using (StreamWriter sw = new StreamWriter("ma_tran_to_mau_do_thi.txt"))
                {
                    sw.WriteLine(soDinh);
                    sw.WriteLine(line1);
                    sw.WriteLine(line2);
                    sw.WriteLine(line3);
                    sw.WriteLine(line4);
                    sw.WriteLine(line5);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "Don't write file!");
                return;
            }

            Console.WriteLine("Write file successfully!");
        }
    }
}

