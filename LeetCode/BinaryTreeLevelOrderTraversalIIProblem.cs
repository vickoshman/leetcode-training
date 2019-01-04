using System.Collections.Generic;
using LeetCode.Trees;

namespace LeetCode
{
  public class BinaryTreeLevelOrderTraversalIIProblem
  {
    private void Count(TreeNode root, List<IList<int>> result, int depth)
    {
      if (root == null)
        return;
      
      depth++;
      
      if (result.Count < depth)
        result.Add(new List<int>());
      
      result[ - 1].Add(root.val);
      
      if (root.left != null)
        Count(root.left, result, depth);
      
      if (root.right != null)
        Count(root.right, result, depth);
    }
    
    public IList<IList<int>> LevelOrderBottom(TreeNode root)
    {
      var result = new List<IList<int>>();

      Count(root, result, 0);
      result.Reverse();
      return result;
    }
  }
}