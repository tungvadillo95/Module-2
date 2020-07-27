using System;

namespace PhoneManager
{
    class Program
    {
        public static PhoneBook phoneBook = new PhoneBook();
        static void Main(string[] args)
        {
            phoneBook.Show();
            byte choice = 8;
            string name, newPhone;
            while (choice != 0)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Add phone manager");
                Console.WriteLine("2. Update phone manager");
                Console.WriteLine("3. Remove phone manager");
                Console.WriteLine("4. Search phone manager");
                Console.WriteLine("5. Show phone manager");
                Console.WriteLine("6. Sort phone manager");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Enter your choice: ");
                choice = byte.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Add phone manager");
                        Console.Write("Enter name: ");
                        name = Console.ReadLine();
                        Console.Write("Enter phone number: ");
                        newPhone = Console.ReadLine();
                        phoneBook.InsertPhone(name, newPhone);
                        break;
                    case 2:
                        Console.WriteLine("Update phone manager");
                        Console.Write("Enter name: ");
                        name = Console.ReadLine();
                        Console.Write("Enter phone number: ");
                        newPhone = Console.ReadLine();
                        phoneBook.UpdatePhone(name, newPhone);
                        break;
                    case 3:
                        Console.WriteLine("Remove phone manager");
                        Console.Write("Enter name: ");
                        name = Console.ReadLine();
                        phoneBook.RemovePhone(name);
                        break;
                    case 4:
                        Console.WriteLine("Search phone manager");
                        Console.Write("Enter name: ");
                        name = Console.ReadLine();
                        phoneBook.SearchPhone(name);
                        break;
                    case 5:
                        phoneBook.Show();
                        break;
                    case 6:
                        phoneBook.Sort();
                        break;
                    case 0:
                        Console.WriteLine("Exit...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                }
            }
        }
    }
}
