using System;

namespace Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            // You will be given a single integer. Your task is to find the sum of its digits.
            int num = int.Parse(Console.ReadLine());
            int leftOver = 0;
            int sum = 0;
            while (num > 0)
            {
                leftOver = num % 10;
                sum += leftOver;
                num /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
