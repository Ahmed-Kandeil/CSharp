using System;

namespace Longest_Word
{
  internal class Program
  {
    static void Main(string[] args)
    {
      string line = "Write a C# Sharp Program to display the following pattern using the alphabet.";
      string[] words = line.Split(new[] { " " }, StringSplitOptions.None);
      string word = "";
      int ctr = 0;
      foreach (String w in words)
      {
        if (w.Length > ctr)
        {
          word = w;
          ctr = w.Length;
        }
      }
      Console.WriteLine(word);
    }
  }
}
