﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingInterview
{
    class _56_K_Closest_Points_Origin
    {
        /*
         973. K Closest Points to Origin
Medium
We have a list of points on the plane.  Find the K closest points to the origin (0, 0).

(Here, the distance between two points on a plane is the Euclidean distance.)

You may return the answer in any order.  The answer is guaranteed to be unique (except for the order that it is in.)

Example 1:

Input: points = [[1,3],[-2,2]], K = 1
Output: [[-2,2]]
Explanation: 
The distance between (1, 3) and the origin is sqrt(10).
The distance between (-2, 2) and the origin is sqrt(8).
Since sqrt(8) < sqrt(10), (-2, 2) is closer to the origin.
We only want the closest K = 1 points from the origin, so the answer is just [[-2,2]].
Example 2:

Input: points = [[3,3],[5,-1],[-2,4]], K = 2
Output: [[3,3],[-2,4]]
(The answer [[-2,4],[3,3]] would also be accepted.)
 
Note:

1 <= K <= points.length <= 10000
-10000 < points[i][0] < 10000
-10000 < points[i][1] < 10000
             */
        public int[][] KClosest(int[][] points, int K)
        {
            Dictionary<int[], int> dict = new Dictionary<int[], int>();

            for (int x = 0; x < points.Length; x++)
            {
                dict.Add(
                    points[x],
                    (points[x][0] * points[x][0]) + (points[x][1] * points[x][1])
                );
            }

            //FIRST APPROACH LINQ
            //return dict.OrderBy(p => p.Value).Select(p => p.Key).Take(K).ToArray();
            
            
            //MANUAL RETURN , BUILD ARRAY
            int count = 0;
            int[][] result = new int[K][];
            foreach (KeyValuePair<int[], int> de in dict.OrderBy(d => d.Value)) {
                if (count < 3) {
                    result[count] = de.Key;
                    count++;
                }
            }

            return result;
        }
    }
}
