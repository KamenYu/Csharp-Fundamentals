using System;
using System.Globalization;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            //If a password is valid print "Password is valid".
            //If it is not valid, for every unfulfilled rule print a message:
            //"Password must be between 6 and 10 characters"
            //"Password must consist only of letters and digits"
            //"Password must have at least 2 digits"

            string password = Console.ReadLine();
            PasswordChecker(password);           
        }

        static void PasswordChecker(string input)
        {
            bool isInvalid = false;
            if (input.Length < 6 || input.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isInvalid = true;
            }

            if (CorrectSymbols(input) == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isInvalid = true;
            }

            if (CorrectAmountOfNumbers(input) < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                isInvalid = true;
            }

            if (isInvalid == false)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool CorrectSymbols(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                char current = input[i];
                if (!((current >= 47 && current <= 58)
                    || (current >= 65 && current <= 90)
                    || (current >= 97 && current <= 122)))
                {
                    return false;
                }
            }
            return true;
        }

        static int CorrectAmountOfNumbers (string input)
        {
            byte counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if(input[i] >= 47 && input[i] <= 58)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
