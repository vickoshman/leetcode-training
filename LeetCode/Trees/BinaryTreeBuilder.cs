using System;

namespace LeetCode.Trees
{
  public class BinaryTreeBuilder
  {
    public TreeNode FromUnsorted(int[] array)
    {
      Array.Sort(array);

      var tree = Build(array, 0, array.Length - 1);

      return tree;
    }

    private static TreeNode Build(int[] array, int from, int to)
    {
      if (from > to)
        return null;

      int middle = (from + to) / 2;
      var rootValue = array[middle];

      var node = new TreeNode(rootValue);

      node.left = Build(array, from, middle - 1);
      node.right = Build(array, middle + 1, to);
      return node;
    }
  }
}