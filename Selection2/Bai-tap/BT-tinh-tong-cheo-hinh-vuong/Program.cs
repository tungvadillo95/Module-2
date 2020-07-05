using System;

namespace BT_tinh_tong_cheo_hinh_vuong
{
    class Program
    {
        static void Main(string[] args)
        {
            int width;
            double max, min;
            Console.WriteLine("Enter width in the square matrix ");
            width = Int32.Parse(Console.ReadLine());
            if (width > 0)
            {
                Console.WriteLine("Enter value max in the square matrix ");
                max = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter value min in the square matrix ");
                min = double.Parse(Console.ReadLine());
                if (max > min)
                {
                    double[,] matrix = GenerateMatrix(width, max, min);
                    Console.WriteLine("The square matrix");
                    PrintMatrix(matrix);
                    MainDiagonal(matrix);
                    FillerDiagonal(matrix);
                }
                else
                {
                    Console.WriteLine("Enter max value and min value wrong!");
                }
            }
            else
            {
                Console.WriteLine("Enter width value wrong!");
            }
        }
        public static double[,] GenerateMatrix(int width, double max, double min)
        {
            double[,] matrix = new double[width, width];
            Random rnd = new Random();
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    matrix[i, j] = Math.Round((rnd.NextDouble() * (max - min) + min), 1);
                }
            }
            return matrix;
        }
        public static void MainDiagonal(double[,] matrix)
        {
            double sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum += matrix[i, i];
            }
            Console.WriteLine("Total sum main diagonal: " + sum);
        }
        public static void FillerDiagonal(double[,] matrix)
        {
            double sum = 0;
            int j = matrix.GetLength(1) - 1;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (j >= 0)
                {
                    sum += matrix[i, j];
                    j--;
                }
            }
            Math.Round(sum, 1);
            Console.WriteLine("Total sum filler diagonal: " + sum);
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
