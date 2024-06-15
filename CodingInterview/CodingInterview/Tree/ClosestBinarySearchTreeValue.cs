using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Tree
{
    class ClosestBinarySearchTreeValue
    {
        public int ClosestValue(TreeNode root, double target) {
            int[] result = new int[1];
            result[0] = root.val;
            helper(root, target, result);

            return result[0];
        }

        public void helper(TreeNode root, double target, int[] result) {
            if (root == null)
                return;

            if (root.val - target < result[0] - target)
                result[0] = root.val;

            if (root.val > target)
                helper(root.left, target, result);
            else
                helper(root.right, target, result);
        }
    }
}