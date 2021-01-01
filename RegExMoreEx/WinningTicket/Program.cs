using System;
using System.Text.RegularExpressions;

namespace WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ticketsToCheck = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            // @"(@+|\^+|#+|\$+)"

            foreach (var ticket in ticketsToCheck)
            {               
                if (ticket.Length == 20)
                {
                    string left = ticket.Substring(0, 10);
                    string right = ticket.Substring(10, 10);

                    MatchCollection leftM = Regex.Matches(left, @"(@+|\^+|#+|\$+)");
                    MatchCollection rightM = Regex.Matches(right, @"(@+|\^+|#+|\$+)");

                    int minLeft = GetMinimumValue(leftM, left);
                    int minRight = GetMinimumValue(rightM, right);

                    if (leftM.Count == 0 && rightM.Count == 0)
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                    else if (leftM[0].Length == 10 && rightM[0].Length == 10)
                    {
                        if (leftM[0].ToString()[0] == rightM[0].ToString()[0])
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - 10{leftM[0].ToString()[0]} Jackpot!");
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - no match");
                        }
                    }
                    else
                    {
                        if (minLeft == int.MaxValue || minRight == int.MaxValue)
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - no match");
                        }
                        else
                        {
                            int min = Math.Min(minLeft, minRight);
                            Console.WriteLine($"ticket \"{ticket}\" - {min}{leftM[0].ToString()[0]}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }           
        }

        private static int GetMinimumValue(MatchCollection matches, string text)
        {
            int min = int.MaxValue;
            foreach (var match in matches)
            {
                if (min > match.ToString().Length && match.ToString().Length >= 6 && match.ToString().Length <=10)
                {
                    min = match.ToString().Length;
                }
            }
            return min;
        }
    }
}