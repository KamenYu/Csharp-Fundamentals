using System;

namespace NumbersInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];  // create an array in given amount

            for (int i = 0; i < n; i++)   // type in the elements
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)  
            {
                Console.Write(array[array.Length - i - 1] + " ");  // reverse the orderof the elements
            }
        }
    }
}
