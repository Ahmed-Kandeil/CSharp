// Made By Ahmed Knadil
// 4211133
// A1
using System;

namespace Calculus
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int trigonometic_function;
      string option = "yes";
      do
      {
        Console.Title = "Differentation Of Trigonometic Function";
        Console.Clear();
        Console.WriteLine("01 => sin(X)");
        Console.WriteLine("02 => cos(X)");
        Console.WriteLine("03 => tan(X)");
        Console.WriteLine("04 => sec(X)");
        Console.WriteLine("05 => csc(X)");
        Console.WriteLine("06 => cot(X)");
        Console.WriteLine("07 => sin^-1(X)");
        Console.WriteLine("08 => cos^-1(X)");
        Console.WriteLine("09 => tan^-1(X)");
        Console.WriteLine("10 => sec^-1(X)");
        Console.WriteLine("11 => csc^-1(X)");
        Console.WriteLine("12 => cot^-1(X)");
        Console.WriteLine("13 => sinh(X)");
        Console.WriteLine("14 => cosh(X)");
        Console.WriteLine("15 => tanh(X)");
        Console.WriteLine("16 => sech(X)");
        Console.WriteLine("17 => csch(X)");
        Console.WriteLine("18 => coth(X)");
        Console.WriteLine("19 => arcsinh(X)");
        Console.WriteLine("20 => arccosh(X)");
        Console.WriteLine("21 => arctanh(X)");
        Console.WriteLine("22 => arcsech(X)");
        Console.WriteLine("23 => arccsch(X)");
        Console.WriteLine("24 => arccoth(X)");
        Console.WriteLine("25 => csc(X) - cot(X)");
        Console.WriteLine("26 => sin^2(4X)");
        Console.WriteLine("27 => sin(4X)cos(4X)");
        Console.WriteLine("28 => csc(X)/tan(2X)");
        Console.WriteLine();
        Console.Write("Enter The Trigonometic Function : ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        trigonometic_function = Convert.ToInt32(Console.ReadLine());
        Console.ResetColor();
        switch (trigonometic_function)
        {
          case 1:
            Console.Title = "Differentation Of Sin";
            Console.Clear();
            Console.WriteLine("sin(X) => cos(X)");
            Console.WriteLine();
            Console.Write("Do You Want To Continue ? ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            option = Console.ReadLine().ToLower();
            Console.ResetColor();
            break;
          case 2:
            Console.Title = "Differentation Of Cos";
            Console.Clear();
            Console.WriteLine("cos(X) => -sin(X)");
            Console.WriteLine();
            Console.Write("Do You Want To Continue ? ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            option = Console.ReadLine().ToLower();
            Console.ResetColor();
            break;
          case 3:
            Console.Title = "Differentation Of Tan";
            Console.Clear();
            Console.WriteLine("tan(X) => sec^2(X)");
            Console.WriteLine();
            Console.Write("Do You Want To Continue ? ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            option = Console.ReadLine().ToLower();
            Console.ResetColor();
            break;
          case 4:
            Console.Title = "Differentation Of Sec";
            Console.Clear();
            Console.WriteLine("sec(X) => sec(X)tan(X)");
            Console.WriteLine();
            Console.Write("Do You Want To Continue ? ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            option = Console.ReadLine().ToLower();
            Console.ResetColor();
            break;
          case 5:
            Console.Title = "Differentation Of Csc";
            Console.Clear();
            Console.WriteLine("csc(X) => -csc(X)cot(X)");
            Console.WriteLine();
            Console.Write("Do You Want To Continue ? ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            option = Console.ReadLine().ToLower();
            Console.ResetColor();
            break;
          case 6:
            Console.Title = "Differentation Of Cot";
            Console.Clear();
            Console.WriteLine("cot(X) => -csc^2(X)");
            Console.WriteLine();
            Console.Write("Do You Want To Continue ? ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            option = Console.ReadLine().ToLower();
            Console.ResetColor();
            break;
          case 7:
            Console.Title = "Differentation Of Sin^-1";
            Console.Clear();
            Console.WriteLine("Sin^-1(X) => 1/(1 - X^2)^1/2");
            Console.WriteLine();
            Console.Write("Do You Want To Continue ? ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            option = Console.ReadLine().ToLower();
            Console.ResetColor();
            break;
          case 8:
            Console.Title = "Differentation Of Cos^-1";
            Console.Clear();
            Console.WriteLine("cos^-1(X) => -1/(1 - X^2)^1/2");
            Console.WriteLine();
            Console.Write("Do You Want To Continue ? ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            option = Console.ReadLine().ToLower();
            Console.ResetColor();
            break;
          case 9:
            Console.Title = "Differentation Of Tan^-1";
            Console.Clear();
            Console.WriteLine("tan^-1(X) => 1/(1 - X^2)");
            Console.WriteLine();
            Console.Write("Do You Want To Continue ? ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            option = Console.ReadLine().ToLower();
            Console.ResetColor();
            break;
          case 10:
            Console.Title = "Differentation Of Sec^-1";
            Console.Clear();
            Console.WriteLine("sec^-1(X) => X(X - 1)^1/2");
            Console.WriteLine();
            Console.Write("Do You Want To Continue ? ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            option = Console.ReadLine().ToLower();
            Console.ResetColor();
            break;
          case 11:
            Console.Title = "Differentation Of Csc^-1";
            Console.Clear();
            Console.WriteLine("csc^-1(X) => -1/X(X - 1)^1/2");
            Console.WriteLine();
            Console.Write("Do You Want To Continue ? ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            option = Console.ReadLine().ToLower();
            Console.ResetColor();
            break;
          case 12:
            Console.Title = "Differentation Of Cot^-1";
            Console.Clear();
            Console.WriteLine("cot^-1(X) => -1/(X + 1)");
            Console.WriteLine();
            Console.Write("Do You Want To Continue ? ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            option = Console.ReadLine().ToLower();
            Console.ResetColor();
            break;
          case 13:
            Console.Title = "Differentation Of Sinh";
            Console.Clear();
            Console.WriteLine("sinh(X) => cosh(X)");
            Console.WriteLine();
            Console.Write("Do You Want To Continue ? ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            option = Console.ReadLine().ToLower();
            Console.ResetColor();
            break;
          case 14:
            Console.Title = "Differentation Of Cosh";
            Console.Clear();
            Console.WriteLine("cosh(X) => sinh(X)");
            Console.WriteLine();
            Console.Write("Do You Want To Continue ? ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            option = Console.ReadLine().ToLower();
            Console.ResetColor();
            break;
          case 15:
            Console.Title = "Differentation Of Tanh";
            Console.Clear();
            Console.WriteLine("tanh(X) => sech^2(X)");
            Console.WriteLine();
            Console.Write("Do You Want To Continue ? ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            option = Console.ReadLine().ToLower();
            Console.ResetColor();
            break;
          case 16:
            Console.Title = "Differentation Of Sech";
            Console.Clear();
            Console.WriteLine("sech(X) => -tanh(X)sech(X)");
            Console.WriteLine();
            Console.Write("Do You Want To Continue ? ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            option = Console.ReadLine().ToLower();
            Console.ResetColor();
            break;
          case 17:
            Console.Title = "Differentation Of Csch";
            Console.Clear();
            Console.WriteLine("csch(X) => -coth(X)csch(X)");
            Console.WriteLine();
            Console.Write("Do You Want To Continue ? ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            option = Console.ReadLine().ToLower();
            Console.ResetColor();
            break;
          case 18:
            Console.Title = "Differentation Of Coth";
            Console.Clear();
            Console.WriteLine("coth(X) => -csch^2(X)");
            Console.WriteLine();
            Console.Write("Do You Want To Continue ? ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            option = Console.ReadLine().ToLower();
            Console.ResetColor();
            break;
          case 19:
            Console.Title = "Differentation Of Arcsinh";
            Console.Clear();
            Console.WriteLine("arcsinh(X) => 1/(X^2+1)^1/2");
            Console.WriteLine();
            Console.Write("Do You Want To Continue ? ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            option = Console.ReadLine().ToLower();
            Console.ResetColor();
            break;
          case 20:
            Console.Title = "Differentation Of Arccosh";
            Console.Clear();
            Console.WriteLine("arccosh(X) => 1/(X^2-1)^1/2");
            Console.WriteLine();
            Console.Write("Do You Want To Continue ? ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            option = Console.ReadLine().ToLower();
            Console.ResetColor();
            break;
          case 21:
            Console.Title = "Differentation Of Arctanh";
            Console.Clear();
            Console.WriteLine("arctanh(X) => 1/(1-X^2)");
            Console.WriteLine();
            Console.Write("Do You Want To Continue ? ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            option = Console.ReadLine().ToLower();
            Console.ResetColor();
            break;
          case 22:
            Console.Title = "Differentation Of Arcsech";
            Console.Clear();
            Console.WriteLine("arcsech(X) => -1/(X(1-X^2))^1/2");
            Console.WriteLine();
            Console.Write("Do You Want To Continue ? ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            option = Console.ReadLine().ToLower();
            Console.ResetColor();
            break;
          case 23:
            Console.Title = "Differentation Of Arccsch";
            Console.Clear();
            Console.WriteLine("arccsch(X) => -1/(X(1+X^2))^1/2");
            Console.WriteLine();
            Console.Write("Do You Want To Continue ? ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            option = Console.ReadLine().ToLower();
            Console.ResetColor();
            break;
          case 24:
            Console.Title = "Differentation Of Arccoth";
            Console.Clear();
            Console.WriteLine("arccoth(X) => 1/(1-X^2)");
            Console.WriteLine();
            Console.Write("Do You Want To Continue ? ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            option = Console.ReadLine().ToLower();
            Console.ResetColor();
            break;
          case 25:
            Console.Title = "Differentation Of Compound Function";
            Console.Clear();
            Console.WriteLine("csc(X) - cot(X) => -csc(X)cot(X)+csc^2(X)");
            Console.WriteLine();
            Console.Write("Do You Want To Continue ? ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            option = Console.ReadLine().ToLower();
            Console.ResetColor();
            break;
          case 26:
            Console.Title = "Differentation Of Compound Function";
            Console.Clear();
            Console.WriteLine("sin^2(4X) => 8sin(4X)cos(4X)");
            Console.WriteLine();
            Console.Write("Do You Want To Continue ? ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            option = Console.ReadLine().ToLower();
            Console.ResetColor();
            break;
          case 27:
            Console.Title = "Differentation Of Compound Function";
            Console.Clear();
            Console.WriteLine("sin(4X)cos(4X) => 4cos(4X)cos(4X)+(-4sin(4X))sin(4X)");
            Console.WriteLine();
            Console.Write("Do You Want To Continue ? ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            option = Console.ReadLine().ToLower();
            Console.ResetColor();
            break;
          case 28:
            Console.Title = "Differentation Of Compound Function";
            Console.Clear();
            Console.WriteLine("csc(X)/tan(2X) => -2con(2X)con(X)^2+2/sin(X)sin(2X)^2");
            Console.WriteLine();
            Console.Write("Do You Want To Continue ? ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            option = Console.ReadLine().ToLower();
            Console.ResetColor();
            break;
          default:
            Console.WriteLine("Error");
            break;
        }
      }
      while (option != "no");
    }
  }
}