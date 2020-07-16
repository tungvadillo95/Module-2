using System;

namespace Collection
{
    class Program
    {
        public static Forum forum = new Forum();
        public static int newID = 0;
        static void Main(string[] args)
        {
            byte choice = 8;
            while (choice != 0)
            {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Create Post");
            Console.WriteLine("2. Update Post");
            Console.WriteLine("3. Remove Post");
            Console.WriteLine("4. Show Posts");
            Console.WriteLine("5. Search");
            Console.WriteLine("6. Rating");
            Console.WriteLine("7. Exit");
            Console.WriteLine("Enter your choice: ");
            choice = byte.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        CreatePost();
                        //Console.WriteLine("Add phone manager");
                        //Console.Write("Enter name: ");
                        //name = Console.ReadLine();
                        //Console.Write("Enter phone number: ");
                        //newPhone = Console.ReadLine();
                        //phoneBook.InsertPhone(name, newPhone);
                        break;
                    case 2:
                        //Console.WriteLine("Update phone manager");
                        //Console.Write("Enter name: ");
                        //name = Console.ReadLine();
                        //Console.Write("Enter phone number: ");
                        //newPhone = Console.ReadLine();
                        //phoneBook.UpdatePhone(name, newPhone);
                        break;
                    case 3:
                        //Console.WriteLine("Remove phone manager");
                        //Console.Write("Enter name: ");
                        //name = Console.ReadLine();
                        //phoneBook.RemovePhone(name);
                        break;
                    case 4:
                        //Console.WriteLine("Search phone manager");
                        //Console.Write("Enter name: ");
                        //name = Console.ReadLine();
                        //phoneBook.SearchPhone(name);
                        break;
                    case 5:
                        forum.Show();
                        break;
                    case 6:
                        //phoneBook.Sort();
                        break;
                    case 7:
                        Console.WriteLine("Exit...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                }
            }
        }
        public static void CreatePost()
        {
            Post post = new Post();
            Console.Write("Title: ");
            post.Title = Console.ReadLine();
            Console.Write("Author: ");
            post.Author = Console.ReadLine();
            Console.Write("Content: ");
            post.Content = Console.ReadLine();
            for(int i=0; i < post.RateList.Length; i++)
            {
                Console.WriteLine($"Enter vote rate {i+1}: ");
                string temp = Console.ReadLine();
                while (!Int32.TryParse(temp, out post.RateList[i]) || (post.RateList[i] < post.MINRATING || post.RateList[i] > post.MAXRATING))
                {
                    Console.Write($"Nhap Lai: ");
                    temp = Console.ReadLine();
                }
            }
            post.ID = newID;
            newID++;
            forum.AddPost(post);
        }
    }
}
