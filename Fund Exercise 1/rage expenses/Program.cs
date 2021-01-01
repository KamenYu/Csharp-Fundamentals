using System;

namespace rage_expenses
{
    class Program
    {
        static void Main(string[] args)
        {          
            //Calculate his rage expenses for renewing his gaming equipment.
            int lostGamesAmount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine()); //Every second lost game, Pesho trashes his headset.      2
            double mousePrice = double.Parse(Console.ReadLine());   //Every third lost game, Pesho trashes his mouse          3
            double keyboadrPrice = double.Parse(Console.ReadLine());  
            //When he trashes both his mouse and headset in the same lost game, he also trashes his keyboard.                 6
            double displayPrice = double.Parse(Console.ReadLine());   
            //Every second time, when he trashes his keyboard, he also trashes his display.                                  12
            double expenses = 0;

            for (int i = 1; i <= lostGamesAmount; i++)  // !! i=1;
            {
                if (i % 2 == 0)
                {
                    expenses += headsetPrice;
                }
                if (i % 3 == 0)
                {
                    expenses += mousePrice;
                }
                if (i % 6 == 0)
                {
                    expenses += keyboadrPrice;
                }
                if (i % 12 == 0)
                {
                    expenses += displayPrice;
                }
            }
            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}
