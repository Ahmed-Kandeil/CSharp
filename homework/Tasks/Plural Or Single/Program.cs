using System;

namespace Plural_Or_Single
{
  internal class Program
  {
    static void Main(string[] args)
    {
      string str;
      Console.WriteLine("Enter A Word :");
      str = Console.ReadLine();
      Console.WriteLine(single(str));
    }
    public static bool single(string word)
    {
      return word.EndsWith("s");
    }
  }
}
