using System;

namespace Bai1
{
    class Program
    {
        public const int MIN = 40;
        public const int MAX = 80;
        static void Main(string[] args)
        {
            Console.WriteLine("***---GENERATE MATRIX-- - ***");
            int size = CreateInteger("size Matrix", 2);
            int[,] matrix = CreateMatrix(size);
            Console.WriteLine("....Show matrix.....");
            ShowMatrix(matrix);
            Console.WriteLine($"Value MIN of matrix: {FindMin(matrix)}");
            Console.WriteLine($"Absolute value for main and sub diagonal difference: {DiagonalDifference(matrix)}");
        }
        static int CreateInteger(string str, int? min = null, int? max = null)
        {
            int num; bool result;
            Console.Write($"Enter {str}: ");
            result = int.TryParse(Console.ReadLine(), out num);
            if (min.HasValue)
            {
                if (max.HasValue)
                {
                    while (!result || num < min.Value || num > max.Value)
                    {
                        Console.WriteLine($"Enter again new {str} from {min.Value} to {max.Value}: ");
                        result = int.TryParse(Console.ReadLine(), out num);
                    }
                }
                else
                {
                    while (!result || num < min.Value)
                    {
                        Console.WriteLine($"Enter again new {str} greater than or equal to {min.Value}: ");
                        result = int.TryParse(Console.ReadLine(), out num);
                    }
                }
            }
            else
            {
                while (!result)
                {
                    Console.WriteLine($"Enter again new  {str}: ");
                    result = int.TryParse(Console.ReadLine(), out num);
                }
            }
            return num;
        }
        static int[,] CreateMatrix(int size)
        {
            int[,] matrix = new int[size, size];
            Random rd = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rd.Next(MIN, MAX);
                }
            }
            return matrix;
        }
        static void ShowMatrix(int[,] matrix)
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
        static int FindMin(int[,] matrix)
        {
            int min = matrix[0, 0];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                    }
                }
            }
            return min;
        }
        static int Sumdiagonal(int[,] matrix)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum += matrix[i, i];
            }
            return sum;
        }
        static int Sumdiagonalfiller(int[,] matrix)
        {
            int sum = 0;
            for (int i = 0, j = matrix.GetLength(0) - 1; i < matrix.GetLength(0); i++, j--)
            {
                sum += matrix[i, j];
            }
            return sum;
        }
        static int DiagonalDifference(int[,] matrix)
        {
            int diagonal = Sumdiagonal(matrix);
            int diagonalfiller = Sumdiagonalfiller(matrix);
            return Math.Abs(diagonal - diagonalfiller);
        }
    }
}
