namespace LeetCode;

public static class TwoSumArray
{
    public static int[] TwoSumBruteForce(int[] nums, int target)
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

    public static int[] TwoSumHashMap1(int[] nums, int target)
    {
        var items = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (items.ContainsKey(target - nums[i]))
                return new int[] { i, items[target - nums[i]] };

            else if (!items.ContainsKey(nums[i]))
                items.Add(nums[i], i);
        }

        return new int[2];
    }

    public static int[] TwoSumHashMap2(int[] nums, int target)
    {
        var resultDict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
            if (!resultDict.ContainsKey(nums[i]))
                resultDict.Add(nums[i], i);

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (resultDict.ContainsKey(complement) && resultDict[complement] != i)
                return new int[] { i, resultDict[complement] };
        }

        return new int[2];
    }

    public static int[] TwoSumHashMap3(int[] nums, int target)
    {
        var resultDict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int resultNum = target - nums[i];

            if (resultDict.ContainsKey(resultNum))
            {
                var result = new int[] { resultDict[resultNum], i };
                return result;
            }

            if (!resultDict.ContainsKey(nums[i]))
                resultDict.Add(nums[i], i);
        }
        return new int[2];
    }

    public static int[] TwoSumHashMap4(int[] nums, int target)
    {
        var complement = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (complement.ContainsKey(nums[i]))
                return new int[] { complement[nums[i]], i };

            else if (!complement.ContainsKey(target - nums[i]))
                complement.Add(target - nums[i], i);
        }

        return new int[2];
    }

    public static int[] TwoSumHashMap5(int[] nums, int target)
    {
        var items = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (items.ContainsKey(target - nums[i]))
                return new int[] { i, items[target - nums[i]] };

            else if (!items.ContainsKey(nums[i]))
                items.Add(nums[i], i);
        }

        return new int[2];
    }
}
