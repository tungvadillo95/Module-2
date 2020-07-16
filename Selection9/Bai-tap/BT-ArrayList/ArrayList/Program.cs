using System;

namespace ArrayLists
{
    class Program
    {
        public static MyList<int> myList = new MyList<int>();
        static void Main(string[] args)
        {
            myList.Add(9);
            myList.Add(21);
            myList.Add(13);
            myList.Add(56);
            myList.Add(97);
            for(int i = 0; i < myList.Items.Length; i++)
            {
                Console.Write($"{myList.Items[i]}\t");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Test Copy.................\n");
            var copyArr =myList.CopyTo(myList.Items);
            for (int i = 0; i < copyArr.Length; i++)
            {
                Console.Write($"{copyArr[i]}\t");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Test Contains.................\n");

            int number;
            Console.WriteLine("Enter number search: ");
            number = int.Parse(Console.ReadLine());
            if (myList.Contains(number))
            {
                Console.WriteLine($"Element {number} in array...");
            }
            else Console.WriteLine($"Element {number} not in array...");
        }
    }
}

