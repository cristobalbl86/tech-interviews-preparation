using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingInterview.Tree
{
    /*
113. Path Sum II
Given a binary tree and a sum, find all root-to-leaf paths where each path's sum equals the given sum.

Note: A leaf is a node with no children.

Example:
Given the below binary tree and sum = 22,

      5
     / \
    4   8
   /   / \
  11  13  4
 /  \    / \
7    2  5   1
Return:

[
   [5,4,11,2],
   [5,8,4,5]
]     
         */

    //* Definition for a binary tree node.
    public class TreeNode42 {
         public int val;
         public TreeNode42 left;
         public TreeNode42 right;
         public TreeNode42(int val=0, TreeNode42 left =null, TreeNode42 right =null) {
             this.val = val;
             this.left = left;
             this.right = right;
         }
     }
    class _42_Path_SumII
    {
        public class Solution
        {
            public IList<IList<int>> PathSum(TreeNode42 root, int sum)
            {

                IList<IList<int>> results = new List<IList<int>>();

                checkPath(root, sum, new List<int>(), results);

                return results;
            }

            public void checkPath(TreeNode42 node, int target, List<int> current, IList<IList<int>> final)
            {

                if (node == null)
                {
                    return;
                }

                current.Add(node.val);

                if (node.val == target && node.right == null && node.left == null)
                {
                    List<int> path = new List<int>(current);
                    final.Add(path);
                }

                checkPath(node.left, target - node.val, current, final);
                checkPath(node.right, target - node.val, current, final);

                current.RemoveAt(current.Count - 1);
            }
        }
    }

    public class MyOwnSolution_2Jun2021
    {
        public IList<IList<int>> PathSum(TreeNode root, int sum)
        {

            List<List<int>> result = new List<List<int>>();

            List<int> path = new List<int>();

            checkPath(root, sum, result, path);

            return result.ToArray();
        }

        public void checkPath(TreeNode node, int target, List<List<int>> result, List<int> path)
        {

            if (node == null) return;

            path.Add(node.val);

            int sum = path.Count > 0 ? path.Select(i => i).Sum() : 0;

            if (sum == target && node.left == null && node.right == null)
            {

                List<int> newpath = new List<int>(path);
                result.Add(newpath);

                //path.RemoveAt(path.Count - 1);
                //return;
            }

            checkPath(node.left, target, result, path);
            checkPath(node.right, target, result, path);

            path.RemoveAt(path.Count - 1);
        }

    }
}
