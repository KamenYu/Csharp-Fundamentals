using System;

namespace AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            // You will receive 3 integers.
            //Write a method Sum to get the sum of the first two integers and
            //Subtract method that subtracts the third integer from the result from the Sum method.

            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            
            Console.WriteLine(Subtract(first, second, third));
        }

        static int Subtract(int a, int b, int c)
        {
            int subtract = Add(a, b) - c;
            return subtract;
        }

        static int Add(int a, int b)
        {
            int sum;
            return sum = a + b;
        }
    }
}
