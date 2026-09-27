using System.Collections.Generic;
using Xunit;

namespace DailyCodingSolution.UnitTests
{
  public class TestSinglyLinkedListReversal
  {
    [Theory]
    [MemberData(nameof(ReverseTestData))]
    public void TestReverseIteratively(SinglyLinkedListNode<int> input, SinglyLinkedListNode<int> expectedResult)
    {
      var result = SinglyLinkedListReversal.ReverseIteratively(input);
      Assert.Equal(expectedResult, result);
    }

    [Theory]
    [MemberData(nameof(ReverseTestData))]
    public void TestReverseRecursively(SinglyLinkedListNode<int> input, SinglyLinkedListNode<int> expectedResult)
    {
      var result = SinglyLinkedListReversal.ReverseRecursively(input);
      Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object[]> ReverseTestData =>
      new List<object[]>
      {
            new object[] { CreateList([1, 2, 3, 4, 5]), CreateList([5, 4, 3, 2, 1]) },
            new object[] { CreateList([1]), CreateList([1]) },
            new object[] { null, null }
      };

    private static SinglyLinkedListNode<int> CreateList(int[] values)
    {
      if (values == null || values.Length == 0)
        return null;

      var head = new SinglyLinkedListNode<int>(values[0]);
      var current = head;

      for (int i = 1; i < values.Length; i++)
      {
        current.Next = new SinglyLinkedListNode<int>(values[i]);
        current = current.Next;
      }

      return head;
    }
  }
}
