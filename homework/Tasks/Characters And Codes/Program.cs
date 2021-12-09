using System;

namespace Characters_And_Codes
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol;
            symbol = 'a';
            Console.WriteLine($"The Code Of '{symbol}' Is : {(int)symbol}");
            symbol = 'b';
            Console.WriteLine($"The Code Of '{symbol}' Is : {(int)symbol}");
            symbol = 'A';
            Console.WriteLine($"The Code Of '{symbol}' Is : {(int)symbol}");
        }
    }
}
