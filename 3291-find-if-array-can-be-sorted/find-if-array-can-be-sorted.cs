public class Solution {
    public bool CanSortArray(int[] nums)
    {
        int CountSetBits(int num)
        {
            int count = 0;
            while (num > 0)
            {
                count += num & 1;
                num >>= 1;
            }
            return count;
        }

        int n = nums.Length;

        // Create a list of tuples to store numbers with their set bit counts
        var numWithBits = new List<Tuple<int, int>>();
        for (int i = 0; i < n; i++)
        {
            numWithBits.Add(new Tuple<int, int>(nums[i], CountSetBits(nums[i])));
        }

        // Try to sort the array while only allowing swaps between adjacent elements with the same bit count
        bool swapped;
        do
        {
            swapped = false;
            for (int i = 0; i < n - 1; i++)
            {
                // Check if the adjacent elements have the same number of set bits
                if (numWithBits[i].Item2 == numWithBits[i + 1].Item2)
                {
                    // If they are out of order, swap them
                    if (numWithBits[i].Item1 > numWithBits[i + 1].Item1)
                    {
                        var temp = numWithBits[i];
                        numWithBits[i] = numWithBits[i + 1];
                        numWithBits[i + 1] = temp;
                        swapped = true;
                    }
                }
            }
        } while (swapped);  // Repeat if any swap happened

        // After sorting by valid swaps, check if the array is fully sorted
        for (int i = 1; i < n; i++)
        {
            if (numWithBits[i].Item1 < numWithBits[i - 1].Item1)
            {
                return false;
            }
        }

        return true;
    }
}
