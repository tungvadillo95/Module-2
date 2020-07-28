using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Bai11_Json_2
{
    public class Data
    {
        public List<Product> products { get; set; }
        public double TotalMoney => Total_Money();
        public double Total_Money()
        {
            double total = 0;
            foreach(var product in products)
            {
                total += product.IntoMoney;
            }
            return total;
        }
    }
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
        public double IntoMoney => Into_Money();
        public string OtherDescriptions { get; set; }
        public double Into_Money()
        {
            return Price * Amount;
        }
        public override string ToString()
        {
            return $"{ID}\t{Name}\t\t{Manufacturer}\t\t{Price}\t\t{OtherDescriptions}\t\t\t\t{Amount}\t{IntoMoney}";
        }

    }
}
