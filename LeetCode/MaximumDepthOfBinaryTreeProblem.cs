using System;
using LeetCode.Trees;

namespace LeetCode
{
  public class MaximumDepthOfBinaryTreeProblem
  {
    private int CalcMax(TreeNode node, int current)
    {
      if (node == null)
        return current;

      current++;
      return Math.Max(CalcMax(node.left, current), CalcMax(node.right, current));
    }
    
    public int MaxDepth(TreeNode root)
    {
      if (root == null)
        return 0;

      return CalcMax(root, 0);
    }
  }
}