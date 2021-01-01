using System;
using System.Linq;
using System.Collections.Generic;

namespace SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            // "{username}-{language}-{points}"
            Dictionary<string, int> studentAndPoints = new Dictionary<string, int>();
            Dictionary<string, int> languageStat = new Dictionary<string, int>();

            while (input != "exam finished")
            {
                if (input.Split('-')[1] == "banned")
                {
                    studentAndPoints.Remove(input.Split('-')[0]);
                }
                else
                {
                    string userName = input.Split('-')[0];
                    string language = input.Split('-')[1];
                    int points = int.Parse(input.Split('-')[2]);

                    if (studentAndPoints.ContainsKey(userName) == false)
                    {
                        studentAndPoints.Add(userName, points);
                    }
                    else
                    {
                        if (studentAndPoints[userName] < points)
                        {
                            studentAndPoints[userName] = points;
                        }
                    }

                    if (languageStat.ContainsKey(language) == false)
                    {
                        languageStat.Add(language, 0);
                    }
                    languageStat[language]++;
                }               
                input = Console.ReadLine();
            }

            Console.WriteLine("Results:");

            foreach (var item in studentAndPoints
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} | {item.Value}");
            }

            Console.WriteLine("Submissions:");

            foreach (var item in languageStat
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
