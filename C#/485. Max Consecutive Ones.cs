public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int max = 0;
        int count = 0;
        foreach (int num in nums) {
            if (num == 1) 
            {
                count++;
            }
            else 
            {
                max = Math.Max(max, count);
                count = 0;
            }
        }
        max = Math.Max(max, count);
        return max;
    }
}