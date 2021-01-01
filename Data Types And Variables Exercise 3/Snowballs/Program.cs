using System;
using System.Numerics;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
          
            BigInteger bestValue = 0;
            short bestSnow = 0;
            short bestTime = 0;
            byte bestQ = 0;

            for (int i = 0; i < n; i++)
            {
                short snowballSnow = short.Parse(Console.ReadLine());
                short  snowballTime = short.Parse(Console.ReadLine());
                byte  snowballQuality = byte.Parse(Console.ReadLine());

                BigInteger value = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);
                
                if (value > bestValue)
                {
                    bestValue = value;
                    bestSnow = snowballSnow;
                    bestTime = snowballTime;
                    bestQ = snowballQuality;
                }
            }
            Console.WriteLine($"{ bestSnow} : { bestTime} = { bestValue} ({ bestQ})");
        }
    }
}
