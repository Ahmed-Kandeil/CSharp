using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nearest_To_One
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Input first integer:");
      int number_1 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Input second integer:");
      int number_2 = Convert.ToInt32(Console.ReadLine());
      int one = 1;
      var val1 = Math.Abs(number_1 - one);
      var val2 = Math.Abs(number_2 - one);
      Console.WriteLine(val1 == val2 ? 0 : (val1 < val2 ? number_1 : number_2));
    }
  }
}
