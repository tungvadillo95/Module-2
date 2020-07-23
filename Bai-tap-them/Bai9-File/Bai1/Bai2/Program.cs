using System;
using System.Collections.Generic;
using System.IO;

namespace Bai2
{
    class Program
    {
        const int MIN = 10;
        const int MAX = 70;
        const int MUTIPLY_OF_VALUE = 5;
        static void Main(string[] args)
        {
            int row, column;
            Console.Write("Enter row: ");
            string strRow = Console.ReadLine();
            while (!IsInterger(strRow, out row) || row <= 2)
            {
                Console.Write("Enter again width in the square matrix!: ");
                strRow = Console.ReadLine();
            }
            Console.Write("Enter column: ");
            string strColumn = Console.ReadLine();
            while (!IsInterger(strColumn, out column) || column <= 2)
            {
                Console.Write("Enter again width in the square matrix!: ");
                strColumn = Console.ReadLine();
            }
            int[,] matrix = GenerateMatrix(row, column);
            var path = @"C:\Users\ASUS\Desktop\BT-CODEGYM\Module-2\Bai-tap-them\Bai9-File\Bai1\Bai2\Data";
            Directory.CreateDirectory(path);
            var fileInput = "data.txt";
            var fileOutput = "out.txt";
            using (StreamWriter sw = File.CreateText($@"{path}\{fileInput}"))
            {
                sw.WriteLine($"{row} {column}");
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        sw.Write($"{matrix[i, j]} ");
                    }
                    sw.WriteLine();
                }
            }
            List<string> data = new List<string>();
            Console.WriteLine("File Input..........");
            using (StreamReader sr = File.OpenText($@"{path}\{fileInput}"))
            {
                var line = string.Empty;
                int number = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    number++;
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
                int[,] newMatrix = ConvertMatrix(data,row,column);
                int countEvent = CountEven(newMatrix);
                sw.WriteLine($"The matrix have {countEvent} even.");
                int countMutiplyValue = CountMutiplyValue(newMatrix, MUTIPLY_OF_VALUE);
                sw.WriteLine($"The matrix have {countMutiplyValue} value multiple of {MUTIPLY_OF_VALUE}.");
            }
        }
        static bool IsInterger(string number, out int value)
        {
            return Int32.TryParse(number, out value);
        }
        static int CountMutiplyValue(int[,] matrix, int value)
        {
            int count = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % value == 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        static int CountEven(int[,] matrix)
        {
            int count = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        static int[,] ConvertMatrix(List<string> data,int row,int column)
        {
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
        static int[,] GenerateMatrix(int row,int column)
        {
            int[,] matrix = new int[row, column];
            Random rnd = new Random();
            for(int i = 0; i < row; i++)
            {
                for(int j = 0; j < column; j++)
                {
                    matrix[i, j] = rnd.Next(MIN, MAX);
                }
            }
            return matrix;
        }
    }
}
