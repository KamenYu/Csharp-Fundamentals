using System;

namespace Integer_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read four integer numbers.
            //Add first to the second, divide (integer) the sum by the third number and
            //multiply the result by the fourth number. Print the result.

            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int fourth = int.Parse(Console.ReadLine());

            int sum = first + second;
            int division = sum / third;
            int multiply = division * fourth;
            Console.WriteLine(multiply);
        }
    }
}
