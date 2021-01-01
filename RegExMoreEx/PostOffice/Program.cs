using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace PostOffice
{
    class Program
    {
        static void Main(string[] args)
        {           
            string[] input = Console.ReadLine().Split('|');

            Match firstM = Regex.Match(input[0], @"([#%*&$])([A-Z]+)\1");
            string letters = firstM.Groups[2].Value;

            MatchCollection secondM = Regex.Matches(input[1], @"(\d{2}:\d{2})");
            Dictionary<int, int> Word = new Dictionary<int, int>();

            MatchCollection thirdM = Regex.Matches(input[2], @"(?<=\s|^)([A-Z][\x21-\x7B\x7D\x7E\x7F]+)(?=\s|$)");
            // (?<=\s|^)[A-Z][^\s][\x21-\x7B\x7D\x7E\x7F]+(?=\s|$) -> 100 / 100

            foreach (Match item in secondM)
            {
                string[] nums = Regex.Split(item.ToString(), ":");
                int firstNum = int.Parse(nums[0]);
                int secondNum = int.Parse(nums[1]);

                if (firstNum >= 65 && firstNum <= 90 && letters.Contains((char)firstNum))
                {
                    if (Word.ContainsKey(firstNum) == false)
                    {
                        Word.Add(firstNum, secondNum);
                    }
                }
            }

            foreach (char ch in letters)
            {
                if (Word.ContainsKey(ch))
                {
                    foreach (Match item in thirdM)
                    {
                        if(item.Value[0] == ch && item.Length == Word[ch] + 1)
                        {
                            Console.WriteLine(item.Value);
                        }
                    }
                }
            }            
        }
    }
}