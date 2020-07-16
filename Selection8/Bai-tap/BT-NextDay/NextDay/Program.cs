using System;

namespace NextDayService
{
    class Program
    {
        static void Main(string[] args)
        {
            NextDay nextday = new NextDay();
            int date, month, year;
            Console.WriteLine("Calculate the next day...");
            Console.Write("Enter date: ");
            date = int.Parse(Console.ReadLine());
            while (date <= 0)
            {
                Console.Write("Enter again date: ");
                date = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter the month: ");
            month = int.Parse(Console.ReadLine());
            while (month <= 0)
            {
                Console.Write("Enter again the month: ");
                month = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter the year: ");
            year = int.Parse(Console.ReadLine());
            while (year <= 0)
            {
                Console.Write("Enter again the year: ");
                year = int.Parse(Console.ReadLine());
            }
            nextday.PrintNextDay(date,month,year);
        }
    }
}
