using System;

namespace Days_Of_The_Week
{
    public class Program
    {
        enum week_days {
            Sat = 1,
            Sun,
            Mon,
            Tue,
            Wed,
            Thu,
            Fri
        };
        static void Main()
        {
            int day_1, day_2;
            day_1 = (int)week_days.Sun;
            day_2 = (int)week_days.Fri;
            Console.WriteLine($"Sun = {day_1}");
            Console.WriteLine($"Fri = {day_2}");
        }
    }
}
