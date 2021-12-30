using System;

namespace Swap_Numbers
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int number_1, numbe_r2, temporary;
      Console.Write("\nInput the First Number : ");
      number_1 = int.Parse(Console.ReadLine());
      Console.Write("\nInput the Second Number : ");
      numbe_r2 = int.Parse(Console.ReadLine());
      temporary = number_1;
      number_1 = numbe_r2;
      number_1 = temporary;
      Console.Write("\nAfter Swapping : ");
      Console.Write("\nFirst Number : " + number_1);
      Console.Write("\nSecond Number : " + numbe_r2);
    }
  }
}
