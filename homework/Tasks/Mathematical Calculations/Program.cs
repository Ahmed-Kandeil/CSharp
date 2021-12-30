using System;

namespace Mathematical_Calculations
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Enter a number: ");
      int number_1 = Convert.ToInt32(Console.ReadLine());

      Console.Write("Enter another number: ");
      int number_2 = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("{0} + {1} = {2}", number_1, number_2, number_1 + number_2);
      Console.WriteLine("{0} - {1} = {2}", number_1, number_2, number_1 - number_2);
      Console.WriteLine("{0} x {1} = {2}", number_1, number_2, number_1 * number_2);
      Console.WriteLine("{0} / {1} = {2}", number_1, number_2, number_1 / number_2);
      Console.WriteLine("{0} mod {1} = {2}", number_1, number_2, number_1 % number_2);
    }
  }
}
