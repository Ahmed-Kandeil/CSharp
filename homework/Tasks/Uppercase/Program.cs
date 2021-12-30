using System;

namespace Uppercase
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Input a string: ");
      string str = Console.ReadLine();
      Console.WriteLine(str.ToUpper());
    }
  }
}
