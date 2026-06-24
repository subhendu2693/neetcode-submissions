public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dictMap  =
         new Dictionary<string,List<string>>();

         if(strs.Length <=1)
         {
            return new List<List<string>>{strs.ToList()};
         }

         foreach(var s in strs)
         {
            char[] c=s.ToLower().ToCharArray();
            Array.Sort(c);
            string sortedString= new String(c);

            if(!dictMap.ContainsKey(sortedString))
            {
                dictMap.Add(sortedString,new List<string>(){s});
            }
            else
            {
                dictMap[sortedString].Add(s);
            }
         }

         return dictMap.Values.ToList<List<string>>();

        //  List<List<string>> val= new List<List<string>>();

        //  foreach(var kvp in dictMap)
        //  {
        //     val.Add(kvp.Value);
        //  }

        // return val;
    }
}
