using System;
using System.Text;
using System.Diagnostics;

namespace DEMOS
{
    class Program
    {
        static void Main(string[] args)
        {
            //----
            //Index OF
            string greeting = Console.ReadLine(); // "O p a   k a k e"
                                                  //  0 1 2 3 4 5 6 7

            Console.WriteLine(greeting.IndexOf("kak"));  // index is 4, because from there kak starts
            Console.WriteLine(greeting.IndexOf("a"));    // 2
            Console.WriteLine(greeting.IndexOf("3", 2)); // 5

            string word = Console.ReadLine();  // word
            string text = Console.ReadLine();  // With a word you can describe a word
            int startIndex = 0;

            while (text.IndexOf(word, startIndex) > -1)
            {
                startIndex = text.IndexOf(word, startIndex) + 1;
                Console.WriteLine($"{ word } found at { startIndex - 1 }"); // word, 7; word 31
            }

            string fruit = "banana, apple, kiwi, banana, apricot";
            Console.WriteLine(fruit.LastIndexOf("banana")); // 21

            //---
            //substring

            string words = "I have to be a wood in order to burn";

            string sub = words.Substring(15, 4); // "wood"

            string substr = words.Substring(18); // "d in order to burn"

            int index = 0;

            while (index + 10 < words.Length)
            {
                Console.WriteLine(words.Substring(index, 10));
                index += 10;
            }

            Console.WriteLine(words.Substring(index));

            //----
            // REPLACE

            //Console.WriteLine(words.Replace("to", "babadook"));
            //Console.WriteLine(words.Replace('a', 'U'));


            // STRING BUILDER

            StringBuilder result = new StringBuilder("pesho");
            result.AppendLine("is the best");
            result.AppendLine("yooo");
            result[0] = 'G';
            result.Insert(4, " not");
            result.Remove(10, 3);
            Console.WriteLine(result);
            result.Clear();
            Console.WriteLine(result); // "" = empty
            string sbResult = result.ToString();


            // STOPWATCH
            int times = 50000;
            string resultt = "";
            Stopwatch watch = Stopwatch.StartNew();

            for (int i = 0; i < times; i++)
            {
                resultt += "text";
            }
            watch.Stop();

            Console.WriteLine(watch.ElapsedMilliseconds);  // 1036

            watch.Reset();

            StringBuilder sbResultt = new StringBuilder();
            watch.Start();
            int sbTimes = 50000;
            for (int i = 0; i < sbTimes; i++)
            {
                sbResultt.Append("text");
            }
            watch.Stop();

            Console.WriteLine(watch.ElapsedMilliseconds); // 0
        }

    }
}
