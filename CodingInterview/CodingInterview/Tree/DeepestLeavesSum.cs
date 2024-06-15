using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Tree
{
    //public class TreeNodeBT
    //{
    //  public int val;
    //  public TreeNode left;
    //  public TreeNode right;
    //  public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    //    {
    //        this.val = val;
    //        this.left = left;
    //        this.right = right;
    //    }
    //}
    class DeepestLeavesSum
    {
        public static int DeepestSum(TreeNode root) {
            int target = getlevels(root);
            return Sum(root, target, 1);
        }

        public static int getlevels(TreeNode root) {
            if (root == null)
                return 0;

            return Math.Max(
                getlevels(root.left),
                getlevels(root.right)) + 1;
        }

        public static int Sum(TreeNode root, int target, int current) {
            if (root == null)
                return 0;

            if (target == current)
                return root.val;

            return Sum(root.left, target, current + 1) +
                Sum(root.right, target, current + 1);
        }
    }
}
/*
 Runtime: 108 ms, faster than 97.33% of C# online submissions for Deepest Leaves Sum.
Memory Usage: 34.5 MB, less than 7.11% of C# online submissions for Deepest Leaves Sum.

1302. Deepest Leaves Sum
Medium
Given a binary tree, return the sum of values of its deepest leaves.
 

Example 1:



Input: root = [1,2,3,4,5,null,6,7,null,null,null,null,8]
Output: 15
 

Constraints:

The number of nodes in the tree is between 1 and 10^4.
The value of nodes is between 1 and 100.
 */
