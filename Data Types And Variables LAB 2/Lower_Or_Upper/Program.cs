using System;

namespace Lower_Or_Upper
{
    class Program
    {
        static void Main(string[] args)
        {
            // if a character is an upper of lower case

            char a = char.Parse(Console.ReadLine());
            int casted = (int)a;

            if (casted >= 65 && casted <= 90)
            {
                Console.WriteLine("upper-case");
            }
            else if (casted >= 90 && casted <= 122)
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
