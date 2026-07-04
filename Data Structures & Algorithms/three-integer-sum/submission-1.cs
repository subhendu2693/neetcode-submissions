public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        List<List<int>> ans= new List<List<int>>();
        Array.Sort(nums);

        for(int i=0; i < nums.Length; i++)
        {
            if(i !=0 && nums[i]==nums[i-1])
            {
                continue;
            }
            int l=i+1;
            int r=nums.Length-1;

            while(l<r)
            {
                if(l > i + 1 && nums[l]==nums[l-1])
                {
                    l++;
                    continue;
                }
                int sum = nums[i]+nums[l]+nums[r];
                if(sum>0)
                {
                    r--;
                }
                else if( sum<0)
                {
                    l++;
                }
                else
                {
                    
                    ans.Add(new List<int>(){nums[i],nums[l],nums[r]});
                    l++;r--;
                }
            }
        }
        return ans;
    }
}
