 using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Security.Cryptography;

namespace DonDoThiVoHuong
{
    class TienIch_DoThi
    {
        // tim duong di euler
        public static List<int> TimChuTrinhEuler(int start, List<LinkedList<int>> danhSachKe)
        {
            // Bước 0: Chuẩn bị
            Stack<int> st = new Stack<int>(); // chứa các đỉnh đã duyệt
            List<int> ketQua = new List<int>(); // chứa kết quả
            int x = -1; // dinh dang duyet
            int y = -1;
            LinkedListNode<int> node = new LinkedListNode<int>(-1);
            // Bước 1
            st.Push(start);
            Console.WriteLine($"Them node {start} vao stack");

            // Bước 2:
            // duyet cho den khi stack 
            while (st.Count != 0)
            {
                x = st.Peek(); // lay gia tri phan tu dau Peek
                if (danhSachKe[x].Count != 0)
                {
                    node = danhSachKe[x].First;
                    y = node.Value;
                    Console.WriteLine("y = " + y);
                    st.Push(node.Value);
                    Console.WriteLine($"them node {node.Value} vao stack");

                    // xoa canh xy
                    Console.WriteLine("xoa canh {0}{1}", x, y);
                    danhSachKe[x].Remove(y);
                    danhSachKe[y].Remove(x);
                }
                else
                {
                    // lay x khoi stack
                    x = st.Pop();
                    ketQua.Add(x);
                    Console.WriteLine($"dinh da duyet: {x}");
                }
            }

            return ketQua;
        }
        // kiem tra chu trinh Euler
        public static int kiemTraChuTrinhEuler(List<LinkedList<int>> danhSachKe)
        {
            int check = 0; // kiem tra bac chan le
            int result = 0; // tra ve do thi co chu trinh hay 0
            int[] bacCuaDinh = new int[danhSachKe.Count];
            for (int i = 0; i < danhSachKe.Count; i++)
            {
                bacCuaDinh[i] = danhSachKe[i].Count;
            }

            foreach (var item in bacCuaDinh)
            {
                if (item % 2 != 0)
                {
                    check++;
                }
            }

            if (check == 2)
            {
                result = -1;
            }
            else if (check > 2)
            {
                result = 0;
            }
            else
            {
                result = 1;
            }
            return result;
        }
        // tao ma tran tu file
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
        // in bac cua dinh
        public static int[] TimBacCuaDinh()
        {
            int[] bac;
            using (StreamReader sr = new StreamReader("matran.DAT"))
            {
                int soDinh = int.Parse(sr.ReadLine());
                int[][] maTran = TaoMaTran();
                bac = new int[soDinh];
                for (int i = 0; i < soDinh; i++)
                {
                    maTran[i] = new int[soDinh];

                    string line = sr.ReadLine();
                    string[] str = line.Split(',');
                    for (int j = 0; j < soDinh; j++)
                    {
                        int x = int.Parse(str[j]);
                        maTran[i][j] = x;
                        bac[j] += x;
                    }
                }
            }
            return bac;
        }
        // in bac cua dinh
        public static void InBacCuaDinh(int[] arr)
        {
            int count = 0;
            foreach (var item in arr)
            {
                Console.WriteLine($"Bac dinh {count}: " + item);
                count++;
            }
        }
        // in ma tran
        public static void InMaTran(List<LinkedList<int>> arr)
        {
            foreach (var item in arr)
            {
                for (LinkedListNode<int> i = item.First; i != null; i = i.Next)
                {
                    Console.Write(i.Value + "\t");
                }
                Console.WriteLine();
            }
        }

        // tim danh sach ke
        public static void DanhSachKe(List<LinkedList<int>> arr)
        {
            Console.WriteLine("\nDanh sach ke");
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
        // doc file danh sach ke
        public static List<LinkedList<int>> docFile()
        {
            List<LinkedList<int>> danhSachKe = new List<LinkedList<int>>();

            StreamReader sr = new StreamReader("matran.txt");
            try
            {
                int soDinh = int.Parse(sr.ReadLine());
                Console.WriteLine("So dinh: {0}", soDinh);

                // doc lan luot cac dong, tạo linkedList
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
                        danhSachKe.Add(t);
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return danhSachKe;
        }

        // chuyen danh sach ke sang ma tran ke
        public static int[][] maTranKeSauKhiChuyen(List<LinkedList<int>> arr)
        {
            int[][] matrix = new int[arr.Count][];

            for (int i = 0; i < arr.Count; i++)
            {
                int tam = 0;
                matrix[i] = new int[arr.Count];
                for (LinkedListNode<int> p = arr[i].First; p != null; p = p.Next)
                {
                    for (int k = tam; k < matrix.Length; k++)
                    {
                        if (k == p.Value)
                        {
                            matrix[i][k] = 1;
                            tam = k + 1;
                            break;
                        }
                        matrix[i][k] = 0;
                    }
                }

            }
            return matrix;
        }

        // kiem tra tinh lien thong
        public static bool kiemTraTinhLienThongCuaDoThi(List<LinkedList<int>> danhSachKe)
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

            // buoc 2, 3
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
        // ghi file
        public static void GhiFile()
        {
            int soDinh = 9;
            string line1 = "1,7";
            string line2 = "0,2,6,8";
            string line3 = "1,3,4,5";
            string line4 = "2,4";
            string line5 = "2,3";
            string line6 = "2,7";
            string line7 = "1,5,7,8";
            string line8 = "0,7";
            string line9 = "1,6";

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
                    sw.WriteLine(line7);
                    sw.WriteLine(line8);
                    sw.WriteLine(line9);
                    //bw.Close();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "Don't write file!");
                return;
            }

            Console.WriteLine("Write file successfully!");
        }
        //public static void GhiFile()
        //{
        //    int soDinh = 6;
        //    string line1 = "0,1,1,1,0,0";
        //    string line2 = "1,0,1,1,1,0";
        //    string line3 = "1,1,0,0,0,1";
        //    string line4 = "1,1,0,0,0,1";
        //    string line5 = "0,1,1,0,0,1";
        //    string line6 = "0,0,0,1,1,0";

        //    try
        //    {
        //        using (StreamWriter sw = new StreamWriter("matran.txt"))
        //        {
        //            sw.WriteLine(soDinh);
        //            sw.WriteLine(line1);
        //            sw.WriteLine(line2);
        //            sw.WriteLine(line3);
        //            sw.WriteLine(line4);
        //            sw.WriteLine(line5);
        //            sw.WriteLine(line6);
        //            //bw.Close();
        //        }

        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message + "Don't write file!");
        //        return;
        //    }

        //    Console.WriteLine("Write file successfully!");
        //}
    }
}
