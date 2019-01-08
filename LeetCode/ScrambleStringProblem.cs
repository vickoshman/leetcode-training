namespace LeetCode
{
  public class ScrambleStringProblem
  {
    public class StringTreeNode
    {
      public string val;
      public StringTreeNode left;
      public StringTreeNode right;

      public StringTreeNode()
      {
      }

      public StringTreeNode(string val)
      {
        this.val = val;
      }
    }

    private StringTreeNode BuildTree(string s, int from, int to)
    {
      if (from >= to)
        return null;

      var root = new StringTreeNode();
      var leftStr = s.Substring(0, to);
      var rightStr = s.Substring(from, to - from + 1);

      int middle = (from + to) / 2;
      root.left = BuildTree(s, 0, middle - 1);
      root.right = BuildTree(s, middle + 1, to);
      return root;
    }

    public bool IsScramble(string s1, string s2)
    {
      var tree = BuildTree(s1, 0, s1.Length - 1);
      return true;
    }
  }
}