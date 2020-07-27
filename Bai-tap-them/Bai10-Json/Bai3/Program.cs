using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Bai3
{
    public class Program
    {
        const int NUMBER_OF_TABLE = 5;
        static Dictionary<string, double> menu = new Dictionary<string, double>();
        const string FILE_PATH = @"C:\Users\ASUS\Desktop\BT-CODEGYM\Module-2\Bai-tap-them\Bai10-Json\Bai3\data";
        const string FILE_DATA = "Oder.json";
        const string FILE_BILL_PATH = @"C:\Users\ASUS\Desktop\BT-CODEGYM\Module-2\Bai-tap-them\Bai10-Json\Bai3\logs_bill";
        static Data data = new Data()
        {
            tables = new List<Table>()
        };
        static void Main(string[] args)
        {
            GenerateMenu(menu);
            GrenerateAllTable(data);
            StarServing();
        }
        static void GenerateMenu(Dictionary<string, double> menu)
        {
            menu.Add("Coffe", 12);
            menu.Add("Milk", 10);
            menu.Add("Bread", 15);
            menu.Add("Hamberger", 20);
            menu.Add("Pizza", 25);
            menu.Add("Fruit", 15);
        }
        static void StarServing()
        {
            string choice = "5";
            while (choice != "0")
            {
                Console.WriteLine("****....BOOK ODER....****");
                Console.WriteLine("1. Oder food and drink.");
                Console.WriteLine("2. Pay.");
                Console.WriteLine("0. Exit.");
                Console.Write("Enter you choice: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("...Oder food and drink...");
                        Console.Write("Enter ID table: ");
                        string number1 = Console.ReadLine();
                        int id;
                        while (!IsID(number1, out id) || id <= 0 || id > NUMBER_OF_TABLE)
                        {
                            Console.Write("ID does not exist!. Enter again ID table: ");
                            number1 = Console.ReadLine();
                        }
                        OderFoodAndDrink(id);
                        break;
                    case "2":
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
        static void Pay()
        {
            Console.Write("Enter ID table: ");
            string number2 = Console.ReadLine();
            int idPay;
            while (!IsID(number2, out idPay) || idPay <= 0 || idPay > NUMBER_OF_TABLE)
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
                var LOG_FILE_BILL = $"Bill_{idPay}_{DateTime.Now.ToString("ddMMyyyyhh")}.json";
                using (StreamWriter sw = File.CreateText($@"{FILE_BILL_PATH}\{LOG_FILE_BILL}"))
                {
                    var datum = JsonConvert.SerializeObject(billTable);
                    sw.Write(datum);
                }
            }
        }
       
        public static bool IsID(string number, out int id)
        {
            return Int32.TryParse(number, out id);
        }
        static void OderFoodAndDrink(int id)
        {
            foreach (var table in data.tables)
            {
                if (table.ID == id)
                {
                    table.Status = true;
                    string oder = "6";
                    while (oder != "0")
                    {
                        WriteJson(data);
                        Console.WriteLine("Menu");
                        Console.WriteLine("1. Coffe");
                        Console.WriteLine("2. Milk");
                        Console.WriteLine("3. Bread");
                        Console.WriteLine("4. Hamberger");
                        Console.WriteLine("5. Fruit Juice");
                        Console.WriteLine("0. Back");
                        Console.Write("Oder: ");
                        oder = Console.ReadLine();
                        switch (oder)
                        {
                            case "1":
                                Console.Write("Amount: ");
                                int amount1 = int.Parse(Console.ReadLine());
                                Food food1 = new Food()
                                {
                                    Name = "Coffe",
                                    Price = GetPrice("Coffe"),
                                    Amount = amount1
                                };
                                table.foods.Add(food1);
                                break;
                            case "2":
                                Console.Write("Amount: ");
                                int amount2 = int.Parse(Console.ReadLine());
                                Food food2 = new Food()
                                {
                                    Name = "Milk",
                                    Price = GetPrice("Milk"),
                                    Amount = amount2
                                };
                                table.foods.Add(food2);
                                break;
                            case "3":
                                Console.Write("Amount: ");
                                int amount3 = int.Parse(Console.ReadLine());
                                Food food3 = new Food()
                                {
                                    Name = "Bread",
                                    Price = GetPrice("Bread"),
                                    Amount = amount3
                                };
                                table.foods.Add(food3);
                                break;
                            case "4":
                                Console.Write("Amount: ");
                                int amount4 = int.Parse(Console.ReadLine());
                                Food food4 = new Food()
                                {
                                    Name = "Hamberger",
                                    Price = GetPrice("Hamberger"),
                                    Amount = amount4
                                };
                                table.foods.Add(food4);
                                break;
                            case "5":
                                Console.Write("Amount: ");
                                int amount5 = int.Parse(Console.ReadLine());
                                Food food5 = new Food()
                                {
                                    Name = "Fruit",
                                    Price = GetPrice("Fruit"),
                                    Amount = amount5
                                };
                                table.foods.Add(food5);
                                break;
                            case "0":
                                Console.WriteLine("Back...");
                                StarServing();
                                break;
                            default:
                                Console.WriteLine("No choice!");
                                break;
                        }
                    }
                }
            }
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
        static double GetPrice(string name)
        {
            foreach (var item in menu.Keys)
            {
                if(item.ToUpper() == name.ToUpper())
                {
                    return menu[item];
                }
            }
            return 0;
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

