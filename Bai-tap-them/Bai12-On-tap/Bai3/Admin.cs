using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3
{
    class Admin : Staff
    {
        public List<Staff> staffs { get; set; }
    }
    class Staff 
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        public string PassWord { get; set; }
        public List<Order> orders{ get; set; }
    }
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
            Console.WriteLine($"Status: {(Status? "Paid": "Unpaid")}");
            Console.WriteLine($"Customer name: {CustomerName}");
            Console.WriteLine($"Customer address: {CustomerAddress}");
            Console.WriteLine("ID\tName\t\t\tManufacturer\t\tPrice\t\tOtherDescriptions\t\tAmount\tIntoMoney");
            foreach(var product in products)
            {
                Console.WriteLine(product.ToString());
            }
            Console.WriteLine($"Total money: {TotalMoney}");
        }
    }
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
