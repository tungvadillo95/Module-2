using System;
using System.Collections.Generic;

namespace Bai3
{
    class Forum
    {
        public static List<Post> PostList = new List<Post>();
        public const int MIN_RATING = 1;
        public const int MAX_RATING = 5;
        static void Main(string[] args)
        {
            string choice = "";
            while (choice != "4")
            {
                Console.WriteLine("***--- MANAGERMENT POST ---***");
                Console.WriteLine("1. Create Post");
                Console.WriteLine("2. Calculator");
                Console.WriteLine("3. Show list");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter your choice: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("... Create Post ...");
                        CreatePost();
                        break;
                    case "2":
                        if (IsEmptyPostList())
                        {
                            Console.WriteLine("The post list is empty!. Press\"Enter\" to continue......");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("... Calculator ...");
                            Calculator();
                        }
                        break;
                    case "3":
                        if (IsEmptyPostList())
                        {
                            Console.WriteLine("The post list is empty!. Press\"Enter\" to continue......");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("... Show list ...");
                            ShowList();
                        }
                        break;
                    case "4":
                        Console.WriteLine("....EXIT...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                }
            }
        }
        static void ShowList()
        {
            foreach(var post in PostList)
            {
                post.Display();
            }
        }
        static void Calculator()
        {
            //float sumAverageRatePost = 0;
            foreach(var post in PostList)
            {
                post.CalculatorRate();
                //sumAverageRatePost += post.AverageRate;
            }
            //float AverageRatePostList = sumAverageRatePost / PostList.Count;
            //Console.WriteLine($"Average rate all post in PostList: {AverageRatePostList}");
        }
        static void CreatePost()
        {
            Post post = new Post();
            Console.Write("Enter ID post(ID > 0): ");
            string strID = Console.ReadLine();
            int postID;
            while(!int.TryParse(strID, out postID) || postID <= 0 || IsIDLiveInPostList(postID))
            {
                Console.Write("Enter again ID post: ");
                strID = Console.ReadLine();
            }
            post.ID = postID;
            Console.Write("Enter Title post: ");
            post.Title = Console.ReadLine();
            Console.Write("Enter Author post: ");
            post.Author = Console.ReadLine();
            Console.Write("Enter Content post: ");
            post.Content = Console.ReadLine();
            int[] rates = new int[4];
            for(int i = 0; i < rates.Length; i++)
            {
                Console.Write($"Vote rate {i+1}: ");
                string strRate = Console.ReadLine();
                int rate;
                while (!int.TryParse(strRate, out rate) || rate > MAX_RATING || rate < MIN_RATING)
                {
                    Console.Write($"Enter again vote rate {i+1}: ");
                    strRate = Console.ReadLine();
                }
                rates[i] = rate;
            }
            post.Rates = rates;
            PostList.Add(post);
        }
        static bool IsIDLiveInPostList(int id)
        {
            foreach(var post in PostList)
            {
                if (post.ID == id)
                {
                    return true;
                }
            }
            return false;
        }
        static bool IsEmptyPostList()
        {
            if (PostList.Count == 0)
            {
                return true;
            }
            return false;
        }
    }
}
