using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string code = Console.ReadLine();
            List<string> attacked = new List<string>();
            List<string> destroyed = new List<string>();

            for (int i = 1; i <= n; i++)
            {
                Regex reg = new Regex("[STARstar]");
                MatchCollection matches = reg.Matches(code);
                int decryptionKey = matches.Count();
                StringBuilder sb = new StringBuilder();               

                for (int j = 0; j < code.Length; j++)
                {
                    int element = code[j] - decryptionKey;
                    sb.Append(((char)element).ToString());
                }

                Regex regex = new Regex
                (@"^[^@!>\-:]*@[^@!>\-:]*(?<name>[A-Z][a-z]+)[^@!>\-:]*:[^@!>\-:]*?(?<pop>\d+)[^@!>\-:]*![^@!>\-:]*(?<type>[A]|[D])[^@!>\-:]*![^@!>\-:]*->[^@!>\-:]*?(?<sCount>\d+)[^@!>\-:]*?$");
                Match message = regex.Match(sb.ToString());

                if (message.Success)
                {
                    if (message.Groups["type"].ToString() == "A")
                    {
                        attacked.Add(message.Groups["name"].Value);
                    }
                    else
                    {
                        destroyed.Add(message.Groups["name"].Value);
                    }                   
                }              

                if (i == n)
                {
                    break;
                }

                code = Console.ReadLine();
            }
            Console.WriteLine($"Attacked planets: {attacked.Count()}");
            foreach (var item in attacked.OrderBy(x => x))
            {
                Console.WriteLine($"-> {item}");
            }
            Console.WriteLine($"Destroyed planets: {destroyed.Count()}");
            foreach (var item in destroyed.OrderBy(x => x))
            {
                Console.WriteLine($"-> {item}");
            }
        }
    }
}
