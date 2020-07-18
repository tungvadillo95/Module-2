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
                        Console.WriteLine("Create Post...");
                        CreatePost();
                        break;
                    case 2:
                        Console.WriteLine("Update Post by ID...");
                        UpdatePost();
                        break;
                    case 3:
                        Console.WriteLine("Remove Post by ID...");
                        RemovePost();
                        break;
                    case 4:
                        forum.Show();
                        break;
                    case 5:
                        SearchTitleOrAuthor();
                        break;
                    case 6:
                        RatingByID();
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
            post.ID = ++newID;
            forum.AddPost(post);
        }
        public static void UpdatePost()
        {
            int id = GetID();
            Console.WriteLine("Enter new content: ");
            string newContent = Console.ReadLine();
            forum.Update(id, newContent);
        }
        public static void RemovePost()
        {
            int id = GetID();
            forum.Remove(id);
        }
        public static int GetID()
        {
            Console.Write("Enter ID: ");
            int id = int.Parse(Console.ReadLine());
            while (id < 0)
            {
                Console.Write("Enter again ID:");
                id = int.Parse(Console.ReadLine());
            }
            return id;
        }
        public static void SearchTitleOrAuthor()
        {
            byte choice_search;
            Console.WriteLine("Search...");
            Console.WriteLine("Enter you choice!");
            Console.WriteLine("1. Search by Title");
            Console.WriteLine("2. Search by Author");
            choice_search = byte.Parse(Console.ReadLine());
            switch (choice_search)
            {
                case 1:
                    Console.Write("Enter Title search: ");
                    string title = Console.ReadLine();
                    Console.WriteLine("Result...");
                    forum.FindTitle(title);
                    break;
                case 2:
                    Console.Write("Enter Author search: ");
                    string author = Console.ReadLine();
                    Console.WriteLine("Result...");
                    forum.FindAuthor(author);
                    break;
                default:
                    Console.WriteLine("No choice!");
                    break;
            }
        }
        public static void RatingByID()
        {
            Console.WriteLine("Rating by ID...");
            int id = GetID();
            int index = forum.FindID(id);
            if (index == -1)
            {
                Console.WriteLine("Invalid Post!");
            }
            else
            {
                int rate = InputRating();
                forum.Posts[index].RateList.Add(rate);
                Console.Write("Result: ");
                forum.Posts[index].Display();
            }
        }
        public static int InputRating()
        {
            string number;
            int rate;
            Console.Write("Enter rate: ");
            number = Console.ReadLine();
            while(!IsRating(number,out rate))
            {
                Console.Write("Enter again rate: ");
                number = Console.ReadLine();
            }
            return rate;
        }
        public static bool IsRating(string number, out int rate)
        {
            bool isRate = (Int32.TryParse(number, out rate) && rate > 0 && rate <= 5);
            return isRate;
        }
    }
}
