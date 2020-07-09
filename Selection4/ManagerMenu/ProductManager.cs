using System;

namespace ProductManagement
{
    class Product
    {
        public string name { get; set; }
        public string code { get; set; }
        public double price { set; get; }
        public DateTime date { get; set; }
        public string madein { get; set; }
        public string ShowProductInfo()
        {
            return $"{name}\t{code}\t{price}\t\t{date.ToString("ddd, MMM dd yyyy")}\t{madein}";
        }

    }
    class ProductService
    {
        public static Product[] products = new Product[0];
        public static int FindProduct(string code)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].code.ToUpper() == code.ToUpper())
                {
                    return i;
                }
            }

            return -1;

        }
        public static void Add(Product product)
        {
            Array.Resize(ref products, products.Length + 1);
            products[products.Length - 1] = product;
        }
        public static void Edit(Product product)
        {
            var pos = FindProduct(product.code);
            if (pos != -1)
            {
                products[pos].name = product.name;
                products[pos].price = product.price;
                products[pos].madein = product.madein;
                // string names, codes, madeins;
                // double prices;
                // DateTime dates;
                // Console.Write("New name: ");
                // names = Console.ReadLine();
                // products[pos].name = names;
                // Console.Write("New code: ");
                // codes = Console.ReadLine();
                // products[pos].name = names;
                // Console.Write("New price: ");
                // prices = double.Parse(Console.ReadLine());
                // products[pos].price = prices;
                // Console.Write("New date: ");
                // dates = DateTime.Parse(Console.ReadLine());
                // products[pos].date = dates;
                // Console.Write("New made in: ");
                // madeins = (Console.ReadLine());
                // products[pos].madein = madeins;
            }
            else
            {
                Console.WriteLine($"Code: {product.code} not found");
            }
        }
        public static void Delete(string code)
        {
            var pos = FindProduct(code);
            if (pos != -1)
            {
                for (int i = pos; i < products.Length - 1; i++)
                {
                    products[i] = products[i + 1];
                }
                Array.Resize(ref products, products.Length - 1);
            }
            else
            {
                Console.WriteLine($"Code: {code} not found");
            }
        }
        public static void Show()
        {
            string table = $"Name \t Code \t Price \t\t Date\t\t\tMadein";
            for (int i = 0; i < products.Length; i++)
            {
                table += $"\n" + products[i].ShowProductInfo();
            }
            Console.WriteLine(table);
        }
    }
}