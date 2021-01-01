using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console
                          .ReadLine());
            int cappacity = int.Parse(Console.ReadLine());

            int rounds = (int)Math.Ceiling((double)people / cappacity);
            Console.WriteLine(rounds);
        }
    }
}
