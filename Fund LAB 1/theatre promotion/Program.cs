using System;
namespace theatre_promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string dayType = Console.ReadLine();       
            int age = int.Parse(Console.ReadLine());

            //Day / Age   0 <= age <= 18    18 < age <= 64     64 < age <= 122
            //Weekday     12$	             18$	            12$
            //Weekend     15$	             20$	            15$
            //Holiday      5$	             12$	            10$

            int ticketPrice = 0;

            if (age >= 0 && age <= 18)
            {
                if (dayType == "Weekday")
                {
                    ticketPrice = 12;
                }
                else if (dayType == "Weekend")
                {
                    ticketPrice = 15;
                }
                else if (dayType == "Holiday")
                {
                    ticketPrice = 5;
                }
            }
            else if (age > 18 && age <= 64)
            {
                if (dayType == "Weekday")
                {
                    ticketPrice = 18;
                }
                else if (dayType == "Weekend")
                {
                    ticketPrice = 20;
                }
                else if (dayType == "Holiday")
                {
                    ticketPrice = 12;
                }
            }
            else if (age > 64 && age <= 122)
            {
                if (dayType == "Weekday")
                {
                    ticketPrice = 12;
                }
                else if (dayType == "Weekend")
                {
                    ticketPrice = 15;
                }
                else if (dayType == "Holiday")
                {
                    ticketPrice = 10;
                }
            }

            if (age >= 0 && age <= 122)
            {
                Console.WriteLine(ticketPrice + "$");
            }
            if (age < 0 || age > 122)
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
