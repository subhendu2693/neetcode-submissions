public class Solution {
     public  int LongestConsecutive(int[] nums) {
       //Solving in O(n)
       HashSet<int> val = new HashSet<int>();
       int best=0;

       foreach(var i in nums)
       {
        if(!val.Contains(i))
        {
            val.Add(i);
        }
       }
       foreach(var i in val)
       {
        var len=0;
        int num = i;
        while(val.Contains(num+1))
        {
            len++;
            num++;
        }
        best=Math.Max(best,len+1);
       }
       return best;  
    }
}
