using System;

namespace Multiplication_Table
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int number, result;
      Console.WriteLine("Enter a number:");
      number = Convert.ToInt32(Console.ReadLine());
      result = number * 1;
      Console.WriteLine("The table is : {0} x {1} = {2}", number, 1, result);
      result = number * 2;
      Console.WriteLine("             : {0} x {1} = {2}", number, 2, result);
      result = number * 3;
      Console.WriteLine("             : {0} x {1} = {2}", number, 3, result);
      result = number * 4;
      Console.WriteLine("             : {0} x {1} = {2}", number, 4, result);
      result = number * 5;
      Console.WriteLine("             : {0} x {1} = {2}", number, 5, result);
      result = number * 6;
      Console.WriteLine("             : {0} x {1} = {2}", number, 6, result);
      result = number * 7;
      Console.WriteLine("             : {0} x {1} = {2}", number, 7, result);
      result = number * 8;
      Console.WriteLine("             : {0} x {1} = {2}", number, 8, result);
      result = number * 9;
      Console.WriteLine("             : {0} x {1} = {2}", number, 9, result);
      result = number * 10;
      Console.WriteLine("             : {0} x {1} = {2}", number, 10, result);
    }
  }
}
