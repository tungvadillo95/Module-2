using System;

namespace BT_xoa_phan_tu_mang
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthArr;
            int valueDel;
            Console.WriteLine("Enter a size: ");
            lengthArr = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter a value delete: ");
            valueDel = Int32.Parse(Console.ReadLine());
            printArray(deleteElement(creatArray(lengthArr), valueDel));
        }
        public static int[] creatArray(int lengthArr)
        {
            int[] arr = new int[lengthArr];
            for (int i = 0; i < lengthArr; i++)
            {
                Console.WriteLine("Enter a value index " + i + ": ");
                arr[i] = Int32.Parse(Console.ReadLine());
            }
            return arr;
        }
        public static int[] deleteElement(int[] arr, int valueDel)
        {
            int check = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == valueDel)
                {
                    check++;
                }
            }
            int[] newArr = new int[arr.Length - check];
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != valueDel)
                {
                    newArr[j] = arr[i];
                    j++;
                }
            }
            if (check == 0)
            {
                Console.WriteLine("Is value delete do not exist in array!");
            }
            return newArr;

        }
        public static void printArray(int[] array)
        {
            Console.WriteLine("Array: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
