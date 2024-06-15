using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Tree
{
    class MaxDepthOfBinaryTree
    {
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
        
        public int MaxDepth(TreeNode root)
        {
            /*
                T= O(n)
                S= O(1)
             */

            if (root == null) return 0;

            int ll = MaxDepth(root.left);
            int rl = MaxDepth(root.right);

            return Math.Max(ll, rl) + 1;
        }
    }
}
/*
 104. Maximum Depth of Binary Tree
Easy

Given the root of a binary tree, return its maximum depth.

A binary tree's maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.

Example 1:


Input: root = [3,9,20,null,null,15,7]
Output: 3
Example 2:

Input: root = [1,null,2]
Output: 2
Example 3:

Input: root = []
Output: 0
Example 4:

Input: root = [0]
Output: 1
 

Constraints:

The number of nodes in the tree is in the range [0, 104].
-100 <= Node.val <= 100
 */
