using System;

namespace BT_tinh_tong_cot
{
    class Program
    {
        static void Main(string[] args)
        {
            int row, col;
            double max, min;
            Console.WriteLine("Enter row in the array ");
            row = Int32.Parse(Console.ReadLine());
            if (row > 0)
            {
                Console.WriteLine("Enter column in the array ");
                col = Int32.Parse(Console.ReadLine());
                if (col > 0)
                {
                    Console.WriteLine("Enter value max in the array ");
                    max = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter value min in the array ");
                    min = double.Parse(Console.ReadLine());
                    if (max > min)
                    {
                        double[,] matrix = GenerateMatrix(row, col, max, min);
                        Console.WriteLine("The Array");
                        PrintMatrix(matrix);
                        sumColumnMatrix(matrix);

                    }
                    else
                    {
                        Console.WriteLine("Enter max value and min value wrong!");
                    }
                }
                else
                {
                    Console.WriteLine("Enter colum value wrong!");
                }
            }
            else
            {
                Console.WriteLine("Enter row value wrong!");
            }
        }
        public static double[,] GenerateMatrix(int row, int col, double max, double min)
        {
            double[,] matrix = new double[row, col];
            Random rnd = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = Math.Round((rnd.NextDouble() * (max - min) + min), 1);
                }
            }
            return matrix;
        }
        public static void sumColumnMatrix(double[,] matrix)
        {
            double sum = 0;
            int column;
            Console.WriteLine("Enter the column to sum");
            column = Int32.Parse(Console.ReadLine());
            if (column >= 0 && column < matrix.GetLength(1))
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    sum += matrix[i, column];
                }
                Math.Round(sum, 1);
                Console.WriteLine("The sum of the columns is: " + sum);
            }
            else
            {
                Console.WriteLine("Enter column worng!");
            }
        }
        public static void PrintMatrix(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
