using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3
{
    class Admin 
    { 
        public List<Order> orders { get; set; }
    }
    class Order
    {
        public string OrderID { get; set; }
        public string Status { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public void Display()
        {
            Console.WriteLine($"OrderID: {OrderID}, Status: {Status}, Customer Name: {CustomerName}, Customer Address: {CustomerAddress}");
        }
    }
}
