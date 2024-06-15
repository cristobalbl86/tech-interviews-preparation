using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Tree
{
    class _61_Validate_BST
    {
        public static bool IsValidBST(TreeNode root)
        {
            return DFS(root, null, null);
        }

        private static bool DFS(TreeNode root, int? min, int? max)
        {
            if (root == null) return true;
            if (min != null && root.val <= min || max != null && root.val >= max)
                return false;

            return DFS(root.left, min, root.val) && DFS(root.right, root.val, max);

        }
    }
}
