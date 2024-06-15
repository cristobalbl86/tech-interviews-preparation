using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview
{
    class _52_Jewels_Stones
    {
        /*
771. Jewels and Stones
Easy
You're given strings J representing the types of stones that are jewels, and S representing the stones you have.  Each character in S is a type of stone you have.  You want to know how many of the stones you have are also jewels.

The letters in J are guaranteed distinct, and all characters in J and S are letters. Letters are case sensitive, so "a" is considered a different type of stone from "A".

Example 1:

Input: J = "aA", S = "aAAbbbb"
Output: 3
Example 2:

Input: J = "z", S = "ZZ"
Output: 0
Note:

S and J will consist of letters and have length at most 50.
The characters in J are distinct.         
             */
        public int NumJewelsInStones(string J, string S)
        {

            if (J == null || S == null)
                return 0;

            int count = 0;
            foreach (var s in S)
            {
                if (J.IndexOf(s) > -1)
                {
                    count++;
                }
            }

            return count;

        }

        public int NumJewelsInStones2(string jewels, string stones)
        {

            int count = 0;
            for (int i = 0; i < stones.Length; i++)
            {
                if (jewels.IndexOf(stones[i]) != -1)
                    count++;
            }
            return count;
        }
    }
}
