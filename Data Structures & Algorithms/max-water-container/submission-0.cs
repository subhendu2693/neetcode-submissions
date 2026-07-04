public class Solution {
    public int MaxArea(int[] heights) {
        int area=0;
        for(int i=0; i < heights.Length;i++)
        {
            for(int j=i+1; j<heights.Length ; j++)
            {
                var h= Math.Min(heights[i],heights[j]);
                var len=j-i;
                area=Math.Max(h*len,area);
            }
        }
        return area;
    }
}
