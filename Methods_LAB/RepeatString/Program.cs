using System;
using System.Text;

namespace RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            short n = short.Parse(Console.ReadLine());
            Console.WriteLine(RepeatStingsByGivenNum(input, n)); 
        }

        static string RepeatStingsByGivenNum (string input, short num)
        {
            StringBuilder result = new StringBuilder();   // use StringBuilder to add to strings, it is faster

            for (int i = 0; i < num; i++)
            {
                result.Append(input);
            }

            return result.ToString();
        }
    }
}
