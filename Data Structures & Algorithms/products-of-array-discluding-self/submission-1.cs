public class Solution {
    //Time-> O(n) Space ->O(n)
    public int[] ProductExceptSelf(int[] nums) {
        int[] prefix= new int[nums.Length];
        int[] postfix = new int[nums.Length];
        int[] product= new int[nums.Length];
        var pre =1;
        var post =1;


        for(int i=0;i < nums.Length; i++)
        {
            prefix[i]=pre;
            pre*=nums[i];
        }

        for(int j=nums.Length-1; j>=0; j--)
        {
            postfix[j]=post;
            post*=nums[j];
        }

        for(int i=0; i < nums.Length; i++)
        {
            product[i]=prefix[i]*postfix[i];
        }

        return product;
    }
}
