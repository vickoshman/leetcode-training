using System.Collections.Generic;
using System.Security.AccessControl;

namespace LeetCode
{
  public class FlattenNestedListIteratorProblem
  {
    public class NestedInteger
    {
      public bool IsInteger()
      {
        return true;
      }

      // @return the single integer that this NestedInteger holds, if it holds a single integer
      // Return null if this NestedInteger holds a nested list
      public int? GetInteger()
      {
        return 0;
      }

      // @return the nested list that this NestedInteger holds, if it holds a nested list
      // Return null if this NestedInteger holds a single integer
      public IList<NestedInteger> GetList()
      {
        return null;
      }
    }

    public class NestedIterator
    {
      private IList<NestedInteger> _list;
      private Queue<int> _queue;
      private int _index;

      public NestedIterator(IList<NestedInteger> nestedList)
      {
        _list = nestedList;
        _index = 0;
        _queue = new Queue<int>();

        while (_queue.Count == 0 && _index < _list.Count)
          PopulateNext(_list[_index++]);
      }

      public bool HasNext()
      {
        return _queue.Count > 0;
      }

      public int Next()
      {
        var val = _queue.Dequeue();
        while (_queue.Count == 0 && _index < _list.Count)
          PopulateNext(_list[_index++]);

        return val;
      }

      private void PopulateNext(NestedInteger nest)
      {
        if (nest.IsInteger())
        {
          //_queue.Enqueue(nest.GetInteger());
          return;
        }

        var list = nest.GetList();
        foreach (var n in list)
        {
          PopulateNext(n);
        }
      }
    }
  }
}