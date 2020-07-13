using System;

namespace Bai_2
{
    class Program
    {
        public static New[] news = new New[0];
        static void Main(string[] args)
        {
            byte choice = 0;
            while (choice != 4)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Insert news");
                Console.WriteLine("2. View list news");
                Console.WriteLine("3. Average news");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter your choice");
                choice = byte.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Insert news");
                        CreatNew();
                        break;
                    case 2:
                        Console.WriteLine("View list news");
                        for (int i = 0; i < news.Length; i++)
                        {
                            news[i].Display();
                        }
                        break;
                    case 3:
                        Console.WriteLine("Average news");
                        for (int i = 0; i < news.Length; i++)
                        {
                            news[i].Calculate();
                            news[i].Display();
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
        public static void CreatNew()
        {
            New newsBulletin = new New();
            Console.Write("Title: ");
            newsBulletin.Title = Console.ReadLine();
            Console.Write("PublishDate: ");
            newsBulletin.PublishDate = Console.ReadLine();
            Console.Write("Author: ");
            newsBulletin.Author = Console.ReadLine();
            Console.Write("Content: ");
            newsBulletin.Content = Console.ReadLine();
            Console.WriteLine("Enter vote rate 1: ");
            newsBulletin.RateList[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter vote rate 2: ");
            newsBulletin.RateList[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter vote rate 3: ");
            newsBulletin.RateList[2] = int.Parse(Console.ReadLine());
            Array.Resize(ref news, news.Length + 1);
            news[news.Length - 1] = newsBulletin;
        }
    }
}
