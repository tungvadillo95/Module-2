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
        public static int COUNT = 3;
        public int MINRATING = 1;
        public int MAXRATING = 5;
        public int[] RateList = new int[COUNT];
        public void CalculatorRate()
        {
            float total = 0;
            foreach (var item in RateList)
            {
                total += item;
            }
            AverageRate =(float)Math.Round(total / RateList.Length, 1);
        }
        public void Display()
        {
            CalculatorRate();
            Console.WriteLine($"ID: {ID}, Title: {Title}, Content: {Content}, Author: {Author}, Count: {COUNT}, AverageRate: {AverageRate}");
        }
    }
}
