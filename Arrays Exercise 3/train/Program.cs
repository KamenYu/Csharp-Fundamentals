using System;
using System.Linq;

namespace train
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int[] train = new int[wagons];  // array with wagon amount of elements

            for (int i = 0; i < wagons; i++)
            {
                train[i] = int.Parse(Console.ReadLine());   // how much is each element

            }
            Console.WriteLine(string.Join(" ", train));   // join the string
            Console.WriteLine(train.Sum());     // sum each element using System.Linq
        }
    }
}
