public class Solution {
     public  int LongestConsecutive(int[] nums) {
        //Solving in nlogn

        if (nums == null || nums.Length == 0)
            return 0;

        Array.Sort(nums);
        int longestLength = 1;
        int best = 1;
        int prev = nums[0];

        for (int k = 1; k < nums.Length; k++)
        {
            int current = nums[k];

            if (current == prev)
                continue;

            if (current == prev + 1)
            {
                longestLength++;
            }
            else
            {
                best = Math.Max(best, longestLength);
                longestLength = 1;
            }

            prev = current;
        }

        return Math.Max(best, longestLength);
    }
}
