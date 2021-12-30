using System;
using System.Linq;

namespace Alphabetical_Order
{
  internal class Program
  {
    static void Main(string[] args)
    {
      string str;
      Console.WriteLine("Enter A String");
      str = Console.ReadLine();
      Console.WriteLine(order(str));
    }
    public static string order(string str1)
    {
      return new string(str1.OrderBy(x => x).ToArray());
    }
  }
}
