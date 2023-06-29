namespace LeetCode
{
    public static class ChestTreasury
    {
        public static int GetResult(int[] chests, int t)
        {
            int chestsSize = chests.Length;
            int[,] maxTreasures = new int[chestsSize, t + 1];

            for (int j = 1; j <= t; j++)
            {
                if (j >= 1)
                {
                    maxTreasures[0, j] = chests[0];
                }
            }

            for (int i = 1; i < chestsSize; i++)
            {
                for (int j = 1; j <= t; j++)
                {
                    maxTreasures[i, j] = maxTreasures[i - 1, j];
                    if (j >= i + 1)
                    {
                        maxTreasures[i, j] = Math.Max(maxTreasures[i, j], maxTreasures[i - 1, j - (i + 1)] + chests[i]);
                    }
                }
            }

            return maxTreasures[chestsSize - 1, t];
        }
    }
}
