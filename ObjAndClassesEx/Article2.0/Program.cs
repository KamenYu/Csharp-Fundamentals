using System;
using System.Linq;
using System.Collections.Generic;

namespace Article
{
    class Program
    {
        static void Main(string[] args)
        {           
            int n = int.Parse(Console.ReadLine());
            List<Article> archive = new List<Article>();            

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                Article article = new Article(command[0], command[1], command[2]);
                archive.Add(article);               
            }

            string line = Console.ReadLine();

            switch (line)
            {
                case "title":
                    archive = archive.OrderBy(x => x.Title).ToList();
                    break;

                case "content":
                    archive = archive.OrderBy(x => x.Content).ToList(); // OrderBy ceates a new collection!!
                    break;

                case "author":
                    archive = archive.OrderBy(x => x.Author).ToList();
                    break;
            }
            Console.WriteLine(String.Join(Environment.NewLine, archive));
        }

        class Article
        {
            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }
            public List<Article> Archive { get; set; }

            public Article(string title, string content, string author)
            {
                Title = title;
                Content = content;
                Author = author;
            }

            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
        }

    }
}
