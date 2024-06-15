/**
 * 14. Longest Common Prefix - Leet Code
 * 
 Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string "".

Example 1:

Input: ["flower","flow","flight"]
Output: "fl"
Example 2:

Input: ["dog","racecar","car"]
Output: ""
Explanation: There is no common prefix among the input strings.
Note:

All given inputs are in lowercase letters a-z.
 */

/**
 * @param {string[]} strs
 * @return {string}
 */
var longestCommonPrefix = function (strs) {
    let commonPrefix = '';

    if (strs === null || strs.length === 0)
        return commonPrefix;

    let idx = 0;
    for (let c of strs[0]) {

        for (let str = 1; str < strs.length; str++) {
            if (idx >= strs[str].length || c !== strs[str][idx]) {
                return commonPrefix;
            }
        }

        commonPrefix += c;
        idx++;
    }

    return commonPrefix;
};