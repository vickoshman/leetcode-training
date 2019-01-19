using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeetCode
{
  public class ImplementQueueUsingStacksProblem
  {
    public class MyQueue
    {
      private Stack<int> _stack;
      /** Initialize your data structure here. */
      public MyQueue()
      {
        _stack = new Stack<int>();
      }

      /** Push element x to the back of queue. */
      public void Push(int x)
      {
        var tmp = new Stack<int>(_stack);
        _stack.Clear();
        _stack.Push(x);

        foreach (var item in tmp)
          _stack.Push(item);
      }

      /** Removes the element from in front of queue and returns that element. */
      public int Pop()
      {
        return _stack.Pop();
      }

      /** Get the front element. */
      public int Peek()
      {
        return _stack.Peek();
      }

      /** Returns whether the queue is empty. */
      public bool Empty()
      {
        return _stack.Count == 0;
      }
    }
  }
}