using System;

namespace ASCIISumator
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program that prints a sum of all characters between two given characters (their ascii code).
             * On the first line you will get a character. 
             * On the second line you get another character. 
             * On the last line you get a random string. 
             * Find all the characters between the two given and print their ascii sum. */
            // copied from java code, also, slower
            //char one = char.Parse(Console.ReadLine());
            //char two = char.Parse(Console.ReadLine());
            //string line = Console.ReadLine();
            //int sum = 0;

            //int start = Math.Min(one, two);
            //int end = Math.Max(one, two);

            //for (int i = 0; i < line.Length; i++)
            //{
            //    char current = line[i];
            //    if (current > start && current < end)
            //    {
            //        sum += current;
            //    }
            //}
            //Console.WriteLine(sum);

            // mine -> wich is faster
            char one = char.Parse(Console.ReadLine());
            char two = char.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            int sum = 0;

            int start = Math.Min(one, two);
            int end = Math.Max(one, two);

            for (int i = 0; i < line.Length; i++)
            {
                for (int j = start + 1; j < end; j++)
                {
                    if (j == line[i])
                    {
                        sum += j;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
