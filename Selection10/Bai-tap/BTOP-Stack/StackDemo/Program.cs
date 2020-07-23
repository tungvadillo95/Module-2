using System;
using System.Collections.Generic;
namespace StackDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "(– b + (b^2 – 4*a*c)^(0.5/ 2*a))";
            Stack<char> bStack = new Stack<char>();
            Console.WriteLine("Hello World!");
            bool result =CheckBrackets(bStack, str);
            if (result)
            {
                Console.WriteLine($"True expression: {str}");
            }
            else
            {
                Console.WriteLine($"False expression: {str}");
            }
        }
        static bool CheckBrackets(Stack<char> bStack, string str)
        {
            foreach (char element in str)
            {
                if (element == '(')
                {
                    bStack.Push(element);
                }
                else if (element == ')')
                {
                    if (bStack.Count == 0)
                    {
                        return false;
                    }
                    char left = element;
                    char sym= bStack.Pop();
                    string check = sym.ToString() + left.ToString();
                    if (check != "()")
                    {
                        return false;
                    }
                }
            }
            if (bStack.Count == 0)
            {
                return true;
            }
            return false;
        }
    }
}
