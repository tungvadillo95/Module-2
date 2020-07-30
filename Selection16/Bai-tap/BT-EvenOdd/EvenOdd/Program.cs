using System;
using System.Threading;

namespace EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            OddThread oddThread = new OddThread();
            var th1 = new Thread(oddThread.Run);
            th1.Name = "ThreadOne";
            EvenThread evenThread = new EvenThread();
            var th2 = new Thread(evenThread.Run);
            th2.Name = "ThreadTwo";
            th1.Start();
            th1.Join();
            th2.Start();
        }
    }
    class OddThread
    {
        public void Run()
        {
            for(int i = 1; i <= 10; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name}: {i}");
                    Thread.Sleep(10);
                }
            }
        }
    }
    class EvenThread
    {
        public void Run()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name}: {i}");
                    Thread.Sleep(15);
                }
            }
        }

    }
}
