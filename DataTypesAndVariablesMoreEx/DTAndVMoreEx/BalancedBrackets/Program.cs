using System;

namespace BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            byte counterOpen = 0;
            byte counterClose = 0;

            for (int i = 1; i <= n; i++)
            {                
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (tokens[0] == "(")
                {
                    counterOpen++;
                }
                else if (tokens[0] == ")")
                {
                    counterClose++;
                    if (counterOpen - counterClose != 0)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                }
                
            }
            if (counterClose == counterOpen)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}

