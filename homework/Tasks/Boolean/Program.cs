using System;

namespace Boolean
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            bool greaterAB = (a > b);
            Console.WriteLine(greaterAB);  // False
            bool equalA1 = (a == 1);
            Console.WriteLine(equalA1);    // True
        }
    }
}
