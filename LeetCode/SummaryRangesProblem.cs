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

      int prev = nums[0];
      var sb = new StringBuilder(prev);
      int numbers = 0;

      for (int i = 0; i < nums.Length; i++)
      {
        if (nums[i] == prev + 1)
        {
          prev = nums[i];
          continue;
        }

        if (sb.Length > 0)
          sb.Append("->");

        sb.Append(prev);
        numbers++;

        if (numbers == 2)
        {
          res.Add(sb.ToString());
          sb.Clear();
          numbers = 0;
        }
      }

      return res;
    }
  }
}