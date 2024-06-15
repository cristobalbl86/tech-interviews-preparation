/*
Merge k sorted linked lists and return it as one sorted list.Analyze and describe its complexity.

    Example:
Input:
[
    1 -> 4 -> 5,
    1 -> 3 -> 4,
    2 -> 6
]
Output: 1 -> 1 -> 2 -> 3 -> 4 -> 4 -> 5 -> 6
*/

/**
 * Definition for singly-linked list.
 * function ListNode(val, next) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.next = (next===undefined ? null : next)
 * }
 */
/**
 * @param {ListNode[]} lists
 * @return {ListNode}
 */
var mergeKLists = function (lists) {

    let currentlist = lists[0];
    for (let x = 1; x < lists.length; x++) {
        currentlist = mergeTwoLists(currentlist, lists[x]);
    }

    return currentlist || null;
};

function mergeTwoLists(l1, l2) {
    let node = new ListNode(-1);
    let startnode = node;

    while (l1 && l2) {
        if (l1.val < l2.val) {
            node.next = l1;
            l1 = l1.next;
        } else {
            node.next = l2;
            l2 = l2.next;
        }
        node = node.next;
    }

    if (l1) {
        node.next = l1;
    } else {
        node.next = l2;
    }

    return startnode.next;
};