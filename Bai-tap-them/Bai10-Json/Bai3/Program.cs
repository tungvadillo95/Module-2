using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Bai3
{
    public class Program
    {
        const int NUMBER_OF_TABLE = 5;
        static Dictionary<int, Food> menu = new Dictionary<int, Food>();
        const string FILE_PATH = @"C:\Users\ASUS\Desktop\BT-CODEGYM\Module-2\Bai-tap-them\Bai10-Json\Bai3\data";
        const string FILE_DATA = "Oder.json";
        const string FILE_BILL_PATH = @"C:\Users\ASUS\Desktop\BT-CODEGYM\Module-2\Bai-tap-them\Bai10-Json\Bai3\logs_bill";
        static Data data = new Data()
        {
            tables = new List<Table>()
        };
        static void Main(string[] args)
        {
            GenerateMenu();
            GrenerateAllTable(data);
            StarServing();
        }
        static void ListFoodMenu(int id,string name, double price)
        {
            Food food = new Food();
            food.IDFood = id;
            food.Name = name;
            food.Price = price;
            menu.Add(food.IDFood, food);
        }
        static void GenerateMenu()
        {
            ListFoodMenu(1, "Coffe", 12000);
            ListFoodMenu(2, "Milk", 10000);
            ListFoodMenu(3, "Bread", 15000);
            ListFoodMenu(4, "Hamberger", 20000);
            ListFoodMenu(5, "Pizza", 25000);
            ListFoodMenu(6, "Fruit", 20000);
        }
        static void StarServing()
        {
            string choice = "5";
            while (choice != "0")
            {
                Console.WriteLine("****....BOOK ODER....****");
                Console.WriteLine("1. Oder food and drink.");
                Console.WriteLine("2. Pay.");
                Console.WriteLine("3. Show status all table.");
                Console.WriteLine("4. Show table.");
                Console.WriteLine("0. Exit.");
                Console.Write("Enter you choice: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("...Oder food and drink...");
                        Console.Write("Enter ID table: ");
                        string number1 = Console.ReadLine();
                        int idTable;
                        while (!IsInteger(number1, out idTable) || idTable <= 0 || idTable > NUMBER_OF_TABLE)
                        {
                            Console.Write("ID does not exist!. Enter again ID table: ");
                            number1 = Console.ReadLine();
                        }
                        OderFoodAndDrink(idTable);
                        break;
                    case "2":
                        Console.WriteLine("...Pay...");
                        Pay();
                        break;
                    case "3":
                        Console.WriteLine("...Show status all table...");
                        ShowStatusAll();
                        break;
                    case "4":
                        Console.WriteLine("...Show table...");
                        Console.Write("Enter ID table: ");
                        string id_Show = Console.ReadLine();
                        int idShow;
                        while (!IsInteger(id_Show, out idShow) || idShow <= 0 || idShow > NUMBER_OF_TABLE)
                        {
                            Console.Write("ID does not exist!. Enter again ID table: ");
                            number1 = Console.ReadLine();
                        }
                        ShowTable(idShow);
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
        static void ShowTable(int id)
        {
            foreach(var table in data.tables)
            {
                if (table.ID == id)
                {
                    Console.WriteLine($"ID: {table.ID}");
                    Console.WriteLine($"Status: {table.Status}");
                    Console.WriteLine("Name\t\tPrice\t\tAmount\t\tIntoMoney");
                    foreach (var food in table.foods)
                    {
                        Console.WriteLine(food.ToString());
                    }
                    Console.WriteLine($"Total money: {table.TotalMoney}");
                }
            }
        }
        static void ShowStatusAll()
        {
            foreach (var table in data.tables)
            {
                Console.WriteLine($"Table ID{table.ID}: {(table.Status ? "Using" : "Not using")}");
            }
        }
        static void Pay()
        {
            Console.Write("Enter ID table: ");
            string number2 = Console.ReadLine();
            int idPay;
            while (!IsInteger(number2, out idPay) || idPay <= 0 || idPay > NUMBER_OF_TABLE)
            {
                Console.Write("ID does not exist!. Enter again ID table: ");
                number2 = Console.ReadLine();
            }
            int check = 1;
            double totalMoney = 0;
            var billTable = new Table()
            {
                ID = idPay,
                Status = true,
                foods = new List<Food>()
            };
            foreach (var table in data.tables)
            {
                if (table.ID == idPay && table.Status)
                {
                    Console.WriteLine("Name\t\tPrice\t\tAmount\t\tIntoMoney");
                    foreach (var food in table.foods)
                    {
                        Console.WriteLine(food.ToString());
                        totalMoney += food.IntoMoney;
                        billTable.foods.Add(food);
                    }
                    Console.WriteLine($"Total money: {totalMoney}");
                    WriteJson(data);
                    SetTable(table);
                }
                else
                {
                    check++;
                }
            }
            if (check > NUMBER_OF_TABLE)
            {
                Console.WriteLine("Invalid table !");
            }
            else
            {
                var LOG_FILE_BILL = $"Bill_{idPay}_{DateTime.Now.ToString("dd_MM_yyyy_hh_mm")}.json";
                using (StreamWriter sw = File.CreateText($@"{FILE_BILL_PATH}\{LOG_FILE_BILL}"))
                {
                    var datum = JsonConvert.SerializeObject(billTable);
                    sw.Write(datum);
                }
            }
        }        public static bool IsInteger(string number, out int value)
        {
            return Int32.TryParse(number, out value);
        }
        static void OderFoodAndDrink(int idTable)
        {
            foreach (var table in data.tables)
            {
                if (table.ID == idTable)
                {
                    table.Status = true;
                    string oder = "7";
                    while (oder != "0")
                    {
                        WriteJson(data);
                        Console.WriteLine("Menu");
                        Console.WriteLine("1. Coffe");
                        Console.WriteLine("2. Milk");
                        Console.WriteLine("3. Bread");
                        Console.WriteLine("4. Hamberger");
                        Console.WriteLine("5. Pizza");
                        Console.WriteLine("6. Fruit");
                        Console.WriteLine("0. Back");
                        Console.Write("Oder: ");
                        oder = Console.ReadLine();
                        switch (oder)
                        {
                            case "0":
                                Console.WriteLine("Back...");
                                StarServing();
                                break;
                            default:
                                int idFood;
                                while (!IsInteger(oder, out idFood) || idFood <= 0 || idFood > menu.Count)
                                {
                                    Console.WriteLine("The selection does not exist!");
                                    OderFoodAndDrink(idTable);
                                }
                                int amount = GetAmount();
                                if (menu[idFood].Amount > 0)
                                {
                                    menu[idFood].Amount += amount;
                                }
                                else
                                {
                                    menu[idFood].Amount = amount;
                                    table.foods.Add(menu[idFood]);
                                }
                                break;
                        }
                    }
                }
            }
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
        static void SetTable(Table table)
        {
            table.Status = false;
            table.foods = new List<Food>()
                    {
                        new Food()
                        {
                            Name = null,
                            Price = 0,
                            Amount = 0
                        }
                    };
        }
        static void WriteJson(Data data)
        {
            using (StreamWriter sw = File.CreateText($@"{FILE_PATH}\{FILE_DATA}"))
            {
                var datum = JsonConvert.SerializeObject(data);
                sw.Write(datum);
            }
        }
        static void GrenerateAllTable(Data data)
        {
            int number = 1;
            for(int i=0;i< NUMBER_OF_TABLE; i++)
            {
                data.tables.Add(new Table()
                {
                    ID = number,
                    Status = false,
                    foods = new List<Food>()
            });
                number++;
            }
        }
    }
}

