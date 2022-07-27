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
    List<TreeNode> list = new List<TreeNode>();
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
    public void inorder(TreeNode root)
    {
        if (root == null) return;
        Console.WriteLine(root.val);
        list.Add(root);
        inorder(root.left);
        inorder(root.right);
    }
    public void Flatten(TreeNode root)
    {
        inorder(root);
        TreeNode basicRoot = root;
        foreach (var item in list)
        {
            item.left = null;
            root.right = item;
            root = root.right;
        }
        while(basicRoot != null)
        {
            Console.WriteLine(basicRoot.val);
            basicRoot = basicRoot.right;
        }
    }
}