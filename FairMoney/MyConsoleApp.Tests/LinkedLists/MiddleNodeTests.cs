[TestFixture]

public class MiddleNodeFinderTests
{

    [Test]
    public void FindWith5Elemets()
    {
        ListNode listNode = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, null)))));

        ListNode result = MiddleNodeFinder.MiddleNode(listNode);

        Console.WriteLine("Middle Node Value is: " + result.Val);
    }

    [Test]
    public void FindWith4Elemets()
    {
        ListNode listNode = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, null))));

        ListNode result = MiddleNodeFinder.MiddleNode(listNode);

        Console.WriteLine("Middle Node Value is: " + result.Val);
    }

    [Test]
    public void FindWith1Elemets()
    {
        ListNode listNode = new ListNode(1, null);

        ListNode result = MiddleNodeFinder.MiddleNode(listNode);

        Console.WriteLine("Middle Node Value is: " + result.Val);
    }

    [Test]
    public void FindWithNull()
    {
        ListNode listNode = null;

        ListNode result = MiddleNodeFinder.MiddleNode(listNode);

        Console.WriteLine("Middle Node Value is: " + (result == null ? "null" : result.Val));
    }
    


      [Test]
    public void FindWith5Elemets2Ptr()
    {
        ListNode listNode = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, null)))));

        ListNode? result = MiddleNodeFinder.MiddleNodeWith2Pointers(listNode);

        Console.WriteLine("Middle Node Value is: " + result.Val);
    }

    [Test]
    public void FindWith4Elemets2Ptr()
    {
        ListNode listNode = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, null))));

        ListNode? result = MiddleNodeFinder.MiddleNodeWith2Pointers(listNode);

        Console.WriteLine("2ptrMiddle Node Value is: " + result.Val);
    }

    [Test]
    public void FindWith1Elemets2Ptr()
    {
        ListNode listNode = new ListNode(1, null);

        ListNode? result = MiddleNodeFinder.MiddleNodeWith2Pointers(listNode);

        Console.WriteLine("2ptrMiddle Node Value is: " + result.Val);
    }
    
    [Test]
    public void FindWithNull2Ptr()
    {
        ListNode listNode = null;

        ListNode? result = MiddleNodeFinder.MiddleNodeWith2Pointers(listNode);

        Console.WriteLine("2ptrMiddle Node Value is: " + (result == null? "null": result.Val));
    }
}