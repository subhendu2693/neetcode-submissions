public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int f=0 ; int b=numbers.Length-1;
        while(f<b)
        {
            int sum= numbers[f]+numbers[b];
            if(sum>target)
            {
                b--;
            }
            else if(sum<target)
            {
                f++;
            }
            else
            {
                f++; b++;
                return new int[]{f,b};
            }      
        }
         return new int[0];
    }
}
