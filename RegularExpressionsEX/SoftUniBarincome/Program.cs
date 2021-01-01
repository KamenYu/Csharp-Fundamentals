using System;
using System.Text.RegularExpressions;

namespace SoftUniBarincome
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string input = Console.ReadLine();
            double income = 0;
            while (input != "end of shift")
            {
                Regex reg = new Regex
                    //  (@"%(?<name>[A-Z][a-z]+)%[^$%|.]*<(?<item>\w+)>[^$%|.]*\|(?<amount>\d+)\|[^$%|.]*?(?<price>\d+\.?\d*?)\$"); // 100 / 100
                    (@"%(?<name>[A-Z][a-z]+)%[^$%|.]*<(?<item>[A-Z]\w+)>[^$%|.]*?\|(?<amount>\d+)\|[^$%|.]*?(?<price>\d+|(?:\d+\.\d{1,}))\$"); // mine!
                var matches = reg.Match(input);
               
                if (matches.Success)
                {
                    double price = double.Parse(matches.Groups[3].Value) * double.Parse(matches.Groups[4].Value);
                    Console.WriteLine($"{matches.Groups[1]}: {matches.Groups["item"]} - {price:f2}");
                    income += price;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {income:f2}");
        }
    }
}
