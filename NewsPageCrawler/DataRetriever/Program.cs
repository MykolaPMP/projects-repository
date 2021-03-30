using System;
using DTO;

namespace DataRetriever
{
    public class Program
    {
        static void Main(string[] args)
        {
            TheVergeCrawler vergeCrawler = new TheVergeCrawler();
            ViceCrawler viceCrawler = new ViceCrawler();



            ICrawl crawler = viceCrawler;
            var list = crawler.Crawl();

            MongoCRUD db = new MongoCRUD("NewsCrawl");

            foreach (var title in list)
            {
                db.InsertRecord("News", title);
                Console.WriteLine("Title: " + title.Title + Environment.NewLine
                    + "Url: " + title.Url + Environment.NewLine
                    + "Author: " + title.Author + Environment.NewLine
                    + "Date of publication: " + title.DateOfPublication + Environment.NewLine);

            }


            Console.WriteLine("");
        }
    }
}
