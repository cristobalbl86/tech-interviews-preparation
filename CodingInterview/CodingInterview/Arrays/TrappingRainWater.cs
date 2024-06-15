using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Arrays
{
    class TrappingRainWater
    {
        public int Trap(int[] height)
        {
            //BRUTE FORCE
            //check max left and right buildings
            //take the min and compare against current value
            //summarize the diff into a totalwater var

            int totalwater = 0;

            for (int i = 0; i < height.Length; i++)
            {

                int maxL = 0;
                int l = i - 1;
                while (l >= 0)
                {
                    maxL = Math.Max(maxL, height[l]);
                    l--;
                }

                int maxR = 0;
                int r = i + 1;
                while (r < height.Length)
                {
                    maxR = Math.Max(maxR, height[r]);
                    r++;
                }

                int minB = Math.Min(maxL, maxR);

                if (minB > height[i])
                {
                    totalwater += (minB - height[i]);
                }
            }

            return totalwater;
        }
        public int Trap_2(int[] height)
        {
            /*
                T= O(n)
                S= O(n)
             */
            //brute force
            //check max left and right buildings
            //take the min and compare against current value
            //summarize the diff into a totalwater var

            if (height == null || height.Length == 0) return 0;

            int totalwater = 0;

            //precompute maximums
            int[] mleft = new int[height.Length];
            int[] mright = new int[height.Length];

            mleft[0] = height[0];
            for (int i = 1; i < height.Length; i++)
            {
                mleft[i] = Math.Max(mleft[i - 1], height[i]);
            }

            mright[height.Length - 1] = height[height.Length - 1];
            for (int i = height.Length - 2; i >= 0; i--)
            {
                mright[i] = Math.Max(mright[i + 1], height[i]);
            }

            for (int i = 0; i < height.Length; i++)
            {

                int minB = Math.Min(mleft[i], mright[i]);

                if (minB > height[i])
                {
                    totalwater += (minB - height[i]);
                }
            }

            return totalwater;
        }
    }
}
