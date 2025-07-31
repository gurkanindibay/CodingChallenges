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

    public static List<List<int>> TreeLevelOrderTraversal(TreeNode node)
    {
        if (node == null) return null;
        List<List<int>> treeList = [];

        Queue<TreeNodeDepth> queue = [];
        queue.Enqueue(new TreeNodeDepth(1, node));

        List<int>[] buckets = new List<int>[100];

        for (int i = 0; i < buckets.Length; i++)
        {
            buckets[i] = [];
        }


        while (queue.Count > 0)
        {
            var currentDN = queue.Dequeue();
            var currentNode = currentDN.Node;

            if (currentNode != null)
            {
                buckets[currentDN.Depth].Add(currentNode.Val);
            }

            if (currentNode != null && currentNode.Left != null)
            {
                queue.Enqueue(new TreeNodeDepth(currentDN.Depth + 1, currentNode.Left));
            }
            if (currentNode != null && currentNode.Right != null)
            {
                queue.Enqueue(new TreeNodeDepth(currentDN.Depth + 1, currentNode.Right));
            }
        }

        return [.. buckets.Where(b => b.Count > 0)];

    }

     public static bool DFSTotal(TreeNode node, int target)
    {
        if (node == null) return false;
        List<List<int>> treeList = [];

        Queue<TreeNodeDepth> queue = [];
        queue.Enqueue(new TreeNodeDepth(0, node));




        while (queue.Count > 0)
        {
            var currentDN = queue.Dequeue();
            var currentNode = currentDN.Node;

            

            if (currentNode != null && currentNode.Left != null)
            {
                queue.Enqueue(new TreeNodeDepth(currentDN.Depth + currentNode.Val, currentNode.Left));
            }
            if (currentNode != null && currentNode.Right != null)
            {
                queue.Enqueue(new TreeNodeDepth(currentDN.Depth + currentNode.Val, currentNode.Right));
            }

            if (currentNode == null) continue;

            if (currentNode.Left == null && currentNode.Right == null)
            {
                if (currentDN.Depth + currentNode.Val == target) return true;
            }
        }

        return false;

    }

    
}