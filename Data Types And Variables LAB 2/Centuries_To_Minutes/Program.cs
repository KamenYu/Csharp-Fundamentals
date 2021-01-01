using System;

namespace Centuries_To_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write program to enter an integer number of centuries and convert it to years, days, hours and minutes
            // $"{c} centuries = {y} years = {days} days = {h} hours = {m} minutes"

            byte c = byte.Parse(Console.ReadLine());
            short y = (short)(c * 100);
            double d = y * 365.2422;
            int days = (int)d;   // check
            int h = days * 24;
            int m = h * 60;

            Console.WriteLine($"{c} centuries = {y} years = {days} days = {h} hours = {m} minutes");
        }
    }
}
