using System;
using System.Threading;

namespace Physics
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int physical_properties, change_type;
      const int sleep = 1500;
      const int long_sleep = 2000;
      double calc_1, calc_2, calc_3, result, kelvin, fahrenheit;
      string option, change_option;
      option = "no";
      do
      {
        Console.Clear();
        Console.WriteLine("1 => Lenght");
        Console.WriteLine("2 => Volume");
        Console.WriteLine("3 => Resistane");
        Console.WriteLine("4 => Electromotive Force");
        Console.WriteLine();
        Console.Write("Choose The Physical Properties : ");
        physical_properties = Convert.ToInt32(Console.ReadLine());
        switch (physical_properties)
        {
          case 1:
            Console.Clear();
            double I_o, I_100, I_T;
            Console.Write("Enter The Io : ");
            I_o = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter The I 100 : ");
            I_100 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter The IT : ");
            I_T = Convert.ToDouble(Console.ReadLine());
            calc_1 = I_T - I_o;
            calc_2 = I_100 - I_o;
            calc_3 = calc_1 / calc_2;
            result = calc_3 * 100;
            Console.Clear();
            Console.WriteLine("Now We Have :");
            Console.WriteLine($"Io = {I_o} I100 = {I_100} IT = {I_T}");
            Console.WriteLine();
            Thread.Sleep(long_sleep);
            Console.WriteLine("We Will Use The Law :");
            Console.WriteLine();
            Console.WriteLine("   IT - Io ");
            Console.WriteLine("  --------- * 100");
            Console.WriteLine("  I100 - Io");
            Console.WriteLine();
            Thread.Sleep(sleep);
            Console.WriteLine("We Will Compensate In The Law :");
            Console.WriteLine();
            Thread.Sleep(long_sleep);
            Console.WriteLine($"  {I_T} - {I_o} ");
            Console.WriteLine("  ------ * 100");
            Console.WriteLine($"  {I_100} - {I_o}");
            Console.WriteLine();
            Console.WriteLine($"The Temperature Is => {result}C");
            Console.WriteLine();
            Console.Write("Do You Want To Change It To Kelvin or Fahrenheit ? ");
            change_option = Console.ReadLine().ToLower();
            if (change_option == "yes")
            {
              Console.WriteLine();
              Console.WriteLine("1 => Kelvin");
              Console.WriteLine("2 => Fahrenheit");
              Console.WriteLine();
              Console.Write("Which Type Do You Want : ");
              change_type = Convert.ToInt32(Console.ReadLine());
              switch (change_type)
              {
                case 1:
                  kelvin = result + 237;
                  Console.WriteLine($"{result}C Is => {kelvin}K");
                  break;
                case 2:
                  fahrenheit = (9 / 5) * result + 32;
                  Console.WriteLine($"{result}C Is => {fahrenheit}F");
                  break;
                default:
                  Console.WriteLine("Wrong Option!!!");
                  break;
              }
            }
            else if (change_option == "no")
            {
              Console.WriteLine("Okay.");
            }
            else
            {
              Console.WriteLine("Wrong Option!!!");
            }
            Console.Write("Do You Want To Continue ? ");
            option = Console.ReadLine().ToLower();
            break;
          case 2:
            Console.Clear();
            double V_o, V_100, V_T;
            Console.Write("Enter The Vo : ");
            V_o = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter The V100 : ");
            V_100 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter The VT : ");
            V_T = Convert.ToDouble(Console.ReadLine());
            calc_1 = V_T - V_o;
            calc_2 = V_100 - V_o;
            calc_3 = calc_1 / calc_2;
            result = calc_3 * 100;
            Console.Clear();
            Console.WriteLine("Now We Have :");
            Console.WriteLine($"Vo = {V_o} V100 = {V_100} VT = {V_T}");
            Console.WriteLine();
            Thread.Sleep(long_sleep);
            Console.WriteLine("We Will Use The Law :");
            Console.WriteLine();
            Console.WriteLine("   VT - Vo ");
            Console.WriteLine("  --------- * 100");
            Console.WriteLine("  V100 - Vo");
            Console.WriteLine();
            Thread.Sleep(sleep);
            Console.WriteLine("We Will Compensate In The Law :");
            Console.WriteLine();
            Thread.Sleep(long_sleep);
            Console.WriteLine($"  {V_T} - {V_o} ");
            Console.WriteLine("  ------ * 100");
            Console.WriteLine($"  {V_100} - {V_o}");
            Console.WriteLine();
            Console.WriteLine($"The Temperature Is => {result}C");
            Console.WriteLine();
            Console.Write("Do You Want To Change It To Kelvin or Fahrenheit ? ");
            change_option = Console.ReadLine().ToLower();
            if (change_option == "yes")
            {
              Console.WriteLine();
              Console.WriteLine("1 => Kelvin");
              Console.WriteLine("2 => Fahrenheit");
              Console.WriteLine();
              Console.Write("Which Type Do You Want : ");
              change_type = Convert.ToInt32(Console.ReadLine());
              switch (change_type)
              {
                case 1:
                  kelvin = result + 237;
                  Console.WriteLine($"{result}C Is => {kelvin}K");
                  break;
                case 2:
                  fahrenheit = (9 / 5) * result + 32;
                  Console.WriteLine($"{result}C Is => {fahrenheit}F");
                  break;
                default:
                  Console.WriteLine("Wrong Option!!!");
                  break;
              }
            }
            else if (change_option == "no")
            {
              Console.WriteLine("Okay.");
            }
            else
            {
              Console.WriteLine("Wrong Option!!!");
            }
            Console.Write("Do You Want To Continue ? ");
            option = Console.ReadLine().ToLower();
            break;
          case 3:
            Console.Clear();
            double R_o, R_100, R_T;
            Console.Write("Enter The Ro : ");
            R_o = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter The R100 : ");
            R_100 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter The RT : ");
            R_T = Convert.ToDouble(Console.ReadLine());
            calc_1 = R_T - R_o;
            calc_2 = R_100 - R_o;
            calc_3 = calc_1 / calc_2;
            result = calc_3 * 100;
            Console.Clear();
            Console.WriteLine("Now We Have :");
            Console.WriteLine($"Ro = {R_o} R100 = {R_100} RT = {R_T}");
            Console.WriteLine();
            Thread.Sleep(long_sleep);
            Console.WriteLine("We Will Use The Law :");
            Console.WriteLine();
            Console.WriteLine("   RT - Ro ");
            Console.WriteLine("  --------- * 100");
            Console.WriteLine("  R100 - Ro");
            Console.WriteLine();
            Thread.Sleep(sleep);
            Console.WriteLine("We Will Compensate In The Law :");
            Console.WriteLine();
            Thread.Sleep(long_sleep);
            Console.WriteLine($"  {R_T} - {R_o} ");
            Console.WriteLine("  ------ * 100");
            Console.WriteLine($"  {R_100} - {R_o}");
            Console.WriteLine();
            Console.WriteLine($"The Temperature Is => {result}C");
            Console.WriteLine();
            Console.Write("Do You Want To Change It To Kelvin or Fahrenheit ? ");
            change_option = Console.ReadLine().ToLower();
            if (change_option == "yes")
            {
              Console.WriteLine();
              Console.WriteLine("1 => Kelvin");
              Console.WriteLine("2 => Fahrenheit");
              Console.WriteLine();
              Console.Write("Which Type Do You Want : ");
              change_type = Convert.ToInt32(Console.ReadLine());
              switch (change_type)
              {
                case 1:
                  kelvin = result + 237;
                  Console.WriteLine($"{result}C Is => {kelvin}K");
                  break;
                case 2:
                  fahrenheit = (9 / 5) * result + 32;
                  Console.WriteLine($"{result}C Is => {fahrenheit}F");
                  break;
                default:
                  Console.WriteLine("Wrong Option!!!");
                  break;
              }
            }
            else if (change_option == "no")
            {
              Console.WriteLine("Okay.");
            }
            else
            {
              Console.WriteLine("Wrong Option!!!");
            }
            Console.Write("Do You Want To Continue ? ");
            option = Console.ReadLine().ToLower();
            break;
          case 4:
            Console.Clear();
            double emf_o, emf_100, emf_T;
            Console.Write("Enter The emfo : ");
            emf_o = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter The emf100 : ");
            emf_100 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter The emfT : ");
            emf_T = Convert.ToDouble(Console.ReadLine());
            calc_1 = emf_T - emf_o;
            calc_2 = emf_100 - emf_o;
            calc_3 = calc_1 / calc_2;
            result = calc_3 * 100;
            Console.Clear();
            Console.WriteLine("Now We Have :");
            Console.WriteLine($"emfo = {emf_o} emf100 = {emf_100} emfT = {emf_T}");
            Console.WriteLine();
            Thread.Sleep(long_sleep);
            Console.WriteLine("We Will Use The Law :");
            Console.WriteLine();
            Console.WriteLine("   emfT - emfo ");
            Console.WriteLine("  ------------- * 100");
            Console.WriteLine("  emf100 - emfo");
            Console.WriteLine();
            Thread.Sleep(sleep);
            Console.WriteLine("We Will Compensate In The Law :");
            Console.WriteLine();
            Thread.Sleep(long_sleep);
            Console.WriteLine($"  {emf_T} - {emf_o} ");
            Console.WriteLine("  ------ * 100");
            Console.WriteLine($"  {emf_100} - {emf_o}");
            Console.WriteLine();
            Console.WriteLine($"The Temperature Is => {result}C");
            Console.WriteLine();
            Console.Write("Do You Want To Change It To Kelvin or Fahrenheit ? ");
            change_option = Console.ReadLine().ToLower();
            if (change_option == "yes")
            {
              Console.WriteLine();
              Console.WriteLine("1 => Kelvin");
              Console.WriteLine("2 => Fahrenheit");
              Console.WriteLine();
              Console.Write("Which Type Do You Want : ");
              change_type = Convert.ToInt32(Console.ReadLine());
              switch (change_type)
              {
                case 1:
                  kelvin = result + 237;
                  Console.WriteLine($"{result}C Is => {kelvin}K");
                  break;
                case 2:
                  fahrenheit = (9 / 5) * result + 32;
                  Console.WriteLine($"{result}C Is => {fahrenheit}F");
                  break;
                default:
                  Console.WriteLine("Wrong Option!!!");
                  break;
              }
            }
            else if (change_option == "no")
            {
              Console.WriteLine("Okay.");
            }
            else
            {
              Console.WriteLine("Wrong Option!!!");
            }
            Console.Write("Do You Want To Continue ? ");
            option = Console.ReadLine().ToLower();
            break;
          default:
            Console.WriteLine("Wrong Option!!!");
            break;
        }
      }
      while (physical_properties < 4 && option != "no");
    }
  }
}