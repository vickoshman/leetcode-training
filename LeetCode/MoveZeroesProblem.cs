using System.Globalization;

namespace LeetCode
{
  public class MoveZeroesProblem
  {
    public void MoveZeroes(int[] nums)
    {
      if (nums == null || nums.Length < 2)
        return;

      int pos = -1;
      for (int i = 0; i < nums.Length; i++)
      {
        if (nums[i] == 0 && pos == -1)
        {
          pos = pos == -1 ? i : pos;
          continue;
        }

        if (pos == -1)
          continue;

        bool changePos = nums[i] != 0;
        nums[pos] = nums[i];
        nums[i] = 0;
        pos = changePos ? pos + 1 : pos;
      }
    }
  }
}