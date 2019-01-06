﻿using System;

namespace LeetCode
{
  public class PowerOfTwoProblem
  {
    public bool IsPowerOfTwo(int n)
    {
      if (n < 1)
        return false;

      while (n > 2)
      {
        if (n % 2 != 0)
          return false;

        n /= 2;
      }

      return true;
    }
  }
}