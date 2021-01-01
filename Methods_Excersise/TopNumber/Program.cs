using System;

namespace TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //A top number is an integer that holds the following properties:
            //Its sum of digits is divisible by 8, e.g. 8, 16, 88.
            //Holds at least one odd digit, e.g. 232, 707, 87578.
            //Write a program to print all master numbers in the range[1…n].

            int n = int.Parse(Console.ReadLine());
            PrintsTopNumber(n);
        }

        static void PrintsTopNumber(int n)
        {
            for (int i = 17; i <= n; i++)
            {
                int sum = 0;
                bool isOdd = false;
                int temp = i;

                while (temp > 0)
                {
                    int digit = temp % 10;
                    if (digit % 2 == 1)
                    {
                        isOdd = true;
                    }
                    sum += digit;
                    temp /= 10;
                }

                if (sum % 8 == 0 && isOdd == true)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
