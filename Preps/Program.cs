using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preps
{
  class Program
  {
    static void Main(string[] args)
    {
      var res = SockMerchantProblem.sockMerchant(new int[] { 1, 1, 3, 1, 2, 1, 3, 3, 3, 3 });
      Console.WriteLine(res);
      Console.ReadKey();
    }
  }
}
