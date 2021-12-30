using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specified_Start
{
  internal class Program
  {
    static void Main(string[] args)
    {
      string str;
      Console.Write("Input a string : ");
      str = Console.ReadLine();
      Console.WriteLine((str.Length < 6 && str.Equals("Hello")) || (str.StartsWith("Hello") && str[5] == ' '));
    }
  }
}
