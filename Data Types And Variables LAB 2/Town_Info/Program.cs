using System;

namespace Town_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            // "Town {name} has population of {population} and area {area} square km".

            string name = Console.ReadLine();
            int population = int.Parse(Console.ReadLine());
            short area = short.Parse(Console.ReadLine());

            Console.WriteLine($"Town {name} has population of {population} and area {area} square km.");
        }
    }
}
