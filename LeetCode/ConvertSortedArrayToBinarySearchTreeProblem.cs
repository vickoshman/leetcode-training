using LeetCode.Trees;

namespace LeetCode
{
  public class ConvertSortedArrayToBinarySearchTreeProblem
  {
    public TreeNode BuildTree(int[] nums, int from, int to)
    {
      if (from > to)
        return null;
      
      int middle = (to + from) / 2;
      
      var node = new TreeNode(nums[middle]);
      node.left = BuildTree(nums, from, middle - 1);
      node.right = BuildTree(nums, middle + 1, to);
      return node;
    }
    
    public TreeNode SortedArrayToBST(int[] nums)
    {
      if (nums == null)
        return null;
      
      return BuildTree(nums, 0, nums.Length - 1);
    }
  }
}