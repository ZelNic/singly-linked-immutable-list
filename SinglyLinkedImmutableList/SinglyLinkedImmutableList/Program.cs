using System;

namespace SinglyLinkedImmutableList
{

    public class Program
    {
        public static void Main(string[] args)
        {
            ListHandler handler = new ListHandler();

            ListNode<int> list1 = new ListNode<int>(1, new ListNode<int>(2, new ListNode<int>(3, null)));
            ListNode<int> list2 = new ListNode<int>(4, new ListNode<int>(5, null));


            Console.WriteLine("Результат замены элемента:");
            ListNode<int> newList1 = handler.ReplaceElement(list1, 3, 10);
            handler.PrintList(newList1);

            Console.WriteLine("Результат объединения:");
            ListNode<int> mergedList = handler.MergeLists(list1, list2);
            handler.PrintList(mergedList);

            Console.ReadLine();
        }
    }
}


