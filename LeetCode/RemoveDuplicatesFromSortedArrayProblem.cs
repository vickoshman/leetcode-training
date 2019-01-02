using System.Linq;

namespace LeetCode
{
  public class RemoveDuplicatesFromSortedArrayProblem
  {
    public int RemoveDuplicates(int[] nums)
    {
      if (nums.Length == 0)
        return 0;

      if (nums[0] == nums[nums.Length - 1])
        return 1;

      int prevValue = nums[0];

      for (int i = 1; i < nums.Length; i++)
      {
        int value = nums[i];

        if (value < prevValue)
          return i;

        if (prevValue == value)
        {
          int max = value;
          for (int j = i; j < nums.Length - 1; j++)
          {
            if (nums[j + 1] > max)
              max = nums[j + 1];

            int tmp = nums[j];
            nums[j] = nums[j + 1];
            nums[j + 1] = tmp;
          }

          if (value == max)
            return i;

          i--;
        }

        prevValue = value;
      }

      return nums.Length;
    }
  }
}