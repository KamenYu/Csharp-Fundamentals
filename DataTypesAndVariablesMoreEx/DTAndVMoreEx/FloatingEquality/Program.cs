using System;

namespace FloatingEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            // 75 / 100
            // if (0.0000001 == eps) == (0.0000001 == eps)   False.
            // if diff < eps True
            // if diff > eps False

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double diff = Math.Abs(a - b);
            double eps = 0.000001;

            bool isDifferent = diff < eps;
            Console.WriteLine(isDifferent);
        }
    }
}

