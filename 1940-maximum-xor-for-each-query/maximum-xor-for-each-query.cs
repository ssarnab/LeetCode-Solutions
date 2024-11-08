public class Solution {
    public int[] GetMaximumXor(int[] nums, int maximumBit) {
        int n = nums.Length;
        int maxK = (1 << maximumBit) - 1;
        int[] answer = new int[n];
        int cumulativeXor = 0;

        foreach (int num in nums) {
            cumulativeXor ^= num;
        }
        for (int i = 0; i < n; i++) {
            answer[i] = cumulativeXor ^ maxK; 
            cumulativeXor ^= nums[n - 1 - i]; 
        }

        return answer;
    }
}
