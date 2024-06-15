using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Arrays
{
    class SubArraySumEqualsK
    {
        public int SubarraySum(int[] nums, int k)
        {
            /*
            //MY APPROACH - NOT WORKING FOR ALL CASES

            if(nums == null || nums.Length == 0) return 0;

            if(nums.Length == 1 && nums[0] == k) return k;

            int sum = 0;
            int count = 0;
            for(int i = 0; i < nums.Length; i++){

                sum += nums[i];

                Console.WriteLine(sum);

                if(sum == k){
                    count++;
                    sum = nums[i];
                }

                if(nums[i] == k){
                    count++;
                }else if(sum > k){
                    sum = nums[i];
                }
            }

            if(sum == k) count++;

            return count;
            */

            /*
            BRUTE FORCE - TIME LIMIT EXCEEDED
            */
            /*
            int count = 0;
            for(int i = 0;  i < nums.Length; i++){
                int sum = nums[i];    
                if(sum == k){
                    count++;
                    //continue;
                }

                for(int j = i+1; j < nums.Length; j++){

                    sum += nums[j];

                    if(sum == k) {
                        count++;
                        //break;
                    }
                }

            }

            return count;
            */

            /*
             DICTIONARY APPROACH
            */
            Dictionary<int, int> sumCount = new Dictionary<int, int>();
            int result = 0;
            int sum = 0;
            sumCount.Add(0, 1);
            foreach (int n in nums)
            {
                // compute sum at each index
                sum += n;
                // if (current sum - k) exists in dictionary then it means we have sum equal to k between two indices
                if (sumCount.ContainsKey(sum - k))
                    result += sumCount[sum - k];
                // add current sum to dic 
                //if it already exists increment count else add new with count set to 1
                if (sumCount.ContainsKey(sum))
                    sumCount[sum] += 1;
                else
                    sumCount.Add(sum, 1);
            }

            return result;
        }
    }
}

/*
 560. Subarray Sum Equals K
Medium

Given an array of integers nums and an integer k, return the total number of continuous subarrays whose sum equals to k.

Example 1:

Input: nums = [1,1,1], k = 2
Output: 2
Example 2:

Input: nums = [1,2,3], k = 3
Output: 2
 

Constraints:

1 <= nums.length <= 2 * 104
-1000 <= nums[i] <= 1000
-107 <= k <= 107
 */