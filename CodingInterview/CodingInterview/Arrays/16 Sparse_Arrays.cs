using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview
{
    class _16_Sparse_Arrays
    {
        /*
         * SPARSE ARRAYS - HACKERRANK
         * There is a collection of input strings and a collection of query strings. For each query string, determine how many times it occurs 
         * in the list of input strings.
            For example, given input  and , we find  instances of ',  of '' and  of ''. For each query, we add an element to our return array, .
         */
        static int[] matchingStrings(string[] strings, string[] queries)
        {
            int[] results = new int[queries.Length];
            int count = 0;
            int pos = 0;
            foreach (var q in queries)
            {
                foreach (var item in strings)
                {
                    if (item.ToString() == q)
                        count++;
                }
                results[pos] += count;
                count = 0;
                pos++;
            }

            return results;
        }
    }
}
