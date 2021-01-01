using System;
using System.Linq;
using System.Collections.Generic;

namespace Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;   // {username} -> {contest} -> {points}
            Dictionary<string, Dictionary<string, int>> judgeLog = new Dictionary<string, Dictionary<string, int>>();
            var final = new SortedDictionary<string, Dictionary<string, int>>();

            while ((input = Console.ReadLine()) != "no more time")
            {
                string[] tokens = input.Split(" -> ");
                string username = tokens[0];
                string contest = tokens[1];
                int points = int.Parse(tokens[2]);

                if (judgeLog.ContainsKey(contest))
                {
                    if (judgeLog[contest].ContainsKey(username))
                    {
                        if (points > judgeLog[contest][username])
                        {
                            judgeLog[contest][username] = points;
                        }
                    }
                    else
                    {
                        judgeLog[contest].Add(username, points);
                    }
                }
                else
                {
                    judgeLog.Add(contest, new Dictionary<string, int>());
                    judgeLog[contest].Add(username, points);
                }

                if (final.ContainsKey(username))
                {
                    if (final[username].ContainsKey(contest))
                    {
                        if (final[username][contest] < points)
                        {
                            final[username][contest] = points;
                        }
                    }
                    else
                    {
                        final[username].Add(contest, points);
                    }
                }
                else
                {
                    final.Add(username, new Dictionary<string, int>());
                    final[username].Add(contest, points);
                }                
            }

            foreach (var contest in judgeLog.Keys)
            {
                Console.WriteLine($"{contest}: {judgeLog[contest].Count()} participants");
                int n = 1;

                foreach (var user in judgeLog[contest].OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{n}. {user.Key} <::> {user.Value}");
                    n++;
                }
            }

            Console.WriteLine("Individual standings:");
            int num = 1;

            Dictionary<string, int> filtered = new Dictionary<string, int>();
            int sum = 0;

            foreach (var item in final)
            {
                foreach (var val in item.Value)
                {
                    sum += val.Value;
                }
                filtered.Add(item.Key, sum);
                sum = 0;
            }

            foreach (var item in filtered.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{num}. {item.Key} -> {item.Value}");
                num++;
            }
        }
    }
}