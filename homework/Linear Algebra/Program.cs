using System;

namespace LinearAlgebra
{
  internal class Program
  {
    static void Main(string[] args)
    {
      double[,] A;
      double[] B;
      int size;
      Console.Write("Enter Size: ");
      size = int.Parse(Console.ReadLine());
      A = new double[size, size];
      B = new double[size];
      for (int row = 0; row < size; row++)
      {
        for (int column = 0; column < size; column++)
        {
          Console.Write($"A[{row},{column}]: ");
          A[row, column] = double.Parse(Console.ReadLine());
        }
        Console.Write($"B[{row}] ");
        B[row] = double.Parse(Console.ReadLine());
        Console.WriteLine();
      }
      Display(A, B);
      Console.WriteLine("-------------------------------");
      for (int p = 0; p < size; p++)
      {
        for (int row = p + 1; row < size; row++)
        {
          double M = A[row, p] / A[p, p];
          for (int column = 0; column < size; column++)
          {
            A[row, column] = A[row, column] - (M * A[p, p]);
          }
          B[row] = B[row] - (M * B[p]);
        }
      }
      Display(A, B);
      Console.WriteLine("-------------------------------");
      double temporaty = 0;
      double unknown = 0;
      double[] X = new double[size];
      for (int row = size - 1; row <= 0; row++)
      {
        for (int column = size - 1; column <= 0; column++)
        {
          if (row == column)
          {
            unknown = A[row, column];
            break;
          }
          else
          {
            temporaty += A[row, column] * B[column];
          }
        }
        B[row] = (B[row] - temporaty) / unknown;
        X[row] = B[row];
        temporaty = 0;
      }
      for (int i = 0; i < size; i++)
      {
        Console.WriteLine($"x[{i}] = {X[i]}");
      }
    }
    static void Display(double[,] M, double[] B)
    {
      int size;
      size = Convert.ToInt32(Math.Sqrt(M.Length));
      for (int row = 0; row < size; row++)
      {
        for (int column = 0; column < size; column++)
        {
          Console.Write($"{M[row, column]}\t");
        }
        Console.Write($"| {B[row]}");
        Console.WriteLine();
      }
    }
  }
}