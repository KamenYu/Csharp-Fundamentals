using System;

namespace Water_OverFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            short capacity = 255;
            short tempInside = 255;

            for (int i = 0; i < n; i++)
            {
                short tempC = capacity;
                short litres = short.Parse(Console.ReadLine());
                
                if ((capacity -= litres) < 0)
                {
                    Console.WriteLine("Insufficient capacity!");
                    capacity = tempC;
                }
            }
            Console.WriteLine(tempInside - capacity);
        }
    }
}
