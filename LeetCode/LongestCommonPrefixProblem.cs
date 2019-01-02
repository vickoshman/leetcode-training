namespace LeetCode
{
  public class LongestCommonPrefixProblem
  {
    public string LongestCommonPrefix(string[] strs)
    {
      string result = "";

      if (strs.Length == 0)
        return result;

      if (strs.Length == 1)
        return strs[0];
      
      bool common = true;
      int index = 0;
      while (common && index < strs[0].Length)
      {
        var current = strs[0][index];
        for (int i = 1; i < strs.Length; i++)
        {
          if (index >= strs[i].Length || strs[i][index] != current)
          {
            common = false;
            break;
          }
        }

        index++;
        if (common)
          result += current;
      }

      return result;
    }
  }
}