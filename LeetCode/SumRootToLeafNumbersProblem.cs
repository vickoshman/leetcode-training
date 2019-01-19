using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using LeetCode.Trees;

namespace LeetCode
{
  public class SumRootToLeafNumbersProblem
  {
    public void Sum(TreeNode root, int soFar, ref int sum)
    {
      soFar *= 10;
      soFar += root.val;

      if (root.left == null && root.right == null)
      {
        sum += soFar;
        return;
      }

      if (root.left != null)
        Sum(root.left, soFar, ref sum);

      if (root.right != null)
        Sum(root.right, soFar, ref sum);
    }

    public int SumNumbers(TreeNode root)
    {
      if (root == null)
        return 0;

      int sum = 0;
      Sum(root, 0, ref sum);
      return sum;
    }
  }
}