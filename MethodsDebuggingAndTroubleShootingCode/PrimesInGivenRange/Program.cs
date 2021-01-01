using System;
using System.Collections.Generic;

namespace PrimesInGivenRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            List<int> primes = new List<int>();
            if (first < second)
            {
                primes = GetListOfPrimes(primes, first, second);
                primes.RemoveAll(x => x == 0);
                Console.WriteLine(string.Join(", ", primes));
            }
            else
            {
                Console.WriteLine(string.Join(", ", primes));
            }
        }

        static List<int> GetListOfPrimes(List<int> primes, int f, int s)
        {
            for (int i = f; i <= s; i++)
            {
                primes.Add(IsPrime(i));
            }

            return primes;
        }

        static int IsPrime(int n)
        {
            if (n > 1)
            {
                if (n == 2 || n == 3 || n == 5 || n == 7)
                {
                    return n;
                }
                else if (n % 2 == 0)
                {
                    return 0;
                }
                else
                {
                    double boundary = (int)Math.Floor(Math.Sqrt(n));

                    for (int j = 3; j <= boundary; j += 2)
                    {
                        if (n % j == 0)
                        {
                            return 0;
                        }
                    }
                    return n;
                }
            }
            else
            {
                return 0;
            }
        }
    }
}
