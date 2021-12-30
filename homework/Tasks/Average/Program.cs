using System;

namespace Average
{
  internal class Program
  {
    static void Main(string[] args)
    {
      double number_1, number_2, number_3, number_4;
      Console.Write("Enter the First number: ");
      number_1 = Convert.ToDouble(Console.ReadLine());
      Console.Write("Enter the Second number: ");
      number_2 = Convert.ToDouble(Console.ReadLine());
      Console.Write("Enter the third number: ");
      number_3 = Convert.ToDouble(Console.ReadLine());
      Console.Write("Enter the fourth number: ");
      number_4 = Convert.ToDouble(Console.ReadLine());
      double result = (number_1 + number_2 + number_3 + number_4) / 4;
      Console.WriteLine("The average of {0}, {1}, {2}, {3} is: {4} ", number_1, number_2, number_3, number_4, result);
    }
  }
}
