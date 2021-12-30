using System;

namespace New_String
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(first_last("Ahmed"));
      Console.WriteLine(first_last("Kandil"));
      Console.WriteLine(first_last("x"));
    }
    public static string first_last(string str)
    {
      return str.Length > 1
          ? str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1) : str;
    }
  }
}
