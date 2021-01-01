using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordToRemove = Console.ReadLine().ToLower();
            string text = Console.ReadLine().ToLower();
            int index = text.IndexOf(wordToRemove);

            while (index >= 0)
            {
                text = text.Remove(index, wordToRemove.Length);
                index = text.IndexOf(wordToRemove);
            }
            Console.WriteLine(text);
        }
    }
}
