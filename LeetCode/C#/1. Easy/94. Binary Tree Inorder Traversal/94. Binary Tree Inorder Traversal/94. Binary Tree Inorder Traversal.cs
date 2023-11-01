Console.WriteLine(new Solution().InorderTraversal(new TreeNode(1)).Select(n=>n.ToString()));

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution
{
    private List<int> nodes = new List<int>();

    public IList<int> InorderTraversal(TreeNode root)
    {

        if (root == null)
            return new List<int>();

        if (root.left == null && root.right == null)
            return new List<int> { root.val };

        TraverseTreeInternal(root);

        return nodes;
    }

    private void TraverseTreeInternal(TreeNode node)
    {
        if (node == null) return;

        TraverseTreeInternal(node.left);

        nodes.Add(node.val);

        TraverseTreeInternal(node.right);
    }
}