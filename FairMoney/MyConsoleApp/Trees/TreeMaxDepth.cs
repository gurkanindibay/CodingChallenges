public class TreeMaxDepth
{
    public static int MaxDepth(TreeNode node)
    {
        if (node == null) return 0;
        Stack<TreeNodeDepth> treeNodeDepths = [];
        treeNodeDepths.Push(new TreeNodeDepth(1, node));
        int maxDepth = 0;
        while (treeNodeDepths.Count > 0)
        {
            TreeNodeDepth current = treeNodeDepths.Pop();
            TreeNode currentNode = current.Node;
            maxDepth = Math.Max(maxDepth, current.Depth);
            if (currentNode != null && currentNode.Left != null)
                treeNodeDepths.Push(new TreeNodeDepth(current.Depth + 1, currentNode.Left));
            if (currentNode != null && currentNode.Right != null)
                treeNodeDepths.Push(new TreeNodeDepth(current.Depth + 1, currentNode.Right));
        }

        return maxDepth;
    }
}