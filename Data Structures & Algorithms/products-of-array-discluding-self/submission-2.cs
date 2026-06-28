public class Solution {
    //Time-> O(n) Space ->O(n)
    public int[] ProductExceptSelf(int[] nums) {
        int[] product= new int[nums.Length];
        var pre =1;
        var post =1;


        for(int i=0;i < nums.Length; i++)
        {
            product[i]=pre;
            pre*=nums[i];
        }

        for(int j=nums.Length-1; j>=0; j--)
        {
            product[j]*=post;
            post*=nums[j];
        }

        return product;
    }
}
