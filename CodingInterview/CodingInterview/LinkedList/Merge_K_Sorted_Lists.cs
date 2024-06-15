using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.LinkedList
{
    class Merge_K_Sorted_Lists
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            /*
             * ITERATIVE APPROACH, USING ARRAYLIST
             * T= O(n)
             * S= O(n)
             * **/

            var finallist = new List<int>();

            foreach (ListNode node in lists)
            {
                var klist = node;
                while (klist != null)
                {
                    finallist.Add(klist.val);
                    klist = klist.next;
                }
            }

            var arrlist = finallist.ToArray();
            Array.Sort(arrlist);

            var newhead = new ListNode(-1);
            var current = newhead;
            for (int i = 0; i < arrlist.Length; i++)
            {
                current.next = new ListNode(arrlist[i]);
                current = current.next;
            }

            return newhead.next;
        }

        /*
         MERGE TWO LISTS APPROACH.
            T= O(n)
            S= O(1)
         */
        public ListNode MergeKLists_(ListNode[] lists)
        {

            ListNode current = null;

            for (int i = 0; i < lists.Length; i++)
            {
                current = mergetwo(current, lists[i]);
            }

            return current;
        }

        public ListNode mergetwo(ListNode l1, ListNode l2)
        {

            ListNode result = new ListNode(-1);
            ListNode current = result;

            while (l1 != null && l2 != null)
            {

                if (l1.val < l2.val)
                {
                    current.next = l1; //new ListNode(l1.val);
                    l1 = l1.next;
                }
                else
                {
                    current.next = l2; //new ListNode(l2.val);
                    l2 = l2.next;
                }
                current = current.next;
            }

            if (l1 != null)
            {
                current.next = l1;
            }
            else if (l2 != null)
            {
                current.next = l2;
            }

            return result.next;
        }
    }
}
/*
 23. Merge k Sorted Lists
Hard

You are given an array of k linked-lists lists, each linked-list is sorted in ascending order.

Merge all the linked-lists into one sorted linked-list and return it.

 

Example 1:

Input: lists = [[1,4,5],[1,3,4],[2,6]]
Output: [1,1,2,3,4,4,5,6]
Explanation: The linked-lists are:
[
  1->4->5,
  1->3->4,
  2->6
]
merging them into one sorted list:
1->1->2->3->4->4->5->6
Example 2:

Input: lists = []
Output: []
Example 3:

Input: lists = [[]]
Output: []
 

Constraints:

k == lists.length
0 <= k <= 10^4
0 <= lists[i].length <= 500
-10^4 <= lists[i][j] <= 10^4
lists[i] is sorted in ascending order.
The sum of lists[i].length won't exceed 10^4.
 */
