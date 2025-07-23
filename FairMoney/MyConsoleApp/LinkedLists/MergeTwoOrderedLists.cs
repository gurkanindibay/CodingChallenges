public class MergeTwoOrderedLists
{
    //merges two nodes and creates a merged list 
    public static ListNode? MergeSort(ListNode? node1, ListNode? node2)
    {
        ListNode dummy = new(0, null);
        ListNode current = dummy;


        while (node1 != null && node2 != null)
        {
            Console.WriteLine(current.Val);
            if (node1.Val < node2.Val)
            {
                current.NextNode = node1;
                node1 = node1.NextNode;
            }
            else
            {
                current.NextNode = node2;
                node2 = node2.NextNode;
            }

            current = current.NextNode;
        }

        current.NextNode = node1 ?? node2;

        return dummy.NextNode;
    }
}