using System;

namespace Even_And_Odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter The Number : ");
            number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} Is Even.");
            }
            else
            {
                Console.WriteLine($"{number} Is Odd.");
            }
        }
    }
}
