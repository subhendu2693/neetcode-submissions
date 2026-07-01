public class Solution {
    public bool IsPalindrome(string s) {
        var charArray= ToCharArrayIgnoringSpaces(s);
        int start=0;
        int end=charArray.Length-1;
        while(start<end)
        {
            if(charArray[start]==charArray[end])
            {
                start++;
                end--;
            }
            else
            {
                return false;
            }
        }
        return true;
        
    }

    public static char[] ToCharArrayIgnoringSpaces(string s)
    {
        if (string.IsNullOrEmpty(s))
            return Array.Empty<char>();
        var lower = s.ToLowerInvariant();
        return lower.Where(c => (c >= 'a' && c <= 'z') || (c >= '0' && c <= '9')).ToArray();
    }
}
