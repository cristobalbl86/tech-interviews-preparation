/*
 * 40. Combination sum II
Given a collection of candidate numbers(candidates) and a target number(target), find all unique combinations in candidates where the candidate numbers sums to target.

Each number in candidates may only be used once in the combination.

    Note:

All numbers(including target) will be positive integers.
The solution set must not contain duplicate combinations.
    Example 1:

Input: candidates = [10, 1, 2, 7, 6, 1, 5], target = 8,
    A solution set is:
[
    [1, 7],
    [1, 2, 5],
    [2, 6],
    [1, 1, 6]
]
Example 2:

Input: candidates = [2, 5, 2, 1, 2], target = 5,
    A solution set is:
[
    [1, 2, 2],
    [5]
]
*/

/**
 * @param {number[]} candidates
 * @param {number} target
 * @return {number[][]}
 */
var combinationSum2 = function (candidates, target) {

    candidates.sort((a, b) => a - b);

    let res = [];
    let dfs = function (id, n, comb) {
        if (n == 0) {
            res.push(comb);
            return;
        }

        for (let i = id; i < candidates.length; i++) {
            if (candidates[i] <= n) {
                dfs(i + 1, n - candidates[i], [...comb, candidates[i]]);
            }
            while (candidates[i + 1] == candidates[i]) //to prevent repeated combinations
                i++;
        }
        return res;
    }

    dfs(0, target, []);
    return res;

};