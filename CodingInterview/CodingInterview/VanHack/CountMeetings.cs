using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.VanHack
{
    class CountMeetings
    {
        public static int countMeetings(List<int> firstDay, List<int> lastDay)
        {
            HashSet<int> scheduled = new HashSet<int>();

            for (int i = 0; i < firstDay.Count; i++)
            {
                for (int j = firstDay[i]; j <= lastDay[i]; j++)
                {
                    if (!scheduled.Contains(j))
                    {
                        scheduled.Add(j);
                        break;
                    }
                }
            }

            return scheduled.Count;

        }
    }
}
/*
 
 */