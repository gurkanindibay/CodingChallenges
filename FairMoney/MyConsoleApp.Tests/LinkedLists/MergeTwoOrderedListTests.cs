[TestFixture]

public class MergeTwoOrderedListsTest
{
    [Test]

    public void TestTwoNonEmptylist()
    {
        ListNode listNode1 = new ListNode(1, new ListNode(3, new ListNode(5, null)));

        ListNode listNode2 = new ListNode(2, new ListNode(4, new ListNode(6, null)));

        ListNode? mergedListNode = MergeTwoOrderedLists.MergeSort(listNode1, listNode2);

        ListNode? currenListNode = mergedListNode;

        Console.WriteLine("---tests---");
        while (currenListNode != null)
        {
            Console.WriteLine(currenListNode.Val);
            currenListNode = currenListNode.NextNode;
        }
    }
}