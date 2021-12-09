using System;
public class EnumTest
{

    public enum DAYS : byte
    { 
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday 
    };
    public static void Main()
    {
        Array dayArray = Enum.GetValues(typeof(EnumTest.DAYS));

        foreach (DAYS day in dayArray)
        {
            Console.WriteLine($"Number {day.ToString("d")} of EnumTest.DAYS is {day}");
        }
    }
}