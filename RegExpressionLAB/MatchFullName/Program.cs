using System;
using System.Text.RegularExpressions;

namespace MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([A-Z][a-z])+ ([A-Z][a-z])+";
            Regex reg = new Regex(pattern);

            string input = Console.ReadLine();
            Console.WriteLine(reg.IsMatch(input));
            Console.WriteLine(reg.Match(input).Value); // the first time it matches the pattern
            Console.WriteLine(reg.Matches(input).Count);  // returns a list thus has the functions of a list

            var matches = reg.Matches(input);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
                Console.WriteLine(match.Index); // from wich index the pattern starts
                Console.WriteLine(match.Groups[1].Value);
            }



        }
    }
}
