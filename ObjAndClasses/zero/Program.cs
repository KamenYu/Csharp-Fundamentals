using System;

namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split();

            Random num = new Random();

            for (int i = 0; i < text.Length; i++)
            {
                int randomizedIndex = num.Next(0, text.Length);

                string word = text[i];
                text[i] = text[randomizedIndex];
                text[randomizedIndex] = word;
            }
            //foreach (string item in text)
            //{
            //    Console.WriteLine(item);
            //}
            Console.WriteLine(string.Join(Environment.NewLine, text));
        }
    }
}
