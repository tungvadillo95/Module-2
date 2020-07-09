using System;
using System.Collections.Generic;
using System.Text;
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
            return $"{name}\t{code}\t{price}\t\t{date.ToString("ddd, MMM dd yyyy")}\t\t{madein}";
        }

    }
    class ProductService
    {
        public Product[] products = new Product[0];
        private int FindProduct(string code)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].Code.ToUpper() == code.ToUpper())
                {
                    return i;
                }
            }
            return -1;
        }
        public void Add(Product product)
        {
            Array.Resize(ref products, products.Length + 1);
            products[products.Length - 1] = product;
        }
        public void Edit(Product product)
        {
            var pos = FindProduct(product.code);
            if(pos != -1)
            {
                products[pos].name = product.name;
                products[pos].price = product.price;
                products[pos].madein = product.madein;
            }
            else
            {
                Console.WriteLine($"Code: {product.code} not found");
            }
        }
        /*public void Edit(Product product)
        {
            var pos = FindProduct(product.code);
            if (pos != -1)
            {
                products[pos].name = product.name;
                products[pos].price = product.price;
                products[pos].madein = product.madein;
            }
            else
            {
                Console.WriteLine($"Code: {product.code} not found");
            }
        }*/
        public void Delete(string code)
        {
            var pos = FindProduct(code);
            if(pos != -1)
            {
                for(int i = pos; i < products.Length - 1; i++)
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
        public void Show()
        {
            string table = $"name \t code \t price \t\t date \t\t madein";
            for(int i = 0; i < products.Length; i++)
            {
                table += $"\n" + products[i].ShowProductInfo();
            }
            Console.WriteLine(table);
        }
    }
}