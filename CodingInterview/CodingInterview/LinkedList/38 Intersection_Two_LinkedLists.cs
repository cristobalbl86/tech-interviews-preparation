using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class _38_Intersection_Two_LinkedLists
    {
        public static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null)
            {
                return null;
            }

            HashSet<ListNode> hs = new HashSet<ListNode>();

            while (headA != null)
            {
                hs.Add(headA);
                headA = headA.next;
            }

            while (headB != null)
            {
                if (hs.Contains(headB))
                {
                    return headB;
                }
                headB = headB.next;
            }

            return null;
        }
    }
}
