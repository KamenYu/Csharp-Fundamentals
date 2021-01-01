using System;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            double m = double.Parse(Console.ReadLine());

            if (@operator == "+")
            {
                Console.WriteLine(Add(n, m));
            }
            if (@operator == "-")
            {
                Console.WriteLine(Subtract(n, m));
            }
            if (@operator == "*")
            {
                Console.WriteLine(Multiply(n, m));
            }
            if (@operator == "/")
            {
                Console.WriteLine(Divide(n, m));
            }
        }

        static double Add (double n, double m)
        {
            return n + m;
        }

        static double Subtract(double n, double m)
        {
            return n - m;
        }

        static double Multiply(double n, double m)
        {
            return n * m;
        }

        static double Divide(double n, double m)
        {
            return n / m;
        }
    }
}
