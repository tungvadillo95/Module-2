using System;
using System.Collections.Generic;

namespace StringLargestLengthDemo
{
    class Program
    {
        static List<StringLargestLength> listLargestLength = new List<StringLargestLength>();
        static List<int> listInteger = new List<int>();
        static void Main(string[] args)
        {
            Console.WriteLine("Find consecutive series with the largest length...");
            Console.Write("Enter you string: ");
            string str = Console.ReadLine();
            StringPassInteger(str);
            SplitString();
            PrintStringLargestLength();
        }
        static void PrintStringLargestLength()
        {
            Console.Write("Result consecutive series with the largest length: ");
            if (listLargestLength.Count == 0)
            {
                for (int i = 0; i < listInteger.Count; i++)
                {
                    Console.Write($"{(char)listInteger[i]}");
                }
            }
            else
            {
                StringLargestLength maxLength = listLargestLength[0];
                foreach (StringLargestLength element in listLargestLength)
                {
                    if (element.CountLength() > maxLength.CountLength())
                    {
                        maxLength = element;
                    }
                }
                foreach (StringLargestLength element in listLargestLength)
                {
                    if (element.CountLength() == maxLength.CountLength())
                    {
                        for (int i = element.First; i <= element.Last; i++)
                        {
                            Console.Write($"{(char)listInteger[i]}");
                        }
                        Console.Write(", ");
                    }
                }
                Console.WriteLine();
            }
        }
        static void StringPassInteger(string str)
        {
            foreach (char element in str)
            {
                listInteger.Add((int)element);
            }
            Console.Write("The original string passed to the integer array: ");
            foreach (int element in listInteger)
            {
                Console.Write($"{element}, ");
            }
            Console.WriteLine();
        }
        static void SplitString()
        {
            int indexFirst = 0;
            int indexLast = listInteger.Count - 1;
            for (int i = 1; i < listInteger.Count; i++)
            {
                if (listInteger[i] >= listInteger[i - 1])
                {
                    indexLast = i;
                    if (i == listInteger.Count - 1)
                    {
                        StringLargestLength stringLargestLength = new StringLargestLength();
                        stringLargestLength.First = indexFirst;
                        stringLargestLength.Last = indexLast;
                        listLargestLength.Add(stringLargestLength);
                    }
                }
                else
                {
                    StringLargestLength stringLargestLength = new StringLargestLength();
                    stringLargestLength.First = indexFirst;
                    stringLargestLength.Last = indexLast;
                    listLargestLength.Add(stringLargestLength);
                    indexFirst = i;
                }
            }
        }
    }
}
