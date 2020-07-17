using System;

namespace Bai_3
{
    class Program
    {
        public const int MIN = 20;
        public const int MAX = 60;
        public const int MULTIPLE_OF = 5;
        static void Main(string[] args)
        {
            string parametersRow = "rowsN";
            string parametersColumn = "columnM";
            Console.WriteLine("GENERATE MATRIX...");
            int row = GetMatrixParameters(parametersRow);
            int column = GetMatrixParameters(parametersColumn);
            int[,] matrix1 = GenerateMatrix(row, column);
            Console.WriteLine("Print Matrix...");
            PrintMatrix(matrix1);
            Console.WriteLine($"Displays a matrix of values that are multiples of {MULTIPLE_OF}");
            PrintMatrixMultiples(matrix1);
            Console.WriteLine("Create and Print Matrix A(swaps rows of old matrix columns)...");
            int[,] matrixA = SwapRowColumn(matrix1);
            PrintMatrix(matrixA);
        }
        public static int[,] SwapRowColumn(int[,] matrix)
        {
            int newRow = matrix.GetLength(1);
            int newColumn = matrix.GetLength(0);
            int[,] newMatrix = new int[newRow, newColumn];
            int indexRow = 0;
            int indexColumn = 0;
            for(int i = 0; i < newMatrix.GetLength(0); i++)
            {
                for(int j = 0; j < newMatrix.GetLength(1); j++)
                {
                    newMatrix[i, j] = matrix[indexRow, indexColumn];
                    indexRow++;
                }
                indexRow = 0;
                indexColumn++;
            }
            return newMatrix;
        }
        public static void PrintMatrixMultiples(int[,] matrix)
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(matrix[i,j]% MULTIPLE_OF == 0)
                    {
                        Console.Write($"{matrix[i, j]}\t");
                    }
                    else
                    {
                        Console.Write($"X\t");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public static int[,] GenerateMatrix(int rowN,int columnM)
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
        public static bool IsInterger(string number, out int value)
        {
            return Int32.TryParse(number, out value);
        }
        public static int GetMatrixParameters(string nameParameter)
        {
            string number;
            int value = 0;
            Console.Write($"Enter {nameParameter} in the square matrix: ");
            number = Console.ReadLine();
            while (!IsInterger(number, out value) || value <= 0)
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
