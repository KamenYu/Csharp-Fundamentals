using System;

namespace NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            NxNMatrixCreator(n);
        }

        static void NxNMatrixCreator(int n)
        {
            for (int row = 1; row <= n; row++)
            {
                Console.Write(n);
                for (int col = 1; col < n; col++)
                {
                    Console.Write(" " + n);
                }
                Console.WriteLine();
            }            
        }
    }
}
