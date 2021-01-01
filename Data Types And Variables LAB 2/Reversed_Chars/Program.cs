using System;

namespace Reversed_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that takes 3 lines of characters
            //and prints them in reversed order with a space

            char line1 = char.Parse(Console.ReadLine());
            char line2 = char.Parse(Console.ReadLine());
            char line3 = char.Parse(Console.ReadLine());

            Console.WriteLine($"{line3} {line2} {line1}");
        }
    }
}
