public class Solution {
    public int MaxArea(int[] heights) {
        int area=0;
        int l=0;
        int r=heights.Length-1;
        while(l<r)
        {
            int b=r-l;
            int len=Math.Min(heights[l],heights[r]);
            area=Math.Max(area,len*b);
            if(heights[l]<heights[r])
            {
                l++;
            }
            else if(heights[l]>heights[r])
            {
                r--;
            }
            else
            {
                l++;r--;
            }
        }

        
        return area;
    }
}
