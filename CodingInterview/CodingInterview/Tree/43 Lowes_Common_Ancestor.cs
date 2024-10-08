﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Tree
{
    /*
235. Lowest Common Ancestor of a Binary Search Tree

Given a binary search tree (BST), find the lowest common ancestor (LCA) of two given nodes in the BST.

According to the definition of LCA on Wikipedia: “The lowest common ancestor is defined between two nodes p and q as the lowest node in T 
    that has both p and q as descendants (where we allow a node to be a descendant of itself).”

Given binary search tree:  root = [6,2,8,0,4,7,9,null,null,3,5]

Example 1:
Input: root = [6,2,8,0,4,7,9,null,null,3,5], p = 2, q = 8
Output: 6
Explanation: The LCA of nodes 2 and 8 is 6.
Example 2:

Input: root = [6,2,8,0,4,7,9,null,null,3,5], p = 2, q = 4
Output: 2
Explanation: The LCA of nodes 2 and 4 is 2, since a node can be a descendant of itself according to the LCA definition.
 
Note:
All of the nodes' values will be unique.
p and q are different and both values will exist in the BST.     
         */


    // Definition for a binary tree node.
    public class TreeNode43 {
         public int val;
         public TreeNode43 left;
         public TreeNode43 right;
         public TreeNode43(int x) { val = x; }
     }

    class _43_Lowes_Common_Ancestor
    {
        public class Solution
        {
            public TreeNode43 LowestCommonAncestor(TreeNode43 root, TreeNode43 p, TreeNode43 q)
            {
                if (p.val < root.val && q.val < root.val)
                {
                    return LowestCommonAncestor(root.left, p, q);
                }
                else if (p.val > root.val && q.val > root.val)
                {
                    return LowestCommonAncestor(root.right, p, q);
                }
                else
                {
                    return root;
                }
            }
        }
    }
}

/*
 Example:
		TreeNode root = new TreeNode(6);
		root.left = new TreeNode(2);
		root.right = new TreeNode(8);
		
		root.left.left = new TreeNode(0);
		root.left.right = new TreeNode(4);
		
		root.left.right.left = new TreeNode(3);
		root.left.right.right = new TreeNode(5);
		
		root.right.left = new TreeNode(7);
		root.right.right = new TreeNode(9);
		
		TreeNode result = LowestCommonAncestor(root, root.left, root.right);
		Console.WriteLine("result :" + result.val.ToString());
 */
