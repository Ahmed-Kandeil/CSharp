using System;

namespace After_10_Years
{
    class Program
    {
        static void Main(string[] args)
        {
            int age, age_after_10;
            Console.WriteLine("Enter Your Age : ");
            age = Convert.ToInt32(Console.ReadLine());
            age_after_10 = age + 10;
            Console.WriteLine($"Your Age After 10 Years Is => {age_after_10}.");
        }
    }
}
