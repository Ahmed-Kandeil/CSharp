using System;

namespace ConsoleApp1
{
    class UesrInput
    {
        static void Main(string[] args)
        {
            // Enter Your Name
            Console.Write("Enter Name: ");

            // Create a variable To Store The Name Value
            string name = Console.ReadLine();

            // Enter Your Age
            Console.Write("Enter Age: ");

            // Create a variable To Store The Age Value
            int age;
            age = Convert.ToInt32(Console.ReadLine());

            // Enter Your Age
            Console.Write("Enter Gander: ");

            // Create a variable To Store The Age Value
            string gender = Console.ReadLine();

            // reate a variable To Store The Gender Type Value
            string type;

            if (age > 18)
            {
                if (gender == "Male")
                {
                    type = "Man";
                }
                else if (gender == "Male")
                {
                    type = "Woman";
                }
                else
                {
                    Console.WriteLine("So You Are Not A Human.");
                }
            }
            else if (age < 18)
            {
                if (gender == "Male")
                {
                    type = "Boy";
                }
                else if (gender == "Male")
                {
                    type = "Girl";
                }
                else
                {
                    Console.WriteLine("So You Are Not A Human.");
                }
            }
            else
            {
                Console.WriteLine("Invalud");
            }
            // Print The Value Of The Variable => name
            Console.WriteLine($"Hi, Dr. {name} How Are You ?");

            // Print The Value Of The Variable => age
            Console.WriteLine($"Really {age} Years Old! Congratulations You Are A {type} Now.");
        }
    }
}
