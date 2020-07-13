using System;

namespace RefacroringVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            string result;
            result = FizzBuzzDemo.FizzBuzz(number);
            Console.WriteLine($"Result: {result}");
        }
    }
    }
