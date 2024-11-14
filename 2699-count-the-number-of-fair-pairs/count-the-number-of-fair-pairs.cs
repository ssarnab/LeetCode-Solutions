
public class Solution {
    public long CountFairPairs(int[] nums, int lower, int upper) {
        Array.Sort(nums);
        long count = 0;

        for (int i = 0; i < nums.Length - 1; i++) {
            int left = i + 1, right = nums.Length - 1;

            // Find the smallest index where nums[i] + nums[left] >= lower
            int start = BinarySearch(nums, left, right, lower - nums[i], true);
            // Find the largest index where nums[i] + nums[right] <= upper
            int end = BinarySearch(nums, left, right, upper - nums[i], false);

            // Add the number of valid pairs
            if (start != -1 && end != -1 && start <= end) {
                count += (end - start + 1);
            }
        }

        return count;
    }

    private int BinarySearch(int[] nums, int left, int right, int target, bool findLowerBound) {
        int result = -1;
        
        while (left <= right) {
            int mid = left + (right - left) / 2;
            if (nums[mid] < target) {
                left = mid + 1;
            } else if (nums[mid] > target) {
                right = mid - 1;
            } else {
                result = mid;
                if (findLowerBound) {
                    right = mid - 1;  // continue searching left
                } else {
                    left = mid + 1;   // continue searching right
                }
            }
        }
        
        return findLowerBound ? left : right;
    }
}
