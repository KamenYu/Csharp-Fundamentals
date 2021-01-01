using System;

namespace Fibonachi
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());            
            Console.WriteLine(GetFibonachi(n));
        }

        private static int GetFibonachi(int n)
        {
            int first = 0;
            int second = 1;
            int result = 0;
            for (int i = 0; i <= n; i++)
            {
                result = first + second;
                second = first;
                first = result;
            }
            return result;
        }
    }
}
