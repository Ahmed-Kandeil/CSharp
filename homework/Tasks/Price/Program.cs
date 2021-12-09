using System;

namespace Price
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            double price = 10.5;
            Console.Write("Enter Your Age : ");
            age = Convert.ToInt32(Console.ReadLine());
            if (age >= 10)
            {
                Console.WriteLine("You Have 50% Discount.");
                price /= 2;
            }
            else
            {
                Console.WriteLine("You Don't Have Discount.");
            }
            Console.WriteLine($"Give Me => ({price}) Plz.");
        }
    }
}
