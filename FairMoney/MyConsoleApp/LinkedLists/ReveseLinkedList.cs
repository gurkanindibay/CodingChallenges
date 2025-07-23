public class ListNode
{
    public int Val;
    public ListNode? NextNode;

    public ListNode(int val, ListNode? nextNode)
    {
        Val = val;
        NextNode = nextNode;
    }

}

public class ReverseLinkedList
{
    public static ListNode? ReverseList(ListNode? node)
    {
        ListNode? current = node;
        ListNode? prev = null;

        while (current != null)
        {
            ListNode? next = current.NextNode;
            current.NextNode = prev;
            prev = current;
            current = next;
        }

        return prev;
    }
}