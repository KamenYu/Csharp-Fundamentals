using System;
using System.Text.RegularExpressions;

namespace ExtractPersonInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                Match name = Regex.Match(line, @"@([A-Za-z]+)\|");
                Match age = Regex.Match(line, @"#(\d+)\*");

                if (name.Success && age.Success)
                {
                    Console.WriteLine($"{name.Groups[1]} is {age.Groups[1]} years old.");
                }
            }
        }
    }
}
