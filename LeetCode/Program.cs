using System;
using LeetCode.Trees;

namespace LeetCode
{
  class Program
  {
    static void Main(string[] args)
    {
      var tree = new BinaryTreeBuilder()
        .FromUnsorted(new int[] { 5, 4, 7, 1, 6, 9, 43, 3, 12 });

      tree.PrintAllKeys();
      Console.WriteLine();

      tree.PrintKeysInGivenRange(5, 12);
      Console.WriteLine();

      var searchResult = tree.Search(0);
      Console.WriteLine(searchResult?.val.ToString() ?? "Not found");

      tree.Insert(17);
       
      var minKey = tree.FindMinKey();
      Console.WriteLine(minKey);

      var nums1 = new[] {1, 2, 3, 0, 0, 0};
      new MergeSortedArrayProblem().Merge(nums1, 3, new [] { 2, 5, 6 }, 3);

      Console.WriteLine();
      Console.ReadKey();
    }
  }
}
