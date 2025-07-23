
[TestFixture]
public class ReverseLinkedListTests
{
    [Test]
    public void ReverseLinkedMultipleNodeTest()
    {
        ListNode listNode = new(1, new ListNode(2, new ListNode(3, null)));

        ListNode? reversed = ReverseLinkedList.ReverseList(listNode);

        Assert.Multiple(() =>
        {
            Assert.That(reversed?.Val, Is.EqualTo(3));
            Assert.That(reversed?.NextNode?.Val, Is.EqualTo(2));
            Assert.That(reversed?.NextNode?.NextNode?.Val, Is.EqualTo(1));
            Assert.That(reversed?.NextNode?.NextNode?.NextNode, Is.EqualTo(null));
        });

    }

    [Test]
    public void ReverseLinkedOneNodeTest()
    {
        ListNode listNode = new(1, null);

        ListNode? reversed = ReverseLinkedList.ReverseList(listNode);

        Assert.Multiple(() =>
        {
            Assert.That(reversed?.Val, Is.EqualTo(1));
            Assert.That(reversed?.NextNode, Is.EqualTo(null));
        });

    }

    [Test]
    public void ReverseLinkedNullTest()
    {
        ListNode? listNode = null;

        ListNode? reversed = ReverseLinkedList.ReverseList(listNode);

        Assert.Multiple(() =>
        {
            Assert.That(reversed, Is.EqualTo(null));
        });
    }
}