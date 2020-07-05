using System;

namespace BT_gop_mang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creat Array 1");
            int[] arr1 = CreateArray();
            Console.WriteLine("Print Array 1");
            PrintArray(arr1);
            Console.WriteLine("Creat Array 2");
            int[] arr2 = CreateArray();
            Console.WriteLine("Print Array 2");
            PrintArray(arr2);
            int[] arr3 = SumArray(arr1, arr2);
            Console.WriteLine("Print Array 3 = Array1 + Array2");
            PrintArray(arr3);
        }
        public static int[] CreateArray()
        {
            int length;
            Console.WriteLine("Enter length array");
            length = Int32.Parse(Console.ReadLine());
            if (length > 0)
            {
                int[] arr = new int[length];
                for (int i = 0; i < length; i++)
                {
                    Console.WriteLine("Enter index value " + i);
                    arr[i] = Int32.Parse(Console.ReadLine());
                }
                return arr;
            }
            else
            {
                Console.WriteLine("Enter Wrong!");
                return null;
            }
        }
        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "  ");
            }
            Console.WriteLine();
        }
        public static int[] SumArray(int[] arr1, int[] arr2)
        {
            int[] sumArr = new int[arr1.Length + arr2.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                sumArr[i] = arr1[i];
            }
            int j = arr1.Length;
            for (int i = 0; i < arr2.Length; i++)
            {
                sumArr[j] = arr2[i];
                j++;
            }
            return sumArr;
        }
    }
}
