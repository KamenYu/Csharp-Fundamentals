using System;
using System.Linq;
using System.Collections.Generic;

namespace CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] text = Console.ReadLine().ToCharArray();

            Dictionary<string, int> counts = new Dictionary<string, int>();           

            foreach (var item in text)
            {
                if (item == ' ')
                {
                    continue;
                }
                else if (counts.ContainsKey(item.ToString()) == false)
                {
                    counts.Add(item.ToString(), 1);
                }
                else
                {
                    counts[item.ToString()]++;
                }
            }

            foreach (var item in counts)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }           
        }
    }
}
