using System;

namespace Absolute_Value
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(result(13, 40));
      Console.WriteLine(result(50, 21));
      Console.WriteLine(result(0, 23));
    }
    public static int result(int number_1, int number_2)
    {
      if (number_1 > number_2)
      {
        return (number_1 - number_2) * 2;
      }
      return number_2 - number_1;
    }
  }
}
