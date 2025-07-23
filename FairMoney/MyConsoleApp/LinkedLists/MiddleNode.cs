public class MiddleNodeFinder
{

    public static ListNode MiddleNode(ListNode node)
    {
        ListNode dummy = new ListNode(0, node);

        int counter = 0;

        ListNode currentNode = dummy.NextNode;

        while (currentNode != null)
        {
            currentNode = currentNode.NextNode;
            counter++;
        }

        int index = (int)Math.Floor((double)counter / 2);

        Console.WriteLine("Counter:" + counter);
        Console.WriteLine("Index:" + index);

        currentNode = dummy.NextNode;
        for (int i = 0; i < index; i++)
        {
            currentNode = currentNode.NextNode;
        }

        return currentNode;
    }


    public static ListNode? MiddleNodeWith2Pointers(ListNode? node)
    {
        ListNode? fast = node;
        ListNode? slow = node;

        while (fast != null && fast.NextNode != null&& slow != null)
        {
            fast = fast.NextNode.NextNode;
            slow = slow.NextNode;
        }

        return slow;
    }
}