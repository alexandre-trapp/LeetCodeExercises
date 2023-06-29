namespace LeetCode
{
    public static class ChestTreasury
    {
        static int CalculateMaximumTreasure(int[] chests, int currentIndex, int remainingAttempts, int[,] maxTreasures)
        {
            if (currentIndex >= chests.Length || remainingAttempts <= 0)
            {
                return 0;
            }

            if (maxTreasures[currentIndex, remainingAttempts] >= 0)
            {
                return maxTreasures[currentIndex, remainingAttempts];
            }

            int currentTreasure = chests[currentIndex];
            
            int takeCurrent = CalculateMaximumTreasure(chests, currentIndex + 1, remainingAttempts - 2, maxTreasures) + currentTreasure;
            int skipCurrent = CalculateMaximumTreasure(chests, currentIndex + 1, remainingAttempts - 1, maxTreasures);

            int maxTreasure = Math.Max(takeCurrent, skipCurrent);
            maxTreasures[currentIndex, remainingAttempts] = maxTreasure;
            
            return maxTreasure;
        }

        public static int GetResult(int[] chests, int remainingAttempts)
        {
            int[,] maxTreasures = new int[chests.Length, remainingAttempts + 1];
            for (int i = 0; i < chests.Length; i++)
            {
                for (int j = 0; j < remainingAttempts + 1; j++)
                {
                    maxTreasures[i, j] = -1;
                }
            }

            return CalculateMaximumTreasure(chests, 0, remainingAttempts, maxTreasures);
        }
    }
}