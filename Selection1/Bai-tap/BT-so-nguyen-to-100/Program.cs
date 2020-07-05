using System;

namespace BT_so_nguyen_to_100
{
    class Program
    {
        static void Main(string[] args)
        {
            int check = 0;
            Console.WriteLine("Danh sach so nguyen to :");
            for (int i = 2; i <= 100; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        check++;
                    }
                }

                if (check == 2)
                {
                    Console.WriteLine(i);
                }
                check = 0;
            }
        }
    }
}
