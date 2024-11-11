public class Solution {
    public int MinimumSubarrayLength(int[] nums, int k) {
        for(int i=0, min=nums.Length+1;;i++) {
            // look forward until we reach k
            for(int o=0; i<nums.Length; i++) {
                o|=nums[i];
                if(o>=k) break;
            }
            if(i>=nums.Length) return min>nums.Length ? -1 : min;
            // look backward to see how short we can make it, but
            // only up to len=min since we want something shorter
            for(int len=0, o=0; ++len<min;i--) {
                o|=nums[i];
                if(o>=k) {min=len; break;}
            }
            if(min==1) return 1; // we're not going to do better than 1!
        }
    }
}