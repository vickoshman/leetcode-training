using System.Collections.Generic;

namespace HackerRank
{
  public class MigratoryBirdsProblem
  {
    static int migratoryBirds(List<int> arr)
    {
      var dic = new Dictionary<int, int>();
      foreach (var element in arr)
      {
        if (dic.ContainsKey(element))
          dic[element]++;
        else
          dic.Add(element, 1);
      }

      int maxKey = 0;
      int maxValue = 0;
      foreach (var kvp in dic)
      {
        if (kvp.Value > maxValue)
        {
          maxKey = kvp.Key;
          maxValue = kvp.Value;
          continue;
        }

        if (kvp.Value == maxValue && kvp.Key < maxKey)
        {
          maxKey = kvp.Key;
          maxValue = kvp.Value;
          continue;
        }
      }

      return maxKey;
    }
  }
}