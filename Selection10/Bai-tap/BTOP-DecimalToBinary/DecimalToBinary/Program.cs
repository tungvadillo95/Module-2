using System;
using System.Collections.Generic;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decimal To Binary...........");
            Console.WriteLine("Enter decimal value: ");
            string value = Console.ReadLine();
            int valueDecimal;
            Stack<int> list = new Stack<int>();
            while(!IsInteger(value,out valueDecimal)|| valueDecimal < 0)
            {
                Console.WriteLine("Enter again decimal value: ");
                value = Console.ReadLine();
            }
            while(valueDecimal / 2 > 0 )
            {
                list.Push(valueDecimal % 2);
                valueDecimal /= 2;
            }
            string result = valueDecimal.ToString();
            foreach (int element in list)
            {
                result += element.ToString();
            }
            Console.WriteLine($"Decimal value {valueDecimal} to Binary: {result}");
        }
        static bool IsInteger(string value, out int valueDecimal)
        {
            return Int32.TryParse(value, out valueDecimal);
        }
    }
}
