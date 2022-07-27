public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution
{
    private List<TreeNode> _list = new List<TreeNode>();
    static void Main()
    {
        Solution solution = new Solution();
        TreeNode root = new TreeNode(1, 
            new TreeNode(2,
            new TreeNode(3), 
            new TreeNode(4)), 
            new TreeNode(5,
            right: new TreeNode(6)));
        solution.Flatten(root);
    }
    private void inorder(TreeNode root)
    {
        if (root == null) return;
        Console.WriteLine(root.val);
        _list.Add(root);
        inorder(root.left);
        inorder(root.right);
    }
    public void Flatten(TreeNode root)
    {
        inorder(root);
        if (_list.Count == 1) return;
        foreach (var item in _list)
        {
            item.left = null;
            root.right = item;
            root = root.right;
        }
    }
}