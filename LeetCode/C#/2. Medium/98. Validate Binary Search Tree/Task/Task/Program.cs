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
            TreeNode root = new TreeNode(2, new TreeNode(1), new TreeNode(3));
            Console.Write(solution.IsValidBST(root));
        }

        private (List<int> left, List<int> right, bool IsBynaryTree) inorder(TreeNode root)
        {
            (List<int> leftTreeValues, List<int> rightTreeValues, bool IsBynaryTree) left_right_node = (new List<int>(), new List<int>(), true);
            if (root == null)
                return (left_right_node);
            (List<int> left, List<int> right, bool IsBynaryTree) branhes = inorder(root.left);
            if (branhes.IsBynaryTree && root.left !=null)
            {
                left_right_node.leftTreeValues.AddRange(branhes.left);
                left_right_node.leftTreeValues.AddRange(branhes.right);
                foreach (var val in left_right_node.leftTreeValues)
                    if (val >= root.val)
                        branhes.IsBynaryTree = false;
            }

            if (branhes.IsBynaryTree == false) return (null, null, false);
            branhes = inorder(root.right);
            if (branhes.IsBynaryTree && root.right !=null)
            { 
                left_right_node.rightTreeValues.AddRange(branhes.left);
                left_right_node.rightTreeValues.AddRange(branhes.right);
                foreach (var val in left_right_node.rightTreeValues)
                    if (val <= root.val)
                        branhes.IsBynaryTree = false;
            }
            if (branhes.IsBynaryTree == false) 
                return (null, null, false);
            left_right_node.leftTreeValues.Add(root.val);
            return left_right_node;
        }

        public bool IsValidBST(TreeNode root)
        {
            (List<int> left, List<int> right, bool IsBynaryTree)  left_right = inorder(root);
            if (left_right.IsBynaryTree)
                return true;
            return false;
        }
    }
}