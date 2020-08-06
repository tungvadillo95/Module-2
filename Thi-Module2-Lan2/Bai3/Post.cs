using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3
{
    class Post : IPost
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public float AverageRate { get; private set; }
        public int[] Rates = new int[4];
        public void CalculatorRate()
        {
            float total = 0;
            foreach (var rate in Rates)
            {
                total += rate;
            }
            if (Rates.Length != 0)
            {
                AverageRate = (float)Math.Round(total / Rates.Length, 1);
            }
        }
        public void Display()
        {
            Console.WriteLine($"ID: {ID}, Title: {Title}, Content: {Content}, Author: {Author}, AverageRate: {AverageRate}");
        }
    }
}
