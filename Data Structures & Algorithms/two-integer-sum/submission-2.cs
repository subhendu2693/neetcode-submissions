public class Solution {
    public int[] TwoSum(int[] nums, int target) {
         Dictionary<int,int> map= new Dictionary<int,int>();

        for(int i=0; i<nums.Length; i++)
        { 
            int complementIndex;
            if(map.TryGetValue(target-nums[i], out complementIndex))
            { 
                return new int[]{complementIndex,i};
            }
            else
            { 
                if (!map.ContainsKey(nums[i]))
                    map.Add(nums[i],i);
            }
        }
        return new int[]{};
    }
}
