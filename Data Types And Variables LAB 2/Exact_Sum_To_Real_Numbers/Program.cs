﻿using System;

namespace Exact_Sum_To_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal sum = 0;

            for (int i = 0; i < n; i++)
            {
                decimal realNum = decimal.Parse(Console.ReadLine());
                sum += realNum;
            }
            Console.WriteLine(sum);
        }
    }
}
