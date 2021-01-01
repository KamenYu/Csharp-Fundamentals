using System;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            int pow = int.Parse(Console.ReadLine());
            Console.WriteLine(GetThePowerOf(num, pow));
        }

        static double GetThePowerOf(double num, int pow)
        {
            double result = 1d;
            for (int i = 0; i < pow; i++)
            {
                result *= num;
            }
            return result;
        }
    }
}
