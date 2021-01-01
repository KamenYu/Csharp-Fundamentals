using System;
using System.Text;

namespace HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder html = new StringBuilder();

            string lineOne = Console.ReadLine();
            html.AppendLine("<h1>");
            html.AppendLine($"    {lineOne}");
            html.AppendLine("</h1>");
            string lineTwo = Console.ReadLine();
            html.AppendLine("<article>");
            html.AppendLine($"    {lineTwo}");
            html.AppendLine("</article>");
            string lineThree = string.Empty;
            while ((lineThree = Console.ReadLine()) != "end of comments")
            {
                html.AppendLine("<div>");
                html.AppendLine($"    {lineThree}");
                html.AppendLine("</div>");
            }
            Console.WriteLine(html.ToString());
        }
    }
}