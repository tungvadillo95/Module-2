using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Bai3
{
    class Order
    {
        public string OrderID { get; set; }
        public bool Status { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public List<Product> products { get; set; }
        public double TotalMoney => Total_Money();
        public double Total_Money()
        {
            double total = 0;
            foreach (var product in products)
            {
                total += product.IntoMoney;
            }
            return total;
        }
        public void Display()
        {
            Console.WriteLine($"Order ID: {OrderID}");
            Console.WriteLine($"Status: {(Status ? "Paid" : "Unpaid")}");
            Console.WriteLine($"Customer name: {CustomerName}");
            Console.WriteLine($"Customer address: {CustomerAddress}");
            Console.WriteLine("ID\tName\t\t\tManufacturer\t\tPrice\t\tOtherDescriptions\t\tAmount\tIntoMoney");
            foreach (var product in products)
            {
                Console.WriteLine(product.ToString());
            }
            Console.WriteLine($"Total money: {TotalMoney}");
        }
    }
}
