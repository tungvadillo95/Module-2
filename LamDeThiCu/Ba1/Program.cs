using System;

namespace Ba1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {3,5,6,4,6,8};
            string str = BinarySearch(arr, 6, 0, arr.Length);
            Console.WriteLine(str);
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
                            result += "**" + (mid + i);
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
                result = "Value does not exist in array!";
            else if (value < arr[mid])
            {
                return BinarySearch(arr, value, head, mid - 1);
            }
            else
                return BinarySearch(arr, value, mid + 1, rear);
            return result;
        }
        //static string BinarySearch(int[] arr, int x, int l, int r)
        //{
        //    int m = l / 2 + r / 2;
        //    string result = "";
        //    if (arr[m] == x)
        //    {
        //        int n = m;
        //        result += m;
        //        bool checkLeft = false;
        //        bool checkRight = false;
        //        int i = 1;
        //        while (true)
        //        {
        //            if ((m - i) >= 0 && (m - i) <= arr.Length - 1)
        //            {
        //                if (arr[m - i] == arr[m])
        //                {
        //                    result += "**" + (m - i);
        //                }
        //                else
        //                {
        //                    checkLeft = true;
        //                }
        //            }
        //            else
        //            {
        //                checkLeft = true;
        //            }
        //            if ((m + i) >= 0 && (m + i) <= arr.Length - 1)
        //            {
        //                if (arr[m + i] == arr[m])
        //                {
        //                    result += "**" + (m + i);
        //                }
        //                else
        //                {
        //                    checkRight = true;
        //                }
        //            }
        //            else
        //            {
        //                checkRight = true;
        //            }
        //            if (checkLeft && checkRight)
        //            {
        //                break;
        //            }
        //            i++;
        //        }
        //    }
        //    else if (l >= r)
        //        result = "no find or not sort yet";
        //    else if (x < arr[m])
        //    {
        //        return BinarySearch(arr, x, l, m - 1);
        //    }
        //    else
        //        return BinarySearch(arr, x, m + 1, r);
        //    return result;
        //}
    }
}
