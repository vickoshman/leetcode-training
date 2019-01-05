namespace LeetCode
{
  public class MaximumSubarrayProblem
  {
    public int MaxSubArray(int[] nums)
    {
      if (nums == null || nums.Length == 0)
        return 0;

      int maxSum = int.MinValue;
      for (int i = 0; i < nums.Length; i++)
      {
        int currentSum = nums[i];
        if (currentSum > maxSum)
          maxSum = currentSum;

        for (int j = i + 1; j < nums.Length; j++)
        {
          currentSum += nums[j];

          if (currentSum > maxSum)
            maxSum = currentSum;
        }
      }

      return maxSum;
    }
  }
}