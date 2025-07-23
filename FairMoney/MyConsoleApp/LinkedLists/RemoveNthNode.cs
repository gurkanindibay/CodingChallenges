public static class RemoveNthNode
{
    public static ListNode? Remove(ListNode list, int n)
    {
        ListNode dummy = new ListNode(0, list);

        ListNode? fast = dummy;
        ListNode? slow = dummy;

        for (int i = 0; i < n; i++)
        {
            fast = fast?.NextNode;
        }

        while (fast.NextNode != null)
        {
            fast = fast.NextNode;
            slow = slow?.NextNode;
        }

        slow.NextNode = slow.NextNode.NextNode;

        return dummy.NextNode;
    }
}