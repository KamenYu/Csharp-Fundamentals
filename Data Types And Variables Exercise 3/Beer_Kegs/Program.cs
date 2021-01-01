using System;

namespace Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            double maxVolume = 0;
            string bestModel = "";

            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                float r = float.Parse(Console.ReadLine());
                int h = int.Parse(Console.ReadLine());
                double volume = Math.PI * r * r * h;

                if (volume > maxVolume)
                {
                    maxVolume = volume;
                    bestModel = model;
                }
            }
            Console.WriteLine(bestModel);
        }
    }
}
