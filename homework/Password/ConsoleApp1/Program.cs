using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string old_password, password, new_password, option;
            int attempts = 3;
            old_password = "0000";
            Console.WriteLine("Enter The Password : ");
            password = Console.ReadLine();
            do
            {
                if (password != old_password)
                {
                    if (attempts > 1)
                    {
                        attempts--;
                        Console.WriteLine($"Wrong Passwrod. Your Have Only {attempts} Attempts Left.");
                        Console.WriteLine("Trt Again : ");
                        password = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Wrong Passwrod. It's Your Last Chance.");
                        password = Console.ReadLine();
                        if (password != old_password)
                        {
                            Console.WriteLine("Game Over Baby.");
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("That's Correct.");
                    Console.WriteLine("Do You Want To Change Your Password ? ");
                    option = Console.ReadLine();
                    option = option.ToLower();
                    if (option == "yes")
                    {
                        Console.WriteLine("Write Your New Password : ");
                        new_password = Console.ReadLine();
                        if (old_password == new_password)
                        {
                            Console.WriteLine("It's The Same Password.");
                        }
                        else
                        {
                            Console.WriteLine("Your password has been changed successfully.");
                            break;
                        }
                    }
                    else if (option == "no")
                    {
                        Console.WriteLine("Have A Nice Day.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong Option.");
                    }
                }
            } while (attempts != 0);
        }
    }
}