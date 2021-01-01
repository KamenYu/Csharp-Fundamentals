using System;
using System.Linq;

namespace EvenOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            //calculate the difference between the sum of the even and the sum of the odd numbers in an array
            int[] evenOdd = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int sumEven = 0;
            int sumOdd = 0;

            foreach (int num in evenOdd)
            {
                if (num % 2 == 0)
                {
                    sumEven += num;
                }
                else
                {
                    sumOdd += num;
                }
            }
            int diff = sumEven - sumOdd;
            Console.WriteLine(diff);
        }
    }
}
