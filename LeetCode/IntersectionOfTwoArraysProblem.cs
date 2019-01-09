using System.Collections.Generic;

namespace LeetCode
{
  public class IntersectionOfTwoArraysProblem
  {
    public int[] Intersection(int[] nums1, int[] nums2)
    {
      var set = new HashSet<int>(nums1);
      var result = new HashSet<int>();

      for (int i = 0; i < nums2.Length; i++)
      {
        if (set.Contains(nums2[i]))
          result.Add(nums2[i]);
      }

      int j = 0;
      var res = new int[result.Count];
      foreach (var r in result)
        res[j++] = r;

      return res;
    }
  }
}