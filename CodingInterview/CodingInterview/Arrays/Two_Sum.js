/**
 * TWO SUM
Given an array of integers, return indices of the two numbers such that they add up to a specific target.
You may assume that each input would have exactly one solution, and you may not use the same element twice.

Example:
Given nums = [2, 7, 11, 15], target = 9,

Because nums[0] + nums[1] = 2 + 7 = 9,
return [0, 1].
 */


/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */
var twoSum = function (nums, target) {

    //MY APPORACH - WORST THAN FORCE BRUTE :(
    let ids = [];
    let pos1 = 0;
    let pos2 = 0;

    for (let n of nums) {
        for (let n2 of nums) {
            if (pos1 === pos2) {
                pos2++;
                continue;
            }

            if (n + n2 === target) {
                ids.push(nums.indexOf(n));
                if (n === n2)
                    ids.push(nums.lastIndexOf(n2));
                else
                    ids.push(nums.indexOf(n2));
                return ids;
            }
            pos2++;
        }
        pos2 = 0;
        pos1++;
    }

    /*
Approach 2: Two-pass Hash Table
To improve our run time complexity, we need a more efficient way to check if the complement exists in the array. If the complement exists, 
we need to look up its index. What is the best way to maintain a mapping of each element in the array to its index? A hash table.

We reduce the look up time from O(n) to O(1)by trading space for speed. A hash table is built exactly for this purpose, it supports fast 
look up in near constant time. I say "near" because if a collision occurred, a look up could degenerate to O(n) time. But look up in hash table 
should be amortized O(1) time as long as the hash function was chosen carefully.

A simple implementation uses two iterations. In the first iteration, we add each element's value and its index to the table. Then, in the second 
iteration we check if each element's complement (target - nums[i]target−nums[i]) exists in the table. Beware that the complement must not be 
nums[i]nums[i] itself!
     */

    //Solution #1 - Using Map (hashtable)
    let iMap = {};

    for (let n = 0; n < nums.length; n++) {
        iMap[nums[n]] = n;
    }

    for (let idx = 0; idx < nums.length; idx++) {
        let rest = target - nums[idx];
        if (iMap[rest] && iMap[rest] !== idx) {
            return [] = [idx, iMap[rest]];
        }
    }

};