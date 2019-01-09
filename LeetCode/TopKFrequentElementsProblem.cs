using System;
using System.Collections.Generic;

namespace LeetCode
{
  public class TopKFrequentElementsProblem
  {
    public IList<int> TopKFrequent(int[] nums, int k)
    {
      var freqByNumber = new Dictionary<int, int>();
      
      for (int i = 0; i < nums.Length; i++)
      {
        if (freqByNumber.ContainsKey(nums[i]))
        {
          freqByNumber[nums[i]]++;
        }
        else
        {
          freqByNumber.Add(nums[i], 1);
        }
      }

      var list = new List<List<int>>();
      foreach (var kvp in freqByNumber)
      {
        while (kvp.Value >= list.Count)
        {
          list.Add(new List<int>());
        }

        list[kvp.Value].Add(kvp.Key);
      }

      list.Reverse();

      var res = new List<int>(k);
      foreach (var l in list)
      {
        res.AddRange(l);
        if (res.Count == k)
          return res;

        if (res.Count < k)
          continue;

        while (res.Count > k)
        {
          res.RemoveAt(res.Count - 1);
        }

        return res;
      }

      return res;
    }
  }
}