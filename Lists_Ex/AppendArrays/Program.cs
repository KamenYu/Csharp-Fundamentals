using System;
using System.Linq;
using System.Collections.Generic;

namespace AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program to append several arrays of numbers.
            //Arrays are separated by '|'.
            //Values are separated by spaces(' ', one or several).
            //Order the arrays from the last to the first, and their values from left to right.

            // 1 2 3 |4 5 6 |  7  8
            // 7 8 4 5 6 1 2 3

            List<string> items = Console.ReadLine()
                .Split('|')
                .ToList();

            items.Reverse();

            List<string> result = new List<string>();

            foreach (string current in items)
            {
                string[] numbers = current
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                foreach (string item in numbers)
                {
                    result.Add(item);
                }
            }
            Console.WriteLine(String.Join(" ", result));
        }
    }
}
