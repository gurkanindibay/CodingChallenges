[TestFixture]

public class TreeMaxDepthTest
{
    private TreeNode CreateTree(int?[] values, int index = 0)
    {
        if (index >= values.Length || values[index] == null) return null;
        TreeNode node = new TreeNode(values[index].Value, null, null);
        node.Left = CreateTree(values, 2 * index + 1);
        node.Right = CreateTree(values, 2 * index + 2);
        return node;
    }

    private bool AreTreesEqual(TreeNode t1, TreeNode t2)
    {
        if (t1 == null && t2 == null) return true;
        if (t1 == null || t2 == null) return false;
        return t1.Val == t2.Val && AreTreesEqual(t1.Left, t2.Left) && AreTreesEqual(t1.Right, t2.Right);
    }

    [Test]
    public void TestNormalTree()
    {
        TreeNode root = CreateTree(new int?[] { 4, 2, 7, 1, 3, 6, 9 });
        int result = TreeMaxDepth.MaxDepth(root);
        Assert.That(result, Is.EqualTo(3));
    }

    [Test]
    public void TestSingleNode()
    {
        TreeNode root = CreateTree(new int?[] { 1 });
        int result = TreeMaxDepth.MaxDepth(root);
        Assert.That(result, Is.EqualTo(1));
    }

    [Test]
    public void TestEmptyTree()
    {
        TreeNode root = null;
        int result = TreeMaxDepth.MaxDepth(root);
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void TestUnbalancedTree()
    {
        TreeNode root = CreateTree(new int?[] { 1, 2, null, 3 });
        int result = TreeMaxDepth.MaxDepth(root);
        Assert.That(result, Is.EqualTo(3));
    }
}