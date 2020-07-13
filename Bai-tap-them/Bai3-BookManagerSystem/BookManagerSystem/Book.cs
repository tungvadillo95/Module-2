using System;
using System.Collections.Generic;
using System.Text;

namespace BookManagerSystem
{
    class Book : IBook
    {
        #region Property
        public int ID { get; set; }
        public string Name { get; set; }
        public string PublishDate { get; set; }
        public string Author { get; set; }
        public string Language { get; set; }
        public float AveragePrice = -1;
        #endregion
        #region Method
        public float GetAveragePrice()
        {
            return AveragePrice;
        }
        public void Display()
        {
            if (AveragePrice != -1)
            {
                Console.WriteLine($"Name: {Name}, Publish Date: {PublishDate}, Author: {Author}, Language: {Language}, Average Price: {AveragePrice}");
            }
            else
            {
                Console.WriteLine($"Name: {Name}, Publish Date: {PublishDate}, Author: {Author}, Language: {Language}");
            }
             
        }
        public const int LENGTH_PRICE_LIST= 5;
        public float[] PriceList = new float[LENGTH_PRICE_LIST];
        public void Calculate()
        {
            float sum = 0;
            for(int i = 0; i < PriceList.Length; i++)
            {
                sum += PriceList[i];
            }
            AveragePrice = sum / PriceList.Length;
        }
        #endregion
    }
}
