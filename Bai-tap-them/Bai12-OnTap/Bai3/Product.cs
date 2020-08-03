using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Bai3
{
    class Product
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
