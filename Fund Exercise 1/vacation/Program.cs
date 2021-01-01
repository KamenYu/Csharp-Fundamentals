using System;

namespace vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            //91/100
            //                        Friday  Saturday    Sunday
            //Students                8.45     9.80        10.46
            //Business               10.90    15.60        16
            //Regular                15       20           22.50

            //•	Students >= 30 people you should reduce the total price by 15%
            //•	Business >= 100 people 10 of them can stay for free.
            //•	Regular >= 10 && <= 20 reduce the total price by 5 %

            int groupAmount = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();                       // Students, Business, Regular
            string day = Console.ReadLine();                             // Friday, Saturday, Sunday
            double price = 0;

            switch (day)
            {
                case "Friday":
                    if (groupType == "Students")
                    {
                        price = groupAmount * 8.45;
                    }
                    else if (groupType == "Business")
                    {
                        price = groupAmount * 10.90;
                    }
                    else if (groupType == "Regular")
                    {
                        price = groupAmount * 15.00;
                    }

                    break;
                case "Saturday":
                    if (groupType == "Students")
                    {
                        price = groupAmount * 9.80;
                    }
                    else if (groupType == "Business")
                    {
                        price = groupAmount * 15.60;
                    }
                    else if (groupType == "Regular")
                    {
                        price = groupAmount * 20.00;
                    }

                    break;
                case "Sunday":
                    if (groupType == "Students")
                    {
                        price = groupAmount * 10.46;
                    }
                    else if (groupType == "Business")
                    {
                        price = groupAmount * 16.00;
                    }
                    else if (groupType == "Regular")
                    {
                        price = groupAmount * 22.50;
                    }

                    break;
            }

            if (groupType == "Students" && groupAmount >= 30)
            {
                price *= 0.85;
            }
            if (groupType == "Business" && groupAmount >= 100)
            {
                price -= 10;     
            }
            if (groupType == "Regular" && groupAmount >= 10 && groupAmount <= 20)
            {
                price *= 0.95;
            }
            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}
