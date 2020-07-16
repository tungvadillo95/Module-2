using System;

namespace FizzBuzzService

{
    class Program
    {
        static void Main(string[] args)
        {
            byte number;
            Console.WriteLine("Enter number: ");
            number = byte.Parse(Console.ReadLine());
            FizzBuzzTranslate fizzBuzzTranslate = new FizzBuzzTranslate();
            Console.WriteLine(fizzBuzzTranslate.Traslate(number));
        }
    }
}
