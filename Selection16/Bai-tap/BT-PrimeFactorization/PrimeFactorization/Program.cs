using System;
using System.Threading;

namespace PrimeFactorization
{
    class Program
    {
        static void Main(string[] args)
        {
            LazyPrimeFactorization lazyPrime = new LazyPrimeFactorization();
            var th1 = new Thread(lazyPrime.Run);
            th1.Name = "ThreadOne";
            OptimizedPrimeFactorization optimizedPrime = new OptimizedPrimeFactorization();
            var th2 = new Thread(optimizedPrime.Run);
            th2.Name = "ThreadTwo";
            th1.Start();
            th2.Start();
        }
    }
    class LazyPrimeFactorization
    {
        public void Run()
        {
            int dem = 0;
            for (int i = 2; i < 1000; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        dem++;
                    }
                }
                if (dem == 2)
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name}: {i}");
                }
                dem = 0;
            }
        }
    }
    class OptimizedPrimeFactorization
    {
        public void Run()
        {
            int dem = 0;
            for (int i = 2; i < 1000; i++)
            {
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        dem++;
                    }
                }
                if (dem == 0)
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name}: {i}");
                }
                dem = 0;
            }
        }
    }
}
