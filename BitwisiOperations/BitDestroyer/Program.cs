﻿using System;

namespace BitDestroyer
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());  
            
            int position = int.Parse(Console.ReadLine());
            int mask = ~ (1 << position);
            int newNumber = number & mask;
            Console.WriteLine(newNumber);
            
        }
    }
}
