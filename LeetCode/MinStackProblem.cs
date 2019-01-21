using System.Collections.Generic;

namespace LeetCode
{
  public class MinStackProblem
  {
    public class MinStack
    {
      private Stack<int> _stack;
      private List<int> _list;

      /** initialize your data structure here. */
      public MinStack()
      {
        _stack = new Stack<int>();
        _list = new List<int>();
      }

      public void Push(int x)
      {
        _stack.Push(x);
        var res = _list.BinarySearch(x);
        if (res < 0)
          res = ~res;
        _list.Insert(res, x);
      }

      public void Pop()
      {
        var element = _stack.Pop();
        _list.Remove(element);
      }

      public int Top()
      {
        return _stack.Peek();
      }

      public int GetMin()
      {
        return _list[0];
      }
    }
  }
}