using System;
using System.Threading;

namespace ThreadBasic
{
    class NumberGenerator
    {
        static void Main(string[] args)
        {
            var th1 = new Thread(Run);
            th1.Priority = ThreadPriority.Lowest;
            th1.Name = "ThreadOne";
            var th2 = new Thread(Run);
            th2.Priority = ThreadPriority.Highest;
            th2.Name = "ThreadTwo";
            th1.Start();
            th2.Start();
        }
        static void Run()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name}: {i}");
                Thread.Sleep(500);
            }
            Console.WriteLine($"{new NumberGenerator().GetHashCode()}");
        }
    }
}
