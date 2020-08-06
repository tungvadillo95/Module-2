using System;

namespace Bai2
{
    class Program
    {
        static int[] arr = new int[0];
        static void Main(string[] args)
        {
            string choice = "";
            while (choice != "5")
            {
                Console.WriteLine("***--- MENU ---***");
                Console.WriteLine("1. Create Array");
                Console.WriteLine("2. Check symmetric array");
                Console.WriteLine("3. Sort array");
                Console.WriteLine("4. Search array");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Enter your choice: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Create Array...");
                        arr = CreatePrintArray();
                        break;
                    case "2":
                        if (IsEmptyArray(arr))
                        {
                            Console.WriteLine("The array is empty!. Press\"Enter\" to continue......");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Check symmetric array...");
                            if (IsSymmetrycArray(arr))
                            {
                                Console.WriteLine("The array is symmetrical!");
                            }
                            else
                            {
                                Console.WriteLine("The array is not symmetrical!");
                            }
                        }
                        break;
                    case "3":
                        Console.WriteLine("Sort array...");
                        if (IsEmptyArray(arr))
                        {
                            Console.WriteLine("The array is empty!. Press\"Enter\" to continue......");
                            Console.ReadLine();
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
                            Console.WriteLine("The array is empty!. Press\"Enter\" to continue......");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.Write("Enter value search: ");
                            string number = Console.ReadLine();
                            int value;
                            while (!int.TryParse(number, out value))
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
        static void Find(int[] arr, int value)
        {
            if (IsIncrement(arr))
            {
                string stringIndex = BinarySearch(arr, value, 0, arr.Length - 1);
                if (stringIndex != "")
                {
                    PrintArray(arr);
                    Console.WriteLine($"Result search: Value {value} is index {stringIndex} in array");
                }
                else
                {
                    Console.WriteLine("Result search: Value not in array");
                }
            }
            else
            {
                Console.WriteLine("This function is not available with this array!. You should sort the array. Press\"Enter\" to continue......");
                Console.ReadLine();
            }
        }
        static bool IsIncrement(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    return false;
                }
            }
            return true;
        }
        static string BinarySearch(int[] arr, int value, int head, int rear)
        {
            int mid = head / 2 + rear / 2;
            string result = "";
            if (arr[mid] == value)
            {
                int index = mid;
                result += mid;
                bool checkLeft = false;
                bool checkRight = false;
                int i = 1;
                while (true)
                {
                    if ((mid - i) >= 0 && (mid - i) <= arr.Length - 1)
                    {
                        if (arr[mid - i] == arr[mid])
                        {
                            result += ", " + (mid - i);
                        }
                        else
                        {
                            checkLeft = true;
                        }
                    }
                    else
                    {
                        checkLeft = true;
                    }
                    if ((mid + i) >= 0 && (mid + i) <= arr.Length - 1)
                    {
                        if (arr[mid + i] == arr[mid])
                        {
                            result += ", " + (mid + i);
                        }
                        else
                        {
                            checkRight = true;
                        }
                    }
                    else
                    {
                        checkRight = true;
                    }
                    if (checkLeft && checkRight)
                    {
                        break;
                    }
                    i++;
                }
            }
            else if (head >= rear)
                result = "";
            else if (value < arr[mid])
            {
                return BinarySearch(arr, value, head, mid - 1);
            }
            else
                return BinarySearch(arr, value, mid + 1, rear);
            return result;
        }
        static bool IsEmptyArray(int[] arr)
        {
            if (arr.Length != 0)
            {
                return false;
            }
            return true;
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
        static bool IsSymmetrycArray(int[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                if (arr[i] != arr[arr.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
        static int[] CreatePrintArray()
        {
            Console.WriteLine("Enter size array");
            string number = Console.ReadLine();
            int size = 0;
            while (!int.TryParse(number, out size) || size <= 0)
            {
                Console.Write("Enter again size array!: ");
                number = Console.ReadLine();
            }
            int[] arr = new int[size];
            Console.Write("Enter MIN value in matrix: ");
            string strMin = Console.ReadLine();
            int min;
            while (!int.TryParse(strMin, out min))
            {
                Console.Write("Enter again MIN value in matrix: ");
                strMin = Console.ReadLine();
            }
            Console.Write("Enter MAX value in matrix: ");
            string strMax = Console.ReadLine();
            int max;
            while (!int.TryParse(strMax, out max) || max < min)
            {
                Console.Write("Enter again MAX value in matrix: ");
                strMax = Console.ReadLine();
            }
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                arr[i] = rnd.Next(min, max);
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
