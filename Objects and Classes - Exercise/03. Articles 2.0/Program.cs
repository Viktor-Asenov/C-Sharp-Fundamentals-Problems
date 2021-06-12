using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> articles = new List<Article>();

            int numArticles = int.Parse(Console.ReadLine());

            for (int i = 0; i < numArticles; i++)
            {
                string[] current = Console.ReadLine().Split(", ");

                var article = new Article
                {
                    Title = current[0],
                    Content = current[1],
                    Author = current[2]
                };

                articles.Add(article);
            }

            string criteria = Console.ReadLine();
            List<Article> orderedArticles = new List<Article>();

            if (criteria == "title")
            {
                orderedArticles = articles.OrderBy(x => x.Title).ToList();
            }
            else if (criteria == "content")
            {
                orderedArticles = articles.OrderBy(x => x.Content).ToList();
            }
            else
            {
                orderedArticles = articles.OrderBy(x => x.Author).ToList();
            }

            foreach (var article in orderedArticles)
            {
                Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
            }            
        }
    }
    class Article
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

    }
}
