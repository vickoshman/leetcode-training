using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToAlgorithms
{
  class Program
  {
    static void Main(string[] args)
    {
      var arr = new int[] {5, 3, 8, 9, 10, 2, 4, 1};
      new MergeSort().Sort(arr);
    }
  }
}
