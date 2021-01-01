using System;

namespace PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            // print a trinagle

            int n = int.Parse(Console.ReadLine());
            PrintTriangle(n);
        }

        static void PrintTriangle(int end)
        {
            for (int i = 1; i <= end; i++)
            {
                PrintNumbersInLine(i);
            }
            for (int i = end - 1; i >= 1; i--)
            {
                PrintNumbersInLine(i);
            }
        }

        static void PrintNumbersInLine(int end)
        {
            for (int i = 1; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
