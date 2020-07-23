using System;

namespace InsertionSortDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 4, 5, 2, 1};
            Console.Write("Array before sort: ");
            PrintArr(arr);
            int newValue;
            for (int i = 1; i < arr.Length; i++)
            {
                newValue = arr[i];
                int j = i;
                while (j > 0 && arr[j - 1] > newValue)
                {
                    arr[j] = arr[j - 1];
                    j--;
                }
                arr[j] = newValue;
                Console.Write($"Sort {i}: ");
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
