[TestFixture]
public class RemoveNthNodeTest
{
    [Test]
    public void TestNthRemove()
    {
        ListNode? result = RemoveNthNode.Remove(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, null)))), 3);

        ListNode current = result;

        while (current != null)
        {
            Console.WriteLine(current.Val);
            current = current.NextNode;
        }
    }

}