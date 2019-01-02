namespace LeetCode
{
  public class SearchInsertPositionProblem
  {
    public int SearchInsert(int[] nums, int target)
    {
      int i = -1;
      while (nums[++i] < target)
      {
        if (nums.Length <= i + 1)
          return i + 1;
      }
      
      return i;
    }
  }
}