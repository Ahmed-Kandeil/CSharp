using System;

namespace Negative_And_Positive
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Input first integer:");
      int number_1 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Input second integer:");
      int number_2 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Check if one is negative and one is positive:");
      Console.WriteLine((number_1 < 0 && number_2 > 0) || (number_1 > 0 && number_2 < 0));
    }
  }
}
