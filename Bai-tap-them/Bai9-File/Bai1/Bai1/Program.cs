using System;
using System.Collections.Generic;
using System.IO;

namespace Bai1
{
    class Program
    {
        const int VALUE_MUTIPLY = 3;
        static void Main(string[] args)
        {
            var path = @"C:\Users\ASUS\Desktop\BT-CODEGYM\Module-2\Bai-tap-them\Bai9-File\Bai1\Bai1\Data";
            var fileInput = "InPut.txt";
            var fileOutput = "OutPut.txt";
            List<string> data = new List<string>();
            Console.WriteLine("File Input..........");
            using (StreamReader sr = File.OpenText($@"{path}\{fileInput}"))
            {
                var line = string.Empty;
                int number = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    number ++;
                    Console.WriteLine($"Line {number}\t: {line}");
                    data.Add($"{line}");
                }
            }
            using (StreamWriter sw = File.CreateText($@"{path}\{fileOutput}"))
            {
                sw.WriteLine("File Output...........");
                int number = 1;
                for (int i = 1; i < data.Count; i++)
                {
                    sw.WriteLine($"Line {number} : {data[i]}");
                    number++;
                }
                int[,] matrix = ConvertMatrix(data);
                int sumMatrix = SumMatrix(matrix);
                sw.WriteLine($"Sum Matrix: {sumMatrix}");
                int countPrime = CountPrime(matrix);
                sw.WriteLine($"The matrix have {countPrime} prime.");
                int countOdd = CountOdd(matrix);
                sw.WriteLine($"The matrix have {countOdd} odd.");
                int sumBorderlineMatrix = SumBorderLineMatrix(matrix);
                sw.WriteLine($"Total matrix boundary value: {sumBorderlineMatrix}");
                int[,] newMatrix = MultiplyValueMatrix(matrix, VALUE_MUTIPLY);
                sw.WriteLine($"New Matrix Mutiply {VALUE_MUTIPLY}");
                PrintMatrix(newMatrix, sw);
            }
        }
        static void PrintMatrix(int[,] matrix, StreamWriter sw)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sw.Write($"{matrix[i, j]}\t");
                }
                sw.WriteLine();
            }
        }
        static int[,] MultiplyValueMatrix(int[,] matrix, int multiplyValue)
        {
            int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    newMatrix[i, j] = matrix[i, j] * multiplyValue;
                }
            }
            return newMatrix;
        }
        static int SumBorderLineMatrix(int[,] matrix)
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
            return sum;
        }
        static int CountOdd(int[,] matrix)
        {
            int count = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        static int CountPrime(int[,] matrix)
        {
            int count = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(IsPrime(matrix[i, j]))
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }
            else
            {
                int i = 2;
                while (i <= Math.Sqrt(number))
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                    i++;
                }
            }
            return true;
        }     
        static int SumMatrix(int[,] matrix)
        {
            int sum = 0;
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }
            }
            return sum;
        }
        static int[,] ConvertMatrix(List<string> data)
        {
            string[] arrRowColumn = data[0].Split(" ");
            int row = int.Parse(arrRowColumn[0]);
            int column = int.Parse(arrRowColumn[1]);
            int[,] matrix = new int[row, column];
            int index_Row_Matrix = 0;
            for (int i = 1; i < data.Count; i++)
            {
                string[] arr = data[i].Split(" ");
                for (int index_Column_Matrix = 0; index_Column_Matrix < matrix.GetLength(1); index_Column_Matrix++)
                {
                    matrix[index_Row_Matrix, index_Column_Matrix] = int.Parse(arr[index_Column_Matrix]);
                }
                index_Row_Matrix++;
            }
            return matrix;
        }
    }
}
