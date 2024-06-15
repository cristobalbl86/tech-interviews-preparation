using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Tree
{
    /*
938. Range Sum of BST
Easy

Given the root node of a binary search tree, return the sum of values of all nodes with value between L and R (inclusive).

The binary search tree is guaranteed to have unique values.

Example 1:
Input: root = [10,5,15,3,7,null,18], L = 7, R = 15
Output: 32
Example 2:

Input: root = [10,5,15,3,7,13,18,1,null,6], L = 6, R = 10
Output: 23
 

Note:
The number of nodes in the tree is at most 10000.
The final answer is guaranteed to be less than 2^31.     
         */
    class _55_Range_Sum_BST
    {
        public int RangeSumBST(TreeNode root, int L, int R)
        {
            int sum = 0;

            if (root == null)
            {
                return sum;
            }

            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);

            while (q.Count > 0)
            {
                TreeNode node = q.Dequeue();

                if (node.val >= L && node.val <= R)
                {
                    sum += node.val;
                }
                if (node.left != null && node.val > L)
                {
                    q.Enqueue(node.left);
                }
                if (node.right != null && node.val < R)
                {
                    q.Enqueue(node.right);
                }
            }

            return sum;
        }

        /*
         RECURSIVE APPROACH
         */
        public int RangeSumBST_(TreeNode root, int L, int R)
        {
            int sum = 0;

            //base
            if (root == null)
            {
                return 0;
            }

            if (root.val >= L && root.val <= R)
                sum = root.val;

            sum += RangeSumBST(root.left, L, R) +
                RangeSumBST(root.right, L, R);

            return sum;
        }
    }
}
