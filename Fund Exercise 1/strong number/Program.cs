using System;

namespace strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int test = num;
            int totalSum = 0;

            while (test > 0)
            {
                int digit = test % 10;
                test /= 10;

                int currentFactorialSum = 1;

                for (int i = 1; i <= digit; i++)
                {
                    currentFactorialSum *= i;
                }
                totalSum += currentFactorialSum;
            }

            if (totalSum == num)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
