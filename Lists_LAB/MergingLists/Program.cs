using System;
using System.Collections.Generic;
using System.Linq;

namespace MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> list2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int minCount = Math.Min(list1.Count, list2.Count);
            int maxCount = Math.Max(list1.Count, list2.Count);

            List<int> result = new List<int>(minCount + maxCount);

            for (int i = 0; i < minCount; i++)
            {
                result.Add(list1[i]);
                result.Add(list2[i]);
            }

            int j = 0;

            for (int i = minCount; i < maxCount; i++)
            {                
                if(list1.Count > list2.Count)
                {
                    result.Add(list1[minCount + j]);
                }
                else
                {
                    result.Add(list2[minCount + j]);
                }
                j++;
            }

            Console.WriteLine(String.Join(" ", result));
        }
    }
}
