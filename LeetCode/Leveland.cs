using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class Leveland
    {
        public static int GetResult(int[] ground)
        {
            int totalOperations = 0;
            int maxGround = GetMaxGround(ground);

            while (!IsLeveled(ground))
            {
                int minIndex = GetMinIndex(ground);
                int maxIndex = GetMaxIndex(ground);
                int diff = ground[maxIndex] - ground[minIndex];
                totalOperations += diff;
                ground[maxIndex] -= diff;
            }

            return totalOperations;
        }

        private static int GetMaxGround(int[] ground)
        {
            int maxGround = 0;

            for (int i = 0; i < ground.Length; i++)
            {
                maxGround = Math.Max(maxGround, ground[i]);
            }

            return maxGround;
        }

        private static bool IsLeveled(int[] ground)
        {
            int firstHeight = ground[0];

            for (int i = 1; i < ground.Length; i++)
            {
                if (ground[i] != firstHeight)
                {
                    return false;
                }
            }

            return true;
        }

        private static int GetMinIndex(int[] ground)
        {
            int minIndex = 0;

            for (int i = 0; i < ground.Length; i++)
            {
                if (ground[i] < ground[minIndex])
                {
                    minIndex = i;
                }
            }

            return minIndex;
        }

        private static int GetMaxIndex(int[] ground)
        {
            int maxIndex = 0;

            for (int i = 0; i < ground.Length; i++)
            {
                if (ground[i] > ground[maxIndex])
                {
                    maxIndex = i;
                }
            }

            return maxIndex;
        }
    }
}