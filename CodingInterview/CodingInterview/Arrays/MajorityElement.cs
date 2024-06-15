using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Arrays
{
    class MajorityElement
    {
        public int MajorityElement_MooreVoting(int[] nums)
        {
            //Approach: Moore's Voting algorithm
            //T=O(n)
            //S=O(1)

            int maj = nums[0];
            int count = 1;

            for(int i=1;i<nums.Length; i++){
                if(nums[i] == maj){
                    count++;
                }else{
                    count--;
                    if(count == 0){
                        maj = nums[i];
                        count = 1;
                    }
                }
            }
            return maj;
        }

        public static int MajorityElement_HashMap(int[] nums)
        {
            //Approach: HashMap
            //T=O(n)
            //S=O(n)

            int maj = 0;
            int count = 0;

            Hashtable ht = new Hashtable();
            for (int i = 0; i < nums.Length; i++)
            {
                if (ht.ContainsKey(nums[i]))
                    ht[nums[i]] = (int)ht[nums[i]] + 1;
                else
                    ht.Add(nums[i], 1);
            }

            foreach (DictionaryEntry pair in ht)
            {
                if ((int)pair.Value > count)
                {
                    maj = (int)pair.Key;
                    count = (int)pair.Value;
                }
            }

            return maj;
        }
    }
}

/*
 169. Majority Element
Easy

Given an array nums of size n, return the majority element.

The majority element is the element that appears more than ⌊n / 2⌋ times. You may assume that the majority element always exists in the array.

Example 1:

Input: nums = [3,2,3]
Output: 3
Example 2:

Input: nums = [2,2,1,1,1,2,2]
Output: 2
 
Constraints:

n == nums.length
1 <= n <= 5 * 104
-231 <= nums[i] <= 231 - 1
 
Follow-up: Could you solve the problem in linear time and in O(1) space?
 */