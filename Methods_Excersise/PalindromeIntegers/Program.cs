using System;
using System.Linq;

namespace PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program which reads a positive integer numbers until you receive
            // "End", for each number print whether the number is palindrome or not.
            string command = Console.ReadLine();
            while(command != "END")
            {
                Console.WriteLine(isItPalindrome(command).ToString().ToLower());
                command = Console.ReadLine();
            }
        }

        static bool isItPalindrome(string text)
        {
            var reversed = text.Reverse().ToArray();

            for (int i = 0; i < text.Length; i++)
            {
                if (!(text[i] == reversed[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
