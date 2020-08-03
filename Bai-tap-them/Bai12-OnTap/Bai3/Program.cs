using System;
using System.Collections.Generic;

namespace Bai3
{
    class Program
    {
        static Admin admin = new Admin()
        {
            ID = "NO1",
            Name = "Jurgen Klopp",
            Position = "coach",
            Email = "123",
            PassWord = "123",
            staffs = new List<Staff>(),
            orders = new List<Order>(),
            menuProduct = new Dictionary<int, Product>()
        };
        static void Main(string[] args)
        {
            admin.GenerateMenuProduct();
            LoginUsingManagerment();
        }
        public static void LoginUsingManagerment()
        {
            string choice = "x";
            while (choice != "0")
            {
                Console.WriteLine("***---MANAGERMENT SOFTWARE---***");
                Console.WriteLine("1. Login account.");
                Console.WriteLine("0. Exit.");
                Console.Write("Enter you choice: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        LoginAdmin();
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
        static void LoginAdmin()
        {
            Console.WriteLine("---Login account---");
            Console.Write("Enter email: ");
            string email = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();
            if (admin.Email == email && admin.PassWord == password)
            {
                admin.AdminInterface();
            }
            else if (IsStaff(email, password))
            {
                foreach (var staff in admin.staffs)
                {
                    if (staff.Email == email && staff.PassWord == password)
                    {
                        staff.InterfaceStaff(staff, admin);
                    }
                }
            }
            else
            {
                Console.WriteLine("Username and password are not correct!");
                LoginUsingManagerment();
            }
        }
        static bool IsStaff(string email, string password)
        {
            foreach(var staff in admin.staffs)
            {
                if (staff.Email == email && staff.PassWord == password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
