using System;

namespace Volume_Of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double V = (length * width * height) / 3;
            Console.WriteLine($"Length: Width: Height: Pyramid Volume: {V:f2}");
        }
    }
}
