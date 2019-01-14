namespace LeetCode
{
  public class RangeSumQueryImmutableProblem
  {
    private readonly int[] _nums;
    public NumArray(int[] nums)
    {
      _nums = nums;
    }

    public int SumRange(int i, int j)
    {
      if (_nums == null)
        return 0;

      if (i < 0 || j >= _nums.Length || i > j)
        return 0;

      int sum = 0;
      for (int index = i; index <= j; index++)
        sum += _nums[index];

      return sum;
    }
  }
}