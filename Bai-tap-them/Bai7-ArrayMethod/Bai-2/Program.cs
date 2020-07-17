using System;

namespace Bai_2
{
    class Program
    {
        public const int MIN = 10;
        public const int MAX = 40;
        static void Main(string[] args)
        {
            Console.WriteLine("GENERATE MATRIX.......");
            string number;
            int width = 0;
            Console.Write("Enter width in the square matrix: ");
            number = Console.ReadLine();
            while (!IsInterger(number, out width) || width <= 0)
            {
                Console.Write("Enter again width in the square matrix!: ");
                number = Console.ReadLine();
            }
            Console.WriteLine("Matrix 1:............");
            int[,] matrix1 = GenerateMatrix(width);
            PrintMatrix(matrix1);
            Console.WriteLine("Matrix 2:............");
            int[,] matrix2 = GenerateMatrix(width);
            PrintMatrix(matrix2);
            Console.WriteLine("SUM Matrix1,Matrix2....");
            PrintMatrix(SumMatrix(matrix1, matrix2));
            Console.WriteLine("MULTIPLICATION Matrix1,Matrix2....");
            PrintMatrix(MultiplicationMatrix(matrix1, matrix2));
        }
        public static int[,] MultiplicationMatrix(int[,] matrix1, int[,] matrix2)
        {
            int[,] result = GenerateMatrix(matrix1.GetLength(0));
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i, j] = matrix1[i, j] * matrix2[i, j];
                }
            }
            return result;
        }
        public static int[,] SumMatrix(int[,] matrix1, int[,] matrix2)
        {
            int[,] result = GenerateMatrix(matrix1.GetLength(0));
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return result;
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
    }
}
