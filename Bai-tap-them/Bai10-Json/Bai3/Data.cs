using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Bai3
{
    public class Data
    {
        public List<Table> tables { get; set; }
    }
    public class Table
    {
        public int ID { get; set; }
        public bool Status { get; set; }
        public List<Food> foods { get; set; }
        public double TotalMoney => Total_Money();
         public double Total_Money()
        {
            double total = 0;
            foreach(var food in foods)
            {
                total += food.IntoMoney;
            }
            return total;
        }

    }
    public class Food
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
        public double IntoMoney => Into_Money();
        public double Into_Money()
        {
            return Price * Amount;
        }
        public override string ToString()
        {
            return $"{Name}\t\t{Price}\t\t{Amount}\t\t{IntoMoney}";
        }

    }
}
