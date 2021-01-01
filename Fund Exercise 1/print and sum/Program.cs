using System;

namespace print_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program to display numbers from given start to given end and their sum. 
            int beginning = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = beginning; i <= end; i++)
            {
                sum += i;
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Sum: " + sum);
        }
    }
}
