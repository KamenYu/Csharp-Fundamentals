using System;

namespace Meters_To_Km
{
    class Program
    {
        static void Main(string[] args)
        {
            // m to km
            int m = int.Parse(Console.ReadLine());
            float km = m * 0.001f;
            Console.WriteLine($"{km:f2}");
        }
    }
}
