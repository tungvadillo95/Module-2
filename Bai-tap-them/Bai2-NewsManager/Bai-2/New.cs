using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_2
{
    public class New : INews
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string PublishDate { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public float AverageRate=-1;
        public New() 
        { 
        }
        public New(int id, string title, string publishDate, string author, string content,float averageRate)
        {
            this.ID = id;
            this.Title = title;
            this.PublishDate = publishDate;
            this.Author = author;
            this.Content = content;
            this.AverageRate = averageRate;
        }
        public float GetAverageRate()
        {
            return AverageRate;
        }
        public int[] RateList = new int[3];
        public void Display()
        {
            if (AverageRate!= -1)
            {
                Console.WriteLine($"Title: {Title}, PublishDate: {PublishDate}, Author: {Author}, Content: {Content}, AverageRate: {AverageRate}");
            }
            else
            {
                Console.WriteLine($"Title: {Title}, PublishDate: {PublishDate}, Author: {Author}, Content: {Content}");
            }

        }

        public void Calculate()
        {
            int sum = 0;
            for(int i = 0; i < RateList.Length; i++)
            {
                sum += RateList[i];
            }
            AverageRate = sum / RateList.Length;
        }
    }
}
