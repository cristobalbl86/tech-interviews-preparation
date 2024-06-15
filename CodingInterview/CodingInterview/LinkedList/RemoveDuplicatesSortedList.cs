using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.LinkedList
{
    class RemoveDuplicatesSortedList
    {
        /*
            HASHSET APPROACH
            T= O(n)
            S= O(n)
         */
        public ListNode DeleteDuplicates(ListNode head)
        {
            ListNode newhead = new ListNode(0);
            ListNode current = newhead;
            var hs = new HashSet<int>();

            while (head != null)
            {
                if (!hs.Contains(head.val))
                {
                    hs.Add(head.val);
                    current.next = new ListNode(head.val);
                    current = current.next;
                }
                head = head.next;
            }

            return newhead.next;
        }
    }
}
/*
 83. Remove Duplicates from Sorted List
Easy
Given the head of a sorted linked list, delete all duplicates such that each element appears only once. Return the linked list sorted as well.

 

Example 1:


Input: head = [1,1,2]
Output: [1,2]
Example 2:


Input: head = [1,1,2,3,3]
Output: [1,2,3]
 

Constraints:

The number of nodes in the list is in the range [0, 300].
-100 <= Node.val <= 100
The list is guaranteed to be sorted in ascending order.
 */
