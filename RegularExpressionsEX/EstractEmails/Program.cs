using System;
using System.Text.RegularExpressions;

namespace EstractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex reg = new Regex(@"(^|(?<=\s))[A-Za-z0-9]+.?\w*@\w+.?\w*?\.\w+\.?\w*?\w+?\b");
            string input = Console.ReadLine();

            MatchCollection matches = reg.Matches(input);

            foreach (Match item in matches)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}
