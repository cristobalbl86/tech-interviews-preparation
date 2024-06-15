using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.LinkedList
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    class Add_Two_Numbers_LinkedList
    {
        /*
         * MY APPROACH - ITERATING LIST AND CONVERT TO STRING-> INT/ TIME LIMIT EXCEEDED
         */
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            long n1 = takeNum(l1);
            long n2 = takeNum(l2);

            string sum = (n1 + n2).ToString();

            ListNode current = new ListNode(-1);
            for (int i = 0; i < sum.Length; i++)
            {
                if (current.val != -1)
                    current = new ListNode(sum[i] - '0', current);
                else
                    current.val = sum[i] - '0';
            }

            return current;
        }

        public long takeNum(ListNode node)
        {

            string res = string.Empty;

            while (node != null)
            {
                res = node.val.ToString() + res;
                node = node.next;
            }

            return Convert.ToInt64(res);
        }

        /*
         * TWO POINTERS APPROACH
         * 
         * T= O(m+n)
         * S= O(m+n)
         */
        public ListNode AddTwoNumbers_(ListNode l1, ListNode l2)
        {

            ListNode current = new ListNode(0);
            ListNode newhead = current;
            int carry = 0;

            while (l1 != null || l2 != null)
            {
                int sum = 0;

                if (l1 == null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }
                else if (l2 == null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }
                else
                {
                    sum += (l1.val + l2.val);
                    l1 = l1.next;
                    l2 = l2.next;
                }

                sum += carry;

                if (sum >= 10)
                {
                    sum = sum % 10;
                    carry = 1;
                }
                else
                    carry = 0;

                ListNode temp = new ListNode(sum);
                current.next = temp;
                current = temp;
            }

            if (carry == 1)
            {
                current.next = new ListNode(1);
            }

            return newhead.next;
        }

        /*
            TWO POINTERS (IMPROVED)
            T= O(m+n)
            S= O(1)
         */
        public ListNode AddTwoNumbers2(ListNode l1, ListNode l2)
        {
            ListNode dummy = new ListNode();
            ListNode p = dummy;
            int carry = 0;

            while (l1 != null || l2 != null || carry != 0)
            {
                if (l1 != null)
                {
                    carry += l1.val;
                    l1 = l1.next;
                }

                if (l2 != null)
                {
                    carry += l2.val;
                    l2 = l2.next;
                }

                p.next = new ListNode(carry % 10);
                p = p.next;
                carry = carry / 10;
            }

            return dummy.next;
        }
    }
}

/*
 2. Add Two Numbers
Medium

You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.

You may assume the two numbers do not contain any leading zero, except the number 0 itself.

Example 1:

Input: l1 = [2,4,3], l2 = [5,6,4]
Output: [7,0,8]
Explanation: 342 + 465 = 807.
Example 2:

Input: l1 = [0], l2 = [0]
Output: [0]
Example 3:

Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
Output: [8,9,9,9,0,0,0,1]
 

Constraints:

The number of nodes in each linked list is in the range [1, 100].
0 <= Node.val <= 9
It is guaranteed that the list represents a number that does not have leading zeros.
 */