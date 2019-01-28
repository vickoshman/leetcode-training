using System.Collections.Generic;

namespace HackerRank
{
  public class SockMerchantProblem
  {
    public static int SockMerchant( int[] ar)
    {
      var set = new HashSet<int>();
      int num = 0;
      foreach (var el in ar)
      {
        if (!set.Add(el))
        {
          num++;
          set.Remove(el);
        }
      }

      return num;
    }
  }
}