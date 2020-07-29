using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Bai11_Json_2
{
    class Program
    {
        static Dictionary<int, Product> menuProduct = new Dictionary<int, Product>();
        static Data data = new Data()
        {
            products = new List<Product>()
        };
        const string FILE_BILL_PATH = @"C:\Users\ASUS\Desktop\BT-CODEGYM\Module-2\Bai-tap-them\Bai11-Json-2\Bai11-Json-2\bill";

        static void Main(string[] args)
        {
            GenerateMenuProduct();
            StarServing();
        }
        static void GenerateProduct(int id, string name, string manufacturer, double price, string otherDescriptions)
        {
            Product product = new Product();
            product.ID = id;
            product.Name = name;
            product.Price = price;
            product.Manufacturer = manufacturer;
            product.OtherDescriptions = otherDescriptions;
            menuProduct.Add(id, product);
        }
        static void GenerateMenuProduct()
        {
            GenerateProduct(1, "Iphone 10       ", "USA    ", 9500000, "Empty");
            GenerateProduct(2, "Nokia 8.1       ", "Finland", 3500000, "Empty");
            GenerateProduct(3, "TV Sony         ", "Janpan ", 1500000, "Empty");
            GenerateProduct(4, "TV Samsung      ", "Korea  ", 1200000, "Empty");
            GenerateProduct(5, "Fridge Panasonic", "VN     ", 7000000, "Empty");
            GenerateProduct(6, "Fridge Toshiba  ", "VN     ", 9000000, "Empty");
            GenerateProduct(7, "Macbook 2020    ", "USA    ", 4000000, "Empty");
            GenerateProduct(8, "Latop Dell      ", "China  ", 2500000, "Empty");
            GenerateProduct(9, "Apple Watch     ", "USA    ", 1100000, "Empty");
            GenerateProduct(10, "Samsum Watch   ", "Korea  ", 9000000, "Empty");
        }
        static void StarServing()
        {
            string choice = "5";
            while (choice != "0")
            {
                Console.WriteLine("****....ONLINE SHOPPING....****");
                Console.WriteLine("1. Buy online product.");
                Console.WriteLine("2. Show shopping cart.");
                Console.WriteLine("3. Edit shopping cart.");
                Console.WriteLine("4. Pay.");
                Console.WriteLine("0. Exit.");
                Console.Write("Enter you choice: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("...Buy online product...");
                        BuyProduct();
                        break;
                    case "2":
                        Console.WriteLine("...Show shopping cart...");
                        ShowCart();
                        break;
                    case "3":
                        Console.WriteLine("...Edit shopping cart...");
                        EditShoppingCart();
                        break;
                    case "4":
                        Console.WriteLine("...Pay...");
                        Pay();
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
        static void EditShoppingCart()
        {
            ShowCart();
            Console.WriteLine("1. Edit amount product");
            Console.WriteLine("2. Remove product");
            Console.WriteLine("0. Back");
            Console.WriteLine("You choice: ");
            string choiceEdit = Console.ReadLine();
            switch (choiceEdit)
            {
                case "1":
                    Console.WriteLine("Edit amount product");
                    EditAmountProduct();
                    break;
                case "2":
                    Console.WriteLine("Remove product");
                    RemoveProduct();
                    break;
                case "0":
                    StarServing();
                    break;
                default:
                    Console.WriteLine("No choice!");
                    EditShoppingCart();
                    break;
            }
        }
        static void RemoveProduct()
        {
            int idEdit = GetIDEdit();
            var productRemove = new Product();
            foreach (var product in data.products)
            {
                if (product.ID == idEdit)
                {
                    productRemove = product;
                }
            }
            data.products.Remove(productRemove);
        }
        static void EditAmountProduct()
        {
            int idEdit = GetIDEdit();
            Console.WriteLine("Enter new amount: ");
            string new_Amount = Console.ReadLine();
            int newAmount;
            while (!IsInteger(new_Amount, out newAmount) || newAmount <= 0 )
            {
                Console.WriteLine("Enter again new amount: ");
                new_Amount = Console.ReadLine();
            }
            foreach (var product in data.products)
            {
                if (product.ID == idEdit)
                {
                    product.Amount = newAmount;
                }
            }
        }
        static int GetIDEdit()
        {
            Console.Write("Enter ID product edit: ");
            string strID = Console.ReadLine();
            int idEdit;
            while (!IsInteger(strID, out idEdit) || idEdit <= 0 || !isIDInShoppingCart(idEdit))
            {
                Console.WriteLine("The ID does not exist in shopping cart!");
                EditShoppingCart();
            }
            return idEdit;
        }
        static bool isIDInShoppingCart(int id)
        {
            foreach (var product in data.products)
            {
                if (product.ID == id)
                {
                    return true;
                }
            }
            return false;
        }
        static void Pay()
        {
            double totalMoney = 0;
            var billTable = new Data()
            {
                products = new List<Product>()
            };
            Console.WriteLine("ID\tName\t\t\tManufacturer\t\tPrice\t\tOtherDescriptions\t\tAmount\tIntoMoney");
            foreach (var product in data.products)
            {
                Console.WriteLine(product.ToString());
                totalMoney += product.IntoMoney;
                billTable.products.Add(product);
            }
            Console.WriteLine($"Total money: {totalMoney} VND");
            WriteBillJson(data);
            SetShoppingCart();
        }
        static void SetShoppingCart()
        {
            data = new Data()
            {
                products = new List<Product>()
            };
            ResetAmount();
        }
        static void ResetAmount()
        {
            foreach (var item in menuProduct)
            {
                item.Value.Amount = 0;
            }
        }
        static void WriteBillJson(Data data)
        {
            var fileBIll = $"bill.json";
            using (StreamWriter sw = File.CreateText($@"{FILE_BILL_PATH}\{fileBIll}"))
            {
                var datum = JsonConvert.SerializeObject(data);
                sw.Write(datum);
            }
        }
        static void ShowCart()
        {
            Console.WriteLine("ID\tName\t\t\tManufacturer\t\tPrice\t\tOtherDescriptions\t\tAmount\tIntoMoney");
                foreach (var product in data.products)
                {
                    Console.WriteLine(product.ToString());
                }
            Console.WriteLine();
        }
        static void BuyProduct()
        {
            string buyNumber = "x";
            while (buyNumber != "0")
            {
                Console.WriteLine("...Menu Product...");
                foreach (var product in menuProduct)
                {
                    Console.WriteLine($"{product.Key}. {product.Value.Name}, price: {product.Value.Price} VND");
                }
                Console.WriteLine("0. Back");
                Console.Write("Buy number: ");
                buyNumber = Console.ReadLine();
                switch (buyNumber)
                {
                    case "0":
                        Console.WriteLine("Back...");
                        StarServing();
                        break;
                    default:
                        int idProduct;
                        while (!IsInteger(buyNumber, out idProduct) || idProduct <= 0 || !isID(idProduct))
                        {
                            Console.WriteLine("The selection does not exist!");
                            BuyProduct();
                        }
                        int amount = GetAmount();
                        if (menuProduct[idProduct].Amount > 0)
                        {
                            menuProduct[idProduct].Amount += amount;
                        }
                        else
                        {
                            menuProduct[idProduct].Amount = amount;
                            data.products.Add(menuProduct[idProduct]);
                        }
                        break;
                }
            }
        }
        static bool isID(int id)
        {
            foreach (var product in menuProduct)
            {
                if (product.Key == id)
                {
                    return true;
                }
            }
            return false;
        }
        static int GetAmount()
        {
            Console.Write("Amount: ");
            string number = Console.ReadLine();
            int value;
            while (!IsInteger(number, out value) || value <= 0)
            {
                Console.Write("The quantity is not valid!. Enter again amount: ");
                number = Console.ReadLine();
            }
            return value;
        }
        static bool IsInteger(string number, out int value)
        {
            return Int32.TryParse(number, out value);
        }
    }
}
