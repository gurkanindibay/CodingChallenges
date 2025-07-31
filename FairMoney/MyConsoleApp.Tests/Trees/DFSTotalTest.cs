[TestFixture]
public class DFSTotalTest
{

    private TreeNode CreateTree(int?[] values, int index = 0)
    {
        if (index >= values.Length || values[index] == null) return null;
        TreeNode node = new TreeNode(values[index].Value, null, null);
        node.Left = CreateTree(values, 2 * index + 1);
        node.Right = CreateTree(values, 2 * index + 2);
        return node;
    }
    [Test]
    public void TestNormalTree()
    {
        TreeNode root = CreateTree(new int?[] { 4, 2, 7, 1, 3, 6, 9 });
        var result = TreeMaxDepth.DFSTotal(root, 7);
        Assert.That(result, Is.EqualTo(true));
    }

     [Test]
    public void TestNormalTree1()
    {
        TreeNode root = CreateTree(new int?[] { 4, 2, 7, 1, 3, 6, 9 });
        var result = TreeMaxDepth.DFSTotal(root, 9);
        Assert.That(result, Is.EqualTo(true));
    }

    [Test]
    public void TestUnbalancedTree1()
    {
        TreeNode root = CreateTree(new int?[] { 1, 2, null, 3 });
        var result = TreeMaxDepth.DFSTotal(root, 6);
        Assert.That(result, Is.EqualTo(true));
    }

    public void TestSingleNode()
    {
        TreeNode root = CreateTree(new int?[] { 1 });
        var result = TreeMaxDepth.DFSTotal(root, 1);
        Assert.That(result, Is.EqualTo(true));
    }
    
    
    public void TestEmptyTree()
    {
         TreeNode root = CreateTree(new int?[] { });
        var result = TreeMaxDepth.DFSTotal(root, 0);
        Assert.That(result,Is.EqualTo(true));
    }
}