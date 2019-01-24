using System.Data.Odbc;

namespace IntroductionToAlgorithms
{
  public class SelectionSort
  {
    public void Sort(int[] arr)
    {
      for (int i = 0; i < arr.Length; i++)
      {
        var min = arr[i];
        int minIndex = i;
        for (int j = i + 1; j < arr.Length; j++)
        {
          if (arr[j] < min)
          {
            min = arr[j];
            minIndex = j;
          }
        }

        var tmp = arr[i];
        arr[i] = arr[minIndex];
        arr[minIndex] = tmp;
      }
    }
  }
}