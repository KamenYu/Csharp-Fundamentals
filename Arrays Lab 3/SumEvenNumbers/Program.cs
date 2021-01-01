using System;

namespace SumEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read an array from the console and sum only the even numbers.
            string[] input = Console.ReadLine().Split();
            int[] allNums = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                allNums[i] = int.Parse(input[i]);
            }
            int sum = 0;
            foreach (int num in allNums)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
