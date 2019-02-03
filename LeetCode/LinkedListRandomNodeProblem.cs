using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeetCode
{
  public class LinkedListRandomNodeProblem
  {
    private Random _random = new Random();
    private List<int> _list = new List<int>();
    private int _index = 0;

    /*public Solution(ListNode head)
    {
      var list = new List<int>();
      var current = head;
      while (current != null)
      {
        list.Add(current.val);
        current = current.next;
      }

      for (int i = 0; i < list.Count; i++)
      {
        int j = _random.Next(i, list.Count);
        var tmp = list[i];
        list[i] = list[j];
        list[j] = tmp;
      }

      _list = list;
    }*/

    public int GetRandom()
    {
      if (_index >= _list.Count)
        _index = 0;

      return _list[_index++];
    }
  }
}