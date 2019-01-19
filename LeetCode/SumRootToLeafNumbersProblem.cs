using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using LeetCode.Trees;

namespace LeetCode
{
  public class SumRootToLeafNumbersProblem
  {
    public void Sum(TreeNode root, List<int> soFar, ref int sum)
    {
      soFar.Add(root.val);

      if (root.left == null && root.right == null)
      {
        int num = 0;
        foreach (var item in soFar)
        {
          num *= 10;
          num += item;
        }

        sum += num;
      }

      if (root.left != null)
        Sum(root.left, soFar.ToList(), ref sum);

      if (root.right != null)
        Sum(root.right, soFar.ToList(), ref sum);
    }

    public int SumNumbers(TreeNode root)
    {
      if (root == null)
        return 0;

      int sum = 0;
      Sum(root, new List<int>(), ref sum);
      return sum;
    }
  }
}