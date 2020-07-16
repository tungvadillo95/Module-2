using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    public class Forum 
    {
        public SortedList<int, Post> Posts { get; set; }
        public Forum()
        {
            Posts = new SortedList<int, Post>();
        }
        public void AddPost(Post post)
        {
            Posts.Add(post.ID, post);
        }
        public void Update(int id, string new_Content) 
        {
            int pos = FindID(id);
            if (pos >= 0) 
            {
                Posts[pos].Content = new_Content;
            }
            else
            {
                Console.WriteLine("ID not in list!");
            }
        }
        public void Remove(int id)
        {
            Posts.Remove(id);
        }
        public void Show()
        {
            for(int i=0; i < Posts.Count; i++)
            {
                Posts[i].Display();
            }
        }
        public void FindTitle(string title)
        {
            for (int i = 0; i < Posts.Count; i++)
            {
                if (Posts[i].Title == title)
                {
                    Posts[i].Display();
                }
            }
        }
        public void FindAuthor(string author)
        {
            for (int i = 0; i < Posts.Count; i++)
            {
                if (Posts[i].Author == author)
                {
                    Posts[i].Display();
                }
            }
        }
        public int FindID(int id)
        {
            for(int i=0; i < Posts.Count; i++)
            {
                if(Posts[i].ID == id)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
