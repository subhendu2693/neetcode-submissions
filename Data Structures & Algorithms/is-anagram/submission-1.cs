public class Solution {
    public bool IsAnagram(string s, string t) {
       if(s.Length!=t.Length)
        {
            return false;
        }
        Dictionary<char,int> sMap=new Dictionary<char,int>();
       
        foreach(char c in s)
        {
            if(sMap.TryGetValue(c,out int count))
            {
                sMap[c]+=1;
            }
            else
            {
                sMap[c] = 1;
            }
        }
        foreach(char c in t)
        {
            if(sMap.TryGetValue(c,out int count))
            {
                sMap[c]-=1;
            }
            else
            {
                return false;
            }
        }
        foreach(var kvp in sMap)
        {
            sMap.TryGetValue(kvp.Key, out int finalCount);
            if(finalCount!=0)
            {
                return false;
            }
        }
        return true;

    }
}
