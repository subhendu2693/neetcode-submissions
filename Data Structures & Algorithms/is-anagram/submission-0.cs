public class Solution {
    public bool IsAnagram(string s, string t) {
       if(s.Length!=t.Length)
        {
            return false;
        }
        Dictionary<char,int> sMap=new Dictionary<char,int>();
        Dictionary<char,int> tMap=new Dictionary<char,int>();

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
            if(tMap.TryGetValue(c,out int count))
            {
                tMap[c]+=1;
            }
            else
            {
                tMap[c] = 1;
            }
        }
        foreach(var kvp in sMap)
        {
            if(!tMap.TryGetValue(kvp.Key,out int count) || count!=kvp.Value)
            {
                return false;
            }
        }
        return true;

    }
}
