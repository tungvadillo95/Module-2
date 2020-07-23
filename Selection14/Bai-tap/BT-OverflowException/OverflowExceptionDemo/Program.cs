using System;

namespace OverflowExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                try
                {
                    int number1 = 99999999;
                    int number2 = 999999999;
                    int result = number1 * number2;

                }
                catch (OverflowException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
