using System;

namespace ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            // aaaaabbbbbcdddeeeedssaa
            // abcdesa

            string input = Console.ReadLine();

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == input [i - 1])
                {
                    input = input.Remove(i, 1);
                    i = 0;
                }
            }
            Console.WriteLine(input);
        }
    }
}
