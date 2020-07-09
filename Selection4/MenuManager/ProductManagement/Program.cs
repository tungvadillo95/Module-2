using System;

namespace ProductManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateProduct();
            ProductService.Show();
            /*CreateProduct();
            ProductService.Show();
            RemoveProduct();
            ProductService.Show();*/

        }
        public static void CreateProduct()
        {
            var product=new Product();
            Console.WriteLine("Product name: ");
            product.name = Console.ReadLine();
            Console.Write("Product Code: ");
            product.code = Console.ReadLine();
            Console.Write("Price: ");
            product.price = double.Parse(Console.ReadLine());
            Console.Write("Product date(yyy/mm/dd): ");
            product.date = DateTime.Parse(Console.ReadLine());
            Console.Write("Made in: ");
            product.madein = Console.ReadLine();
            ProductService.Add(product);
        }
         public static void RemoveProduct()
        {
            Console.Write("Enter code: ");
            var code = Console.ReadLine();
            ProductService.Delete(code);
        }
        public static void EditProduct()
        {
            Console.WriteLine("Enter product: ");
            var product= Console.ReadLine();
            ProductService.Delete(product);
        }
    }
}
