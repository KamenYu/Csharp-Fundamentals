using System;
using System.Text.RegularExpressions;

namespace MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            MatchCollection dates = Regex.Matches(Console.ReadLine(), @"\b(?<day>\d{2})(.)(?<month>\w{3})(\1)(?<year>\d{4})\b"); 

            foreach (Match item in dates)
            {
                var date = item.Groups["day"].Value;
                var month = item.Groups["month"].Value;
                var year = item.Groups["year"].Value;

                Console.WriteLine($"Day: {date}, Month: {month}, Year: {year}");
            }
        }
    }
}
