public class Solution {
    public int Reverse(int x) {
        // Handle special case for int.MinValue
        if (x == int.MinValue) {
            return 0;
        }
        // Handle negative numbers
        int sign = (x < 0) ? -1 : 1;
        x = Math.Abs(x);

        // Reverse the digits
        int reversedX = 0;
        while (x != 0) {
            int digit = x % 10;

            // Check for integer overflow
            if (reversedX > (int.MaxValue - digit) / 10) {
                return 0;
            }

            reversedX = reversedX * 10 + digit;
            x /= 10;
        }

        return sign * reversedX;
    }
}