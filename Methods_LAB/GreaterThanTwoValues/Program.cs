using System;

namespace GreaterThanTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = Console.ReadLine();

            if(value == "int")
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine(GetBigger(num1, num2));
            }

            if (value == "char")
            {
                char num1 = char.Parse(Console.ReadLine());
                char num2 = char.Parse(Console.ReadLine());
                Console.WriteLine(GetBigger(num1, num2));
            }

            if (value == "string")
            {
                string num1 = Console.ReadLine();
                string num2 = Console.ReadLine();
                Console.WriteLine(GetBigger(num1, num2));
            }
        }

        static int GetBigger(int a, int b)
        {
            int compared = a.CompareTo(b);

            if (compared > 0)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        static char GetBigger(char a, char b)
        {
            int compared = a.CompareTo(b);

            if (compared > 0)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        static string GetBigger(string a, string b)
        {
            int compared = a.CompareTo(b);

            if (compared > 0)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
