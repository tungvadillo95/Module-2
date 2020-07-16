using System;

namespace ListBasic_2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList list = new MyLinkedList(10);
            list.AddFirst(11);
            list.AddFirst(12);
            list.AddFirst(13);
            list.Add(9, 4);
            list.Add(15, 4);
            list.PrintList();
            Console.WriteLine(list.GetData(4).Data);
            Console.WriteLine(list.GetData(5).Data);
        }
    }
}
