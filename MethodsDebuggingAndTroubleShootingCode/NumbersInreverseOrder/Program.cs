using System;

namespace NumbersInreverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num = decimal.Parse(Console.ReadLine());
            Console.WriteLine(ReversedNum(num.ToString())); 
        }

        private static string ReversedNum(string n)
        {
            char[] arr = n.ToCharArray();
            Array.Reverse(arr);
            
            return new string (arr);
        }
    }
}
