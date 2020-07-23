using System;

namespace BinarySearchDemo
{
    class Program
    {
        static int[] list = { 2, 4, 7, 10, 11, 45, 50, 59, 60, 66, 69, 70, 79 };
        public static void Main(String[] args)
        {
            Console.WriteLine(BinarySearch(list, 2));
            Console.WriteLine(BinarySearch(list, 11));
            Console.WriteLine(BinarySearch(list, 79));
            Console.WriteLine(BinarySearch(list, 1));
            Console.WriteLine(BinarySearch(list, 45));
            Console.WriteLine(BinarySearch(list, 80));
        }
        static int BinarySearch(int[] list, int key)
        {
            int low = 0;
            int high = list.Length - 1;
            while (high >= low)
            {
                int mid = (low + high) / 2;
                if (key < list[mid])
                    high = mid - 1;
                else if (key == list[mid])
                    return mid;
                else
                    low = mid + 1;
            }
            return -1;
        }
    }
}
