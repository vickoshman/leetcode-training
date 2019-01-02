namespace LeetCode
{
  public class MergeSortedArrayProblem
  {
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
      int index = m;
      for (int i = 0; i < n; i++)
      {
        nums1[index++] = nums2[i];
      }

      for (int i = 0; i <= nums1.Length - 2; i++)
      {
        for (int j = 0; j <= nums1.Length - 2; j++)
        {
          if (nums1[j] > nums1[j + 1])
          {
            int temp = nums1[j + 1];
            nums1[j + 1] = nums1[j];
            nums1[j] = temp;
          }
        }
      }
    }
  }
}