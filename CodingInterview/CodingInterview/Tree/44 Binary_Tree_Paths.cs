using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingInterview.Tree
{
    /*
257. Binary Tree Paths
Given a binary tree, return all root-to-leaf paths.

Note: A leaf is a node with no children.

Example:

Input:

   1
 /   \
2     3
 \
  5

Output: ["1->2->5", "1->3"]

Explanation: All root-to-leaf paths are: 1->2->5, 1->3     
         */

    //Definition for a binary tree node.
    public class TreeNode44 {
         public int val;
         public TreeNode44 left;
         public TreeNode44 right;
         public TreeNode44(int val=0, TreeNode44 left =null, TreeNode44 right =null) {
             this.val = val;
             this.left = left;
             this.right = right;
         }
     }

    class _44_Binary_Tree_Paths
    {

        public class Solution
        {
            public IList<string> BinaryTreePaths(TreeNode44 root)
            {
                List<string> paths = new List<string>();

                getpaths(root, paths, "");
                return paths;
            }

            public void getpaths(TreeNode44 node, List<string> list, string path)
            {
                if (node == null)
                {
                    return;
                }

                if (path.Length == 0)
                    path += node.val;
                else
                    path += "->" + node.val;

                if (node.left == null & node.right == null)
                {
                    list.Add(path);
                    path = "";
                }

                getpaths(node.left, list, path);
                getpaths(node.right, list, path);
            }
        }
    }
}
