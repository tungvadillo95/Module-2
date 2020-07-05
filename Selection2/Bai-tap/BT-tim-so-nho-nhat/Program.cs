using System;

namespace BT_tim_so_nho_nhat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creat array");
            int[] arr = CreateArray();
            Console.WriteLine("Print array");
            PrintArray(arr);
            int min = ResultMin(arr);
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
        public static int ResultMin(int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Min value in array is: " + min);
            return min;
        }
        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "  ");
            }
            Console.WriteLine();
        }
    }
}
