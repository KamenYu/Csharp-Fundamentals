using System;

namespace DataTypeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Integer
            //Floating point
            //Characters
            //Boolean
            //Strings

            string input = "";

            while ((input = Console.ReadLine()) != "END")
            {
                if (int.TryParse(input, out int integer))
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (double.TryParse(input, out double realNumber))
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (char.TryParse(input, out char symbol))
                {
                    Console.WriteLine($"{input} is character type");
                }
                else if (bool.TryParse(input, out bool statement))
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }
            }
        }
    }
}


