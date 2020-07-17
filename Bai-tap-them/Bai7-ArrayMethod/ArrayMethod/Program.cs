using System;

namespace ArrayMethod
{
    class Program
    {
        public const int MIN = 10;
        public const int MAX = 90;
        static void Main(string[] args)
        {
            string number;
            int width = 0;
            Console.WriteLine("GENERATE MATRIX...");
            Console.Write("Enter width in the square matrix: ");
            number = Console.ReadLine();
            while (!IsInterger(number, out width) || width <= 0)
            {
                Console.Write("Enter again width in the square matrix!: ");
                number = Console.ReadLine();
            }
            int[,] matrix = GenerateMatrix(width);
            Console.WriteLine("Print Matrix...........");
            PrintMatrix(matrix);
            SumEvenMatrix(matrix);
            SumMainDiagonal(matrix);
            SumFillerDiagonal(matrix);
            SumBorderlineMatrix(matrix);
            PrintSquardBottonLeft(matrix);
            PrintSquardTopLeft(matrix);
            PrintSquardBottonRight(matrix);
            PrintSquardTopRight(matrix);
        }
        public static bool IsInterger(string number, out int width)
        {
            return Int32.TryParse(number, out width);
        }
        public static int[,] GenerateMatrix(int width)
        {
            int[,] matrix = new int[width, width];
            Random rnd = new Random();
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    matrix[i, j] = rnd.Next(MIN, MAX);
                }
            }
            return matrix;
        }
        public static void SumEvenMatrix(int[,] matrix)
        {
            int sumEven = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        sumEven += matrix[i, j];
                    }
                }
            }
            Console.WriteLine($"Total sum of even numbers in the matrix: {sumEven}");
        }
        public static void SumMainDiagonal(int[,] matrix)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum += matrix[i, i];
            }
            Console.WriteLine("Total sum main diagonal: " + sum);
        }
        public static void SumFillerDiagonal(int[,] matrix)
        {
            int sum = 0;
            int j = matrix.GetLength(1) - 1;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (j >= 0)
                {
                    sum += matrix[i, j];
                    j--;
                }
            }
            Console.WriteLine("Total sum filler diagonal: " + sum);
        }
        public static void SumBorderlineMatrix(int[,] matrix)
        {
            int sum = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                sum += matrix[0, j];
            }
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                sum += matrix[matrix.GetLength(0) - 1, j];
            }
            for (int i = 1; i < matrix.GetLength(0) - 1; i++)
            {
                sum += matrix[i, 0];
            }
            for (int i = 1; i < matrix.GetLength(0) - 1; i++)
            {
                sum += matrix[i, matrix.GetLength(1) - 1];
            }
            Console.WriteLine("Total sum of value on the boundary: " + sum);
        }
        public static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public static void PrintSquardBottonLeft(int[,] matrix)
        {
            Console.WriteLine("The corner is square at botton-left...");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public static void PrintSquardTopLeft(int[,] matrix)
        {
            Console.WriteLine("The corner is square at top-left...");
            int count = matrix.GetLength(1);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < count; j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                --count;
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public static void PrintSquardBottonRight(int[,] matrix)
        {
            Console.WriteLine("The corner is square at botton-left...");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = matrix.GetLength(1) - 1; j > i; j--)
                {
                    Console.Write("\t");
                }
                for (int k = i; k >= 0; k--)
                {
                    Console.Write($"{matrix[i, matrix.GetLength(1) - 1 - k]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public static void PrintSquardTopRight(int[,] matrix)
        {
            Console.WriteLine("The corner is square at top-left...");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("\t");
                }
                for (int k = i; k < matrix.GetLength(1); k++)
                {
                    Console.Write($"{matrix[i, k]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
