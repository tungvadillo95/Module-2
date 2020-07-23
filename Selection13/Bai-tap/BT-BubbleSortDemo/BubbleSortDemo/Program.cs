using System;
using System.Collections;

namespace BubbleSortDemo
{

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {3,4,5,2,1};
            Console.Write("Array before sort: ");
            PrintArr(arr);
            int n = arr.Length;
            int i, j, temp;
            bool swapped;
            for (i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }
                Console.Write($"Sort {i + 1}: ");
                PrintArr(arr);
                if (swapped == false)
                    break;
            }
            Console.Write("Array after sort: ");
            
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