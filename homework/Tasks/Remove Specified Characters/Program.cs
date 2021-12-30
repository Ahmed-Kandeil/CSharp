using System;

namespace Remove_Specified_Characters
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(remove_char("Ahmed Kandil", 1));
      Console.WriteLine(remove_char("Ahmed Kandil", 9));
      Console.WriteLine(remove_char("Ahmed Kandil", 0));
    }
    public static string remove_char(string str, int index)
    {
      return str.Remove(index, 1);
    }
  }
}
