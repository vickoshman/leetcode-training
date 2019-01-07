namespace LeetCode
{
  public class ReverseStringProblem
  {
    public string ReverseString(string s)
    {
      if (s == null)
        return null;

      if (s.Length < 2)
        return s;

      var array = s.ToCharArray();
      for (int i = 0; i < s.Length / 2; i++)
      {
        var tmp = array[i];
        array[i] = array[s.Length - i - 1];
        array[s.Length - i - 1] = tmp;
      }

      return new string(array);
    }
  }
}