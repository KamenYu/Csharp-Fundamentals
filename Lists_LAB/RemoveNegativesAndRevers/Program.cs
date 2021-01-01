using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNegativesAndRevers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()//" ", StringSplitOptions.RemoveEmptyEntries
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < 0)
                {
                    list.RemoveAt(i);
                    i = -1;
                }
            }           

            if (list.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                list.Reverse();
                Console.WriteLine(String.Join(" ", list));
            }
        }
    }
}
