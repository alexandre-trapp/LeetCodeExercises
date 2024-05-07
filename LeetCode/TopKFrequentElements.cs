namespace LeetCode
{
    public static class TopKFrequentElements
    {
        public static int[] TopKFrequent(int[] nums, int k)
        {
            int[] result = new int[k];
            var dictNums = new Dictionary<int, int>();
                
            for (int i = 0; i < nums.Length; i++)
            {
                if (dictNums.ContainsKey(nums[i]))
                {
                    dictNums[nums[i]]++;
                }
                else
                {
                    dictNums.Add(nums[i], 1);
                }
            }

            var pQueue = new PriorityQueue<int, int>();
            foreach (var key in dictNums.Keys)
            {
                pQueue.Enqueue(key, dictNums[key]);
                if (pQueue.Count > k) pQueue.Dequeue();
            }

            int i2 = k;
            while (pQueue.Count > 0)
            {
                result[--i2] = pQueue.Dequeue();
            }

            return result;
        }
    }
}
