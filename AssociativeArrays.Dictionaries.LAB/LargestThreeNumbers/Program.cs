using System;
using System.Linq;

namespace LargestThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .OrderByDescending(x => x)             
                .ToArray();

            if (numbers.Length <= 3)
            {
                Console.WriteLine(string.Join(" ",numbers));
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }
    }
}
