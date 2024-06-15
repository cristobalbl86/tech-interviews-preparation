using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.LinkedList
{
    class PalindromeLinkedList
    {
        public bool IsPalindrome(ListNode head)
        {
            /*
             * STACK APPROACH
                T=O(n)
                S=O(n)
             */
            ListNode current = head;

            var st = new Stack<int>();

            while (current != null)
            {
                st.Push(current.val);
                current = current.next;
            }

            while (st.Count > 0)
            {
                if (st.Pop() != head.val) return false;
                head = head.next;
            }

            return true;

        }

        public bool IsPalindrome2(ListNode head)
        {
            /*
                T= O(n)
                S= O(1)
             */
            if (head == null || head.next == null)
                return true;

            ListNode slow = head;
            ListNode fast = head;

            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }

            if (fast != null)
                slow = slow.next;

            slow = reverse(slow);
            fast = head;

            while (slow != null)
            {
                if (fast.val != slow.val) return false;

                slow = slow.next;
                fast = fast.next;
            }

            return true;
        }

        public ListNode reverse(ListNode head)
        {

            ListNode prev = null;

            while (head != null)
            {
                ListNode next = head.next;
                head.next = prev;
                prev = head;
                head = next;
            }

            return prev;
        }
    }
}
/*
 234. Palindrome Linked List
Easy
Given the head of a singly linked list, return true if it is a palindrome.

Example 1:
Input: head = [1,2,2,1]
Output: true
Example 2:


Input: head = [1,2]
Output: false
 

Constraints:

The number of nodes in the list is in the range [1, 105].
0 <= Node.val <= 9
 */
