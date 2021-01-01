using System;
using System.Globalization;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateSrting = Console.ReadLine();
            DateTime date = DateTime.ParseExact(dateSrting, "dd-MM-yyyy",
                CultureInfo.InvariantCulture);
            Console.WriteLine(date.DayOfWeek);
        }
    }
}
