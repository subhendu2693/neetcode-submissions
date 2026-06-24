public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var map = new Dictionary<int,int>();

        foreach(var i in nums)
        {
            if(!map.ContainsKey(i))
            {
                map.Add(i,1);
            }
            else
            {
                map[i]+=1;
            }
        }

        int[] sorted = map
        .OrderByDescending(kvp=>kvp.Value)
        .Select(kvp=>kvp.Key)
        .ToArray();
        int[] result = new int[k];

        Array.Copy(sorted, 0, result, 0, k);

        return result;
    }
}
