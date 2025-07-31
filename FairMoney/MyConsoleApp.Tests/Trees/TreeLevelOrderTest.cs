[TestFixture]

public class TreeLevelOrderTest
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


    private bool AreListsEqual(List<List<int>> l1, List<List<int>> l2)
    {
        if (l1 == null && l2 == null) return true;
        if (l1 == null || l2 == null) return false;
        if (l1.Count != l2.Count) return false;

        for (int i = 0; i < l1.Count; i++)
        {
            if (l1[i].Count != l2[i].Count) return false;
            for (int j = 0; j < l1[i].Count; j++)
            {
                if (l1[i][j] != l2[i][j]) return false;
            }
        }

        return true;
    }

    [Test]
    public void TestNormalTree()
    {
        TreeNode root = CreateTree(new int?[] { 4, 2, 7, 1, 3, 6, 9 });
        List<List<int>> expected = [[4], [2, 7], [1, 3, 6, 9]];
        var result = TreeMaxDepth.TreeLevelOrderTraversal(root);

        Console.Write("[");
        for (int i = 0; i < result.Count; i++)
        {
            Console.Write("[");
            for (int j = 0; j < result[i].Count; j++)
            {
                Console.Write(result[i][j]);
                Console.Write(",");
            }
            Console.Write("],");
        }
        Console.Write("]");
        Assert.That(AreListsEqual(result, expected));
    }

    [Test]
    public void TestSingleNode()
    {
        TreeNode root = CreateTree(new int?[] { 1 });
        List<List<int>> expected = [[1]];
        var result = TreeMaxDepth.TreeLevelOrderTraversal(root);
        Assert.That(AreListsEqual(result, expected));
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
        List<List<int>> expected = [[1], [2], [3]];
        var result = TreeMaxDepth.TreeLevelOrderTraversal(root);
        Assert.That(AreListsEqual(result, expected));
    }
}