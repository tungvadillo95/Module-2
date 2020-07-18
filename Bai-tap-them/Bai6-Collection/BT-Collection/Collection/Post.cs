using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    public class Post : IPost
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public float AverageRate { get; private set; }
        public const int MINRATING = 1;
        public const int MAXRATING = 5;
        public List<int> RateList = new List<int>();
        public void CalculatorRate()
        {
            float total = 0;
            foreach (var item in RateList)
            {
                total += item;
            }
            if (RateList.Count != 0)
            {
                AverageRate = (float)Math.Round(total / RateList.Count, 1);
            }
        }
        public void Display()
        {
            CalculatorRate();
            Console.WriteLine($"ID: {ID}, Title: {Title}, Content: {Content}, Author: {Author}, Count: {RateList.Count}, AverageRate: {AverageRate}");
        }
    }
}
