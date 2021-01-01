using System;

namespace ages
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            
            string growth = "";

            if (age >= 0 && age <= 2)
            {
                growth = "baby";
            }
            else if (age >= 3 && age <= 13)
            {
                growth = "child";

            }
            else if (age >= 14 && age <= 19)
            {
                growth = "teenager";
            }
            else if (age >= 20 && age <= 65)
            {
                growth = "adult";
            }
            else if ( age >= 66)
            {
                growth = "elder";
            }
            Console.WriteLine(growth);
        }
    }
}
