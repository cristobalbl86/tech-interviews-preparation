using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.LinkedList
{
    class PartitionList
    {
        /*
            T= O(n)
            S= O(n)
         */
        public ListNode Partition(ListNode head, int x)
        {
            var dummy1 = new ListNode(0);
            var dummy2 = new ListNode(0);

            var list1 = dummy1;
            var list2 = dummy2;

            while (head != null)
            {

                if (head.val >= x)
                {
                    //list2.next = new ListNode(head.val);
                    //list2 = list2.next;
                    list2.next = head;
                    list2 = head;
                }
                else
                {
                    //list1.next = new ListNode(head.val);
                    //list1 = list1.next;
                    list1.next = head;
                    list1 = head;
                }

                head = head.next;
            }

            list2.next = null;
            list1.next = dummy2.next;

            return dummy1.next;
        }
    }
}
/**
 86. Partition List
Medium

Given the head of a linked list and a value x, partition it such that all nodes less than x come before nodes greater than or equal to x.

You should preserve the original relative order of the nodes in each of the two partitions.

Example 1:


Input: head = [1,4,3,2,5,2], x = 3
Output: [1,2,2,4,3,5]
Example 2:

Input: head = [2,1], x = 2
Output: [1,2]
 

Constraints:

The number of nodes in the list is in the range [0, 200].
-100 <= Node.val <= 100
-200 <= x <= 200
 */
