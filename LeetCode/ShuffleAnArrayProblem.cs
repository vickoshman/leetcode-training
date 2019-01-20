using System;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;

namespace LeetCode
{
  public class ShuffleAnArrayProblem
  {
    public class Solution
    {
      private int[] _nums;
      private int _index = 0;

      public Solution(int[] nums)
      {
        _nums = nums;
      }

      /** Resets the array to its original configuration and return it. */
      public int[] Reset()
      {
        return _nums;
      }

      /** Returns a random shuffling of the array. */
      public int[] Shuffle()
      {
        var copy = _nums.ToArray();
        var random = new Random();
        for (int i = 0; i < copy.Length; i++)
        {
          var r = random.Next(0, i + 1);

          var tmp = copy[i];
          copy[i] = copy[r];
          copy[r] = tmp;
        }

        return copy;
      }
    }
  }
}