namespace LeetCode
{
  public class ImplementStrStrProblem
  {
    public int StrStr(string haystack, string needle)
    {
      if (needle.Length == 0)
        return 0;

      if (haystack.Length < needle.Length || haystack.Length == 0 || needle.Length == 0)
        return -1;

      for (int i = 0; i < haystack.Length; i++)
      {
        if (haystack[i] != needle[0])
          continue;

        if (haystack.Length - i < needle.Length)
        {
          return -1;
        }

        bool found = true;
        for (int j = 0; j < needle.Length; j++)
        {
          int index = i + j;
          if (haystack.Length <= index || haystack[index] != needle[j])
          {
            found = false;
            break;
          }
        }

        if (found)
          return i;
      }

      return -1;
    }
  }
}