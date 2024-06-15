using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Tree
{
    class SearchInBST
    {
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

        public class Solution
        {
            /*
             * MY APPROACH
             * 
                T= O(n)
                S= O(1)
             */
            public TreeNode SearchBST(TreeNode root, int val)
            {
                if (root == null) return null;
                if (root.val == val) return root;

                TreeNode left = SearchBST(root.left, val);
                TreeNode right = SearchBST(root.right, val);

                if (left != null) 
                    return left;
                else if (right != null) 
                    return right;

                return null;
            }

            /*
             SECOND APPROACH
             */
            public TreeNode SearchBST2(TreeNode root, int val)
            {
                if (root == null) return null;
                if (root.val == val) return root;

                if (root.val > val)
                    return SearchBST2(root.left, val);
                else if (root.val < val)
                    return SearchBST2(root.right, val);

                return null;
            }

            /*
             ITERATIVE APPROACH
             */
            public TreeNode SearchBST3(TreeNode root, int val)
            {
                if (root == null) return null;

                while (root != null)
                {
                    if (root.val > val)
                    {
                        root = root.left;
                    }
                    else if (root.val < val)
                    {
                        root = root.right;
                    }

                    if (root == null || root.val == val) return root;
                }

                return null;
            }
        }
    }
}
