using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string namePattern = "[A-Za-z]";
            string digitPattern = @"\d";

            string checker = Console.ReadLine();

            Dictionary<string, int> log = new Dictionary<string, int>();

            while (checker != "end of race")
            {
                var nameMatch = Regex.Matches(checker, namePattern);
                string currentPlayer = String.Concat(nameMatch);
                var km = Regex.Matches(checker, digitPattern);
                int sum = km.Select(x => int.Parse(x.Value)).Sum();

                if (names.Contains(currentPlayer))
                {
                    if (log.ContainsKey(currentPlayer))
                    {
                        log[currentPlayer] += sum;
                    }
                    else
                    {
                        log.Add(currentPlayer, sum);
                    }
                }
                checker = Console.ReadLine();
            }

            var ordered = log.OrderByDescending(x => x.Value).Select(x =>x.Key).ToList();

            Console.WriteLine($"1st place: {ordered[0]}");
            Console.WriteLine($"2nd place: {ordered[1]}");
            Console.WriteLine($"3rd place: {ordered[2]}");            
        }
    }
}
