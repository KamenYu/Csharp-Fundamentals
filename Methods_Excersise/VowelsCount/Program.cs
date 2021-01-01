using System;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a method that counts the amount of vowels in a given string
            // y is not a vowel
            string input = Console.ReadLine();           
            Console.WriteLine(VowelsCounter(input));
        }   

        static string VowelsCounter(string input)
        {
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {                
                switch (input[i].ToString())
                {
                    case "a":
                    case "e":
                    case "o":
                    case "u":
                    case "i":
                    case "A":
                    case "E":
                    case "O":
                    case "U":
                    case "I":
                        counter++;
                        break;
                }                            
            }
            return counter.ToString();
        }
    }
}
