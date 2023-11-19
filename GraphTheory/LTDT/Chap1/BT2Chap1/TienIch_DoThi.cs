using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Reflection;
using System.Security.Cryptography;

namespace BT2Chap1
{
    internal class TienIch_DoThi
    {
        // kiem tra tinh lien thong
        public static bool kiemTraLienThong(List<LinkedList<int>> danhSachKe)
        {
            bool ketQua = true;
            int[] dinhDaXet = new int[danhSachKe.Count];
            Queue<int> q = new Queue<int>();
            int dinhXet = -1;

            for (int i = 0; i < dinhDaXet.Length; i++)
            {
                dinhDaXet[i] = 0;
            }
            // buoc 1
            dinhDaXet[0] = 1;
            q.Enqueue(0);

            // buoc 2
            while (q.Count > 0)
            {
                dinhXet = q.Dequeue();
                if (danhSachKe[dinhXet].Count != 0)
                {
                    foreach (var x in danhSachKe[dinhXet])
                    {
                        if (dinhDaXet[x] == 0)
                        {
                            dinhDaXet[x] = 1;
                            q.Enqueue(x);
                        }
                    }
                }
            }

            // buoc 4
            foreach (var x in dinhDaXet)
            {
                if (x == 0)
                {
                    ketQua = false;
                    break;
                }
            }

            return ketQua;
        }
        // in ma tran ke sau khi chuyen tu danh sach ke
        public static void InMaTranKeSauKhiChuyen(int[][] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    Console.Write(arr[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
        // chuyen tu danh sach ke sang ma tran ke
        public static int[][] maTranSauKhiChuyen(List<LinkedList<int>> arr)
        {
            int[][] maTrix = new int[arr.Count][];
            int k = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                maTrix[i] = new int[arr.Count];
                k = 0;
                for (LinkedListNode<int> p = arr[i].First; p != null; p = p.Next)
                {
                    for (int j = k; j < maTrix[i].Length; j++)
                    {

                        if (j == p.Value)
                        {
                            maTrix[i][j] = 1;
                            k = j + 1;
                            break;
                        }
                        else
                        {
                            maTrix[i][j] = 0;
                        }
                    }
                }

            }
            return maTrix;
        }

        // in danh sach ke 
        public static void InDanhSachKe(List<LinkedList<int>> arr)
        {
            int index = 0;
            foreach (var item in arr)
            {
                int count = 0;
                Console.Write($"Dinh {index} ke voi cac dinh: ");
                for (LinkedListNode<int> i = item.First; i != null; i = i.Next)
                {
                    if (i.Value != 0)
                    {
                        Console.Write(+count + "\t");
                    }
                    count++;
                }
                Console.WriteLine();
                index++;
            }
        }
        // chuyen tu ma tran ke sang danh sach ke
        public static List<LinkedList<int>> docFile()
        {
            List<LinkedList<int>> danhSachKe = new List<LinkedList<int>>();

            using (StreamReader sr = new StreamReader("matrix.txt"))
            {
                int soDinh = int.Parse(sr.ReadLine());

                // doc lan luot, tao linkedlist
                for (int i = 0; i < soDinh; i++)
                {
                    LinkedList<int> t = new LinkedList<int>();
                    string s0 = sr.ReadLine();
                    if (s0 != null)
                    {
                        string[] danhSachDinhKe = s0.Split(new char[] { ',' });
                        for (int j = 0; j < danhSachDinhKe.Length; j++)
                        {
                            int x = int.Parse(danhSachDinhKe[j]);
                            t.AddLast(x);
                        }
                    }
                    danhSachKe.Add(t);
                }
            }
            return danhSachKe;
        }
        // dem so phan tu tren dong hay cot khac i
        public static int[] DemBacCuaDinh(int[][] maTrix)
        {
            int[] arr = new int[0];
            using (StreamReader sr = new StreamReader("matrix.DAT"))
            {
                int soDinh = int.Parse(sr.ReadLine());
                arr = new int[soDinh];

                maTrix = new int[soDinh][];
                for (int i = 0; i < soDinh; i++)
                {
                    maTrix[i] = new int[soDinh];
                    string line = sr.ReadLine();
                    string[] str = line.Split(new char[] { ',' });
                    for (int j = 0; j < soDinh; j++)
                    {
                        int x = int.Parse(str[j]);
                        if (x != 0)
                        {
                            arr[i]++;
                        }
                    }
                }

            }
            return arr;
        }
        // in bac ma tran trong so
        public static void InBacMaTranTrongSo(int[] arr)
        {
            int count = 0;
            foreach (var item in arr)
            {
                Console.WriteLine($"Bac thu {count}: {item}");
                count++;
            }
        }
        // tao ma tran tu file
        public static int[][] TaoManTran()
        {
            int[][] maTrix = new int[0][];
            using (StreamReader sr = new StreamReader("matrix.DAT"))
            {
                int soDinh = int.Parse(sr.ReadLine());
                maTrix = new int[soDinh][];

                for (int i = 0; i < soDinh; i++)
                {
                    maTrix[i] = new int[soDinh];
                    string line = sr.ReadLine();
                    //Console.WriteLine(line);
                    string[] arrInt = line.Split(',');

                    for (int j = 0; j < soDinh; j++)
                    {
                        int x = int.Parse(arrInt[j]);
                        maTrix[i][j] = x;
                    }
                }
            }
            return maTrix;
        }
        // tim bac cua dinh
        public static int[] TimBacCuaDinh()
        {
            int[] bacCuaDinh;
            int[][] maTrix = new int[0][];
            using (StreamReader sr = new StreamReader("matrix.DAT"))
            {
                int soDinh = int.Parse(sr.ReadLine());
                bacCuaDinh = new int[soDinh];
                maTrix = new int[soDinh][];
                for (int i = 0; i < soDinh; i++)
                {
                    maTrix[i] = new int[soDinh];
                    string line = sr.ReadLine();
                    //Console.WriteLine(line);
                    string[] arrInt = line.Split(',');

                    for (int j = 0; j < soDinh; j++)
                    {
                        int x = int.Parse(arrInt[j]);
                        bacCuaDinh[i] += x;
                    }
                }
            }
            return bacCuaDinh;
        }
        // in bac cua dinh
        public static void InbacCuaDinh(int[] arr)
        {
            int count = 0;
            foreach (var item in arr)
            {
                Console.WriteLine($"Bac cua dinh {count}: {item}");
                count++;
            }
        }
        // in ma tran
        public static void InMaTran(int[][] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    Console.Write(arr[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
        // ghi file ma tran
        public static void GhiFile()
        {
            // MA TRẬN KỀ
            int soDinh = 6;
            string line1 = "0,1,0,1,0,0";
            string line2 = "0,0,0,0,1,0";
            string line3 = "1,1,0,0,0,0";
            string line4 = "0,1,0,0,0,1";
            string line5 = "0,0,1,0,0,0";
            string line6 = "0,0,0,0,1,0";

            // MA TRẬN TRỌNG SỐ
            //int soDinh = 5;
            //string line1 = "0,5,4,0,7";
            //string line2 = "5,0,6,0,9";
            //string line3 = "4,6,0,0,0";
            //string line4 = "0,0,0,0,0";
            //string line5 = "7,9,0,0,0";

            try
            {
                using (StreamWriter sw = new StreamWriter("matrix.txt"))
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
                Console.WriteLine(e.Message + "Ghi file không thành công!");
                return;
            }
            Console.WriteLine("Ghi file thanh cong.");
        }
    }
}
