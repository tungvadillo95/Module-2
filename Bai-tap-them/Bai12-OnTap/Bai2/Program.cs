using System;

namespace Bai2
{
    class Program
    {
        public const int MIN = 10;
        public const int MAX = 50;
        static void Main(string[] args)
        {
            string parametersRowA = "rowsN";
            string parametersColumnA = "columnM";
            Console.WriteLine("GENERATE MATRIX...");
            int rowA = GetMatrixParameters(parametersRowA);
            int columnA = GetMatrixParameters(parametersColumnA);
            int[,] matrixA = GenerateMatrix(rowA, columnA);
            Console.WriteLine("Print Matrix A ...");
            ShowMatrix(matrixA);
            Console.ReadKey();
            string parametersColumnB = "column Matrix B (M x K)";
            int columnB = GetMatrixParameters(parametersColumnB);
            int[,] matrixB = GenerateMatrix(columnA, columnB);
            Console.WriteLine("Print Matrix B ...");
            ShowMatrix(matrixB);
            Console.WriteLine("Print Matrix C = A x B ...");
            int[,] matrixC = MultipleMatrix(matrixA, matrixB);
            ShowMatrix(matrixC);
        }
        public static int[,] MultipleMatrix(int[,] matrixA, int[,] matrixB)
        {
            int[,] matrixMultiple = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
            for(int i = 0; i < matrixA.GetLength(0); i++)
            {
                for(int j = 0; j < matrixB.GetLength(1); j++)
                {
                    int sum = 0;
                    for(int m = 0; m < matrixA.GetLength(1); m++)
                    {
                        sum += matrixA[i, m] * matrixB[m, j];
                    }
                    matrixMultiple[i, j] = sum;
                }
            }
            return matrixMultiple;
        }
        public static int GetMatrixParameters(string nameParameter)
        {
            string number;
            int value;
            Console.Write($"Enter {nameParameter} in the square matrix: ");
            number = Console.ReadLine();
            while (!Int32.TryParse(number, out value) || value <= 0)
            {
                Console.Write($"Enter again {nameParameter} in the square matrix!: ");
                number = Console.ReadLine();
            }
            return value;
        }
        public static int[,] GenerateMatrix(int rowN, int columnM)
        {
            int[,] matrix = new int[rowN, columnM];
            Random rnd = new Random();
            for (int i = 0; i < rowN; i++)
            {
                for (int j = 0; j < columnM; j++)
                {
                    matrix[i, j] = rnd.Next(MIN, MAX);
                }
            }
            return matrix;
        }
        public static void ShowMatrix(int[,] matrix)
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
