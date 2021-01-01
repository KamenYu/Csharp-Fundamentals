using System;
using System.Collections.Generic;

namespace BitAtPosition1
{
    class Program
    {
        static void Main(string[] args)
        {
            // decimal      51
            // binary       110011
            // indexOrder   543210     

            int n = int.Parse(Console.ReadLine());
            // decimal 51
            // binary  110011

            int p = n >> 1;
            // binary  11001, removing the last element

            int bit = p & 1;
            Console.WriteLine(bit);
            
        }
    }
}
