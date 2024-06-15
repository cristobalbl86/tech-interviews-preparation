using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Tree
{
    class BinaryTree_RightSideView
    {
        /*
            T= O(n)
            S= O(n)
         */
        public IList<int> RightSideView(TreeNode root)
        {
            var res = new List<int>();

            if (root == null) return res;

            var Q = new Queue<TreeNode>();

            Q.Enqueue(root);

            while (Q.Count > 0)
            {
                int nodes = Q.Count;

                for (int i = 0; i < nodes; i++)
                {
                    TreeNode current = Q.Dequeue();

                    if (i == nodes - 1) res.Add(current.val);

                    if (current.left != null)
                        Q.Enqueue(current.left);
                    if (current.right != null)
                        Q.Enqueue(current.right);
                }
            }

            return res;
        }
    }
}
/*
 199. Binary Tree Right Side View
Medium

Given the root of a binary tree, imagine yourself standing on the right side of it, return the values of the nodes you can see ordered from top to bottom.

Example 1:


Input: root = [1,2,3,null,5,null,4]
Output: [1,3,4]
Example 2:

Input: root = [1,null,3]
Output: [1,3]
Example 3:

Input: root = []
Output: []
 

Constraints:

The number of nodes in the tree is in the range [0, 100].
-100 <= Node.val <= 100
 */
