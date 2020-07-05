using System;

namespace BT_them_phan_tu_mang
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeN;
            int index;
            int X;
            Console.WriteLine("Enter a size: ");
            sizeN = Int32.Parse(Console.ReadLine());
            int[] array = new int[sizeN];
            Console.WriteLine("Enter a index inserted: ");
            index = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter a value inserted: ");
            X = Int32.Parse(Console.ReadLine());
            if (index < 0 || index > array.Length)
            {
                Console.WriteLine("Enter Wrong!");
            }
            else
            {
                printArray(insertArray(array, index, X));
            }
        }
        public static int[] insertArray(int[] array, int index, int X)
        {
            int[] newArray = new int[array.Length + 1];
            for (int i = 0; i < newArray.Length; i++)
            {
                if (i < index)
                {
                    newArray[i] = array[i];
                }
                if (i > index)
                {
                    newArray[i] = array[i - 1];
                }
            }
            newArray[index] = X;
            return newArray;
        }
        public static void printArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ", ");
            }
        }
    }
}