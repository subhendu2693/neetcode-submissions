public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {

        List<List<int>> sol= new List<List<int>>(); 
        HashSet<string> seen= new HashSet<string>();

        for(int i=0; i < nums.Length; i++)
        {
            for(int j=i+1; j<nums.Length;j++)
            {
                for(int k=j+1; k<nums.Length;k++)
                {
                    if(nums[i]+nums[j]+nums[k]==0)
                    {
                        int[] triplet= new int[]{nums[i],nums[j],nums[k]};
                        Array.Sort(triplet);
                        string item= triplet[0]+","+triplet[1]+","+triplet[2];
                        if(!seen.Contains(item))
                        {
                            seen.Add(item);
                            sol.Add(new List<int>(){nums[i],nums[j],nums[k]});

                        }
                        
                    }

                }
            }
        }
        return sol;
    }
}
