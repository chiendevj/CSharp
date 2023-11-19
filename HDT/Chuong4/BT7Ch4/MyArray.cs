using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_OnTap
{
    class MyArray
    {
        
        private int[] arr;

        // properties

        public int[] Arr
        {
            get
            {
                return arr;
            }

            set
            {
                arr = value;
            }
        }

        // constrcutor
        public MyArray()
        {
            int[] arr = new int[0];
        }

        public MyArray(int[] arr)
        {
            this.arr = arr;
        }

        public MyArray(int n)
        {
            int[] arr = new int[n];
        }


        // Method
        public string toString()
        {
            string str = "";
            for (int i = 0; i < Arr.Length; i++)
            {
                str += $" {this.arr[i],3 }" + $"{"", -3}";
            }
            return str;
        }

        public static void Nhap(int[] arr)
        {
            
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"A[{i}]= ");
                int.TryParse(Console.ReadLine(), out arr[i]);
            }
        }

        // A. ++: TĂNG CÁC PHẦN TỬ LÊN `1 ĐƠN VỊ
        public static MyArray operator ++(MyArray arr)
        {
            for (int i = 0; i < arr.Arr.Length; i++)
            {
                arr.Arr[i] = arr.Arr[i] + 1;
            }
            return arr;
        }

        // B. ++: Giảm CÁC PHẦN TỬ 1 ĐƠN VỊ
        public static MyArray operator --(MyArray arr)
        {
            for (int i = 0; i < arr.Arr.Length; i++)
            {
                arr.Arr[i] = arr.Arr[i] - 1;
            }
            return arr;
        }

        // C +(num) : cộng thêm các phần tử một số num
        public static MyArray operator +(MyArray arr,int num)
        { 
            for (int i = 0; i < arr.Arr.Length; i++)
            {
                arr.Arr[i] = arr.Arr[i] + num;
            }
            return arr;
        }

        // D -(num) : trừ các phần tử một số num
        public static MyArray operator -(MyArray arr, int num)
        {
            for (int i = 0; i < arr.Arr.Length; i++)
            {
                arr.Arr[i] = arr.Arr[i] - num;
            }
            return arr;
        }

        // E + hai mảng : 
        public static MyArray operator +(MyArray arr1, MyArray arr2)
        {
            int[] arr3 = new int[0];
            if (arr1.Arr.Length < arr2.Arr.Length)
            {
                arr3 = new int[arr2.Arr.Length];
                for (int i = 0; i < arr3.Length; i++)
                {
                    arr3[i] = arr1.Arr[i] + arr2.Arr[i];
                }
                
            }
            else
            {
                arr3 = new int[arr1.Arr.Length];
                for (int i = 0; i < arr3.Length; i++)
                {
                    arr3[i] = arr1.Arr[i] + arr2.Arr[i];
                }


            }
            MyArray myarr = new MyArray(arr3);
            return myarr;
        }

        // E * hai mảng : 
        public static int[,] operator *(MyArray arr1, MyArray arr2)
        {
            int[,] arr3 = new int[0,0];
            if (arr1.Arr.Length < arr2.Arr.Length)
            {
                arr3 = new int[arr1.Arr.Length, arr2.Arr.Length];
                for (int i = 0; i < arr1.Arr.Length; i++)
                {
                    for (int j = 0; j < arr2.Arr.Length; j++)
                    {
                        arr3[i, j] = arr1.Arr[i] * arr2.Arr[j];
                    }
                }

            }
            else
            {
                arr3 = new int[arr2.Arr.Length, arr1.Arr.Length];
                for (int i = 0; i < arr2.Arr.Length; i++)
                {
                    for (int j = 0; j < arr1.Arr.Length; j++)
                    {
                        arr3[i, j] = arr2.Arr[i] * arr1.Arr[j];
                    }
                }

            }
            
            return arr3;
        }

    }
}
