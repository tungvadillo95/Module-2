using System;

namespace InsertionSortDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 11, 13,11, 5, 6 };
            InsertionSort(arr);
            PrintArray(arr);
        }
        static void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }
        static void PrintArray(int[] arr)
        {
            int i;
            for (i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
    }
}
