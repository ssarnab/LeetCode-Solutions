public class Solution {
    public int MinimizedMaximum(int n, int[] quantities) {
        int left = 1;
        int right = quantities.Max(); // Max value in quantities as upper bound
        
        while (left < right) {
            int mid = left + (right - left) / 2;
            if (CanDistribute(mid, n, quantities)) {
                right = mid; // try for a smaller maximum
            } else {
                left = mid + 1; // increase the minimum bound
            }
        }
        
        return left; // The minimized maximum number of products any store receives
    }
    
    private bool CanDistribute(int maxProductsPerStore, int n, int[] quantities) {
        int storeCount = 0;
        
        foreach (int quantity in quantities) {
            storeCount += (quantity + maxProductsPerStore - 1) / maxProductsPerStore;
            if (storeCount > n) {
                return false; // more stores are required than available
            }
        }
        
        return true; // the distribution is possible within the given store count
    }
}
