using System;
using System.Runtime.Remoting.Messaging;

namespace LeetCode.Trees
{
  public static class TreeExtensions
  {
    public static void PrintAllKeys(this TreeNode tree)
    {
      if (tree == null)
        return;

      Console.Write("{0} ", tree.val);
      PrintAllKeys(tree.left);
      PrintAllKeys(tree.right);
    }

    public static void PrintKeysInGivenRange(this TreeNode tree, int from, int to)
    {
      if (tree == null)
        return;

      if (tree.left != null && tree.left.val > from)
        PrintKeysInGivenRange(tree.left, from, to);

      Console.Write("{0} ", tree.val);

      if (tree.right != null && tree.right.val <= to)
        PrintKeysInGivenRange(tree.right, from, to);
    }

    public static TreeNode Search(this TreeNode tree, int key)
    {
      if (tree == null || tree.val == key)
        return tree;

      if (key < tree.val)
        return Search(tree.left, key);

      return Search(tree.right, key);
    }

    public static TreeNode Insert(this TreeNode tree, int key)
    {
      if (tree.val == key)
        throw new Exception("Duplicated key");

      if (key < tree.val)
      {
        if (tree.left != null)
          return Insert(tree.left, key);
        
        tree.left = new TreeNode(key);
        return tree;
      }

      if (tree.right != null)
        return Insert(tree.right, key);

      tree.right = new TreeNode(key);
      return tree;
    }

    public static TreeNode Delete(this TreeNode root, int key)
    {
      if (root == null)
        return root;
      
      if (key < root.val)
        root.left = Delete(root.left, key);
      else if (key > root.val)
        root.right = Delete(root.right, key);
      else
      {
        if (root.left == null)
          return root.right;
        else if (root.right == null)
          return root.left;

        root.val = FindMinKey(root.right);
        root.right = Delete(root.right, root.val);
      }

      return root;
    }

    public static int FindMinKey(this TreeNode root)
    {
      var current = root;
      int min = root.val;

      while (current.left != null)
      {
        min = current.left.val;
        current = current.left;
      }

      return min;
    }
  }
}