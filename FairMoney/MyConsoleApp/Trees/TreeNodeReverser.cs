public class TreeNodeReverser
{
    public static TreeNode? ReverseTreeNodeIterative(TreeNode? node)
    {
        if (node == null) return null;

        TreeNode? temp = node.Right;
        node.Right = node.Left;
        node.Left = temp;

        ReverseTreeNodeIterative(node.Right);
        ReverseTreeNodeIterative(node.Left);

        return node;

    }

    public static TreeNode? ReverseTreeNodeIterativeIterative(TreeNode? node)
    {
        Stack<TreeNode> treeNodes = [];

        treeNodes.Push(node);

        while (treeNodes.Count > 0)
        {
            var current = treeNodes.Pop();
            var temp = current.Left;
            current.Left = current.Right;
            current.Right = temp;

            treeNodes.Push(current.Left);
            treeNodes.Push(current.Right);
        }

        return node;

        
    }
}