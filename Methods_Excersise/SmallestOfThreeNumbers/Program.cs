using System;

namespace SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            Console.WriteLine(SmallestOfThreeNumbers(first, second, third));
        }

        static int SmallestOfThreeNumbers(int a, int b, int c)
        {
            int smallest = 0;
            if (a < b && a < c)
            {
                smallest = a;
            }
            else if (b < a && b < c)
            {
                smallest = b;
            }
            else if (c < a && c < b)
            {
                smallest = c;
            }
            else
            {
                smallest = a;
            }
            return smallest;
        }
    }
}
