﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.LinkedList
{
    class ReverseLinkedList
    {
        public ListNode ReverseList(ListNode head)
        {
            /*
             T= O(n)
            S= O(1)
             */
            if (head == null || head.next == null) return head;

            ListNode newhead = head;
            ListNode prev = null;

            while (newhead != null)
            {
                ListNode next = newhead.next;

                newhead.next = prev;

                prev = newhead;
                newhead = next;
            }

            return prev;


        }
    }
}
/*
 206. Reverse Linked List
Easy

Given the head of a singly linked list, reverse the list, and return the reversed list.

Example 1:

Input: head = [1,2,3,4,5]
Output: [5,4,3,2,1]
Example 2:

Input: head = [1,2]
Output: [2,1]
Example 3:

Input: head = []
Output: []
 
Constraints:

The number of nodes in the list is the range [0, 5000].
-5000 <= Node.val <= 5000
 */
