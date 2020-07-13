using System;

namespace Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creat Math Operand... ");
            NewMathOperator();
        }
        public static void NewMathOperator()
        {
            int firstOperand;
            int secondOperand;
            char mathOperator;
            Console.Write("Enter first operand: ");
            firstOperand = int.Parse(Console.ReadLine());
            Console.Write("Enter second operand: ");
            secondOperand = int.Parse(Console.ReadLine());
            Console.Write("Enter math operator: ");
            mathOperator = char.Parse(Console.ReadLine());
            int result = Calculator.Calculate(firstOperand, secondOperand, mathOperator);
            Console.WriteLine($"Math operator: {firstOperand} {mathOperator} {secondOperand} = {result}");

        }
    }
}
