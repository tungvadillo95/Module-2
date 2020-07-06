using System;

namespace BT_tim_so_lon_nhat
{
    class Program
    {
        static void Main(string[] args)
        {
            int row;
            int column;
            double[,] arr;
            double max;
            Console.WriteLine("Enter row number");
            row = Int32.Parse(Console.ReadLine());
            if (row > 0)
            {
                Console.WriteLine("Enter column number");
                column = Int32.Parse(Console.ReadLine());
                if (column > 0)
                {
                    arr = CreateArray(row, column);
                    PrintArray(arr);
                    max = ResultMax(arr);
                    Console.WriteLine("Coordinates Max :");
                    CoordinatesMax(max, arr);
                }
                else
                {
                    Console.WriteLine("Enter Wrong!");
                }
            }
            else
            {
                Console.WriteLine("Enter Wrong!");
            }
        }
        public static double[,] CreateArray(int row, int column)
        {
            double[,] arr = new double[row, column];
            double value;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.WriteLine("Enter coordinates value x" + j + "y" + i);
                    value = double.Parse(Console.ReadLine());
                    arr[j, i] = value;
                }
            }
            return arr;
        }
        public static double ResultMax(double[,] arr)
        {
            double max = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (max < arr[i, j])
                    {
                        max = arr[i, j];
                    }
                }
            }
            Console.WriteLine("Max value is: " + max);
            return max;
        }
        public static void CoordinatesMax(double max, double[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (max == arr[i, j])
                    {
                        Console.WriteLine("X= " + j + " Y= " + i);
                    }
                }
            }
        }
        public static void PrintArray(double[,] arr)
        {
            Console.WriteLine("Print array");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
