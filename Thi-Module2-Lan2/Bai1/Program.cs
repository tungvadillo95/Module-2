using System;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            string parametersRow = "rowsN";
            string parametersColumn = "columnM";
            Console.WriteLine("***--- GENERATE MATRIX ---***");
            int row = GetMatrixParameters(parametersRow);
            int column = GetMatrixParameters(parametersColumn);
            int[,] matrix = CreateMatrix(row, column);
            Console.WriteLine("...Print Matrix ...");
            PrintMatrix(matrix);
            int maxValue = FindMax(matrix);
            Console.WriteLine($"MAX value in matrix: {maxValue}");
            Console.WriteLine("... Show the bottom triangle ...");
            ShowMatrix(matrix);
        }
        public static void ShowMatrix(int[,] matrix)
        {
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
        public static int FindMax(int[,] matrix)
        {
            int max = matrix[0, 0];
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                    }
                }
            }
            return max;
        }
        public static int[,] CreateMatrix(int rowN, int columnM)
        {
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
            while(!int.TryParse(strMax, out max)|| max < min)
            {
                Console.Write("Enter again MAX value in matrix: ");
                strMax = Console.ReadLine();
            }
            int[,] matrix = new int[rowN, columnM];
            Random rnd = new Random();
            for (int i = 0; i < rowN; i++)
            {
                for (int j = 0; j < columnM; j++)
                {
                    matrix[i, j] = rnd.Next(min, max);
                }
            }
            return matrix;
        }
        public static int GetMatrixParameters(string nameParameter)
        {
            string number;
            int value = 0;
            Console.Write($"Enter {nameParameter} in the square matrix: ");
            number = Console.ReadLine();
            while (!int.TryParse(number, out value) || value <= 0)
            {
                Console.Write($"Enter again {nameParameter} in the square matrix!: ");
                number = Console.ReadLine();
            }
            return value;
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
