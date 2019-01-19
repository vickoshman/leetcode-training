using System.Collections.Generic;
using LeetCode.Trees;

namespace LeetCode
{
  public class PathSumIIIProblem
  {
    private void Find(TreeNode root, int sum, ref int num)
    {
      if (sum == 0)
      {
        num++;
        return;
      }

      if (root.left != null)
      {
        Find(root.left, sum - root.val, ref num);
      }

      if (root.right != null)
      {
        Find(root.right, sum - root.val, ref num);
      }
    }

    public int PathSum(TreeNode root, int sum)
    {
      int num = 0;
      Find(root, sum, ref num);
      return num;
    }
  }
}