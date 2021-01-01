using System;

namespace login
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string correctPass = string.Empty;

            for (int i = userName.Length - 1; i >= 0; i--)
            {
                correctPass += userName[i];
            }

            string pass = Console.ReadLine();
            int counter = 0;
            while (correctPass != pass)
            {
                counter++;
                if (counter == 4)
                {
                    Console.WriteLine($"User {userName} blocked!");
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
                pass = Console.ReadLine();
            }
            if (correctPass == pass)
            {
                Console.WriteLine($"User {userName} logged in.");
            }
        }
    }
}
