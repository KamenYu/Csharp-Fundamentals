using System;

namespace Tripples_Of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program to read an integer n and print all triples of the first n small Latin letters,
            // ordered alphabetically:

            // 3 -> aaa, aab, aac, aba, abb, abc, aca, acb, acc .... cca, ccb, ccc

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {               
                for (int j = 0; j < n; j++)
                {                   
                    for (int k = 0; k < n; k++)
                    {
                        char first = (char)('a' + i);
                        char second = (char)('a' + j);
                        char third = (char)('a' + k);
                        Console.WriteLine($"{first}{second}{third}");
                    }
                }
            }
        }
    }
}
