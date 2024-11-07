public class Solution {
    public int LargestCombination(int[] candidates) {
        // Maximum bit length we need to consider is 24 (since 10^7 < 2^24)
        int maxBitLength = 24;
        int[] bitCount = new int[maxBitLength];
        
        // For each candidate, count the number of 1's in each bit position
        foreach (int num in candidates) {
            for (int i = 0; i < maxBitLength; i++) {
                if ((num & (1 << i)) != 0) {
                    bitCount[i]++;
                }
            }
        }
        
        // Find the maximum count of 1's in any bit position
        int maxCombinationSize = 0;
        foreach (int count in bitCount) {
            maxCombinationSize = Math.Max(maxCombinationSize, count);
        }
        
        return maxCombinationSize;
    }
}
