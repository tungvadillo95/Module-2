using System;
using System.Collections.Generic;
using System.IO;

namespace ReadFileCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\ASUS\Desktop\BT-CODEGYM\Module-2\Selection15\Bai-tap\BT-ReadFileCSV\ReadFileCSV\country.csv";
            List<string> data = new List<string>();
            using (StreamReader sr = File.OpenText($"{path}"))
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
            string[,] matrixString = ConvertStringMatrix(data);
            Console.WriteLine("List Country.........");
            int indexColumnCountry = matrixString.GetLength(1) - 1;
            for(int i = 0; i < matrixString.GetLength(0); i++)
            {
                Console.Write($"{matrixString[i,indexColumnCountry]}, ");
            }
        }
        static string[,] ConvertStringMatrix(List<string> data)
        {
            string[] arrColumn = data[1].Split(",");
            string[,] matrixString = new string[data.Count, arrColumn.Length];
            for (int i = 0; i < data.Count; i++)
            {
                string[] arr = data[i].Split(",");
                for (int j = 0; j < arr.Length; j++)
                {
                    matrixString[i, j] = arr[j];
                }
            }
            return matrixString;
        }
    }
}
