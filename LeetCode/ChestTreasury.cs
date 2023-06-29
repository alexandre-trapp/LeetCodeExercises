namespace LeetCode
{
    public static class ChestTreasury
    {
        public static int GetResult(int[] chests, int t)
        {
            int chestsSize = chests.Length;
            int[,] maxTreasures = new int[chestsSize + 1, t + 1];

            for (int i = 1; i <= chestsSize; i++)
            {
                for (int j = 1; j <= t; j++)
                {
                    maxTreasures[i, j] = maxTreasures[i - 1, j]; // Carry forward the previous maximum

                    if (j >= i)
                    {
                        maxTreasures[i, j] = Math.Max(maxTreasures[i, j], maxTreasures[i - 1, j - i] + chests[i - 1]); // Take current chest and add to the previous maximum
                    }
                }
            }

            return maxTreasures[chestsSize, t];
        }
    }
}
