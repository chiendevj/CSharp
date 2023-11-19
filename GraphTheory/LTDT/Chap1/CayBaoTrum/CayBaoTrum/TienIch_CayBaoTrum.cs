using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CayBaoTrum
{
    
    internal class TienIch_CayBaoTrum
    {
        public static Edge[] Prim(int[][] maTran, int soDinh)
        {
            // Khai bao
            Edge[] ketQua = new Edge[soDinh - 1];
            int soCanh = 0;
            int tongTS = 0;

            // dindDaXet: cac dinh chua xet, danh dau = 0
            int[] dinhDaXet = new int[soDinh];
            for (int j = 0; j < soDinh; j++)
            {
                dinhDaXet[j] = 0;
            }

            // Chon mot dinh bat ky (thu 0) lam dinh dau tien
            dinhDaXet[0] = 1;

            do
            {
                int min = int.MaxValue;
                int dinhBatDau = -1;
                int dinhKetThuc = -1;

                for (int i = 0; i < soDinh; i++)
                {
                    if (dinhDaXet[i] == 1)
                    {
                        for (int j = 0; j < soDinh; j++)
                        {
                            if (dinhDaXet[j] == 0 && maTran[i][j] != 0 && maTran[i][j] < min)
                            {
                                min = maTran[i][j];
                                dinhBatDau = i;
                                dinhKetThuc = j;
                            }
                        }
                    }
                }

                if (dinhBatDau != -1 && dinhKetThuc != -1)
                {
                    ketQua[soCanh] = new Edge();
                    ketQua[soCanh].StartPoint = dinhBatDau;
                    ketQua[soCanh].EndPoint = dinhKetThuc;
                    tongTS += min;
                    Console.WriteLine($"({dinhBatDau}, {dinhKetThuc})  \nTong trong so: {tongTS}");
                    dinhDaXet[dinhKetThuc] = 1;
                    soCanh++;
                }
            } while (soCanh < soDinh - 1);
            return ketQua;
        }

        public static Edge[] Prim2(int[][] maTran, int soDinh)
        {
            // khai bao
            Edge[] ketQua = new Edge[soDinh -1];
            int min = int.MaxValue;
            int soCanh = 0;
            int tongTS = 0;
            int temp = -1;

            // dindDaXet cac dinh chua xet danh dau = 0
            int[] dinhDaXet = new int[soDinh];
            for (int j = 0; j < soDinh; j++)
            {
                dinhDaXet[j] = 0;
            }

            // tim min thu 0
            int i = 0; 
            Console.WriteLine($"Lập min = int.MaxValue = {min: #,###} Tổng trọng số = {tongTS}");
            for (i = 0; i < soDinh; i++)
            {
                if (maTran[0][i] != 0)
                {
                    Console.WriteLine($"Xét đỉnh 0 với {i} có trọng số là {maTran[0][i]}");
                    if (min > maTran[0][i] && maTran[0][i] != 0)
                    {
                        min = maTran[0][i];
                        ketQua[0] = new Edge();
                        ketQua[0].EndPoint = i;
                        tongTS = min;
                    }
                }
                
            }
            ketQua[0].StartPoint = 0;
            dinhDaXet[0] = 1;
            dinhDaXet[ketQua[0].EndPoint] = 1;
            soCanh++;
            Console.WriteLine("Đỉnh 1: min = " + min + " Tổng trọng số = " + tongTS + " số cạnh đã đi qua = " + soCanh);

            do
            {
                min = int.MaxValue;
                for (i = 0; i < soDinh; i++)
                {
                    if (dinhDaXet[i] == 1)
                    {
                        for (int j = 0;j < soDinh; j++)
                        {
                            if (dinhDaXet[j] == 1)
                            {
                                continue;
                            }
                            else
                            {
                                if (min > maTran[i][j] && maTran[i][j] != 0)
                                {
                                Console.WriteLine($"Xét đỉnh {i} với {j} có trọng số là {maTran[i][j]}");
                                    min = maTran[i][j];
                                    ketQua[soCanh] = new Edge();
                                    ketQua[soCanh].StartPoint = i;
                                    ketQua[soCanh].EndPoint = j;
                                    temp = j;
                                }
                            }
                        }
                    }
                }
                tongTS += min;
                dinhDaXet[temp] = 1;
                //Console.WriteLine("min = " + min);
                soCanh++;
                Console.WriteLine("Đỉnh " + temp +", Min = " + min + " Tổng trọng số = " + tongTS + " số cạnh đã đi qua = " + soCanh);
            } while (soCanh < soDinh -1);

            return ketQua;
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


            using (StreamReader sr = new StreamReader("matran.txt"))
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
            string line1 = "0,6,0,3,2";
            string line2 = "6,0,7,0,4";
            string line3 = "0,7,0,2,0";
            string line4 = "3,0,2,0,1";
            string line5 = "2,4,0,1,0";
           

            try
            {
                using (StreamWriter sw = new StreamWriter("matran.txt"))
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
