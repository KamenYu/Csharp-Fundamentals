using System;
using System.Text.RegularExpressions;

namespace MatchFullNameJudge
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            string input = Console.ReadLine();

            Regex reg = new Regex(pattern);
            var matches = reg.Matches(input);

            foreach (Match match in matches)
            {
                Console.Write(match.Value + " ");
            }
        }
    }
}
