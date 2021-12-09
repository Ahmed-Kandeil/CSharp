using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double area, radius;
            const double pi = 3.1416;
            Console.WriteLine("Enter The Radius : ");
            radius = Convert.ToDouble(Console.ReadLine());
            area = pi * radius * radius;
            Console.WriteLine($"The Area Is => {area}");
        }
    }
}
