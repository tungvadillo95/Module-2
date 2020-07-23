using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsDemo
{
    public class GenericClass<T>
    {
        public static bool IsEqual(T value1, T value2)
        {
            if(value1.Equals(value2))
            {
                return true;
            }
            return false;
        }
        public void PrintResult(T value1, T value2)
        {
            bool result = IsEqual(value1, value2);
            if (result)
            {
                Console.WriteLine($"Result: {value1} equal {value2}");
            }
            else
            {
                Console.WriteLine($"Result: {value1} not equal {value2}");
            }
            Console.WriteLine();

        }
    }
}
