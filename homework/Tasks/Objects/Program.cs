using System;

namespace Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            object dataContainer;
            dataContainer = 5;
            Console.Write("The Value Of DataContainer Is : ");
            Console.WriteLine(dataContainer);
            dataContainer = "Five";
            Console.Write("The Value Of DataContainer Is : ");
            Console.WriteLine(dataContainer);
        }
    }
}