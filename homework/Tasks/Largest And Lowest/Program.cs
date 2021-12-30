using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_And_Lowest
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Input first integer:");
      int number_1 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Input second integer:");
      int number_2 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Input third integer:");
      int number_3 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Largest of three: " + Math.Max(number_1, Math.Max(number_2, number_3)));
      Console.WriteLine("Lowest of three: " + Math.Min(number_1, Math.Min(number_2, number_3)));
    }
  }
}
