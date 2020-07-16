using System;
using System.Collections.Generic;
using System.Text;

namespace StackLinkedList
{
    class GenericStackClient
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Stack of integers");
            StackOfIntegers();
            Console.WriteLine("\n2. Stack of Strings");
            StackOfIStrings();
        }
        private static void StackOfIntegers()
        {
            MyGenericStack<Int32> stack = new MyGenericStack<Int32>();
            stack.Push(5);
            stack.Push(4);
            stack.Push(3);
            stack.Push(2);
            stack.Push(1);
            Console.WriteLine("1.1. Size of stack after push operations: " + stack.Size());
            Console.WriteLine("1.2. Pop elements from stack..");
            while (!stack.IsEmpty())
            {
                stack.Pop();
            }
            Console.WriteLine("\n1.3 Size of stack after pop operations : " + stack.Size());
        }

        private static void StackOfIStrings()
        {
            MyGenericStack<String> stack = new MyGenericStack<String>();
            stack.Push("Five");
            stack.Push("Four");
            stack.Push("Three");
            stack.Push("Two");
            stack.Push("One");
            Console.WriteLine("2.1 Size of stack after push operations: " + stack.Size());
            Console.WriteLine("2.2. Pop elements from stack..");
            while (!stack.IsEmpty())
            {
                stack.Pop();
            }
            Console.WriteLine("\n2.3. Size of stack after pop operations : " + stack.Size());
        }
    }
}
