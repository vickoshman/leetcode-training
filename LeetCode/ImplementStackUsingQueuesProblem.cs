using System.Collections.Generic;

namespace LeetCode
{
  public class ImplementStackUsingQueuesProblem
  {
    public class MyStack
    {
      private Queue<int> _queue;
      /** Initialize your data structure here. */
      public MyStack()
      {
        _queue = new Queue<int>();
      }

      /** Push element x onto stack. */
      public void Push(int x)
      {
        var tmp = new Queue<int>(_queue);
        _queue.Clear();
        _queue.Enqueue(x);

        foreach (var item in tmp)
        {
          _queue.Enqueue(item);
        }
      }

      /** Removes the element on top of the stack and returns that element. */
      public int Pop()
      {
        return _queue.Dequeue();
      }

      /** Get the top element. */
      public int Top()
      {
        return _queue.Peek();
      }

      /** Returns whether the stack is empty. */
      public bool Empty()
      {
        return _queue.Count == 0;
      }
    }
  }
}