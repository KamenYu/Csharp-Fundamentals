using System;

namespace CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a method that receives two characters and prints on a single line all the characters
            //in between them according to ASCII.

            char one = char.Parse(Console.ReadLine());
            char two = char.Parse(Console.ReadLine());

            PrintingPartOfASCII(one, two);
        }

        static void PrintingPartOfASCII (char one, char two)
        {
            if (one < two)
            {
                for (int j = one + 1; j < two; j++)
                {
                    Console.Write((char)j + " ");
                }
            }
            else
            {
                for (int j = two + 1; j < one; j++)
                {
                    Console.Write((char)j + " ");
                }
            }
        }       
    }
}
