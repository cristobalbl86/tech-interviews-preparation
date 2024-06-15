using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Amazon
{
    public class interval {
        public int start;
        public int end;
        public interval(int start, int end) {
            this.start = start;
            this.end = end;
        }
    }
    class MeetingRoomsII
    {
        /*
         TWO POINTERS APROACH, I & J
            T = O(m+n)
            S = O(m+n)
         */
        public static int minMeetingRooms(interval[] intervals)
        {
            int n = intervals.Length;

            int[] starts = new int[n];
            int[] ends = new int[n];

            int i = 0;
            foreach (interval interval in intervals)
            {
                starts[i] = interval.start;
                ends[i++] = interval.end;
            }

            Array.Sort(starts);
            Array.Sort(ends);

            int s = 0, e = 0, rooms = 0, max = 0;
            while (s < n && e < n)
            {
                if (starts[s] < ends[e])
                {
                    rooms++;
                    s++;
                }
                else
                {
                    rooms--;
                    e++;
                }

                max = Math.Max(max, rooms);
            }

            return max;
        }
    }
}
/*
 0,30 5,10 15,20
2

7,10 2,4
1

         i
0, 5, 15
10,20,50
   j

2

max = 2

 */

/*
 TEST CASES

//TEST #1 *******************************
interval[] intervals = new interval[3];
		
intervals[0] = new interval(0,30);
intervals[1] = new interval(5,10);
intervals[2] = new interval(15,20);
		
int rooms = minMeetingRooms(intervals);
		
Console.WriteLine(rooms);
	
//TEST #2 ******************************
interval[] intervals2 = new interval[2];
		
intervals2[0] = new interval(7,10);
intervals2[1] = new interval(2,4);
		
rooms = minMeetingRooms(intervals2);
		
Console.WriteLine(rooms);

 */
