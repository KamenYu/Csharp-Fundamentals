using System;

namespace Pounds_To_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 British Pound = 1.31 Dollars
            // decimal

            decimal pounds = decimal.Parse(Console.ReadLine());
            decimal dollars = pounds * 1.31m;
            Console.WriteLine($"{dollars:f3}");
        }
    }
}
