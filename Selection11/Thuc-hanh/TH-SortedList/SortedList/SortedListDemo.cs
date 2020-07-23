using System;
using System.Collections;

namespace SortedListDemo
{
    class SortedListDemo
    {
        static void Main(string[] args)
        {
            SortedList mySL = new SortedList();
            mySL.Add(2, "two");
            mySL.Add(1, "one");
            mySL.Add(3, "three");
            int myKey = 2;
            Console.WriteLine("The key \"{0}\" is {1}.", myKey, mySL.ContainsKey(myKey) ? "in the SortedList" : "NOT in the SortedList");
            myKey = 4;
            Console.WriteLine("The key \"{0}\" is {1}.", myKey, mySL.ContainsKey(myKey) ? "in the SortedList" : "NOT in the SortedList");
            string myValue = "one";
            Console.WriteLine("The value \"{0}\" is {1}.", myValue, mySL.ContainsValue(myValue) ? "in the SortedList" : "NOT in the SortedList");
            myValue = "nine";
            Console.WriteLine("The value \"{0}\" is {1}.", myValue, mySL.ContainsValue(myValue) ? "in the SortedList" : "NOT in the SortedList");
        }
    }
}
