using System;
using System.Linq;

namespace FromLeftToRight
{
    class Program
    {
        static void Main(string[] args)
        {
            //On the next N lines, you will receive a string with 2 numbers separated by single space.
            //If the left number is greater, you need to print the sum of all digits in the left number,
            //otherwise print the sum of all digits in the right number.

            short n = short.Parse(Console.ReadLine());
            long sum = 0;
            for (short i = 0; i < n; i++)
            {
                long[] numbers = Console.ReadLine()
                    .Split()
                    .Select(long.Parse)
                    .ToArray();
                long left = numbers[0];
                long right = numbers[1];

                if (left > right)
                {
                    long abs = Math.Abs(left);
                    while (abs > 0)
                    {
                        long digit = abs % 10;
                        sum += digit;
                        abs /= 10;
                    }
                    Console.WriteLine(sum);
                }
                else
                {
                    long abs = Math.Abs(right);
                    while (abs > 0)
                    {
                        long digit = abs % 10;
                        sum += digit;
                        abs /= 10;
                    }
                    Console.WriteLine(sum);
                }
                sum = 0;
            }
        }
    }
}

