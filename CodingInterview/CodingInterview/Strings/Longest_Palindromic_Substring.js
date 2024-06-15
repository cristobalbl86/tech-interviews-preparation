/*
5. Longest Palindromic Substring - LeetCode
Given a string s, find the longest palindromic substring in s.You may assume that the maximum length of s is 1000.

Example 1:
Input: "babad"
Output: "bab"
Note: "aba" is also a valid answer.

Example 2:
Input: "cbbd"
Output: "bb"
*/

/**
 * @param {string} s
 * @return {string}
 */
var longestPalindrome = function (s) {

    if (!s)
        return '';
    else if (s.length <= 1)
        return s;

    let word = '';
    let palindrome = '';

    for (let i = 0; i < s.length; i++) {

        for (let j = i + 1; j < s.length; j++) {
            word = s.substr(i, (j - i) + 1);

            if (IsPalindrome(word) && word.length > palindrome.length) {
                palindrome = word;
            }
        }

        if (palindrome.length === 0)
            palindrome = s[i];
    }

    return palindrome;
};

function IsPalindrome(s) {
    let result = '';
    for (let l of s) {
        result = l + result;
    }
    return result === s;
}


//BEST APPROACH ************************************************
var longestPalindrome = function (s) {

    let maxpalindrome = '';

    for (let i = 0; i < s.length; i++) {
        maxpalindrome = checkPalindrome(s, maxpalindrome, i, i);
        maxpalindrome = checkPalindrome(s, maxpalindrome, i, i + 1);
    }

    return maxpalindrome;
}

function checkPalindrome(s, maxpalindrome, left, right) {
    while (s[left] && s[left] === s[right]) {
        left--;
        right++;
    }

    if (right - left - 1 > maxpalindrome.length) {
        return s.substring(left + 1, right);
    }

    return maxpalindrome;
}