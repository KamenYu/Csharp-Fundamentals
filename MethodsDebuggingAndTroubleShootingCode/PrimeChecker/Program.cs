using System;

namespace PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            Console.WriteLine(IsPrime(n));
        }

        static bool IsPrime(double n)
        {
            if (n > 1)
            {
                if (n == 2 || n == 3 || n == 5)
                {
                    return true;
                }
                else if (n % 2 == 0)
                {
                    return false;
                }
                else
                {
                    double boundary = (int)Math.Floor(Math.Sqrt(n));

                    for (int i = 3; i <= boundary; i += 2)
                    {
                        if (n % i == 0)
                        {
                            return false;
                        }
                    }
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
