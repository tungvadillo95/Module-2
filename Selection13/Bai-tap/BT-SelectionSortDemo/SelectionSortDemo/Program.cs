using System;

namespace SelectionSortDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 4, 5, 2, 1 };
            Console.Write("Array before sort: ");
            PrintArr(arr);
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[min_idx])
                        min_idx = j;
                }
                int temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;
                Console.Write($"Sort {i + 1}: ");
                PrintArr(arr);
            }
            Console.Write("Array after sort: ");
            PrintArr(arr);
        }
        static void PrintArr(int[] arr)
        {
            foreach (int value in arr)
            {
                Console.Write(value + "\t");
            }
            Console.WriteLine("\n");
        }
    }
}
