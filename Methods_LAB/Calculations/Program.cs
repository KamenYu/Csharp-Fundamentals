using System;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that receives a string on the first line (add, multiply, subtract, divide)
            //and on the next two lines receives two numbers.
            //Create four methods (for each calculation) and invoke the right one depending on the command.
            //The method should also print the result (needs to be void)

            string action = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (action == "add")
            {
                Add(a, b);
            }
            else if (action == "subtract")
            {
                Subtract(a, b);
            }
            else if (action == "multiply")
            {
                Multiply(a, b);
            }
            else if (action == "divide")
            {
                Divide(a, b);
            }
        }

        static void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }

        static void Subtract(int x, int y)
        {
            Console.WriteLine(x - y);
        }

        static void Multiply(int x, int y)
        {
            Console.WriteLine(x * y);
        }

        static void Divide(int x, int y)
        {
            Console.WriteLine(x / y);
        }
    }
}
