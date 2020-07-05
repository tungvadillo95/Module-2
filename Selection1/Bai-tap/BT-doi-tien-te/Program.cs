using System;

namespace BT_doi_tien_te
{
    class Program
    {
        static void Main(string[] args)
        {
            int rate = 23000;
            int moneyUSD;
            Console.WriteLine("Enter a money USD: ");
            moneyUSD = Convert.ToInt32(Console.ReadLine());
            if (moneyUSD > 0)
            {
                Console.WriteLine(moneyUSD + " USD equal:" + (rate * moneyUSD) + " VND");
            }
            else
            {
                Console.WriteLine("Enter Wrong!");
            }
        }
    }
}
