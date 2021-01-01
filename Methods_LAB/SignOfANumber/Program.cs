using System;

namespace SignOfANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a method that prints the sign of an integer number n:            
            SignOfAnInteger(int.Parse(Console.ReadLine()));
        }

        static void SignOfAnInteger (int output)
        {
            if (output > 0)
            {
                Console.WriteLine("The number {0} is positive.", output);
            }
            else if (output < 0)
            {
                Console.WriteLine("The number {0} is negative.", output);
            }
            else
            {
                Console.WriteLine("The number {0} is zero.", output);
            }
        }
    }
}
