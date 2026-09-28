using System.Collections.Generic;
using System.Linq;

namespace DailyCodingSolution
{
  /// <summary>
  /// Breadth-first search (DFS) - Implement a simple binary tree class, then traverse it level by level using a Stack<TreeNode>.
  /// </summary>
  public static class TreeDFS
  {
    public static List<int> Traverse(TreeNode root)
    {
      var result = new List<int>();
      if (root == null)
      {
        return result;
      }

      var stack = new Stack<TreeNode>();
      stack.Push(root);

      while (stack.Count > 0)
      {
        var currentNode = stack.Pop();
        result.Add(currentNode.Value);

        if (currentNode.Right != null)
        {
          stack.Push(currentNode.Right);
        }

        if (currentNode.Left != null)
        {
          stack.Push(currentNode.Left);
        }
      }

      return result;
    }
  }
}
