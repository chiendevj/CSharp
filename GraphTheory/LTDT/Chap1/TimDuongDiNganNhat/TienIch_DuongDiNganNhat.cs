using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimDuongDiNganNhat
{
    internal class TienIch_DuongDiNganNhat
    {
        public static int tongMang(int[] myArr)
        {
            int tong = 0;
            for (int i = 0; i < myArr.Length; i++)
            {
                tong += myArr[i];
            }
            return tong;
        }

        public static void DuongDiNganNhat_Dijkstra(int[][] mtts, int dinhDau)
        {
            const int VOCUNG = 1000;
            int soDinh = mtts.GetLength(0);
            int dinhXet = -1;
            int[] dinhTruoc = new int[soDinh];
            int[] khoangCach = new int[soDinh];
            int i;

            // gan gia tri VOCUNG cho cac cap dinh khong co duong di
            for (i = 0; i < soDinh; i++)
            {
                for (int j = 0; j < soDinh; j++)
                {
                    if (mtts[i][j] == 0 && i != j)
                    {
                        mtts[i][j] = VOCUNG;
                    }
                }
            }
            InMaTran(mtts);

            // khoang cach tu dinh dau den cac dinh con lai
            for (i = 0; i < soDinh; i++)
            {
                khoangCach[i] = mtts[dinhDau][i];
            }

            khoangCach[dinhDau] = 0; // khoang cach tu dinhDau den dinhDau = 0

            Console.WriteLine("Khoảng cách từ đỉnh đầu đến các đỉnh còn lại:");
            inMang(khoangCach);

            int[] daXet = new int[soDinh]; // daXet[i] = 0 neu dinh i chua duoc xet
            for (i = 0; i < daXet.Length; i++)
            {
                daXet[i] = 0;
                dinhTruoc[i] = dinhDau;
            }

            daXet[dinhDau] = 1;

            // buoc 2: tim dinh co khoang cach den dinhDau 
            int min = VOCUNG;
            for (i = 0; i < soDinh; i++)
            {
                if (daXet[i] != 1)
                {
                    if (mtts[dinhDau][i] < min)
                    {
                        min = mtts[dinhDau][i];
                        dinhXet = i;
                    }
                }
            }

            khoangCach[dinhXet] = min;
            daXet[dinhXet] = 1;
            dinhTruoc[dinhXet] = dinhDau;
            int temp = -1;

            // Buoc 3
            while (tongMang(daXet) < soDinh)
            {
                min = VOCUNG;
                for (i = 0; i < soDinh; i++)
                {
                    if (daXet[i] != 1)
                    {
                        // tinh lai khoangCach[i]
                        if (khoangCach[i] > (khoangCach[dinhXet] + mtts[dinhXet][i]))
                        {
                            khoangCach[i] = khoangCach[dinhXet] + mtts[dinhXet][i];
                            dinhTruoc[i] = dinhXet;
                            
                        }

                        if (min > khoangCach[i])
                        {
                            min = khoangCach[i];
                            temp = i;
                        }
                    }
                }
                dinhXet = temp;
                daXet[dinhXet] = 1;
                khoangCach[dinhXet] = min;

            }

            // in dinhTruoc
            Console.WriteLine("Đỉnh trước: ");
            for (i = 0; i < soDinh; i++)
            {
                Console.WriteLine("Trước đỉnh {0} là {1}", i, dinhTruoc[i]);
            }

            // in khoang cach
            Console.WriteLine("Khoảng cách:");
            for (i = 0; i < soDinh; i++)
            {
                Console.WriteLine("Khoảng cách từ 0 đến {0} là {1}", i, khoangCach[i]);
            }

            Console.WriteLine(inDuongDi_Djkstra(dinhDau, 3, dinhTruoc));

        }

        public static string inDuongDi_Djkstra(int dinhDau, int dinhCuoi, int[] dinhTruoc)
        {
            int i = dinhCuoi;
            int temp = dinhDau;
            string duongDi ="Đường đi ngắn nhất từ " + dinhDau + " đến " + dinhCuoi + " là: " + dinhDau + "";
            while (dinhTruoc[i] != dinhDau)
            {
                temp = dinhTruoc[i];
                duongDi += $" - {temp}";
                i = temp;
            }
            duongDi += $" - {dinhCuoi}";

            return duongDi;
        }
        public static void inMang(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();
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
            int soDinh = 6;
            string line1 = "0,5,5,0,0,6";
            string line2 = "5,0,1,6,0,0";
            string line3 = "5,1,0,4,0,7";
            string line4 = "0,6,4,0,2,3";
            string line5 = "0,0,0,2,0,5";
            string line6 = "6,0,7,3,5,0";

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
                    sw.WriteLine(line6);
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
