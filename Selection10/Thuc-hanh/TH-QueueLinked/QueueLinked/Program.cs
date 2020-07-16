using System;

namespace QueueLinked
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkedListQueue queue = new MyLinkedListQueue();
            queue.Enqueue(10);
            Console.WriteLine("Dequeued item is " + queue.Dequeue().key);
            queue.Enqueue(20);
            Console.WriteLine("Dequeued item is " + queue.Dequeue().key);
            queue.Dequeue();
            queue.Dequeue();
            //Console.WriteLine("Dequeued item is " + queue.Dequeue().key);
            //Console.WriteLine("Dequeued item is " + queue.Dequeue().key);
            queue.Enqueue(30);
            queue.Enqueue(40);
            queue.Enqueue(50);
            Console.WriteLine("Dequeued item is " + queue.Dequeue().key);
            Console.WriteLine("Dequeued item is " + queue.Dequeue().key);
            Console.WriteLine("Dequeued item is " + queue.Dequeue().key);
        }
    }
}
