using System;
using System.Threading;

namespace Admin
{
    class Program
    {
        static int table_width = 73;
        static void Main()
        {
            string name, new_name, quiting, quiting_opiton, option_not_admin, password;
            const string main_title = "Admins";
            quiting_opiton = "yes";
            const string old_password = "0000";
            int number, position, option_admin, attempts, i;
            number = 0;
            attempts = 3;
            const int prograes = 80, short_sleep = 500, sleep = 1000, long_sleep = 1250;
            string[] admins = {
                "ahmed",
                "amr",
                "kandeil"
            };
            Console.Title = main_title;
            Console.Write("Enter Your Name : ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            name = Console.ReadLine().ToLower();
            Console.ForegroundColor = ConsoleColor.White;
            var check = Array.Exists(admins, x => x == name);
            position = Array.IndexOf(admins, name);
            if (check == true)
            {
                Console.WriteLine($"Hi {name} Welcome Back");
                do
                {
                    Console.Title = main_title;
                    Console.Clear();
                    Console.WriteLine("1 => Check The Employees Work Report.");
                    Console.WriteLine("2 => See The Project Progress.");
                    Console.WriteLine("3 => Submit The Project To The Boss.");
                    Console.WriteLine("4 => Your Name Is Wrong And Your Want To Change It.");
                    Console.WriteLine("5 => You Have Been Promoted To A higher Position And Want To Delete Your Name Or Your Are Quiting ?");
                    Console.WriteLine("6 => Log Out.");
                    Console.WriteLine();
                    Console.Write("What Do You Want To Do ? ");
                    option_admin = Convert.ToInt32(Console.ReadLine());
                    switch (option_admin)
                    {
                        case 1:
                            Console.Title = "The Employees Work Report";
                            Console.Clear();
                            PrintLine();
                            PrintRow("Ahmed", "Khalid", "Amr", "Mohamed");
                            PrintLine();
                            PrintRow("Web Designer", "UI/UX Designer", "Web Developer", "Project Manager");
                            PrintRow("Finished His Work", "Finished His Work", "Need 2 More Days", "Almost Finished");
                            PrintLine();
                            Console.WriteLine();
                            Console.Write("Do You Want To Continue ? ");
                            quiting_opiton = Console.ReadLine().ToLower();
                            break;
                        case 2:
                            Console.Title = "The Project Progress";
                            Console.Clear();
                            Console.Write("E \\ ");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write("Khalid");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(" Have Finished The ");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("UI/UX Design");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(".");
                            Console.Write("E \\ ");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write("Ahmed");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(" Have Finished Coding The ");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("Design Into A Website");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(".");
                            Console.Write("E \\ ");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write("Mohamed");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(" Is About To Complete The ");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("Website Test");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(".");
                            Console.Write("The Prograes Is => ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write($"{prograes}%");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(" In Total.");
                            Console.WriteLine();
                            Console.Write("Do You Want To Continue ? ");
                            quiting_opiton = Console.ReadLine().ToLower();
                            break;
                        case 3:
                            Console.Title = "Submiting The Project";
                            Console.Clear();
                            Console.Write("Loading");
                            for (i = 0; i < 3; i++)
                            {
                                Thread.Sleep(long_sleep);
                                Console.Write(".");
                            }
                            Console.WriteLine();
                            Thread.Sleep(sleep);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Loading Complete.");
                            Console.ForegroundColor = ConsoleColor.White;
                            Thread.Sleep(short_sleep);
                            Console.Write("Submiting");
                            for (i = 0; i < 3; i++)
                            {
                                Thread.Sleep(long_sleep);
                                Console.Write(".");
                            }
                            Console.WriteLine();
                            Thread.Sleep(sleep);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("You Have Submitted The Project Successfully.");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine();
                            Console.Write("Do You Want To Continue ? ");
                            quiting_opiton = Console.ReadLine().ToLower();
                            break;
                        case 4:
                            Console.Clear();
                            do
                            {
                                Console.Title = "Changing The Name";
                                Console.Write("Write Your New Name: ");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                new_name = Console.ReadLine().ToLower();
                                Console.ForegroundColor = ConsoleColor.White; 
                                if (name == new_name)
                                {
                                    Console.WriteLine("It's The Same.");
                                }
                                else
                                {
                                    admins[position] = new_name;
                                    Console.WriteLine("You Have Updated Your Name.");
                                    foreach (string admin in admins)
                                    {
                                        number++;
                                        Console.WriteLine($"{number} => {admin}");
                                    }
                                }
                            }
                            while (name == new_name);
                            Console.WriteLine();
                            Console.Write("Do You Want To Continue ? ");
                            quiting_opiton = Console.ReadLine().ToLower();
                            break;
                        case 5:
                            Console.Title = "Deleting The Name";
                            Console.Clear();
                            Console.Write("Are You Quiting ? ");
                            quiting = Console.ReadLine().ToLower();
                            bool is_quiting(string remove_tool)
                            {
                                return remove_tool != name;
                            }
                            admins = Array.FindAll(admins, is_quiting);
                            Console.WriteLine("You Have Deleted Your Name.");
                            foreach (string admin in admins)
                            {
                                number++;
                                Console.WriteLine($"{number} => {admin}");
                            }
                            // Increasing The Derma
                            // In A Comic Way
                            if (quiting == "yes")
                            {
                                Thread.Sleep(long_sleep);
                                Console.Write("I'm Sorry Because I Don't Feel ");
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write("SAD");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine(".");
                                Thread.Sleep(sleep);
                                Console.ForegroundColor= ConsoleColor.Gray;
                                Console.WriteLine("After All, I'm Just A Machine.");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else if (quiting == "no")
                            {
                                Thread.Sleep(long_sleep);
                                Console.Write("I'm Sorry Because I Don't Feel ");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("HAPPY");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine(".");
                                Thread.Sleep(sleep);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine("After All, I'm Just A Machine.");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else
                            {
                                Console.WriteLine("Why Don't You Want To Tell Me Because I'm Just A Machine After All.");
                            }
                            Console.WriteLine();
                            Console.Write("Do You Want To Continue ? ");
                            quiting_opiton = Console.ReadLine().ToLower();
                            break;
                        case 6:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("You Have Successfully Logged Out");
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        default:
                            Console.WriteLine("Worng Opition.");
                            break;
                    }
                }
                while (option_admin != 6 && quiting_opiton == "yes");
            }
            else
            {
                Console.WriteLine("You Are Not Admin.");
                Console.Write("Do You Want To Become An Admin ? ");
                option_not_admin = Console.ReadLine().ToLower();
                if (option_not_admin == "yes")
                {
                    Console.WriteLine("Enter The Password : ");
                    Console.BackgroundColor = ConsoleColor.White;
                    password = Console.ReadLine();
                    Console.BackgroundColor = ConsoleColor.Black;
                    do
                    {
                        if (password != old_password)
                        {
                            if (attempts > 1)
                            {
                                attempts--;
                                Console.WriteLine($"Wrong Passwrod. Your Have Only {attempts} Attempts Left.");
                                Console.WriteLine("Trt Again : ");
                                Console.BackgroundColor = ConsoleColor.White;
                                password = Console.ReadLine();
                                Console.BackgroundColor = ConsoleColor.Black;
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
                        }
                    } while (attempts != 0 && old_password != password);
                    Array.Resize(ref admins, admins.Length + 1);
                    admins[admins.Length - 1] = name;
                    Console.WriteLine("Well Done You Are Now An Admin.");
                    Console.WriteLine("Note : But It Will Take 14 Days To Be Actived!!");
                    foreach (string admin in admins)
                    {
                        number++;
                        Console.WriteLine($"{number} => {admin}");
                    }
                }
                else if (option_not_admin == "no")
                {
                    Console.WriteLine("Have A Nice Day.");
                }
                else
                {
                    Console.WriteLine("Wrong Option.");
                }
            }
        }
        static void PrintLine()
        {
            Console.WriteLine(new string('-', table_width));
        }
        static void PrintRow(params string[] columns)
        {
            int width = (table_width - columns.Length) / columns.Length;
            string row = "|";
            foreach (string column in columns)
            {
                row += AlignCentre(column, width) + "|";
            }
            Console.WriteLine(row);
        }
        static string AlignCentre(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;
            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }
    }
}