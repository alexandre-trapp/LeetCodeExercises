using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class FindTargetIndex
    {
        public static int FindTargetIndexArrayFromValue(int[] nums, int value)
        {
            if (nums.Length == 0)
                return -1;

            var left = 0;
            var right = nums.Length - 1;
            int middle = (left + right) /2;

            int index = -1;
            while (index < 0)
            {
                if (left > right) return index;

                if (nums[left] == value) return left;

                else if (nums[right] == value) return right;

                else if (nums[middle] == value) return middle;

                if (middle == 0 || left == right) return index;

                left++;
                right--;
                middle = middle/2;
            }

            return index;
        }
    }
}
