using System.Linq;
using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Netherrealms
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] demons = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x).ToArray();               

            int hp = 0;
            double attack = 0;

            List<string> demonLog = new List<string>();
            for (int i = 0; i < demons.Length; i++)
            {
                MatchCollection health = Regex.Matches(demons[i], @"[^\d\+\-\*\/\.]");
                MatchCollection numbers = Regex.Matches(demons[i], @"[+-]?\d+\.?\d*");
                MatchCollection signs = Regex.Matches(demons[i], @"[*\/]");

                string demonName = demons[i];

                foreach (Match item in health)
                {
                    char el = char.Parse(item.ToString());
                    hp += el;
                }

                foreach (Match item in numbers)
                {
                    attack += double.Parse(item.ToString());
                }

                if (attack == 0)
                {
                    string pattern = $"{demonName} - {hp} health, 0.00 damage";
                    demonLog.Add(pattern);
                }
                else
                {
                    if (signs.Count == 0)
                    {
                        demonLog.Add($"{demonName} - {hp} health, {attack:f2} damage");
                    }
                    else
                    {
                        foreach (Match item in signs)
                        {
                            char el = char.Parse(item.ToString());

                            if (el == '*')
                            {
                                attack *= 2;
                            }
                            else if (el == '/')
                            {
                                attack /= 2;
                            }                          
                        }
                        demonLog.Add($"{demonName} - {hp} health, {attack:f2} damage");
                    }                    
                }
                hp = 0;
                attack = 0;
            }

            Console.WriteLine(String.Join(Environment.NewLine, demonLog));
        }
    }
}