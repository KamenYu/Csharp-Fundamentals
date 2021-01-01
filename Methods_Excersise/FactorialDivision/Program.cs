using System;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read two integer numbers.
            //Calculate factorial of each number.
            //Divide the first result by the second and print the division formatted to the second decimal point.

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            decimal result = FindFactorielNum(a) / FindFactorielNum(b);
            Console.WriteLine($"{result:f2}");
        }

        static decimal FindFactorielNum(int a)
        {
            decimal factoriel = 1;
            for (int i = 1; i <= a; i++)
            {
                factoriel *= i;
            }
            return factoriel;
        }
    }
}
