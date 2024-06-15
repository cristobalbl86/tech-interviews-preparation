using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.LinkedList
{
    class RemoveDuplicatesSortedListII
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            /*
             T= O(n)
             S= O(1)
             */

            //create new head and connect to current head
            ListNode newhead = new ListNode(-1);
            newhead.next = head;

            ListNode current = head; //point CURRENT to the existing list
            ListNode newlist = newhead; //point NEW to the newhead

            while (current != null)
            {
                //if CURRENT element is duplicated then move
                while (current.next != null && current.val == current.next.val)
                {
                    current = current.next;
                }

                //if CURRENT and NEW are the same, just move one position
                if (newlist.next == current)
                {
                    current = current.next;
                    newlist = newlist.next;
                }
                else //if there is a gap, then NEW must point to the next element after CURRENT
                {
                    newlist.next = current.next;
                    current = current.next;
                }

            }
            return newhead.next;
        }
    }
}
/*
 82. Remove Duplicates from Sorted List II
Medium

Given the head of a sorted linked list, delete all nodes that have duplicate numbers, leaving only distinct numbers from the original list. Return the linked list sorted as well.

 

Example 1:


Input: head = [1,2,3,3,4,4,5]
Output: [1,2,5]
Example 2:


Input: head = [1,1,1,2,3]
Output: [2,3]
 

Constraints:

The number of nodes in the list is in the range [0, 300].
-100 <= Node.val <= 100
The list is guaranteed to be sorted in ascending order.
 */
