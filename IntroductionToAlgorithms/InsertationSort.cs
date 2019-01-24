using System.Globalization;
using System.Security.AccessControl;

namespace IntroductionToAlgorithms
{
  public class InsertationSort
  {
    public void Sort(int[] arr)
    {
      for (int j = 1; j < arr.Length; j++)
      {
        var key = arr[j];
        int i = j - 1;
        while (i >= 0 && arr[i] < key)
        {
          var temp = arr[i];
          arr[i] = arr[i + 1];
          arr[i + 1] = temp;
          i--;
        }

        arr[i + 1] = key;
      }
    }
  }
}