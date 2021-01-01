using System;

namespace PthBit
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            // decimal 51
            // binary  110011
            int p = int.Parse(Console.ReadLine());
            int m = n >> p;
            // binary  11001, removing the last element

            int bit = m & 1;
            Console.WriteLine(bit);
        }
    }
}
