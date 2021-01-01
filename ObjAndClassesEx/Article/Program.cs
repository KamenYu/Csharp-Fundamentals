using System;
using System.Linq;

namespace Article
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            int n = int.Parse(Console.ReadLine());

            Article article = new Article(line[0], line[1], line[2]);

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries);

                switch (command[0])
                {
                    case "Edit":
                        article.EditContent(command[1]);
                        break;

                    case "Rename":
                        article.RenameTitle(command[1]);
                        break;

                    case "ChangeAuthor":
                        article.ChangeAuthor(command[1]);
                        break;
                }
            }
            Console.WriteLine(article.ToString());
        }

        class Article
        {
            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }

            public Article(string title, string content, string author)
            {
                Title = title;
                Content = content;
                Author = author;
            }

            public void EditContent(string content)
            {
                Content = content;
            }

            public void RenameTitle(string title)
            {
                Title = title;
            }

            public void ChangeAuthor(string author)
            {
                Author = author;
            }

            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
        }
    }
}
