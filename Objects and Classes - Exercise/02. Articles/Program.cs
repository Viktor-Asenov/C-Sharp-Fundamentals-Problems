using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            var article = new Article
            {
                Title = input[0],

                Content = input[1],

                Author = input[2]
            };

            int numberCommands = int.Parse(Console.ReadLine());            

            for (int i = 0; i < numberCommands; i++)
            {
                string[] currentCommand = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries);

                string command = currentCommand[0];

                if (command == "Edit")
                {
                    string newContent = currentCommand[1];

                    article.Content = newContent;

                }
                else if (command == "ChangeAuthor")
                {
                    string newAuthor = currentCommand[1];

                    article.Author = newAuthor;
                }
                else if (command == "Rename")
                {
                    string newTitle = currentCommand[1];

                    article.Title = newTitle;
                }
            }

            Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
        }
    }

    class Article
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }       

    }
}

