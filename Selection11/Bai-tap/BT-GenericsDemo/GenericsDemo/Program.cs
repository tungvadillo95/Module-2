using System;

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericClass<int> listInteger = new GenericClass<int>();
            GenericClass<string> listString = new GenericClass<string>();
            listInteger.PrintResult(5, 5);
            listInteger.PrintResult(4, 5);
            listString.PrintResult("one", "one");
            listString.PrintResult("one", "two");
        }
    }
}
