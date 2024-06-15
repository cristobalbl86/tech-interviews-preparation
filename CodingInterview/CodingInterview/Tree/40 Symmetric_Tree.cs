using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Tree
{
    /*101.Symmetric Tree
     Given a binary tree, check whether it is a mirror of itself (ie, symmetric around its center).
For example, this binary tree [1,2,2,3,4,4,3] is symmetric:
    1
   / \
  2   2
 / \ / \
3  4 4  3
 
But the following [1,2,2,null,3,null,3] is not:
    1
   / \
  2   2
   \   \
   3    3
 
Follow up: Solve it both recursively and iteratively.
         */
    //Definition for a binary tree node.
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

    class _40_Symmetric_Tree
    {

        public class Solution
        {
            public bool IsSymmetric(TreeNode root)
            {
                if (root == null)
                {
                    return true;
                }

                return checkSymmetric(root.left, root.right);
            }

            public bool checkSymmetric(TreeNode left, TreeNode right)
            {
                if (left == null || right == null)
                {
                    return left == right;
                }
                if (left.val != right.val)
                {
                    return false;
                }

                if (!checkSymmetric(left.left, right.right) ||
                    !checkSymmetric(left.right, right.left))
                {
                    return false;
                }
                return true;
            }
        }
    }
}
