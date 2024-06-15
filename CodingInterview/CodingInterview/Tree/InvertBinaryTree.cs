using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Tree
{
    class InvertBinaryTree
    {
        /*196ms*/
        public class MySolution
        {
            public TreeNode InvertTree(TreeNode root)
            {
                invert(root);
                return root;
            }

            public void invert(TreeNode node)
            {
                if (node == null) return;

                TreeNode tmp = node.right;
                node.right = node.left;
                node.left = tmp;

                invert(node.right);
                invert(node.left);
            }
        }


        /*84 ms*/
        public class Solution
        {
            public TreeNode InvertTree(TreeNode root)
            {
                return invert(root);
            }

            public TreeNode invert(TreeNode node)
            {
                if (node == null) return null;

                TreeNode left = invert(node.left);
                TreeNode right = invert(node.right);

                node.left = right;
                node.right = left;

                return node;
            }
        }
    }
}

/*
226. Invert Binary Tree
Easy

Given the root of a binary tree, invert the tree, and return its root.


Example 1:

Input: root = [4,2,7,1,3,6,9]
Output: [4,7,2,9,6,3,1]
Example 2:


Input: root = [2,1,3]
Output: [2,3,1]
Example 3:

Input: root = []
Output: []
 

Constraints:

The number of nodes in the tree is in the range [0, 100].
-100 <= Node.val <= 100
*/