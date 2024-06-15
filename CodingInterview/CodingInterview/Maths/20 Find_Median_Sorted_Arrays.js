/*
 * 4. Median of Two Sorted Arrays - LeetCode
There are two sorted arrays nums1 and nums2 of size m and n respectively.

Find the median of the two sorted arrays.The overall run time complexity should be O(log(m + n)).

You may assume nums1 and nums2 cannot be both empty.

    Example 1:

nums1 = [1, 3]
nums2 = [2]

The median is 2.0
Example 2:

nums1 = [1, 2]
nums2 = [3, 4]

The median is(2 + 3) / 2 = 2.5
*/
/**
 * @param {number[]} nums1
 * @param {number[]} nums2
 * @return {number}
 */
var findMedianSortedArrays = function (nums1, nums2) {

    let numbers = [...nums1, ...nums2];

    numbers.sort((a, b) => a - b);

    let st = 0;
    let ed = numbers.length - 1;

    while (st <= ed) {
        if (st === ed) {
            return numbers[st];
        }

        st++;
        ed--;
    }

    return ((numbers[st - 1] + numbers[ed + 1]) / 2);

};