namespace LeetCode
{
  public class RangeSumQueryImmutableProblem
  {
    private readonly int[] _sums;
    public RangeSumQueryImmutableProblem(int[] nums)
    {
      if (nums == null)
        return;

      _sums = new int[nums.Length + 1];
      _sums[0] = 0;
      for (int i = 0; i < nums.Length; i++)
        _sums[i + 1] = _sums[i] + nums[i];
    }

    public int SumRange(int i, int j)
    {
      if (_sums == null)
        return 0;

      if (i < 0 || j >= _sums.Length - 1 || i > j)
        return 0;
      
      return _sums[j + 1] - _sums[i];
    }
  }
}