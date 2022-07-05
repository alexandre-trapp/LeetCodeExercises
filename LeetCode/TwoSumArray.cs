namespace LeetCode;

public static class TwoSumArray
{
    public static int[] TwoSum(int[] nums, int target)
    {
        var result = new List<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            for (int n = 0; n < nums.Length; n++)
            {
                if (i == n)
                    continue;

                int sum = nums[i] + nums[n];
                if (sum == target)
                {
                    result.Add(i);
                    result.Add(n);

                    return result.ToArray();
                }
            }
        }

        return result.ToArray();
    }
}
