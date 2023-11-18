namespace SinglyLinkedImmutableList
{
    public class ListNode<T>
    {
        public readonly T Head;
        public readonly ListNode<T> Tail;

        public ListNode(T value, ListNode<T> next)
        {
            Head = value;
            Tail = next;
        }
    }
}
