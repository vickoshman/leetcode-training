using System.Collections.Generic;

namespace LeetCode
{
  public class ThreeSumProblem
  {
    public IList<IList<int>> ThreeSum(int[] nums)
    {
      var result = new List<IList<int>>();
      if (nums.Length < 3)
        return result;

      for (int i = 0; i < nums.Length; i++)
      {
        for (int j = 0; j < nums.Length; j++)
        {
          if (i == j)
            continue;

          for (int k = 0; k < nums.Length; k++)
          {
            if (j == k || i == k)
              continue;

            var a = nums[i];
            var b = nums[j];
            var c = nums[k];

            if (a + b + c != 0)
              continue;

            bool isDuplicate = false;
            foreach (var triplet in result)
            {
              int ia = triplet.IndexOf(a);
              int ib = triplet.IndexOf(b);
              int ic = triplet.IndexOf(c);
              if (ia != -1 && ib != -1 && ic != -1 && ia != ib && ib != ic)
              {
                isDuplicate = true;
                break;
              }
            }

            if (!isDuplicate)
              result.Add(new List<int> { a, b, c });
          }
        }
      }

      return result;
    }
  }
}