using HtmlAgilityPack;
using System;
using System.Linq;
using System.Text;

namespace CrawlNews
{
    class Program
    {
        static void Main(string[] args)
        {
            HtmlWeb htmlWeb = new HtmlWeb();
            Console.OutputEncoding = Encoding.UTF8;
            HtmlDocument document = htmlWeb.Load("https://dantri.com.vn/the-gioi.htm");
            var listGenreTitle = document.DocumentNode.SelectNodes("//h3[@class='news-item__title']/a").ToList();
            foreach (var item in listGenreTitle)
            {
                Console.WriteLine(item.InnerHtml);
            }
        }
    }
}
