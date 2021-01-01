using System;
using System.Collections.Generic;
using System.Linq;

namespace SumAdjacentEqualNums
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> names = new List<string>() { "Josh", "Anna", "Jello", "Jumbo" };

            //List<int> numbers = new List<int>();
            //numbers.Add(55);
            //numbers.Add(65);
            //numbers.Add(45);
            //Console.WriteLine(numbers[0]);
            ////Console.WriteLine(numbers[4]);
            //Console.WriteLine(numbers.Count);

            List<double> numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            for (int i = 0; i < numbers.Count - 1; i++)    // remove the last position to run away from range exception issue
            {
                if (numbers[i] == numbers[i+1])
                {
                    numbers[i] += numbers[i + 1];
                    numbers.RemoveAt(i + 1);
                    i = -1;
                }
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
