using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ProductManagementBinary
{
    class Program
    {
        static List<Product> listProduct = new List<Product>();
        const string PATH = @"C:\Users\ASUS\Desktop\BT-CODEGYM\Module-2\Selection15\Bai-tap\BT-ProductManagementBinary\ProductManagementBinary\dataproduct.bin";
        static void Main(string[] args)
        {
            string choice = "4";
            while (choice != "0")
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Generate product.");
                Console.WriteLine("2. Print list product.");
                Console.WriteLine("3. Search product.");
                Console.WriteLine("0. Exit.");
                Console.WriteLine("Enter you choice: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Generate product......");
                        AddProduct();
                        break;
                    case "2":
                        Console.WriteLine("Print list product......");
                        PrintListProduct();
                        break;
                    case "3":
                        Console.WriteLine("Search product by ID......");
                        Console.WriteLine("Enter ID: ");
                        int id = int.Parse(Console.ReadLine());
                        FindProductByID(id);
                        break;
                    case "0":
                        Console.WriteLine("Exit...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                }
            }
        }
        static void BinaryFileApplication(Product product)
        {
            BinaryWriter bw;
            BinaryReader br;
            int id = product.ID;
            string name = product.Name;
            string manufacturer = product.Manufacturer;
            double price = product.Price;
            string otherDescriptions = product.OtherDescriptions;
            try
            {
                bw = new BinaryWriter(new FileStream(PATH, FileMode.Append));
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot create file.");
                return;
            }
            try
            {
                bw.Write(id);
                bw.Write(name);
                bw.Write(manufacturer);
                bw.Write(price);
                bw.Write(otherDescriptions);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot write to file.");
                return;
            }
            bw.Close();
        }
        static void AddProduct()
        {
            Product product = new Product();
            Console.WriteLine("Enter ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Manufacturer: ");
            string manufacturer = Console.ReadLine();
            Console.WriteLine("Enter Price: ");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Other Descriptions: ");
            string otherDescriptions = Console.ReadLine();
            product.ID = id;
            product.Name = name;
            product.Manufacturer = manufacturer;
            product.Price = price;
            product.OtherDescriptions = otherDescriptions;
            BinaryFileApplication(product);
            listProduct.Add(product);

        }
        static void PrintListProduct()
        {
            foreach(Product product in listProduct)
            {
                product.Display();
                List<string> dataProduct = new List<string>();
                dataProduct.Add(product.DataProduct());
            }
        }
        static void FindProductByID(int id)
        {
            foreach (Product product in listProduct)
            {
                if (product.ID == id)
                {
                    product.Display();
                }
                else
                {
                    Console.WriteLine("Not available!");
                }
            }
        }
    }
}
