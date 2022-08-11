using System;
using System.Collections.Generic;

namespace Task
{
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
        static void Main()
        {
            Solution solution = new Solution();
            TreeNode root = new TreeNode(2, new TreeNode(1), new TreeNode(3, new TreeNode(-1), new TreeNode(4)));
            Console.Write(solution.IsValidSubTree(root, null,null));
        }

        public bool IsValidSubTree(TreeNode root , int? max , int? min)
        {
            if(root == null)
                return true;

            if ((max != null && root.val <= max) ||
                (min != null && root.val >= min)) // not binary 
                return false;
            return IsValidSubTree(root.right, root.val, min) && IsValidSubTree(root.left, max, root.val);

        }
    }
}