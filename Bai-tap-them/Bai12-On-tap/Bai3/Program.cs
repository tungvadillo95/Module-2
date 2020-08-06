using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Bai3
{
    class Program
    {
        static Dictionary<int, Product> menuProduct = new Dictionary<int, Product>();
        static Admin admin = new Admin()
        {
            ID = "NO1",
            Name = "Jurgen Klopp",
            Position = "coach",
            Email = "123",
            PassWord = "123",
            staffs = new List<Staff>(),
            orders = new List<Order>()
        };
        const string FILE_PATH = @"C:\Users\ASUS\Desktop\BT-CODEGYM\Module-2\Bai-tap-them\Bai12-On-tap\Bai3\data";
        const string FILE_STAFFS_NAME = "staffs.json";
        const string FILE_ODERS_ADMIN_NAME = "orders_admin.json";
        const string FILE_ODERS_STAFF_NAME = "orders_staff.json";
        static void Main(string[] args)
        {
            GenerateMenuProduct();
            LoginUsingManagerment();
        }
        static void LoginUsingManagerment()
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
                        //choice = "0";
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
                GetAdminInterface();
            }
            else
            {
                Console.WriteLine("Username and password are not correct!");
                LoginUsingManagerment();
            }
        }
        static void GetAdminInterface()
        {
            Console.Clear();
            string choice = "x";
            while (choice != "0")
            {
                Console.WriteLine("***---ADMIN MANAGERMENT---***");
                Console.WriteLine("1. Managerment staff.");
                Console.WriteLine("2. Managerment order.");
                Console.WriteLine("3. Managerment product.");
                Console.WriteLine("4. Change password.");
                Console.WriteLine("0. Back.");
                Console.Write("Enter you choice: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        ManagermentStaff();
                        break;
                    case "2":
                        ManagermanetOrder();
                        break;
                    case "3":
                        ManagermentProduct();
                        break;
                    case "4":
                        StartChangePassword();
                        break;
                    case "0":
                        LoginUsingManagerment();
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                }
            }
        }
        static void StartChangePassword()
        {
            Console.Clear();
            string choice = "x";
            while (choice != "0")
            {
                Console.WriteLine("***... Change password ...***");
                Console.WriteLine("1. Change password.");
                Console.WriteLine("0. Back.");
                Console.Write("Enter you choice: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        ChangePasswordAd();
                        break;
                    case "0":
                        GetAdminInterface();
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                }

            }
        }
        static void ChangePasswordAd()
        {
            Console.WriteLine("... Change password ...");
            Console.WriteLine("Login....");
            Console.Write("Enter email: ");
            string email = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();
            string newPassword, temp;
            if (admin.Email == email && admin.PassWord == password)
            {
                Console.WriteLine("Login complete....");
                Console.Write("Enter new password: ");
                newPassword = Console.ReadLine();
                Console.Write("Enter again new password: ");
                temp = Console.ReadLine();
                if (newPassword == temp)
                {
                    Console.WriteLine("Change password complete....");
                    admin.PassWord = newPassword;
                }
                else
                {
                    Console.WriteLine("Password are not correct!");
                    StartChangePassword();
                }
            }
            else
            {
                Console.WriteLine("Username and password are not correct!");
                StartChangePassword();
            }

        }
        static void ManagermentProduct()
        {
            Console.Clear();
            string choice = "x";
            while (choice != "0")
            {
                Console.WriteLine("**-- Managerment product --**");
                Console.WriteLine("1. Add product.");
                Console.WriteLine("2. Edit product.");
                Console.WriteLine("3. Remove product.");
                Console.WriteLine("4. Search product.");
                Console.WriteLine("5. Show all product.");
                Console.WriteLine("0. Back.");
                Console.Write("Enter you choice: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        AddProduct();
                        break;
                    case "2":
                        StartEditProduct();
                        break;
                    case "3":
                        RemoveProduct();
                        break;
                    case "4":
                        SearchProduct();
                        break;
                    case "5":
                        ShowMenuProduct();
                        break;
                    case "0":
                        GetAdminInterface();
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                }

            }
        }
        static void SearchProduct()
        {
            Console.Clear();
            string choice = "x";
            while (choice != "0")
            {
                Console.WriteLine("... Search product ...");
                Console.WriteLine("1. Search product by ID.");
                Console.WriteLine("2. Search product by Name.");
                Console.WriteLine("0. Back.");
                Console.Write("Enter you choice: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        SearchProductById();
                        break;
                    case "2":
                        SearchProductByName();
                        break;
                    case "0":
                        ManagermentProduct();
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                }

            }
        }
        static void SearchProductByName()
        {
            Console.WriteLine("Search product by Name...");
            Console.Write("Enter new product Name: ");
            string productName = Console.ReadLine();
            int check = 0;
            foreach (var product in menuProduct)
            {
                if (product.Value.Name == productName)
                {
                    Console.WriteLine("ID\tName\t\t\tManufacturer\t\tPrice\t\tOtherDescriptions\t\tAmount\tIntoMoney");
                    Console.WriteLine(product.ToString());
                }
            }
            if (check == 0)
            {
                Console.WriteLine("Product Name does not exist! Press\"Enter\"to go back...");
                Console.ReadKey();
            }
        }
        static void SearchProductById()
        {
            Console.WriteLine("Search product by ID...");
            Console.Write("Enter new product ID: ");
            string productId = Console.ReadLine();
            int productID;
            int check = 0;
            while (!Int32.TryParse(productId, out productID) || productID <= 0)
            {
                Console.WriteLine("The new product ID is not validate!");
                Console.Write("Enter again new product ID: ");
                productId = Console.ReadLine();
            }
            foreach(var product in menuProduct)
            {
                if (product.Value.ID == productID)
                {
                    Console.WriteLine("ID\tName\t\t\tManufacturer\t\tPrice\t\tOtherDescriptions\t\tAmount\tIntoMoney");
                    Console.WriteLine(product.ToString());
                }
            }
            if (check == 0)
            {
                Console.WriteLine("Product ID does not exist! Press\"Enter\"to go back...");
                Console.ReadKey();
            }
        }
        static void ShowMenuProduct()
        {
            Console.WriteLine("... Show all product...");
            Console.WriteLine("ID\tName\t\t\tManufacturer\t\tPrice\t\tOtherDescriptions\t\tAmount\tIntoMoney");
            foreach(var product in menuProduct)
            {
                Console.WriteLine(product.ToString());
            }
        }
        static void RemoveProduct()
        {
            Console.WriteLine("... Remove product ...");
            Console.Write("Enter new product ID: ");
            string productId = Console.ReadLine();
            int productID;
            while (!Int32.TryParse(productId, out productID) || productID <= 0 || !IsProductID(productID))
            {
                Console.WriteLine("The new product ID already exists or is not validate!");
                Console.Write("Enter again new product ID: ");
                productId = Console.ReadLine();
            }
            menuProduct.Remove(productID);
        }
        static void StartEditProduct()
        {
            Console.WriteLine("... Edit product ...");
            Console.WriteLine("Enter product ID: ");
            string idProduct = Console.ReadLine();
            int idProductEdit;
            while(!Int32.TryParse(idProduct,out idProductEdit)|| idProductEdit<=0)
            {
                Console.WriteLine("Enter again product ID: ");
                idProduct = Console.ReadLine();
            }
            int check = 0;
            foreach(var product in menuProduct)
            {
                if (product.Value.ID == idProductEdit)
                {
                    EditProduct(product.Value);
                }
            }
            if (check == 0)
            {
                Console.WriteLine("ID does not exist ! Press \"Enter\" to go continue...");
                Console.ReadKey();
            }
        }
        static void EditProduct(Product product)
        {
            string choice = "x";
            while (choice != "0")
            {
                Console.WriteLine("Do you want edit ?");
                Console.WriteLine("1. Edit product ID.");
                Console.WriteLine("2. Edit product Name.");
                Console.WriteLine("3. Edit product Manufacturer.");
                Console.WriteLine("4. Edit product Price.");
                Console.WriteLine("5. Edit product Amount.");
                Console.WriteLine("6. Edit product OtherDescriptions.");
                Console.WriteLine("0. Back");
                Console.Write("Enter you choice: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        EditProductID(product);
                        break;
                    case "2":
                        EditProductName(product);
                        break;
                    case "3":
                        EditProductManufacturer(product);
                        break;
                    case "4":
                        EditProductPrice(product);
                        break;
                    case "5":
                        EditProductAmount(product);
                        break;
                    case "6":
                        EditProductOtherDescriptions(product);
                        break;
                    case "0":
                        ManagermentProduct();
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                }
            }
            
        }
        static void EditProductOtherDescriptions(Product product)
        {
            Console.WriteLine("Edit product Other Descriptions...");
            Console.Write("Enter new product name: ");
            string newProductOtherDescriptions = Console.ReadLine();
            product.OtherDescriptions = newProductOtherDescriptions;
        }
        static void EditProductAmount(Product product)
        {
            Console.WriteLine("Edit product Amount...");
            Console.Write("Enter new product ID: ");
            string newAmount = Console.ReadLine();
            int newProductAmount;
            while (!Int32.TryParse(newAmount, out newProductAmount) || newProductAmount < 0 )
            {
                Console.WriteLine("The new product ID already exists or is not validate!");
                Console.Write("Enter again new product ID: ");
                newAmount = Console.ReadLine();
            }
            product.Amount = newProductAmount;
        }
        static void EditProductPrice(Product product)
        {
            Console.WriteLine("Edit product Price...");
            Console.Write("Enter new product Price: ");
            string newPrice = Console.ReadLine();
            double newProductPrice;
            while (!Double.TryParse(newPrice, out newProductPrice) || newProductPrice <= 0 )
            {
                Console.WriteLine("The new product ID already exists or is not validate!");
                Console.Write("Enter again new product ID: ");
                newPrice = Console.ReadLine();
            }
            product.Price = newProductPrice;
        }
        static void EditProductManufacturer(Product product)
        {
            Console.WriteLine("Edit product Manufacturer...");
            Console.Write("Enter new product name: ");
            string newProductManufacturer = Console.ReadLine();
            product.Manufacturer = newProductManufacturer;
        }
        static void EditProductName(Product product)
        {
            Console.WriteLine("Edit product Name...");
            Console.Write("Enter new product name: ");
            string newProductName = Console.ReadLine();
            while (IsNameLiveInMenuList(newProductName))
            {
                Console.Write("Product name already exists or is not validate!");
                Console.Write("Enter again new product name: ");
                newProductName = Console.ReadLine();
            }
            product.Name = newProductName;
        }
        static bool IsNameLiveInMenuList(string nameProduct)
        {
            foreach(var product in menuProduct)
            {
                if (product.Value.Name == nameProduct)
                {
                    return true;
                }
            }
            return false;
        }
        static void EditProductID(Product product)
        {
            Console.WriteLine("Edit product ID...");
            Console.Write("Enter new product ID: ");
            string newID = Console.ReadLine();
            int newProductID;
            while(!Int32.TryParse(newID,out newProductID)||newProductID<=0|| IsProductID(newProductID))
            {
                Console.WriteLine("The new product ID already exists or is not validate!");
                Console.Write("Enter again new product ID: ");
                newID = Console.ReadLine();
            }
            product.ID = newProductID;
        }
        static void AddProduct()
        {
            Console.WriteLine("... Add product ...");
            Console.Write("Enter product ID: ");
            string newProductId = Console.ReadLine();
            int newProductID;
            while (!Int32.TryParse(newProductId, out newProductID) || newProductID <= 0 || IsIDLiveInMenuProduct(newProductID))
            {
                Console.WriteLine("The product id already exist in menu product!");
                Console.Write("Enter again product ID: ");
                newProductId = Console.ReadLine();
            }
            Console.Write("Enter product name: ");
            string newProductName = Console.ReadLine();
            while (IsNameInMenuProduct(newProductName))
            {
                Console.WriteLine("The product name already exist in menu product!");
                Console.Write("Enter again product name: ");
                newProductName = Console.ReadLine();
            }
            Console.Write("Enter product manufacturer: ");
            string newProductManufacturer = Console.ReadLine();
            Console.Write("Enter product price: ");
            string new_ProductPrice = Console.ReadLine();
            double newProductPrice;
            while (!Double.TryParse(new_ProductPrice, out newProductPrice) || newProductPrice <= 0)
            {
                Console.Write("Enter again product price: ");
                new_ProductPrice = Console.ReadLine();
            }
            Console.Write("Enter product amount: ");
            string new_ProductAmount = Console.ReadLine();
            int newProductAmount;
            while (!Int32.TryParse(new_ProductAmount, out newProductAmount) || newProductAmount <= 0)
            {
                Console.Write("Enter again product amount: ");
                new_ProductPrice = Console.ReadLine();
            }
            Console.Write("Enter product other descriptions): ");
            string newOtherDescriptions = Console.ReadLine();
            GenerateProduct(newProductID, newProductName, newProductManufacturer, newProductPrice, newOtherDescriptions);

        }
        static bool IsNameInMenuProduct(string newProductName)
        {
            foreach (var product in menuProduct)
            {
                if (product.Value.Name.ToUpper() == newProductName.ToUpper())
                {
                    return true;
                }
            }
            return false;
        }
        static bool IsIDLiveInMenuProduct(int newProductID)
        {
            foreach(var product in menuProduct)
            {
                if(product.Value.ID == newProductID)
                {
                    return true;
                }
            }
            return false;
        }
        static void ManagermentStaff()
        {
            Console.Clear();
            string choice = "x";
            while (choice != "0")
            {
                Console.WriteLine("**-- Managerment staff --**");
                Console.WriteLine("1. Add staff.");
                Console.WriteLine("2. Edit staff.");
                Console.WriteLine("3. Remove staff.");
                Console.WriteLine("0. Back.");
                Console.Write("Enter you choice: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        AddStaff();
                        break;
                    case "2":
                        EditStaff();
                        break;
                    case "3":
                        RemoveStaff();
                        break;
                    case "0":
                        GetAdminInterface();
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                }
                
            }

        }
        static void SaveFileJsonStaffs()
        {
            using (StreamWriter sw = File.CreateText($@"{FILE_PATH}\{FILE_STAFFS_NAME}"))
            {
                var data = JsonConvert.SerializeObject(admin.staffs);
                sw.Write(data);
            }
        }
        static void AddStaff()
        {
            Console.WriteLine("-- Add staff --");
            Console.Write("Enter ID new Staff: ");
            string newStaffID = Console.ReadLine();
            while (IsIDLiveInListStaff(newStaffID))
            {
                Console.Write("The staff id  already exist in list staffs!");
                Console.Write("Enter again ID new Staff: ");
                newStaffID = Console.ReadLine();
            }
            Console.Write("Enter Name new Staff: ");
            string newStaffName = Console.ReadLine();
            Console.Write("Enter Position new Staff: ");
            string newStaffPosition = Console.ReadLine();
            Console.Write("Enter Email new Staff: ");
            string newStaffEmail = Console.ReadLine();
            while (IsEmailInListStaff(newStaffEmail))
            {
                Console.Write("The staff email already exist in list staffs!");
                Console.Write("Enter again Email new Staff: ");
                newStaffEmail = Console.ReadLine();
            }
            Console.Write("Enter PassWord new Staff: ");
            string newStaffPassword = Console.ReadLine();
            Staff staff = new Staff()
            {
                ID = newStaffID,
                Name = newStaffName,
                Position = newStaffPosition,
                Email = newStaffEmail,
                PassWord = newStaffPassword,
                orders = new List<Order>()
            };
            admin.staffs.Add(staff);
            SaveFileJsonStaffs();
        }
        static bool IsEmailInListStaff(string newStaffEmail)
        {
            foreach (var staff in admin.staffs)
            {
                if (staff.Email == newStaffEmail)
                {
                    return true;
                }
            }
            return false;
        }
        static bool IsIDLiveInListStaff(string newStaffID)
        {
            foreach(var staff in admin.staffs)
            {
                if (staff.ID == newStaffID)
                {
                    return true;
                }
            }
            return false;
        }
        static void EditStaff()
        {
            Console.WriteLine("-- Edit staff --");
            Console.WriteLine("Enter ID: ");
            string id = Console.ReadLine();
            int check = 0;
            foreach(var staff in admin.staffs)
            {
                if (staff.ID == id)
                {
                    EditProfileStaff(staff);
                    check++;
                }
            }
            if (check == 0) 
            {
                Console.WriteLine("ID does not exist ! Press \"Enter\" to go continue...");
                Console.ReadKey();
            }
            SaveFileJsonStaffs();
        }
        static void EditProfileStaff(Staff staff)
        {
            string choice = "x";
            while(choice != "0")
            {
                SaveFileJsonStaffs();
                Console.WriteLine("Do you want edit? ");
                Console.WriteLine("1. ID");
                Console.WriteLine("2. Name");
                Console.WriteLine("3. Position");
                Console.WriteLine("4. Email");
                Console.WriteLine("5. PassWord");
                Console.WriteLine("0. Back");
                Console.Write("Enter you choice: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("New ID: ");
                        string newID = Console.ReadLine();
                        while (IsIDLiveInListStaff(newID))
                        {
                            Console.Write("The staff id  already exist in list staffs!");
                            Console.Write("Enter again ID new Staff: ");
                            newID = Console.ReadLine();
                        }
                        staff.ID = newID;
                        break;
                    case "2":
                        Console.WriteLine("New Name: ");
                        string newName = Console.ReadLine();
                        staff.Name = newName;
                        break;
                    case "3":
                        Console.WriteLine("New Position: ");
                        string newPosition = Console.ReadLine();
                        staff.Position = newPosition;
                        break;
                    case "4":
                        Console.WriteLine("New Email: ");
                        string newEmail = Console.ReadLine();
                        while (IsEmailInListStaff(newEmail))
                        {
                            Console.Write("The staff email already exist in list staffs!");
                            Console.Write("Enter again Email new Staff: ");
                            newEmail = Console.ReadLine();
                        }
                        staff.Email = newEmail;
                        break;
                    case "5":
                        Console.WriteLine("New PassWord: ");
                        string newPassWord = Console.ReadLine();
                        staff.PassWord = newPassWord;
                        break;
                    case "0":
                        ManagermentStaff();
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                }
            }
        }
        static void RemoveStaff()
        {
            Console.WriteLine("-- Remove staff --");
            Console.WriteLine("Enter ID: ");
            string id = Console.ReadLine();
            int check = 0;
            if (admin.staffs.Count != 0)
            {
                Staff staffRemove = new Staff();
                foreach (var staff in admin.staffs)
                {
                    if (staff.ID == id)
                    {
                        staffRemove = staff;
                        check++;
                    }
                }
                admin.staffs.Remove(staffRemove);
                if (check == 0)
                {
                    Console.WriteLine("ID does not exist!Press\"Enter\"to go continue...");
                    Console.ReadKey();
                }
                SaveFileJsonStaffs();
            }
            else
            {
                Console.WriteLine("Empty staff list!Press \"Enter\" to go continue...");
                Console.ReadKey();
            }
           
        }
        static void ManagermanetOrder()
        {
            Console.Clear();
            PayAndSavingOrderPain();
            string choice = "x";
            while (choice != "0")
            {
                Console.WriteLine("**-- Managerment order --**");
                Console.WriteLine("1. Generate order.");
                Console.WriteLine("2. Edit order.");
                Console.WriteLine("3. Search order.");
                Console.WriteLine("4. Show all order.");
                Console.WriteLine("0. Back.");
                Console.Write("Enter you choice: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        StartGenerateOrder();
                        break;
                    case "2":
                        StartEditOrder();
                        break;
                    case "3":
                        StartSearchOder();
                        break;
                    case "4":
                        ShowAllOrder();
                        break;
                    case "0":
                        GetAdminInterface();
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                }

            }
        }
        static void PayAndSavingOrderPain()
        {
            foreach(var staff in admin.staffs)
            {
                foreach(var order in staff.orders)
                {
                    if (order.Status)
                    {
                        var LOG_FILE_BILL = $"Bill_{order.OrderID}_{DateTime.Now.ToString("dd_MM_yyyy_hh_mm_ss")}.json";
                        using (StreamWriter sw = File.CreateText($@"{FILE_PATH}\{LOG_FILE_BILL}"))
                        {
                            var datum = JsonConvert.SerializeObject(order);
                            sw.Write(datum);
                        }
                        staff.orders.Remove(order);
                    }
                }
            }
            for(int i = 0; i < admin.orders.Count; i++)
            {
                if (admin.orders[i].Status)
                {
                    var LOG_FILE_BILL = $"Bill_{admin.orders[i].OrderID}_{DateTime.Now.ToString("dd_MM_yyyy_hh_mm_ss")}.json";
                    using (StreamWriter sw = File.CreateText($@"{FILE_PATH}\{LOG_FILE_BILL}"))
                    {
                        var datum = JsonConvert.SerializeObject(admin.orders[i]);
                        sw.Write(datum);
                    }
                    admin.orders.Remove(admin.orders[i]);
                }
            }
        }
        static void SaveFileJsonOders()
        {
            using (StreamWriter sw = File.CreateText($@"{FILE_PATH}\{FILE_ODERS_ADMIN_NAME}"))
            {
                var data = JsonConvert.SerializeObject(admin.orders);
                sw.Write(data);
            }

        }
        static void ShowAllOrder()
        {
            Console.WriteLine("-- Show all order --");
            foreach(var order in admin.orders)
            {
                order.Display();
            }
        }
        static void StartSearchOder()
        {
            Console.Clear();
            string choice = "x";
            while (choice != "0")
            {
                Console.WriteLine("-- Search order --");
                Console.WriteLine("1. Search order by order ID.");
                Console.WriteLine("2. Search order by customer name.");
                Console.WriteLine("3. Search order by customer address.");
                Console.WriteLine("0. Back.");
                Console.Write("Enter you choice: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        SearchOrderByOrderID();
                        break;
                    case "2":
                        SearchOderByCustomerName();
                        break;
                    case "3":
                        SearchOderByCustomerAddress();
                        break;
                    case "0":
                        ManagermanetOrder();
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                }

            }
        }
        static void SearchOderByCustomerAddress()
        {
            Console.WriteLine("Search order by customer address...");
            Console.Write("Enter customer address: ");
            string customerAddress = Console.ReadLine();
            int count = 0;
            foreach (var order in admin.orders)
            {
                if (order.CustomerAddress.ToUpper() == customerAddress.ToUpper())
                {
                    order.Display();
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Customer address does not exist! Press\"Enter\"to go back...");
                Console.ReadKey();
            }
        }
        static void SearchOderByCustomerName()
        {
            Console.WriteLine("Search order by customer name...");
            Console.Write("Enter customer name: ");
            string customerName = Console.ReadLine();
            int count = 0;
            foreach(var order in admin.orders)
            {
                if(order.CustomerName.ToUpper()== customerName.ToUpper())
                {
                    order.Display();
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Customer name does not exist! Press\"Enter\"to go back...");
                Console.ReadKey();
            }
        }
        static void SearchOrderByOrderID()
        {
            Console.Write("Enter order ID: ");
            string orderID = Console.ReadLine();
            bool isOrderIDInListOderAdmin = IsOrderIDInListOrderAdmin(orderID);
            if (isOrderIDInListOderAdmin)
            {
                foreach (var order in admin.orders)
                {
                    if (order.OrderID == orderID)
                    {
                        order.Display();
                    }
                }
            }
            else
            {
                Console.WriteLine("Oder ID does not exist! Press\"Enter\"to go back...");
                Console.ReadKey();
            }

        }
        static void StartEditOrder()
        {
            Console.Clear();
            string choice = "x";
            while (choice != "0")
            {
                SaveFileJsonOders();
                Console.WriteLine("-- Edit order --");
                Console.WriteLine("1. Edit order ID.");
                Console.WriteLine("2. Edit status order.");
                Console.WriteLine("3. Edit customer name.");
                Console.WriteLine("4. Edit customer address.");
                Console.WriteLine("5. Edit list product.");
                Console.WriteLine("0. Back.");
                Console.Write("Enter you choice: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        EditOrderID();
                        break;
                    case "2":
                        EditOrderStatus();
                        break;
                    case "3":
                        EditCustomerName();
                        break;
                    case "4":
                        EditCustomerAddress();
                        break;
                    case "5":
                        EditListProduct();
                        break;
                    case "0":
                        ManagermanetOrder();
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                }

            }
        }
        static void EditOrderID()
        {
            Console.WriteLine("Edit order ID...");
            Console.Write("Enter order ID: ");
            string orderID = Console.ReadLine();
            bool isOrderIDInListOderAdmin = IsOrderIDInListOrderAdmin(orderID);
            if (isOrderIDInListOderAdmin)
            {
                Console.Write("Enter new order ID: ");
                string newOrderID = Console.ReadLine();
                foreach(var order in admin.orders)
                {
                    if (order.OrderID == orderID)
                    {
                        order.OrderID = newOrderID;
                    }
                }
            }
            else
            {
                Console.WriteLine("Oder ID does not exist! Press\"Enter\"to go back...");
                Console.ReadKey();
            }
        }
        static void EditOrderStatus()
        {
            Console.WriteLine("Edit order status ...");
            Console.Write("Enter order ID: ");
            string orderID = Console.ReadLine();
            bool isOrderIDInListOderAdmin = IsOrderIDInListOrderAdmin(orderID);
            if (isOrderIDInListOderAdmin)
            {
                Console.Write("Order status was pay? ( Y : Yes or Other : No)");
                string newStatusOder = Console.ReadLine();
                bool newStatus = false;
                if (newStatusOder.ToUpper() == "Y")
                {
                    newStatus = true;
                }
                foreach (var order in admin.orders)
                {
                    if (order.OrderID == orderID)
                    {
                        order.Status = newStatus;
                    }
                }
            }
            else
            {
                Console.WriteLine("Oder ID does not exist! Press\"Enter\"to go back...");
                Console.ReadKey();
            }
            PayAndSavingOrderPain();

        }
        static void EditCustomerName()
        {
            Console.WriteLine("Edit customer name...");
            Console.WriteLine("Edit order ID...");
            Console.Write("Enter order ID: ");
            string orderID = Console.ReadLine();
            bool isOrderIDInListOderAdmin = IsOrderIDInListOrderAdmin(orderID);
            if (isOrderIDInListOderAdmin)
            {
                Console.Write("Enter new order ID: ");
                string newCustomerName = Console.ReadLine();
                foreach (var order in admin.orders)
                {
                    if (order.OrderID == orderID)
                    {
                        order.CustomerName = newCustomerName;
                    }
                }
            }
            else
            {
                Console.WriteLine("Oder ID does not exist! Press\"Enter\"to go back...");
                Console.ReadKey();
            }
        }
        static void EditCustomerAddress()
        {
            Console.WriteLine("Edit customer address...");
            Console.WriteLine("Edit order ID...");
            Console.Write("Enter order ID: ");
            string orderID = Console.ReadLine();
            bool isOrderIDInListOderAdmin = IsOrderIDInListOrderAdmin(orderID);
            if (isOrderIDInListOderAdmin)
            {
                Console.Write("Enter new order ID: ");
                string newCustomerAddress = Console.ReadLine();
                foreach (var order in admin.orders)
                {
                    if (order.OrderID == orderID)
                    {
                        order.CustomerAddress = newCustomerAddress;
                    }
                }
            }
            else
            {
                Console.WriteLine("Oder ID does not exist! Press\"Enter\"to go back...");
                Console.ReadKey();
            }
        }
        static void EditListProduct()
        {
            Console.WriteLine("Edit list product...");
            Console.Write("Enter order ID: ");
            string orderID = Console.ReadLine();
            bool isOrderIDInListOderAdmin = IsOrderIDInListOrderAdmin(orderID);
            if (isOrderIDInListOderAdmin)
            {
                Console.Write("Enter new order ID: ");
                string newOrderID = Console.ReadLine();
                foreach (var order in admin.orders)
                {
                    if (order.OrderID == orderID)
                    {
                        StartEditListProduct(order);

                    }
                }
            }
            else
            {
                Console.WriteLine("Oder ID does not exist! Press\"Enter\"to go back...");
                Console.ReadKey();
            }
        }
        static void StartEditListProduct(Order order)
        {
            ShowListProductInOrder(order);
            Console.WriteLine("1. Edit amount product");
            Console.WriteLine("2. Remove product");
            Console.WriteLine("0. Back");
            Console.WriteLine("You choice: ");
            string choiceEdit = Console.ReadLine();
            switch (choiceEdit)
            {
                case "1":
                    Console.WriteLine("Edit amount product");
                    EditAmountProduct(order);
                    break;
                case "2":
                    Console.WriteLine("Remove product");
                    RemoveProduct(order);
                    break;
                case "0":
                    StartEditOrder();
                    break;
                default:
                    Console.WriteLine("No choice!");
                    StartEditListProduct(order);
                    break;
            }
        }
        static void EditAmountProduct(Order order)
        {
            int idEdit = GetIDProductEdit(order);
            Console.WriteLine("Enter new amount: ");
            string new_Amount = Console.ReadLine();
            int newAmount;
            while (!Int32.TryParse(new_Amount, out newAmount) || newAmount <= 0)
            {
                Console.WriteLine("Enter again new amount: ");
                new_Amount = Console.ReadLine();
            }
            foreach (var product in order.products)
            {
                if (product.ID == idEdit)
                {
                    product.Amount = newAmount;
                }
            }
        }
        static void RemoveProduct(Order order)
        {
            int idEdit = GetIDProductEdit(order);
            var productRemove = new Product();
            foreach (var product in order.products)
            {
                if (product.ID == idEdit)
                {
                    productRemove = product;
                }
            }
            order.products.Remove(productRemove);
        }
        static int GetIDProductEdit(Order order)
        {
            Console.Write("Enter ID product edit: ");
            string strID = Console.ReadLine();
            int idProductEdit;
            while (!Int32.TryParse(strID, out idProductEdit) || idProductEdit <= 0 || !IsIDInOrderListProduct(idProductEdit, order))
            {
                Console.WriteLine("The ID does not exist in shopping cart!");
                StartEditListProduct(order);
            }
            return idProductEdit;
        }
        static bool IsIDInOrderListProduct(int idProductEdit, Order order)
        {
            foreach (var product in order.products)
            {
                if (product.ID == idProductEdit)
                {
                    return true;
                }
            }
            return false;
        }
        static void ShowListProductInOrder(Order order)
        {
            Console.WriteLine("ID\tName\t\t\tManufacturer\t\tPrice\t\tOtherDescriptions\t\tAmount\tIntoMoney");
            foreach (var product in order.products)
            {
                Console.WriteLine(product.ToString());
            }
            Console.WriteLine();
        }
        static bool IsOrderIDInListOrderAdmin(string oderID)
        {
            foreach(var order in admin.orders)
            {
                if (order.OrderID == oderID)
                {
                    return true;
                }
            }
            return false;
        }
        static void StartGenerateOrder()
        {
            Console.Clear();
            string choice = "x";
            while (choice != "0")
            {
                SaveFileJsonOders();
                PayAndSavingOrderPain();
                Console.WriteLine("-- Generate order --");
                Console.WriteLine("1. Generate order.");
                Console.WriteLine("0. Back.");
                Console.Write("Enter you choice: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        GenerateOrder();
                        break;
                    case "0":
                        ManagermanetOrder();
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                }

            }
        }
        static void GenerateOrder()
        {
            Console.WriteLine("Generate order...");
            Console.Write("Enter order ID: ");
            string idOder = Console.ReadLine();
            Console.Write("Order was pay? ( Y : Yes or Other : No)");
            string statusOder = Console.ReadLine();
            bool status = false;
            if(statusOder.ToUpper() == "Y")
            {
                status = true;
            }
            Console.Write("Enter Customer name:");
            string customerName = Console.ReadLine();
            Console.Write("Enter Customer address:");
            string customerAddress = Console.ReadLine();
            Order order = new Order()
            {
                OrderID =idOder,
                Status = status,
                CustomerName = customerName,
                CustomerAddress = customerAddress,
                products = new List<Product>()
            };
            GenerateListProduct(order);
            //admin.ordersAdmin.Add(order);
            //StartGenerateOrder();
        }
        static void GenerateListProduct(Order order)
        {
            string buyNumber = "x";
            while (buyNumber != "0")
            {
                Console.WriteLine("** Generate list product **");
                Console.WriteLine("     ...Menu Product...");
                foreach (var product in menuProduct)
                {
                    Console.WriteLine($"{product.Key}. {product.Value.Name}, price: {product.Value.Price} VND");
                }
                Console.WriteLine("0. Back");
                Console.Write("Add product : ");
                buyNumber = Console.ReadLine();
                switch (buyNumber)
                {
                    case "0":
                        Console.WriteLine("Back...");
                        admin.orders.Add(order);
                        StartGenerateOrder();
                        break;
                    default:
                        int idProduct;
                        while (!Int32.TryParse(buyNumber, out idProduct) || idProduct <= 0 || !IsProductID(idProduct))
                        {
                            Console.WriteLine("The selection does not exist!");
                            GenerateListProduct(order);
                        }
                        int amount = GetAmount();
                        if (menuProduct[idProduct].Amount > 0)
                        {
                            menuProduct[idProduct].Amount += amount;
                        }
                        else
                        {
                            menuProduct[idProduct].Amount = amount;
                            order.products.Add(menuProduct[idProduct]);
                        }
                        break;
                }
            }
        }
        static int GetAmount()
        {
            Console.Write("Amount: ");
            string number = Console.ReadLine();
            int quantity;
            while (!Int32.TryParse(number, out quantity) || quantity <= 0)
            {
                Console.Write("The quantity is not validate!. Enter again amount: ");
                number = Console.ReadLine();
            }
            return quantity;
        }
        static bool IsProductID(int id)
        {
            foreach (var product in menuProduct)
            {
                if (product.Value.ID == id)
                {
                    return true;
                }
            }
            return false;
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
    }
}
