using System;

namespace padawan_equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int studentCount = int.Parse(Console.ReadLine());
            double singleLightsaber = double.Parse(Console.ReadLine());   // prices
            double singleRobe = double.Parse(Console.ReadLine());
            double singleBelt = double.Parse(Console.ReadLine());
            double belts = 0;

            if (studentCount >= 6)
            {
                belts = studentCount - studentCount / 6;
            }
            else
            {
                belts = studentCount;
            }

            double lightSabersNeeded = Math.Ceiling((studentCount * 0.1) + studentCount);
            double neededMoney = lightSabersNeeded * singleLightsaber + singleBelt * belts + studentCount * singleRobe;

            if (neededMoney <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {neededMoney:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {neededMoney-money:f2}lv more.");
            }
        }
    }
}
