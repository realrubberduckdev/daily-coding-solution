using System.Collections.Generic;
using Xunit;

namespace DailyCodingSolution.UnitTests
{
    public class TestTreeBFS
    {
        [Theory]
        [MemberData(nameof(TraverseTestData))]
        public void TestTraverse(BinaryTree tree, List<int> expectedTraversal) =>
          Assert.Equal(TreeBFS.Traverse(tree.Root), expectedTraversal);

        public static IEnumerable<object[]> TraverseTestData =>
          new List<object[]>
          {
            new object[] { new BinaryTree { Root = new TreeNode(1) { Left = new TreeNode(2), Right = new TreeNode(3) } }, new List<int> { 1, 2, 3 } }
          };
    }
}