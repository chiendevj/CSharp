using System;
using System.IO;

namespace BT2
{
    class BT2
    {
        static void Main(string[] args)
        {
            Sach[] arr = new Sach[0];
            DocDSach(ref arr, @"D:\SapXep\BT2_Chuong3\InputBai2Chuong3.txt");
            XuatDSach(arr);
            // Câu d
            //BubbleSort(arr);
            //XuatDSach(arr);

            //BubbleSort2(arr);
            //XuatDSach(arr);

            //InterchangeSort(arr);
            //XuatDSach(arr);

            //InterchangeSort2(arr);
            //XuatDSach(arr);

            //SeclectionSort(arr);
            //XuatDSach(arr);

            //SeclectionSort2(arr);
            //XuatDSach(arr);

            InsertionSort(arr);
            XuatDSach(arr);

            //InsertionSort2(arr);
            //XuatDSach(arr);

            //QuickSort(arr,0, arr.Length-1);
            //XuatDSach(arr);

        }
        static void QuickSort(Sach[] arr, int left, int right)
        {
            if (left >= right) return;
            int i = left;
            int j = right;

            Sach mid = arr[(left + right) / 2];
            while (i <= j)
            {
                while (arr[i].GiaBan < mid.GiaBan) i++;
                while (arr[j].GiaBan > mid.GiaBan) j--;
                if (i <= j)
                {
                    Sach item = arr[j];
                    arr[j] = arr[i];
                    arr[i] = item;
                    i++;
                    j--;
                }
            }
            QuickSort(arr, left, j);
            QuickSort(arr, i, right);
        }
        static void InsertionSort3(Sach[] arr)
        {
            int pos = 0;
            Sach v;
            for (int i = 1; i < arr.Length; i++)
            {
                pos = i - 1;
                v = arr[i];
                while (pos >= 0 && v.NamXB < arr[pos].NamXB)
                {
                    arr[pos + 1] = arr[pos];
                    pos--;
                }
                arr[pos + 1] = v;
            }
        }
        static void InsertionSort2(Sach[] arr)
        {
            int pos = 0;    // lưu giá trị i - 1;
            Sach v; // lưu giá trị arr[i] tránh bị đè mất data;
            for (int i = 1; i < arr.Length; i++)
            {
                pos = i - 1;
                v = arr[i];
                while (pos >= 0 && v.GiaBan > arr[pos].GiaBan)    // v > arr[pos] giảm dần
                {
                    arr[pos + 1] = arr[pos];
                    pos--;
                }
                arr[pos + 1] = v; // chèn v vào dãy
            }
        }
        static void InsertionSort(Sach[] arr)
        {
            int pos = 0;    // lưu giá trị i - 1;
            Sach v; // lưu giá trị arr[i] tránh bị đè mất data;
            for (int i = 1; i < arr.Length; i++)
            {
                pos = i - 1;
                v = arr[i];
                while (pos >= 0 && String.Compare(v.MaSach,arr[pos].MaSach) < 0)    // v > arr[pos] giảm dần
                {
                    arr[pos + 1] = arr[pos];
                    pos--;
                }
                arr[pos + 1] = v; // chèn v vào dãy
            }
        }
        static void SeclectionSort(Sach[] arr)
        {
            Console.WriteLine("\nDanh sach tang dan theo ma sach");

            Sach[] t = new Sach[arr.Length];
            int min = 0;
            for (int i = 0; i < arr.Length -1; i++)
            {
                min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (String.Compare(arr[i].MaSach,arr[j].MaSach) < 0)
                    {
                        min = j;
                    }
                    if (String.Compare(arr[i].MaSach, arr[j].MaSach) > 0)
                    {
                        t[i] = arr[i];
                        arr[i] = arr[j];
                        arr[j] = t[i];
                    }
                }
            }
        }
        static void SeclectionSort2(Sach[] arr)
        {
            Console.WriteLine("\nDanh sach tang dan theo ma sach(swap)");

            Sach[] t = new Sach[arr.Length];
            int min = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (String.Compare(arr[i].MaSach, arr[j].MaSach) < 0)
                    {
                        min = j;
                    }
                    if (String.Compare(arr[i].MaSach, arr[j].MaSach) > 0)
                    {
                        Swap(ref arr[i], ref arr[j]);
                    }
                }
            }
        }
        static void BubbleSort(Sach[] arr)
        {
            Console.WriteLine("\nDanh sach tang dan theo tua sach");
            Sach[] t = new Sach[arr.Length];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = arr.Length - 1; j > i; j--)
                {
                    if (String.Compare(arr[i].TenSach,arr[j].TenSach) > 0)
                    {
                        t[i] = arr[i];
                        arr[i] = arr[j];
                        arr[j] = t[i];
                    }
                }
            }
        }
        static void BubbleSort2(Sach[] arr)
        {
            Console.WriteLine("\nDanh sach tang dan theo tua sach(swap)");
            Sach[] t = new Sach[arr.Length];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = arr.Length - 1; j > i; j--)
                {
                    if (String.Compare(arr[i].TenSach, arr[j].TenSach) > 0)
                    {
                        Swap(ref arr[i],ref arr[j]);
                    }
                }
            }
        }
        static void InterchangeSort2(Sach[] arr)
        {
            Console.WriteLine("\nDanh sach giam dan theo nam XB(swap)");
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i].NamXB < arr[j].NamXB)
                        Swap(ref arr[i], ref arr[j]);
                }
            }
        }
        static void InterchangeSort(Sach[] arr)
        {
            Console.WriteLine("\nDanh sach giam dan theo nam XB");

            Sach[] t = new Sach[arr.Length];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i].NamXB < arr[j].NamXB)
                    {
                        t[i] = arr[i];
                        arr[i] = arr[j];
                        arr[j] = t[i];
                    }
                }
            }
        }
        static void Swap(ref Sach a, ref Sach b)
        {
            Sach t;
            t = a;
            a = b;
            b = t;
        }
        static void XuatDSach(Sach[] arr)
        {
            Console.WriteLine($"{"MaSach",-10}{"TenSach",-10}{"NamXB",-10}{"GiaBan",-10}");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].Xuat();
            }
            Console.WriteLine();
        }
        static void DocDSach(ref Sach[] arr, string path)
        {
            int n = 0;
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    int.TryParse(sr.ReadLine(), out n);
                    arr = new Sach[n];
                    for (int i = 0; i < arr.Length; i++)
                    {
                        Sach s = new Sach();
                        s.Doc(sr);
                        arr[i] = s;
                    }
                }
            }
            catch (IOException)
            {

                Console.WriteLine("File not found!");
            }
        }
    }
}