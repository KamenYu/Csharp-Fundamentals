using System;

namespace Sum_Of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());      // number of chars
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                char input = char.Parse(Console.ReadLine());
                int numeric = (int)input;
                sum += numeric;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
