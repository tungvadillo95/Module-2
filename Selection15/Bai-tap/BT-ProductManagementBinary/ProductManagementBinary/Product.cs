using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagementBinary
{
    class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public double Price { get; set; }
        public string OtherDescriptions { get; set; }
        public void Display()
        {
            Console.Write($"ID: {ID}, Name: {Name}, Manufacturer: {Manufacturer}, Price: {Price}, Other Descriptions: {OtherDescriptions}");
            Console.WriteLine();
        }
        public string DataProduct()
        {
            return $"ID: {ID}, Name: {Name}, Manufacturer: {Manufacturer}, Price: {Price}, Other Descriptions: {OtherDescriptions}";
        }
    }
}
