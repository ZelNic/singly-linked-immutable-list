using System;
using System.Collections.Generic;

namespace SinglyLinkedImmutableList
{
    public class ListHandler
    {
        public ListNode<T> ReplaceElement<T>(ListNode<T> head, T oldValue, T newValue)
        {
            if (head == null)
            {
                return null;
            }

            if (EqualityComparer<T>.Default.Equals(head.Head, oldValue))
            {
                return new ListNode<T>(newValue, ReplaceElement(head.Tail, oldValue, newValue));
            }

            return new ListNode<T>(head.Head, ReplaceElement(head.Tail, oldValue, newValue));
        }

        public ListNode<T> MergeLists<T>(ListNode<T> list1, ListNode<T> list2)
        {
            if (list1 == null)
            {
                return list2;
            }
            if (list2 == null)
            {
                return list1;
            }

            return new ListNode<T>(list1.Head, MergeLists(list1.Tail, list2));
        }

        public void PrintList<T>(ListNode<T> head)
        {
            ListNode<T> current = head;
            while (current != null)
            {
                Console.Write(current.Head + " ");
                current = current.Tail;
            }
            Console.WriteLine();
        }
    }
}

