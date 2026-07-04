public class Solution {
    public int[] ReplaceElements(int[] arr) {
        int[] ans= new int[arr.Length];
        for(int i=0; i < arr.Length-1; i++)
        {
            int maxNum=0;
            for(int j=i+1; j<arr.Length;j++)
            {
                maxNum=Math.Max(maxNum,arr[j]);
            }
            ans[i]=maxNum;

        }
        ans[arr.Length-1]=-1;

        return ans;
    }
}