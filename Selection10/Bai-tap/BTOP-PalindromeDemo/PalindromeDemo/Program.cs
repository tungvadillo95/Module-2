using System;
using System.Collections.Generic;

namespace PalindromeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check out the Palindrome string.....");
            Console.Write("Enter string: ");
            string str = Console.ReadLine();
            string strUpper = str.ToUpper();
            Queue<char> first_Half_String = new Queue<char>();
            Stack<char> last_Half_String = new Stack<char>();
            bool IsPalindrome = true;
            for (int i = 0; i < strUpper.Length / 2; i++)
            {
                first_Half_String.Enqueue(strUpper[i]);
            }
            for(int i = strUpper.Length/2; i < strUpper.Length; i++)
            {
                last_Half_String.Push(strUpper[i]);
            }
            for(int i = 0; i < strUpper.Length/2; i++)
            {
                char charQueue = first_Half_String.Dequeue();
                char charStack = last_Half_String.Pop();
                if (charQueue != charStack)
                {
                    IsPalindrome = false;
                }
            }
            if (IsPalindrome)
            {
                Console.WriteLine($"String {str} is Palindrome");
            }
            else
            {
                Console.WriteLine($"String {str} is not Palindrome");
            }
        }
    }
}
