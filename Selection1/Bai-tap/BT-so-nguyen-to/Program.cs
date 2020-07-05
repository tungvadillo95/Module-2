using System;

namespace BT_so_nguyen_to
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int n = 2;
            while (count != number)
            {
                int check = 0;
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        check++;
                    }
                }
                if (check == 2)
                {
                    count++;
                    Console.WriteLine("Prime number " + count + " is: " + n);
                }
                n++;
            }
        }
    }
}
