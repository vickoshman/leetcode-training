using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace LeetCode
{
  public class SummaryRangesProblem
  {
    public IList<string> SummaryRanges(int[] nums)
    {
      var res = new List<string>();

      if (nums.Length == 0)
        return res;

      if (nums.Length == 1)
        return new List<string>() { nums[0].ToString()};

      var prev = nums[0];
      var rangeStart = prev;

      for (int i = 1; i < nums.Length; i++)
      {
        var current = nums[i];

        if (current == prev + 1)
        {
          prev = current;
          continue;
        }

        if (rangeStart == prev)
        {
          res.Add(rangeStart.ToString());
          i--;
        }
        else
        {
          res.Add(rangeStart + "->" + prev);
        }

        rangeStart = current;
        prev = current;
      }

      return res;
    }
  }
}