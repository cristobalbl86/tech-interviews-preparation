/*
 * 2. Add Two Numbers - LEET CODE
Medium

You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.

You may assume the two numbers do not contain any leading zero, except the number 0 itself.

Example:

Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
Output: 7 -> 0 -> 8
Explanation: 342 + 465 = 807.
 */

/**
 * Definition for singly-linked list.
 * function ListNode(val, next) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.next = (next===undefined ? null : next)
 * }
 */
/**
 * @param {ListNode} l1
 * @param {ListNode} l2
 * @return {ListNode}
 */

/**
Runtime: 112 ms, faster than 83.84% of JavaScript online submissions for Add Two Numbers.
Memory Usage: 42.1 MB, less than 26.77% of JavaScript online submissions for Add Two Numbers.
 */

var addTwoNumbers = function (l1, l2) {
    let num1 = '', num2 = '', result;

    while (l1 != null) {
        num1 = `${l1.val}${num1}`;
        l1 = l1.next;
    }
    while (l2 != null) {
        num2 = `${l2.val}${num2}`;
        l2 = l2.next;
    }
    
    result = BigInt(num1) + BigInt(num2);

    let tempNode = new ListNode(0);
    for (let n of result.toString().split('')) {
        if (tempNode.val !== 0) {
            tempNode = new ListNode(n, tempNode);
        } else {
            tempNode.val = n;
        }
    }

    return tempNode;
};