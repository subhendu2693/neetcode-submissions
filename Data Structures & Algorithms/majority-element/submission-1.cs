public class Solution {
    public int MajorityElement(int[] nums) {
        int max=0;
        if(nums.Length==1)
        {
            return nums[0];
        }
        Dictionary<int,int> map= new Dictionary<int,int>();
        foreach(int i in nums)
        {
            if(!map.TryGetValue(i, out int val))
            {
                map.Add(i,1);

            }
            else
            {
                if(map[i] >= nums.Length/2 )
                {
                    max = i; 
                    break;
                }
                map[i]+=1;
            }
        }

       return max;
    }
}