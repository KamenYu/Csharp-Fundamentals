using System;
using System.Text.RegularExpressions;
using System.Text;
using System.Linq;

namespace RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
           // 90/ 100, check AGAIN
            string input = Console.ReadLine();
            MatchCollection angerMatches = Regex.Matches(input, @"(\D+)(\d+)");
            StringBuilder sb = new StringBuilder();
            int symbolCounter = 0;
            // string allLetters = "acbdefghijklmnopqrstuvwxyz!@£$%^&*()_+=-#€§±:\"|<>?/.,{}[]";
            // be2£e2pe1
            // Ss1ab1BA1
            foreach (Match match in angerMatches)
            {
                int n = int.Parse(match.Groups[2].ToString());
                for (int i = 0; i < n; i++)
                {
                    sb.Append(match.Groups[1].ToString().ToUpper());
                }

                //symbolCounter += match.ToString().Where(c => allLetters.Contains(c)).Count();
            }

            symbolCounter = sb.ToString().Distinct().Count();
            Console.WriteLine($"Unique symbols used: {symbolCounter}");
            Console.WriteLine(sb);
        }
    }
}
