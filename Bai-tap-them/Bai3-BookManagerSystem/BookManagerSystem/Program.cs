using System;

namespace BookManagerSystem
{
    class Program
    {
        public static Book[] bookList = new Book[0];
        static void Main(string[] args)
        {
            byte choice = 5;
            while (choice != 4)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Insert new book");
                Console.WriteLine("2. View list of books");
                Console.WriteLine("3. Average Price");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter your choice");
                choice = byte.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Insert new book");
                        CreatBook();
                        break;
                    case 2:
                        Console.WriteLine("View list of books");
                        for (int i = 0; i < bookList.Length; i++)
                        {
                            bookList[i].Display();
                        }
                        break;
                    case 3:
                        Console.WriteLine("Average Price");
                        for (int i = 0; i < bookList.Length; i++)
                        {
                            bookList[i].Calculate();
                            bookList[i].Display();
                        }
                        break;
                    case 4:
                        Console.WriteLine("End program !");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                }
            }
        }
        public static void CreatBook()
        {
            Book newbook = new Book();
            Console.Write("Name: ");
            newbook.Name = Console.ReadLine();
            Console.Write("Publish Date: ");
            newbook.PublishDate = Console.ReadLine();
            Console.Write("Author: ");
            newbook.Author = Console.ReadLine();
            Console.Write("Language: ");
            newbook.Language = Console.ReadLine();
            newbook.ID++;
            for(int i = 0; i < newbook.PriceList.Length; i++)
            {
                Console.WriteLine($"Enter price {i+1}: ");
                newbook.PriceList[i] = float.Parse(Console.ReadLine());
            }
            Array.Resize(ref bookList, bookList.Length + 1);
            bookList[bookList.Length - 1] = newbook;
        }
    }
}
