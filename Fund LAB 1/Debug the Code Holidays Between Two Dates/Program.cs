using System;
using System.Globalization;                                        // CultureInfo works with System.Globalization

class HolidaysBetweenTwoDates
{           
    static void Main()
    {
        DateTime startDate = DateTime.ParseExact(Console.ReadLine(),     // ParseExact takes exaclty d.MM.yyyy and expects same output
            "d.M.yyyy", CultureInfo.InvariantCulture);             // for dateTime format look -> date time string format
        DateTime endDate = DateTime.ParseExact(Console.ReadLine(),
            "d.M.yyyy", CultureInfo.InvariantCulture);
        var holidaysCount = 0;

        for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))     // FOR cycle i = 1; 1 <= 20; !!i++!!
        {
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)     // either Saturday OR Sunday
            {
                holidaysCount++;
            }
        }
        Console.WriteLine(holidaysCount);
    }
}

