using System;
using System.Collections.Generic;
using System.Text;

namespace NextDayService
{
    public class NextDay
    {
        public string PrintNextDay(int date, int month, int year)
        {
            int new_day=date;
            int new_month=month;
            int new_year=month;
            if (date < DayInMonth(month, year))
            {
                new_day = date + 1;
                Print(new_day, month, year);
            } 
            else if(date == DayInMonth(month, year))
            {
                new_day = 1;
                if (month < 12)
                {
                    new_month = month + 1;
                    Print(new_day, new_month, year);
                }
                else if(month == 12)
                {
                    new_month = 1;
                    new_year = year + 1;
                    Print(new_day, new_month, new_year);
                }
                else
                {
                    Console.WriteLine("Enter worng!");
                }
            }
            else
            {
                Console.WriteLine("Enter wrong!");
            }
            return $"{new_day}/{new_month}/{new_year}";
        }
        public static bool IsLeapYear(int year)
        {
            bool isDivisibleBy4 = year % 4 == 0;
            if (isDivisibleBy4)
            {
                bool isDivisibleBy100 = year % 100 == 0;
                if (isDivisibleBy100)
                {
                    bool isDivisibleBy400 = year % 400 == 0;
                    if (isDivisibleBy400)
                    {
                        return  true;
                    }
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
        public static byte DayInMonth(int month,int year)
        {
            byte day_is_month;
            switch (month)
            {
                case 2:
                    if (IsLeapYear(year))
                    {
                        day_is_month = 29;
                    }
                    else
                    {
                        day_is_month = 28;
                    }
                    break;
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    day_is_month = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    day_is_month = 30;
                    break;
                default:
                    day_is_month = 0;
                    break;
            }
            return day_is_month;
        }
        public static void Print(int date, int month, int year)
        {
            Console.WriteLine($"Tomorow(dd/mm/yyyy): {date}/{month}/{year}");
        }
    }
}
