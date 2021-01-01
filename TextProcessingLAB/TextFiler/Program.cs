using System;

namespace TextFiler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] censure = Console.ReadLine().Split(", ");

            string text = Console.ReadLine();

            for (int i = 0; i < censure.Length; i++)
            {
                text = text.Replace(censure[i],
                    new string('*', censure[i].Length));
            }

            Console.WriteLine(text);
        }
    }
}
