using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodingInterview
{
    class _54_Sort_Array_By_Parity
    {
        /*
905. Sort Array By Parity
Easy

Given an array A of non-negative integers, return an array consisting of all the even elements of A, followed by all the odd elements of A.

You may return any answer array that satisfies this condition.


Example 1:

Input: [3,1,2,4]
Output: [2,4,3,1]
The outputs [4,2,3,1], [2,4,1,3], and [4,2,1,3] would also be accepted.
 

Note:
1 <= A.length <= 5000
0 <= A[i] <= 5000         
             */
        public int[] SortArrayByParity(int[] A)
        {

            //LINQ approach
            /*
            int[] even = A.Where(n=> n % 2 == 0).ToArray();
            int[] odd = A.Where(n=> n%2 != 0).ToArray();

            return even.Concat(odd).ToArray();
            */

            //ITERATIVE APPROACH
            int orderidx = 0;

            for (int x = 0; x < A.Length; x++)
            {
                if (A[x] % 2 == 0)
                {
                    int temp = A[orderidx];
                    A[orderidx++] = A[x];
                    A[x] = temp;
                }
            }

            return A;

        }

        public int[] SortArrayByParity_(int[] A)
        {
            /**
                T= O(n)
                S= O(1)
             */
            int evens = 0;

            for (int i = 0; i < A.Length; i++)
            {

                if (A[i] % 2 == 0)
                {
                    int temp = A[i];
                    A[i] = A[evens];
                    A[evens] = temp;

                    evens++;
                }
            }
            return A;
        }
    }
}
