using System.Collections.Generic;
using Xunit;

namespace DailyCodingSolution.UnitTests
{
    public class TestTreeDFS
    {
        [Theory]
        [MemberData(nameof(TraverseTestData))]
        public void TestTraverse(BinaryTree tree, List<int> expectedTraversal) =>
          Assert.Equal(expectedTraversal, TreeDFS.Traverse(tree.Root));

        public static IEnumerable<object[]> TraverseTestData =>
          new List<object[]>
          {
            new object[] { new BinaryTree { Root = new TreeNode(1) { Left = new TreeNode(2), Right = new TreeNode(3) } }, new List<int> { 1, 2, 3 } },
            new object[]
            {
              new BinaryTree
              {
                Root = new TreeNode(1)
                {
                  Left = new TreeNode(2)
                  {
                    Left = new TreeNode(4),
                    Right = new TreeNode(5)
                  },
                  Right = new TreeNode(3)
                  {
                    Left = new TreeNode(6)
                  }
                }
              },
              new List<int> { 1, 2, 4, 5, 3, 6 }
            }
          };
    }
}