using System;
using System.Collections.Generic;

namespace Hexadecimal_To_Decimal
{
  internal class Program
  {
    static void Main(string[] args)
    {
      string hexadecimal = "4B0";
      Console.WriteLine("Hexadecimal number: " + hexadecimal);
      int Decimal = int.Parse(hexadecimal, System.Globalization.NumberStyles.HexNumber);
      Console.WriteLine("Convert to-");
      Console.WriteLine("Decimal number: " + Decimal);
    }
  }
}
