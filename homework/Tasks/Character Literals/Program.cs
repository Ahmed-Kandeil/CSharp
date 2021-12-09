using System;

namespace Character_Literals
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol;
            symbol = 'a'; // An ordinary symbol
            Console.WriteLine(symbol);
            symbol = '\u006F'; // Unicode symbol code in The hexadecimal format
            Console.WriteLine(symbol);
            symbol = '\u8449'; // 葉 (Leaf in Traditional Chinese)
            Console.WriteLine(symbol);
            symbol = '\''; // Assigning the single quote symbol
            Console.WriteLine(symbol);
            symbol = '\\'; // Assigning the backslash symbol
            Console.WriteLine(symbol);
            symbol = '\n'; // Assigning new line symbol
            Console.WriteLine(symbol);
            symbol = '\t'; // Assigning TAB symbol
            Console.WriteLine(symbol);
            symbol = 'a'; // Incorrect: use single quotes
            Console.WriteLine(symbol);
        }
    }
}
