using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.LinkedList
{
    class Merge_Two_Sorted_Lists
    {
        /*
         T= O(mn)
         S= O(1)
         */
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
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
 21. Merge Two Sorted Lists
Easy
Merge two sorted linked lists and return it as a sorted list. The list should be made by splicing together the nodes of the first two lists.

Example 1:


Input: l1 = [1,2,4], l2 = [1,3,4]
Output: [1,1,2,3,4,4]
Example 2:

Input: l1 = [], l2 = []
Output: []
Example 3:

Input: l1 = [], l2 = [0]
Output: [0]
 

Constraints:

The number of nodes in both lists is in the range [0, 50].
-100 <= Node.val <= 100
Both l1 and l2 are sorted in non-decreasing order.
 */
