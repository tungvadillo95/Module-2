using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace Bai3
{
    class Program
    {
        static Admin admin = new Admin()
        {
            orders = new List<Order>()
        };
        const string FILE_PATH = @"C:\Users\ASUS\Desktop\BT-CODEGYM\Module-2\LamDeThiCu\Bai3";
        const string FILE_NAME_DATA = "database.json";
        static void Main(string[] args)
        {
            StartManagementOrder();
        }
        static void StartManagementOrder()
        {
            string choice = "";
            while (choice != "0")
            {
                SaveFileJson();
                Console.WriteLine("****....Management Order....****");
                Console.WriteLine("1. Creat order.");
                Console.WriteLine("2. Show all order.");
                Console.WriteLine("3. Search order.");
                Console.WriteLine("4. Set order status .");
                Console.WriteLine("5. Update order.");
                Console.WriteLine("0. Exit....");
                Console.Write("Enter you choice: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        CreatOrder();
                        break;
                    case "2":
                        ShowAllOrder();
                        break;
                    case "3":
                        SearchOrder();
                        break;
                    case "4":
                        SetOrderStatus();
                        break;
                    case "5":
                        UpdateOrder();
                        break;
                    case "0":
                        Console.WriteLine("****....EXIT....****");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                }
            }
        }
        static void SaveFileJson()
        {
            using (StreamWriter sw = File.CreateText($@"{FILE_PATH}\{FILE_NAME_DATA}"))
            {
                var data = JsonConvert.SerializeObject(admin);
                sw.Write(data);
            }
        }
        static void UpdateOrder()
        {
            Console.WriteLine("... Update order ...");
            Console.Write("Enter order ID: ");
            string orderID = Console.ReadLine();
            int check = 0;
            foreach (var order in admin.orders)
            {
                if (order.OrderID == orderID && order.Status == "Receive")
                {
                    StartUpdateOrder(order);
                }
            }
            if (check == 0)
            {
                Console.Write("Order ID does not exist or The order has been paid or canceled !. Press \"Enter\" to continue...");
                Console.ReadLine();
            }
        }
        static void StartUpdateOrder(Order order)
        {
            string choice = "";
            while (choice != "0")
            {
                Console.WriteLine("Do you want update?");
                Console.WriteLine("1. Customer name.");
                Console.WriteLine("2. Customer address.");
                Console.WriteLine("0. Exit....");
                Console.Write("Enter you choice: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Write("Enter new customer name: ");
                        string newCustomerName = Console.ReadLine();
                        order.CustomerName = newCustomerName;
                        break;
                    case "2":
                        Console.Write("Enter new customer address: ");
                        string newCustomerAddress = Console.ReadLine();
                        order.CustomerAddress = newCustomerAddress;
                        break;
                    case "0":
                        StartManagementOrder();
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                }
            }
        }
        static void SetOrderStatus()
        {
            Console.WriteLine("... Set order status ...");
            Console.Write("Enter order ID: ");
            string orderID = Console.ReadLine();
            int check = 0;
            foreach (var order in admin.orders)
            {
                if (order.OrderID == orderID)
                {
                    string newOrderStatus = GetOrderStatus();
                    order.Status = newOrderStatus;
                    check++;
                }
            }
            if (check == 0)
            {
                Console.Write("Order ID does not exist! Press \"Enter\" to continue...");
                Console.ReadLine();
            }
        }
        static string GetOrderStatus()
        {
            Console.Write("Set order status: P (Pain) or Orther (Cancel): ");
            string newOrderStatus = Console.ReadLine();
            if (newOrderStatus.ToUpper() == "P")
            {
                return "Pain";
            }
            else
            {
                return "Cancel";
            }
        }
        static void SearchOrder()
        {
            string choice = "";
            while (choice != "0")
            {
                Console.WriteLine("... Search order ...");
                Console.WriteLine("1. Search order by order ID.");
                Console.WriteLine("2. Search order by customer name.");
                Console.WriteLine("3. Search order by customer address.");
                Console.WriteLine("0. Exit....");
                Console.Write("Enter you choice: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        SearchOrderByOrderID();
                        break;
                    case "2":
                        SearchOrderByCustomerName();
                        break;
                    case "3":
                        SearchOrderByCustomerAddress();
                        break;
                    case "0":
                        StartManagementOrder();
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                }
            }
        }
        static void SearchOrderByOrderID()
        {
            Console.WriteLine("Search order by order ID...");
            Console.Write("Enter order ID: ");
            string orderID = Console.ReadLine();
            int check = 0;
            foreach (var order in admin.orders)
            {
                if (order.OrderID == orderID)
                {
                    order.Display();
                    check++;
                }
            }
            if (check == 0)
            {
                Console.Write("Order ID does not exist! Press \"Enter\" to continue...");
                Console.ReadLine();
            }
        }
        static void SearchOrderByCustomerAddress()
        {
            Console.WriteLine("Search order by customer address...");
            Console.Write("Enter customer address: ");
            string customerAddress = Console.ReadLine();
            int check = 0;
            foreach (var order in admin.orders)
            {
                if (order.CustomerAddress == customerAddress)
                {
                    order.Display();
                    check++;
                }
            }
            if (check == 0)
            {
                Console.Write("Customer address does not exist! Press \"Enter\" to continue...");
                Console.ReadLine();
            }
        }
        static void SearchOrderByCustomerName()
        {
            Console.WriteLine("Search order by customer name...");
            Console.Write("Enter customer name: ");
            string orderCustomerName = Console.ReadLine();
            int check = 0;
            foreach (var order in admin.orders)
            {
                if (order.CustomerName == orderCustomerName)
                {
                    order.Display();
                    check++;
                }
            }
            if (check == 0)
            {
                Console.Write("Customer name does not exist! Press \"Enter\" to continue...");
                Console.ReadLine();
            }
        }
        static void ShowAllOrder()
        {
            Console.WriteLine("... Show all order ...");
            foreach (var order in admin.orders)
            {
                order.Display();
            }
        }
        static void CreatOrder()
        {
            Console.WriteLine("... Creat order...");
            Console.Write("Enter order ID: ");
            string orderID = Console.ReadLine();
            string orderStatus = "Receive";
            Console.Write("Enter customer name: ");
            string customerName = Console.ReadLine();
            Console.Write("Enter customer address: ");
            string customerAddress = Console.ReadLine();
            Order order = new Order()
            {
                OrderID = orderID,
                Status = orderStatus,
                CustomerName = customerName,
                CustomerAddress = customerAddress
            };
            admin.orders.Add(order);
        }
    }
}
