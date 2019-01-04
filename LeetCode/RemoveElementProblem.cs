namespace LeetCode
{
  public class RemoveElementProblem
  {
    public int RemoveElement(int[] nums, int val)
    {
      if (nums == null || nums.Length == 0)
        return 0;

      int shift = 0;
      for (int i = 0; i < nums.Length - shift; i++)
      {
        if (nums[i] != val)
          continue;

        var index = nums.Length - shift - 1;
        if (index < 0 || index == nums.Length)
          return 0;

        var last = nums[index];
        nums[i] = last;
        shift++;

        if (last == val)
          i--;
      }

      return nums.Length - shift;
    }
  }
}