using System;
using System.Collections.Generic;

namespace BinaryDigitsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            byte b = byte.Parse(Console.ReadLine());
            List<int> result = new List<int>();
            int digit;
            byte count = 0;

            while (n > 0)
            {
                digit =  n % 2;
                result.Add(digit);
                n /= 2;
            }

            result.Reverse();

            foreach (var item in result)
            {
                if (item == b)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
