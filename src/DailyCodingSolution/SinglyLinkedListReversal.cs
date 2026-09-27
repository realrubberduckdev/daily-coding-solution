using System;
using System.Collections.Generic;

namespace DailyCodingSolution
{
  /// <summary>
  /// Implement your own singly linked list class, then reverse it iteratively and recursively
  /// </summary>
  public class SinglyLinkedListReversal
  {
    public static SinglyLinkedListNode<T> ReverseIteratively<T>(SinglyLinkedListNode<T> head)
    {
      SinglyLinkedListNode<T> prev = null;
      SinglyLinkedListNode<T> current = head;

      while (current != null)
      {
        SinglyLinkedListNode<T> nextNode = current.Next;
        current.Next = prev;
        prev = current;
        current = nextNode;
      }

      return prev; // New head of the reversed list
    }

    public static SinglyLinkedListNode<T> ReverseRecursively<T>(SinglyLinkedListNode<T> head)
    {
      // Base case: if the list is empty or has only one node, return the head
      if (head == null || head.Next == null)
        return head;

      // Recursively reverse the rest of the list
      SinglyLinkedListNode<T> newHead = ReverseRecursively(head.Next);

      // Reverse the current node's pointer
      head.Next.Next = head;
      head.Next = null;

      return newHead;
    }
  }

  public class SinglyLinkedListNode<T> : IEquatable<SinglyLinkedListNode<T>>
  {
    public T Value { get; set; }
    public SinglyLinkedListNode<T> Next { get; set; }

    public SinglyLinkedListNode(T value)
    {
      Value = value;
      Next = null;
    }

    public bool Equals(SinglyLinkedListNode<T> other)
    {
      return this.Value.Equals(other.Value);
    }
  }
}