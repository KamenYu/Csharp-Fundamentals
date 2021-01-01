using System;
namespace multiplication_table
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the 10 times table 

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} X {i} = {n * i}");
            }
        }
    }
}
