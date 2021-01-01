using System;

namespace Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // A number is special when its sum of digits is 5, 7 or 11.
            short num = short.Parse(Console.ReadLine());

            for (short i = 1; i <= num; i++)
            {
                if (i >= 1)
                {
                    int digit1 = i / 10;
                    int digit2 = i % 10;
                    int sum = digit1 + digit2;

                    if (sum == 5 || sum == 7 || sum == 11)
                    {
                        Console.WriteLine($"{i} -> {"True"}");
                    }
                    else
                    {
                        Console.WriteLine($"{i} -> {"False"}");
                    }
                }
            }
        }
    }
}
