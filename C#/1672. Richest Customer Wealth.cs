public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int max = 1; 
        foreach(var custo in accounts) 
            max = Math.Max(max, custo.Sum());
        return max;
    }
}