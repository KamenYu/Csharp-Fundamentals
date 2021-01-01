using System;

namespace Print_Part_Of_The_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            string output = "";

            for (int i = start; i <= end; i++)
            {
                char symbol = (char)i;
                output += symbol + " ";
            }
            Console.WriteLine(output);
        }
    }
}
