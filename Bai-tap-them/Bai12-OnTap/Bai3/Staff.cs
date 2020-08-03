using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Bai3
{
    class Staff
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        public string PassWord { get; set; }
        public List<Order> orders { get; set; }
        public void DisplayInfoStaff()
        {
            Console.WriteLine($"ID: {ID}, Name: {Name}, Email: {Email}, PassWord: {PassWord}");
        }
        public void DisplayOrdersStaff()
        {
            foreach(var order in orders)
            {
                order.Display();
            }
        }
        public void InterfaceStaff(Staff staff, Admin admin)
        {
            Console.Clear();
            string choice = "x";
            while (choice != "0")
            {
                Console.WriteLine("***---STAFF MANAGERMENT---***");
                Console.WriteLine("1. Managerment order.");
                Console.WriteLine("2. Information managerment staff");
                Console.WriteLine("0. Back.");
                Console.Write("Enter you choice: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        ManagermanetOrder(staff, admin);
                        break;
                    case "2":
                        InfoManagermentStaff(staff, admin);
                        break;
                    case "0":
                        Program.LoginUsingManagerment();
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                }
            }
        }
        public void InfoManagermentStaff(Staff staff, Admin admin)
        {
            Console.Clear();
            string choice = "x";
            while (choice != "0")
            {
                Console.WriteLine("**-- Information Managerment --**");
                Console.WriteLine("1. Edit staff.");
                Console.WriteLine("2. Show information staff.");
                Console.WriteLine("0. Back.");
                Console.Write("Enter you choice: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        EditProfileStaff(staff, admin);
                        break;
                    case "2":
                        ShowInfoStaff(staff);
                        break;
                    case "0":
                        staff.InterfaceStaff(staff, admin);
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                }
            }
        }
        public void ShowInfoStaff(Staff staff)
        {
            Console.WriteLine("... Show information staff ...");
            staff.DisplayInfoStaff();

        }
        public void EditProfileStaff(Staff staff, Admin admin)
        {
            string choice = "x";
            while (choice != "0")
            {
                Console.WriteLine("Do you want edit? ");
                Console.WriteLine("1. Name");
                Console.WriteLine("2. Email");
                Console.WriteLine("3. PassWord");
                Console.WriteLine("0. Back");
                Console.Write("Enter you choice: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("New Name: ");
                        string newName = Console.ReadLine();
                        staff.Name = newName;
                        break;
                    case "2":
                        Console.WriteLine("New Email: ");
                        string newStaffEmail = Console.ReadLine();
                        while (IsEmailInListStaff(newStaffEmail, admin))
                        {
                            Console.Write("The staff email already exist in list staffs!");
                            Console.Write("Enter again Email new Staff: ");
                            newStaffEmail = Console.ReadLine();
                        }
                        staff.Email = newStaffEmail;
                        break;
                    case "3":
                        Console.WriteLine("New PassWord: ");
                        string newPassWord = Console.ReadLine();
                        staff.PassWord = newPassWord;
                        break;
                    case "0":
                        staff.InterfaceStaff(staff, admin);
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                }
            }
        }
        public bool IsEmailInListStaff(string newStaffEmail, Admin admin)
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
        public void ManagermanetOrder(Staff staff, Admin admin)
        {
            Console.Clear();
            string choice = "x";
            while (choice != "0")
            {
                SaveOrder();
                Console.WriteLine("**-- Managerment order --**");
                Console.WriteLine("1. Generate order.");
                Console.WriteLine("2. Edit order.");
                Console.WriteLine("3. Search order.");
                Console.WriteLine("4. Show all order.");
                Console.WriteLine("5. Pay order.");
                Console.WriteLine("0. Back.");
                Console.Write("Enter you choice: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        StartGenerateOrder(staff, admin);
                        break;
                    case "2":
                        StartEditOrder(staff, admin);
                        break;
                    case "3":
                        StartSearchOder(staff, admin);
                        break;
                    case "4":
                        ShowAllOrder(staff);
                        break;
                    case "5":
                        PayOrder(staff, admin);
                        break;
                    case "0":
                        InterfaceStaff(staff, admin);
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                }
            }
        }
        public void PayOrder(Staff staff, Admin admin)
        {
            Console.Write("Enter order ID: ");
            string orderID = Console.ReadLine();
            bool isOrderIDInListOderAdmin = IsOrderIDInListOrderAdmin(orderID, staff);
            if (isOrderIDInListOderAdmin)
            {
                foreach (var order in staff.orders)
                {
                    if (order.OrderID == orderID)
                    {
                        order.Status = true;
                        order.Display();
                        BillPayOrder(staff);
                    }
                }
            }
            else
            {
                Console.WriteLine("Oder ID does not exist! Press\"Enter\"to go back...");
                Console.ReadKey();
            }
        }
        public void BillPayOrder(Staff staff)
        {
            foreach (var order in staff.orders)
            {
                if (order.Status)
                {
                    const string FILE_PATH = @"C:\Users\ASUS\Desktop\BT-CODEGYM\Module-2\Bai-tap-them\Bai12-OnTap\Bai3\data";
                    var LOG_FILE_BILL = $"Bill_{order.OrderID}_{Name}_{DateTime.Now.ToString("dd_MM_yyyy_hh_mm_ss")}.json";
                    using (StreamWriter sw = File.CreateText($@"{FILE_PATH}\{LOG_FILE_BILL}"))
                    {
                        var datum = JsonConvert.SerializeObject(order);
                        sw.Write(datum);
                    }
                    staff.orders.Remove(order);
                    break;
                }
            }
        }
        public void ShowAllOrder(Staff staff)
        {
            Console.WriteLine("-- Show all order --");
            foreach (var order in staff.orders)
            {
                order.Display();
            }
        }
        public void StartSearchOder(Staff staff, Admin admin)
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
                        SearchOrderByOrderID(staff);
                        break;
                    case "2":
                        SearchOderByCustomerName(staff);
                        break;
                    case "3":
                        SearchOderByCustomerAddress(staff);
                        break;
                    case "0":
                        ManagermanetOrder(staff, admin);
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                }

            }
        }
        public void SearchOderByCustomerAddress(Staff staff)
        {
            Console.WriteLine("Search order by customer address...");
            Console.Write("Enter customer address: ");
            string customerAddress = Console.ReadLine();
            int count = 0;
            foreach (var order in staff.orders)
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
        public void SearchOderByCustomerName(Staff staff)
        {
            Console.WriteLine("Search order by customer name...");
            Console.Write("Enter customer name: ");
            string customerName = Console.ReadLine();
            int count = 0;
            foreach (var order in staff.orders)
            {
                if (order.CustomerName.ToUpper() == customerName.ToUpper())
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
        public void SearchOrderByOrderID(Staff staff)
        {
            Console.Write("Enter order ID: ");
            string orderID = Console.ReadLine();
            bool isOrderIDInListOderAdmin = IsOrderIDInListOrderAdmin(orderID, staff);
            if (isOrderIDInListOderAdmin)
            {
                foreach (var order in staff.orders)
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
        public void StartEditOrder(Staff staff, Admin admin)
        {
            Console.Clear();
            string choice = "x";
            while (choice != "0")
            {
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
                        EditOrderID(staff);
                        break;
                    case "2":
                        EditOrderStatus(staff);
                        break;
                    case "3":
                        EditCustomerName(staff);
                        break;
                    case "4":
                        EditCustomerAddress(staff);
                        break;
                    case "5":
                        EditListProduct(staff, admin);
                        break;
                    case "0":
                        ManagermanetOrder(staff, admin);
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                }
            }
        }
        public void EditListProduct(Staff staff, Admin admin)
        {
            Console.WriteLine("Edit list product...");
            Console.Write("Enter order ID: ");
            string orderID = Console.ReadLine();
            bool isOrderIDInListOderAdmin = IsOrderIDInListOrderAdmin(orderID, staff);
            if (isOrderIDInListOderAdmin)
            {
                Console.Write("Enter new order ID: ");
                string newOrderID = Console.ReadLine();
                foreach (var order in staff.orders)
                {
                    if (order.OrderID == orderID)
                    {
                        StartEditListProduct(order, staff, admin);

                    }
                }
            }
            else
            {
                Console.WriteLine("Oder ID does not exist! Press\"Enter\"to go back...");
                Console.ReadKey();
            }
        }
        public void StartEditListProduct(Order order, Staff staff, Admin admin)
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
                    EditAmountProduct(order, staff, admin);
                    break;
                case "2":
                    Console.WriteLine("Remove product");
                    RemoveProduct(order, staff, admin);
                    break;
                case "0":
                    StartEditOrder(staff, admin);
                    break;
                default:
                    Console.WriteLine("No choice!");
                    break;
            }
        }
        public void RemoveProduct(Order order, Staff staff, Admin admin)
        {
            int idEdit = GetIDProductEdit(order, staff, admin);
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
        public void EditAmountProduct(Order order, Staff staff, Admin admin)
        {
            int idEdit = GetIDProductEdit(order, staff, admin);
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
        public int GetIDProductEdit(Order order, Staff staff, Admin admin)
        {
            Console.Write("Enter ID product edit: ");
            string strID = Console.ReadLine();
            int idProductEdit;
            while (!Int32.TryParse(strID, out idProductEdit) || idProductEdit <= 0 || !IsIDInOrderListProduct(idProductEdit, order))
            {
                Console.WriteLine("The ID does not exist in shopping cart!");
                StartEditListProduct(order, staff, admin);
            }
            return idProductEdit;
        }
        public bool IsIDInOrderListProduct(int idProductEdit, Order order)
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
        public void ShowListProductInOrder(Order order)
        {
            Console.WriteLine("ID\tName\t\t\tManufacturer\t\tPrice\t\tOtherDescriptions\t\tAmount\tIntoMoney");
            foreach (var product in order.products)
            {
                Console.WriteLine(product.ToString());
            }
            Console.WriteLine();
        }
        public void EditCustomerAddress(Staff staff)
        {
            Console.WriteLine("Edit customer address...");
            Console.WriteLine("Edit order ID...");
            Console.Write("Enter order ID: ");
            string orderID = Console.ReadLine();
            bool isOrderIDInListOderAdmin = IsOrderIDInListOrderAdmin(orderID, staff);
            if (isOrderIDInListOderAdmin)
            {
                Console.Write("Enter new order ID: ");
                string newCustomerAddress = Console.ReadLine();
                foreach (var order in staff.orders)
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
        public void EditCustomerName(Staff staff)
        {
            Console.WriteLine("Edit customer name...");
            Console.WriteLine("Edit order ID...");
            Console.Write("Enter order ID: ");
            string orderID = Console.ReadLine();
            bool isOrderIDInListOderAdmin = IsOrderIDInListOrderAdmin(orderID, staff);
            if (isOrderIDInListOderAdmin)
            {
                Console.Write("Enter new order ID: ");
                string newCustomerName = Console.ReadLine();
                foreach (var order in staff.orders)
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
        public void EditOrderStatus(Staff staff)
        {
            Console.WriteLine("Edit order status ...");
            Console.Write("Enter order ID: ");
            string orderID = Console.ReadLine();
            bool isOrderIDInListOderAdmin = IsOrderIDInListOrderAdmin(orderID, staff);
            if (isOrderIDInListOderAdmin)
            {
                Console.Write("Order status was pay? ( Y : Yes or Other : No)");
                string newStatusOder = Console.ReadLine();
                bool newStatus = false;
                if (newStatusOder.ToUpper() == "Y")
                {
                    newStatus = true;
                }
                foreach (var order in staff.orders)
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
        }
        public void EditOrderID(Staff staff)
        {
            Console.WriteLine("Edit order ID...");
            Console.Write("Enter order ID: ");
            string orderID = Console.ReadLine();
            bool isOrderIDInListOderAdmin = IsOrderIDInListOrderAdmin(orderID, staff);
            if (isOrderIDInListOderAdmin)
            {
                Console.Write("Enter new order ID: ");
                string newOrderID = Console.ReadLine();
                foreach (var order in staff.orders)
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
        public bool IsOrderIDInListOrderAdmin(string oderID, Staff staff)
        {
            foreach (var order in staff.orders)
            {
                if (order.OrderID == oderID)
                {
                    return true;
                }
            }
            return false;
        }
        public void StartGenerateOrder(Staff staff, Admin admin)
        {
            Console.Clear();
            string choice = "x";
            while (choice != "0")
            {
                Console.WriteLine("-- Generate order --");
                Console.WriteLine("1. Generate order.");
                Console.WriteLine("0. Back.");
                Console.Write("Enter you choice: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        GenerateOrder(staff, admin);
                        break;
                    case "0":
                        staff.ManagermanetOrder(staff, admin);
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                }
            }
        }
        public void GenerateOrder(Staff staff, Admin admin)
        {
            Console.WriteLine("Generate order...");
            Console.Write("Enter order ID: ");
            string idOder = Console.ReadLine();
            bool status = false;
            Console.Write("Enter Customer name:");
            string customerName = Console.ReadLine();
            Console.Write("Enter Customer address:");
            string customerAddress = Console.ReadLine();
            Order order = new Order()
            {
                OrderID = idOder,
                Status = status,
                CustomerName = customerName,
                CustomerAddress = customerAddress,
                products = new List<Product>()
            };
            GenerateListProduct(order,staff, admin);
        }
        public void GenerateListProduct(Order order, Staff staff, Admin admin)
        {
            string buyNumber = "x";
            while (buyNumber != "0")
            {
                Console.WriteLine("** Generate list product **");
                Console.WriteLine("     ...Menu Product...");
                foreach (var product in admin.menuProduct)
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
                        staff.orders.Add(order);
                        StartGenerateOrder(staff, admin);
                        break;
                    default:
                        int idProduct;
                        while (!Int32.TryParse(buyNumber, out idProduct) || idProduct <= 0 || !IsProductID(idProduct, admin))
                        {
                            Console.WriteLine("The selection does not exist!");
                            GenerateListProduct(order, staff, admin);
                        }
                        int amount = GetAmount();
                        if (admin.menuProduct[idProduct].Amount > 0)
                        {
                            admin.menuProduct[idProduct].Amount += amount;
                        }
                        else
                        {
                            admin.menuProduct[idProduct].Amount = amount;
                            order.products.Add(admin.menuProduct[idProduct]);
                        }
                        break;
                }
            }
        }
        public bool IsProductID(int id, Admin admin)
        {
            foreach (var product in admin.menuProduct)
            {
                if (product.Value.ID == id)
                {
                    return true;
                }
            }
            return false;
        }
        public int GetAmount()
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
        public void SaveOrder()
        {
            const string FILE_PATH = @"C:\Users\ASUS\Desktop\BT-CODEGYM\Module-2\Bai-tap-them\Bai12-OnTap\Bai3\data\orders";
            var FILE_ORDER_STAFF = $"order_{Name}.json";
            using (StreamWriter sw = File.CreateText($@"{FILE_PATH}\{FILE_ORDER_STAFF}"))
            {
                var datum = JsonConvert.SerializeObject(orders);
                sw.Write(datum);
            }

        }
    }
}
