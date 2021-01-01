using System;
using System.Linq;
using System.Collections.Generic;

namespace OddOccurences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split()
                .ToArray();

            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (string word in words)
            {
                string wordInLower = word.ToLower();

                if (counts.ContainsKey(wordInLower))
                {
                    counts[wordInLower]++;
                }
                else
                {
                    counts.Add(wordInLower, 1);
                }
            }

            foreach (var item in counts)
            {
                if (item.Value % 2 == 1)
                {
                    Console.Write(item.Key + " ");
                }
            }
        }
    }
}
