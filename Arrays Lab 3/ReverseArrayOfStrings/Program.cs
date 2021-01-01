using System;

namespace ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //a b c d e    input
            string[] input = Console.ReadLine().Split();
            //a //b //c //d //e
           
            
            for (int i = 0; i < input.Length / 2; i++)
            {
                string temp = input[i];
                input[i] = input[input.Length - 1 - i];
                input[input.Length - 1 - i] = temp;
            }
            Console.WriteLine(String.Join(" ", input));
            //e d c b a    result
        }
    }
}
