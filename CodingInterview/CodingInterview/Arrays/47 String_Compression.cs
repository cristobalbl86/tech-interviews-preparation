using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodingInterview
{
    /*
     443. String Compression

Share
Given an array of characters, compress it in-place.
The length after compression must always be smaller than or equal to the original array.
Every element of the array should be a character (not int) of length 1.
After you are done modifying the input array in-place, return the new length of the array.

Follow up:
Could you solve it using only O(1) extra space?

 
Example 1:
Input:
["a","a","b","b","c","c","c"]
Output:
Return 6, and the first 6 characters of the input array should be: ["a","2","b","2","c","3"]
Explanation:
"aa" is replaced by "a2". "bb" is replaced by "b2". "ccc" is replaced by "c3".
 
Example 2:
Input:
["a"]
Output:
Return 1, and the first 1 characters of the input array should be: ["a"]
Explanation:
Nothing is replaced.
 
Example 3:
Input:
["a","b","b","b","b","b","b","b","b","b","b","b","b"]
Output:
Return 4, and the first 4 characters of the input array should be: ["a","b","1","2"].
Explanation:
Since the character "a" does not repeat, it is not compressed. "bbbbbbbbbbbb" is replaced by "b12".
Notice each digit has it's own entry in the array.
         
         */

    class _47_String_Compression
    {
        public static int Compress(char[] chars)
        {
            /*
             * Input
["a","a","a","b","b","a","a"]
Output
["a","5","b","2"]
Expected
["a","3","b","2","a","2"]
             * 
             * 
             * 
            int idx = 0;
            var temparr = chars.GroupBy(c => c).Select(c => new { Char = c.Key, Counter = c.Count() }).ToArray();
            foreach (var item in temparr)
            {
                chars[idx++] = Convert.ToChar(item.Char);
                if(item.Counter > 1){
                    foreach(char c in item.Counter.ToString().ToCharArray()){
                        chars[idx++] = c;
                    }
                }
            }

            return idx;
            */

            int index = 0, resIndex = 0;

            while (index < chars.Length)
            {
                char curr = chars[index];
                int cnt = 0;

                while (index < chars.Length && chars[index] == curr)
                {
                    cnt++;
                    index++;
                }

                chars[resIndex] = curr;
                resIndex++;

                if (cnt > 1)
                {
                    foreach (char c in cnt.ToString().ToCharArray())
                    {
                        chars[resIndex] = c;
                        resIndex++;
                    }
                }
            }

            return resIndex;

        }
    }
}
