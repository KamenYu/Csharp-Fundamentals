using System;

namespace Chars_To_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char third = char.Parse(Console.ReadLine());

            string firstTS = first.ToString();
            string secondTS = second.ToString();
            string thirdTS = third.ToString();

            Console.WriteLine(first+second+third);
        }
    }
}
