using System;
using System.Linq;

namespace RoundingAwayFromZero
{
    class Program
    {
        static void Main(string[] args)
        {
            //double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();  shorter to write in one row
            string[] input = Console.ReadLine().Split();
            double[] numbers = new double[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = double.Parse(input[i]);
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (numbers[i] == 0)    // this is s BUG in Judge, because it gives -0 as an input
                { numbers[i] = 0; }
                Console.WriteLine($"{numbers[i]} => {(int)Math.Round(numbers[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
