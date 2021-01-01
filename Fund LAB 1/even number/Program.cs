using System;
namespace even_number
{
    class Program
    {
        static void Main(string[] args)
        {
            // odd = "Please write an even number."
            // even = "The number is: "

            int num = int.Parse(Console.ReadLine());

            while (num % 2 != 0)
            {
                Console.WriteLine("Please write an even number.");
                num = int.Parse(Console.ReadLine());
            }
            if (num % 2 == 0)
            {
                Console.WriteLine("The number is: " + Math.Abs(num));
            }
        }
    }
}
