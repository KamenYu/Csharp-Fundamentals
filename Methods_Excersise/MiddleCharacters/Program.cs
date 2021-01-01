using System;

namespace MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will receive a single string.
            //Write a method that prints the middle character.
            //If the length of the string is even there are two middle characters.

            string input = Console.ReadLine();
            Console.WriteLine(ReturnMidlleChars(input));
        }

        static string ReturnMidlleChars(string input)
        {            
            string middle;
            
            if (input.Length % 2 == 0)
            {
                string middle2 = input[input.Length / 2].ToString();
                string middle1 = input[(input.Length / 2) - 1].ToString();
                middle = middle1 + middle2;
            }
            else
            {
                middle = input[input.Length / 2].ToString();                   
            }
            return middle;
        }
    }
}
