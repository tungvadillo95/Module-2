using System;
using ProductManagement;

namespace ManagerMenu
{
    class Program
    {
        public static ProductService ProductService = new ProductService();
        static void Main(string[] args)
        {
            byte choice = 5;
            while (choice != 0)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Add product manager");
                Console.WriteLine("2. Edit product manager");
                Console.WriteLine("3. Delete product manager");
                Console.WriteLine("4. Show product manager");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Enter your choice: ");
                choice = byte.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Add product manager");
                        CreateProduct();
                        break;
                    case 2:
                        Console.WriteLine("Edit product manager");
                        EditProduct();
                        break;
                    case 3:
                        Console.WriteLine("Delete product manager");
                        RemoveProduct();
                        break;
                    case 4:
                        Console.WriteLine("Show product manager");
                        ProductService.Show();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                }
            }
        }
        public static void CreateProduct()
        {
            var product = new Product();
            Console.WriteLine("Product name: ");
            product.name = Console.ReadLine();
            Console.Write("Product Code: ");
            product.code = Console.ReadLine();
            Console.Write("Price: ");
            product.price = double.Parse(Console.ReadLine());
            Console.Write("Product date(yyyy/mm/dd): ");
            product.date = DateTime.Parse(Console.ReadLine());
            Console.Write("Made in: ");
            product.madein = Console.ReadLine();
            ProductService.Add(product);
        }
        public static void RemoveProduct()
        {
            Console.Write("Enter code want delete: ");
            string code = Console.ReadLine();
            ProductService.Delete(code);
        }
        public static void EditProduct()
        {
            var product = new Product();
            Console.Write("Product name: ");
            product.name = Console.ReadLine();
            Console.Write("Product code: ");
            product.code = Console.ReadLine();
            Console.Write("Product price: ");
            product.price = double.Parse(Console.ReadLine());
            Console.Write("Product date(yyyy/mm/dd): ");
            product.date = DateTime.Parse(Console.ReadLine());
            Console.Write("Product made in: ");
            product.madein = (Console.ReadLine());
            ProductService.Edit(product);
            // Console.WriteLine("Enter code product: ");
            // var code = Console.ReadLine();
            // ProductService.Edit(code);
        }
    }
}
