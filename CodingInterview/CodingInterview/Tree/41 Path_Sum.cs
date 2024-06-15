using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Tree
{
    /*
     112. Path Sum
Given a binary tree and a sum, determine if the tree has a root-to-leaf path such that adding up all the values along the path equals the given sum.

Note: A leaf is a node with no children.

Example:

Given the below binary tree and sum = 22,

      5
     / \
    4   8
   /   / \
  11  13  4
 /  \      \
7    2      1
return true, as there exist a root-to-leaf path 5->4->11->2 which sum is 22.
         */

    //Definition for a binary tree node.
    public class TreeNode1 {
         public int val;
         public TreeNode1 left;
         public TreeNode1 right;
         public TreeNode1(int val=0, TreeNode1 left=null, TreeNode1 right=null) {
             this.val = val;
             this.left = left;
             this.right = right;
         }
     }

    class _41_Path_Sum
    {

        public class Solution
        {
            public bool HasPathSum(TreeNode1 root, int sum)
            {

                if (root == null)
                    return false;

                return checkSum(root, 0, sum);
            }

            public bool checkSum(TreeNode1 currentNode, int accumulated, int target)
            {
                if (currentNode == null)
                    return false;

                accumulated += currentNode.val;

                if (accumulated == target && currentNode.left == null & currentNode.right == null)
                {
                    return true;
                }

                bool found = checkSum(currentNode.left, accumulated, target) || checkSum(currentNode.right, accumulated, target);

                return found;
            }
        }
    }
}
