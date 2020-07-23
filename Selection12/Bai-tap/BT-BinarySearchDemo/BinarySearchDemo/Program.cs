using System;

namespace BinarySearchDemo
{
    class Program
    {
        static int[] list = { 2, 4, 7, 10, 11, 45, 50, 59, 60, 66, 69, 70, 79 };
        public static void Main(String[] args)
        {
            Console.WriteLine(BinarySearch(list, 0, 13, 4));
            Console.WriteLine(BinarySearch(list, 0, 13, 10));
            Console.WriteLine(BinarySearch(list, 0, 13, 22));
            Console.WriteLine(BinarySearch(list, 0, 13, 69));
            Console.WriteLine(BinarySearch(list, 0, 13, 79));
        }
        static int BinarySearch(int[] arr, int low, int high, int value)
        {
            if (high >= low)
            {
                int mid = (high + low) / 2; 
                if (arr[mid] == value)
                {
                    return mid;
                }
                if (arr[mid] > value)
                {
                    return BinarySearch(arr, low, mid - 1, value); 
                }
                return BinarySearch(arr, mid + 1, high, value);
            }
            return -1;
        }
    }
}
