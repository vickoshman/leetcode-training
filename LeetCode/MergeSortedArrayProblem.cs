namespace LeetCode
{
  public class MergeSortedArrayProblem
  {
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
      n--;
      m--;

      int pos = nums1.Length - 1;
      while (n >= 0 || m >= 0)
      {
        if (m == -1)
        {
          nums1[pos--] = nums2[n--];
          continue;
        }

        if (n == -1)
        {
          nums1[pos--] = nums1[m--];
          continue;
        }

        if (nums1[m] > nums2[n])
        {
          nums1[pos] = nums1[m];
          m--;
        }
        else
        {
          nums1[pos] = nums2[n];
          n--;
        }

        pos--;
      }
    }
  }
}