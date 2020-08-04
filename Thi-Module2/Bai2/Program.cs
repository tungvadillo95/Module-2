using System;

namespace Bai2
{
    class Program
    {
        public const int MIN = 10;
        public const int MAX = 50;
        static int[] arr = new int[0];
        static void Main(string[] args)
        {
            string choice = "";
            while (choice != "5")
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Create Array.");
                Console.WriteLine("2. Check increment array.");
                Console.WriteLine("3. Sort array.");
                Console.WriteLine("4. Search array.");
                Console.WriteLine("5. Exit.");
                Console.WriteLine("Enter your choice: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Create Array...");
                        arr = Create_Print_Array();
                        break;
                    case "2":
                        Console.WriteLine("Check symmetric array...");
                        if (IsIncrement(arr))
                        {
                            Console.WriteLine("The array is increment!");
                        }
                        else
                        {
                            Console.WriteLine("The array is not increment!");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Sort array...");
                        if (IsEmptyArray(arr))
                        {
                            Console.WriteLine("The array is empty!");
                        }
                        else
                        {
                            Console.Write("Print array: ");
                            BubbleSort(arr);
                            PrintArray(arr);
                        }
                        break;
                    case "4":
                        Console.WriteLine("Search array...");
                        if (IsEmptyArray(arr))
                        {
                            Console.WriteLine("The array is empty!");
                        }
                        else
                        {
                            Console.Write("Enter value search: ");
                            string number = Console.ReadLine();
                            int value;
                            while (!Int32.TryParse(number, out value))
                            {
                                Console.Write("Enter again value search!: ");
                                number = Console.ReadLine();
                            }
                            Find(arr, value);
                        }
                        break;
                    case "5":
                        Console.WriteLine("Exit...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                }
            }
        }
        static void BubbleSort(int[] arr)
        {
            int i, j, temp;
            int n = arr.Length;
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
                if (swapped == false)
                    break;
            }
        }
        static void Find(int[] arr, int value)
        {
            if (IsCanSortUpArray(arr))
            {
                int[] newarr = SelectionSort(arr);
                int index = BinaraySearch(newarr, value);
                if (index != -1)
                {
                    Console.WriteLine($"Sort array: ");
                    PrintArray(newarr);
                    Console.WriteLine($"Result search: Value {value} is index {index} in array");
                }
                else
                {
                    Console.WriteLine("Result search: Value not in array");
                }
            }
            else
            {
                Console.WriteLine("This function is not available with this array!");
            }
        }
        static bool IsCanSortUpArray(int[] arr)
        {
            int[] arrA = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arrA[i] = arr[i];
            }
            int[] newarr = SelectionSort(arrA);
            for (int i = 1; i < newarr.Length; i++)
            {
                if (newarr[i] == newarr[i - 1])
                {
                    return false;
                }
            }
            return true;
        }
        static int BinaraySearch(int[] arr, int value)
        {
            int low = 0;
            int high = arr.Length - 1;
            while (high >= low)
            {
                int mid = (low + high) / 2;
                if (value < arr[mid])
                {
                    high = mid - 1;
                }
                else if (value == arr[mid])
                {
                    return mid;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return -1;
        }
        static bool IsEmptyArray(int[] arr)
        {
            if (arr.Length != 0)
            {
                return false;
            }
            return true;
        }
        static int[] SelectionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (arr[j] < arr[min_idx])
                        min_idx = j;
                int temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;
            }
            return arr;
        }
        static bool IsIncrement(int[] arr)
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] >= arr[i + 1])
                {
                    return false;
                }
            }
            return true;
        }
        static int[] Create_Print_Array()
        {
            Console.WriteLine("Enter size array");
            string number = Console.ReadLine();
            int size = 0;
            while (!Int32.TryParse(number, out size) || size <= 0)
            {
                Console.Write("Enter again size array!: ");
                number = Console.ReadLine();
            }
            int[] arr = new int[size];
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                arr[i] = rnd.Next(MIN, MAX);
            }
            Console.Write("Print Array: ");
            PrintArray(arr);
            return arr;
        }
        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}, ");
            }
            Console.WriteLine();
        }
    }
}
