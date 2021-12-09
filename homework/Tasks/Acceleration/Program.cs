using System;

namespace Acceleration
{
    class Program
    {
        static void Main(string[] args)
        {
            double acceleration, time, distance;
            Console.WriteLine("Enter The Acceleration : ");
            acceleration = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter The Time : ");
            time = Convert.ToDouble(Console.ReadLine());
            distance = acceleration * time * time;
            Console.WriteLine($"The Distance Is =>({distance}m)");
        }
    }
}
