using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Tree
{
    /*
     572. Subtree of Another Tree

Given two non-empty binary trees s and t, check whether tree t has exactly the same structure and node values with a subtree of s. A subtree of s is a tree consists of a node in s and all of this node's descendants. The tree s could also be considered as a subtree of itself.

Example 1:
Given tree s:

     3
    / \
   4   5
  / \
 1   2
Given tree t:
   4 
  / \
 1   2
Return true, because t has the same structure and node values with a subtree of s.
 

Example 2:
Given tree s:

     3
    / \
   4   5
  / \
 1   2
    /
   0
Given tree t:
   4
  / \
 1   2
Return false.
         */


    /**
* Definition for a binary tree node.
* public class TreeNode {
*     public int val;
*     public TreeNode left;
*     public TreeNode right;
*     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
*         this.val = val;
*         this.left = left;
*         this.right = right;
*     }
* }
*/
    class _48_SubTree_Of_Tree
    {
        public class Solution
        {
            public static bool IsSubtree(TreeNode s, TreeNode t)
            {

                if (s == null)
                {
                    return false;
                }
                else if (foundSub(s, t))
                {
                    return true;
                }
                else
                {
                    return IsSubtree(s.left, t) || IsSubtree(s.right, t);
                }
            }

            public static bool foundSub(TreeNode root, TreeNode target)
            {
                if (root == null || target == null)
                {
                    return root == null && target == null;
                }
                else if (root.val == target.val)
                {
                    return foundSub(root.left, target.left) && foundSub(root.right, target.right);
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
