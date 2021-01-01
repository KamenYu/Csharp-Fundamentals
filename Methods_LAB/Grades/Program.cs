using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a method that receives a grade between 2.00 and 6.00 and prints the corresponding grade in words
            //2.00 – 2.99 - "Fail"
            //3.00 – 3.49 - "Poor"
            //3.50 – 4.49 - "Good"
            //4.50 – 5.49 - "Very good"
            //5.50 – 6.00 - "Excellent"
            Grade(double.Parse(Console.ReadLine()));
        }

        static void Grade(double amount)
        {
            if (amount == 2.00 || amount <= 2.99)
            {
                Console.WriteLine("Fail");
            }
            else if (amount == 3 || amount <= 3.49)
            {
                Console.WriteLine("Poor");
            }
            else if (amount == 3.5 || amount <= 4.49)
            {
                Console.WriteLine("Good");
            }
            else if (amount == 4.5 || amount <= 5.49)
            {
                Console.WriteLine("Very good");
            }
            else if (amount == 5.5 || amount <= 6.00)
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
