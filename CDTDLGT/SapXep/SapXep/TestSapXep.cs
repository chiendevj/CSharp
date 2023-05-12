using System;

namespace SapXep
{
    class TestSapXep
    {
        static void Main(string[] args)
        {
            int soPt = 0;
            Console.Write("Nhap so phan tu: ");
            int.TryParse(Console.ReadLine(), out soPt);
            int[] arr = new int[soPt];
            NhapMang(soPt,arr);
            XuatMang(arr);
            //InterchangeSort2(arr);
            //XuatMang(arr);
            //SelectionSort2(arr);
            //XuatMang(arr);
            //InsertionSort(arr);
            //XuatMang(arr);

            int left = 0;
            int right = arr.Length - 1;
            QuickSort(arr,left, right);
            XuatMang(arr);
        }
        static void QuickSort(int[] arr, int left, int right)
        {
            if (left >= right) return;
            int i = left;
            int j = right;

            int mid = arr[(left + right) / 2];
            while (i <= j)
            {
                while (arr[i] < mid) i++;
                while (arr[j] > mid) j--;
                if (i <= j)
                {
                    int item = arr[j];
                    arr[j] = arr[i];
                    arr[i] = item;
                    i++;
                    j--;
                }
            }
            QuickSort(arr, left, j);
            QuickSort(arr, i, right);
        }
        static void InsertionSort(int[] arr)
        {
            int pos = 0;    // lưu giá trị i - 1;
            int v = 0; // lưu giá trị arr[i] tránh bị đè mất data;
            for (int i = 1; i < arr.Length; i++)
            {
                pos = i - 1;
                v = arr[i];
                while (pos >= 0 && v < arr[pos])    // v > arr[pos] giảm dần
                {
                    arr[pos + 1] = arr[pos];
                    pos--;
                }
                arr[pos + 1] = v; // chèn v vào dãy
            }
        }
        static void SelectionSort2(int[] arr)
        {
            int min = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    // tìm min gán cho j
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    } 
                }
                // Sắp xếp
                Swap(ref arr[min], ref arr[i]);
            }
        }
        static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;
                int item = 0;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    // tìm min gán cho j
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                    // Sắp xếp
                    if (arr[i] > arr[j])
                    {
                        item = arr[min];
                        arr[min] = arr[i];
                        arr[i] = item;
                    }
                }
            }
        }
        static void BubbleSort3(int[] arr)
        {
            bool check = false;
            for (int i = 0; i < arr.Length - 1 && !check; i++)
            {
                check = true;
                for (int j = arr.Length - 1; j > i; j--)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        Swap(ref arr[j], ref arr[j - 1]);
                        check = false;
                    }
                }
            }
        }
        static void BubbleSort2(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = arr.Length - 1; j > i; j--)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        Swap(ref arr[j],ref arr[j -1]);
                    }
                }
            }
        }
        static void BubbleSort(int[] arr)
        {
            int item = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = arr.Length - 1; j > i; j--)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        item = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = item;
                    }
                }
            }
        }
        static void Swap(ref int a,ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
        static void InterchangeSort2(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        Swap(ref arr[i], ref arr[j]);
                    }
                }
            }
        }
        static void InterchangeSort(int[] arr)
        {
            int item = 0;
            for (int i = 0; i < arr.Length -1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        item = arr[i];
                        arr[i] = arr[j];
                        arr[j] = item;
                    }
                }
            }
        }
        static void XuatMang(int[] arr)
        {
            
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] +"\t");
            }
            Console.WriteLine();
        }
        static void NhapMang(int soPt, int[] arr)
        {
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1,50);
            }
        }
    }
}
