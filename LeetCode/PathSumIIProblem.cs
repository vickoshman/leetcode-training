using System.Collections.Generic;
using System.Linq;
using LeetCode.Trees;

namespace LeetCode
{
  public class PathSumIIProblem
  {
    private void Find(TreeNode root, int sum, List<int> soFar, int sumSoFar, List<IList<int>> result)
    {
      soFar.Add(root.val);
      sumSoFar += root.val;

      if (root.left == null && root.right == null && sumSoFar == sum)
      {
        result.Add(soFar.ToList());
        return;
      }

      if (root.left != null)
      {
        Find(root.left, sum, soFar.ToList(), sumSoFar, result);
      }

      if (root.right != null)
        Find(root.right, sum, soFar.ToList(), sumSoFar, result);
    }

    public IList<IList<int>> PathSum(TreeNode root, int sum)
    {
      var result = new List<IList<int>>();
      if (root != null)
        Find(root, sum, new List<int>(), 0, result);

      return result;
    }
  }
}