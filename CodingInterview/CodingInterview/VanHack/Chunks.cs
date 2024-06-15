using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.VanHack
{
    class Chunks
    {
        public static string[] Chunk(string s, int chunks)
        {
            List<string> current = new List<string>();

            int _size = s.Length / chunks;
            int _extra = s.Length % chunks;

            string item = string.Empty;
            int pos = 0;

            while (pos < s.Length)
            {
                if (_extra == 0)
                {
                    item = s.Substring(pos, _size);
                    pos = pos + _size;
                }
                else
                {
                    item = s.Substring(pos, _size + 1);
                    pos = pos + _size + 1;
                    _extra--;
                }
                current.Add(item);
            }

            return current.ToArray();
        }
    }
}
/*
 Task
In this challenge, you'll complete two functions to split a string into evenly-sized chunks. One function will return an iterator while the other will return a primitive array of the resulting chunks.

The procedures to perform the chunking should take two parameters, s and chunks, where s is the source string to chunk and chunks is the number of chunks the result array should contain.

If the string cannot be partitioned evenly, excess characters should be distributed starting from the beginning of the list. The final array should have all pairs such that the length difference between any two elements is no greater than 1.

Here is the class skeleton to flesh out, which is located in ./src/Chunker.cs in your workspace:

public class Chunker 
{
    public static IEnumerable<string> ChunkIter(string s, int chunks) {}
    public static string[] Chunk(string s, int chunks) {}
}
Argument constraints:

Strings may be comprised of any characters in the ASCII range.
0 ≤ s.Length ≤ 106
-1 ≤ chunks ≤ 106
If fewer than 1 chunks are specified, throw an ArgumentException.
If more chunks are specified than the string has the capacity to handle, assume chunks == s.Length.
If s is an empty string and chunks > 0, return an empty array.
Examples
Given the string s = "abcdefg" and chunks = 3, return ["abc", "de", "fg"]. Note that the remainder of 1 was distributed to the first element in the list.

Given the string s = "abcdefgh" and chunks = 3, return ["abc", "def", "gh"]. Again, note that the remainder of 2 was distributed to the first element in the list followed by the second element in the list.

s="abcde", chunks=0 → throws ArgumentException
s="abcde", chunks=1 → ["abcde"]
s="abcde", chunks=2 → ["abc", "de"]
s="abcde", chunks=3 → ["ab", "cd", "e"]
s="abcde", chunks=4 → ["ab", "c", "d", "e"]
s="abcde", chunks=5 → ["a", "b", "c", "d", "e"]
s="abcde", chunks=6 → ["a", "b", "c", "d", "e"]
s="abcdefghijklm", chunks=4 → ["abcd", "efg", "hij", "klm"]
s="abcdefghijklm", chunks=5 → ["abc", "def", "ghi", "jk", "lm"]
 */
