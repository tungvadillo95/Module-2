using System;
using System.Collections.Generic;

namespace StackReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array Integer
            Console.WriteLine("Reverse Array Integer...");
            int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            Stack<int> arrStack = new Stack<int>();
            Console.Write("Array before: ");
            PrintArrayInteger(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                arrStack.Push(arr[i]);
            }
            Console.Write("Reverse array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arrStack.Pop();
            }
            PrintArrayInteger(arr);
            Console.WriteLine();

            //Array String
            Console.WriteLine("Reverse Array String...");
            string str = "Hello World";
            Stack<string> strStack = new Stack<string>();
            Console.Write("Array before: "+str);
            Console.WriteLine();
            string[] words = str.Split(" ");
            for (int i = 0; i < words.Length; i++)
            {
                strStack.Push(words[i]);
            }
            Console.Write("Reverse array: ");
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = strStack.Pop();
                Console.Write(words[i]+" ");
            }
            Console.WriteLine();
        }
        static void PrintArrayInteger(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}, ");
            }
            Console.WriteLine();
        }
    }
}
