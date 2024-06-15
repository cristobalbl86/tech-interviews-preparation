using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingInterview
{
    class _60_Min_Cost_Connect_Sticks
    {
        public static int connectSticks(int[] sticks) {
            int cost = 0;

            List<int> list = new List<int>();
            foreach (int val in sticks) {
                list.Add(val);
            }

            while (list.Count > 1) {
                list = list.OrderBy(key => key).ToList();
                int sum = list[0] + list[1];
                list.RemoveAt(0);
                list.RemoveAt(0);

                list.Add(sum);

                cost += sum;
            }

            return cost;

        }
    }
}
