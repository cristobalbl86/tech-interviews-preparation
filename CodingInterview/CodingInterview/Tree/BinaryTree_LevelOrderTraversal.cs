using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Tree
{
    class BinaryTree_LevelOrderTraversal
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            /*
                T= O(n)
                S= O(n)
             */
            var result = new List<List<int>>();

            if (root == null) return result.ToArray();

            var q = new Queue<TreeNode>();
            q.Enqueue(root);

            while (q.Count > 0)
            {
                int count = q.Count;
                var curlist = new List<int>();

                for (int i = 0; i < count; i++)
                {
                    TreeNode node = q.Dequeue();
                    curlist.Add(node.val);

                    if (node.left != null) q.Enqueue(node.left);
                    if (node.right != null) q.Enqueue(node.right);

                }
                result.Add(curlist);
            }

            return result.ToArray();
        }
    }
}
/*
 102. Binary Tree Level Order Traversal
Medium

Given the root of a binary tree, return the level order traversal of its nodes' values. (i.e., from left to right, level by level).

Example 1:


Input: root = [3,9,20,null,null,15,7]
Output: [[3],[9,20],[15,7]]
Example 2:

Input: root = [1]
Output: [[1]]
Example 3:

Input: root = []
Output: []
 

Constraints:

The number of nodes in the tree is in the range [0, 2000].
-1000 <= Node.val <= 1000
 */
