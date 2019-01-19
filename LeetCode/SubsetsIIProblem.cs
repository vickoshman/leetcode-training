using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
  public class SubsetsIIProblem
  {
    private void Explore(int[] nums, int from, List<int> soFar, Dictionary<string, IList<int>> result)
    {
      if (from >= nums.Length)
      {
        var copy = soFar.ToList();
        copy.Sort();
        var key = string.Join(":", copy);
        if (!result.ContainsKey(key))
          result.Add(key, soFar.ToArray());

        return;
      }

      for (int i = from; i < nums.Length; i++)
      {
        soFar.Add(nums[i]);
        Explore(nums, i + 1, soFar, result);
        soFar.RemoveAt(soFar.Count - 1);
        Explore(nums, i + 1, soFar, result);
      }
    }

    public IList<IList<int>> SubsetsWithDup(int[] nums)
    {
      var result = new Dictionary<string, IList<int>>();
      Explore(nums, 0, new List<int>(), result);
      return result.Values.ToList();
    }
  }
}