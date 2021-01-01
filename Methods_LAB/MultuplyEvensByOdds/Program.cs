using System;

namespace MultuplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            // |-1233456| = 1233456
            // 2+4+6 = 12
            // 1+3+3+5 = 12
            // 12 * 12 = 144

            int n = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine(MultiplyEvenByOddDigits(n));
        }

        static int MultiplyEvenByOddDigits (int n)
        {
            return GetEvenDigitsSum(n) * GetOddsDigitsSum(n);
        }

        static int GetEvenDigitsSum(int n)
        {
            string number = n.ToString();
            int sum = 0;

            for (int i = 0; i < number.Length; i++)
            {
                int currentDigit = int.Parse(number[i].ToString());
                if (currentDigit % 2 == 0)
                {
                    sum += currentDigit;
                }
            }
            return sum;
        }

        static int GetOddsDigitsSum(int n)
        {
            string number = n.ToString();
            int sum = 0;

            for (int i = 0; i < number.Length; i++)
            {
                int currentDigit = int.Parse(number[i].ToString());
                if (currentDigit % 2 == 1)
                {
                    sum += currentDigit;
                }
            }
            return sum;
        }
    }
}
