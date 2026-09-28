using System.Collections.Generic;
using System.Linq;

namespace DailyCodingSolution
{
  /// <summary>
  /// Breadth-first search (BFS) - Implement a simple binary tree class, then traverse it level by level using a Queue<TreeNode>.
  /// </summary>
  public static class TreeBFS
  {
    public static List<int> Traverse(TreeNode root)
    {
      var result = new List<int>();
      if (root == null)
      {
        return result;
      }

      var queue = new Queue<TreeNode>();
      queue.Enqueue(root);

      while (queue.Count > 0)
      {
        var currentNode = queue.Dequeue();
        result.Add(currentNode.Value);

        if (currentNode.Left != null)
        {
          queue.Enqueue(currentNode.Left);
        }

        if (currentNode.Right != null)
        {
          queue.Enqueue(currentNode.Right);
        }
      }

      return result;
    }
  }

  public class TreeNode(int value)
  {
    public int Value { get; set; } = value;
    public TreeNode Left { get; set; } = null;
    public TreeNode Right { get; set; } = null;
  }

  public class BinaryTree
  {
    public TreeNode Root { get; set; } = null;

    public void Insert(int value)
    {
      if (Root == null)
      {
        Root = new TreeNode(value);
        return;
      }

      var currentNode = Root;
      while (true)
      {
        if (value < currentNode.Value)
        {
          if (currentNode.Left == null)
          {
            currentNode.Left = new TreeNode(value);
            break;
          }
          currentNode = currentNode.Left;
        }
        else
        {
          if (currentNode.Right == null)
          {
            currentNode.Right = new TreeNode(value);
            break;
          }
          currentNode = currentNode.Right;
        }
      }
    }
  }
}