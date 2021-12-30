﻿using System;

namespace Sum_Of_First_500_Prime_Numbers
{
  internal class Program
  {
    public static void Main()
    {
      Console.WriteLine("Sum of the first 500 prime numbers: ");
      long sum = 0;
      int ctr = 0;
      int n = 2;
      while (ctr < 500)
      {
        if (isPrime(n))
        {
          sum += n;
          ctr++;
        }
        n++;
      }
      Console.WriteLine(sum.ToString());
    }
    public static bool isPrime(int n)
    {
      int x = (int)Math.Floor(Math.Sqrt(n));
      if (n == 1) return false;
      if (n == 2) return true;
      for (int i = 2; i <= x; ++i)
      {
        if (n % i == 0) return false;
      }
      return true;
    }
  }
}
