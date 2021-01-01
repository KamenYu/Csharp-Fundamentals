using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var reg = @"\+[3][5][9]([ -])[2](\1)\d{3}(\1)\d{4}\b";
            MatchCollection phoneNumbers = Regex.Matches(input, reg);

            string[] matched = phoneNumbers
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();

            Console.Write(string.Join(", ", matched));            
        }
    }
}
