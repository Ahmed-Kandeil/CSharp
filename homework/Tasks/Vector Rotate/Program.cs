using System;

namespace Vector_Rotate
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int[] nums = { 1, 2, 8 };
      Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums));
      var temp = nums[0];
      for (var i = 0; i < nums.Length - 1; i++)
      {
        nums[i] = nums[i + 1];
      }
      nums[nums.Length - 1] = temp;
      Console.WriteLine("After rotating array becomes: [{0}]", string.Join(", ", nums));
    }
  }
}
