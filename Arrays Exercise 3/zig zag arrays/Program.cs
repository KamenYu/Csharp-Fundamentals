using System;

namespace zig_zag_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] arrayOne = new string[n];
            string[] arrayTwo = new string[n];

            for (int i = 0; i < n; i++)
            {
                string[] temp = Console.ReadLine()
                    .Split();

                if (i % 2 == 0)
                {
                    arrayOne[i] = temp[0];
                    arrayTwo[i] = temp[1];
                }
                else
                {
                    arrayOne[i] = temp[1];
                    arrayTwo[i] = temp[0];
                }
            }
            Console.WriteLine(string.Join(" ", arrayOne));
            Console.WriteLine(string.Join(" ", arrayTwo));
        }
    }
}
