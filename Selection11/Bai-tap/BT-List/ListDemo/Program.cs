using System;
using System.Collections.Generic;

namespace ListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> animal = new List<string>();
            animal.Add("lion");
            animal.Add("cat");
            animal.Add("dog");
            animal.Add("elephant");
            PrintList(animal);
            animal.Remove("dog");
            PrintList(animal);
            animal.Sort();
            PrintList(animal);
            Console.WriteLine($"Index \"cat\" in list: {animal.IndexOf("cat")} ");
        }
        public static void PrintList(List<string> nameList)
        {
            Console.WriteLine("Print List...");
            foreach (var element in nameList)
            {
                Console.Write($"{element}\t");
            }
            Console.WriteLine();
        }
    }
}
