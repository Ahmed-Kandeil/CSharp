using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string first_name, last_name, full_name;
            first_name = "Ahmed";
            last_name = "Kandeil";
            Console.WriteLine($"Hello, {first_name}!\n");
            full_name = first_name + " " + last_name;
            Console.WriteLine($"Your full name is {full_name}.");
        }
    }
}
