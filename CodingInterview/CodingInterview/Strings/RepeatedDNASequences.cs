using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Strings
{
    class RepeatedDNASequences
    {
        /*
         * TWO HASHSETS APPROACH
         * T= O(n-10)
         * S= O(n-10)
         */
        public IList<string> FindRepeatedDnaSequences(string s)
        {
            var hs = new HashSet<string>();
            var hsrep = new HashSet<string>();

            for (int i = 0; i + 9 < s.Length; i++)
            {
                string chunk = s.Substring(i, 10);
                if (hs.Contains(chunk))
                {
                    if (!hsrep.Contains(chunk))
                        hsrep.Add(chunk);
                }
                else
                    hs.Add(chunk);
            }

            return new List<string>(hsrep);
        }
    }
}
/*
                 i        |
AAAAACCCCCAAAAACCCCCCAAAAAGGGTTT

hashSet
*AAAAACCCCC
AAAACCCCCA
AAACCCCCAA
AACCCCCAAA
ACCCCCAAAA
CCCCCAAAAA
CCCCAAAAAC
CCCAAAAACC
CCAAAAACCC
CAAAAACCCC
AAAACCCCCC
AAACCCCCCA
AACCCCCCAA
ACCCCCCAAA
CCCCCCAAAA


hsRep
AAAAACCCCC
CCCCCAAAAA

*/
/*
 187. Repeated DNA Sequences
Medium

The DNA sequence is composed of a series of nucleotides abbreviated as 'A', 'C', 'G', and 'T'.

For example, "ACGAATTCCG" is a DNA sequence.
When studying DNA, it is useful to identify repeated sequences within the DNA.

Given a string s that represents a DNA sequence, return all the 10-letter-long sequences (substrings) that occur more than once in a DNA molecule. You may return the answer in any order.

 

Example 1:

Input: s = "AAAAACCCCCAAAAACCCCCCAAAAAGGGTTT"
Output: ["AAAAACCCCC","CCCCCAAAAA"]
Example 2:

Input: s = "AAAAAAAAAAAAA"
Output: ["AAAAAAAAAA"]
 

Constraints:

1 <= s.length <= 105
s[i] is either 'A', 'C', 'G', or 'T'.*/
